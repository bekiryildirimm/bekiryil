using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Picasso.Services;
using Picasso.EzanVakitleri;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Windows;
using EzanVakti;

public class EzanListe  //namaz vakitleri verilerinin çeşitli değişkenlerde liste olarak tutulduğu sınıf
{
    public string imsak { get; set; }
    public string gunes { get; set; }
    public string ogle { get; set; }
    public string ikindi { get; set; }
    public string aksam { get; set; }

    public string yatsi { get; set; }
    public string readable { get; set; }
    public string GregDate { get; set; }
    public int GregDay { get; set; }
    public string GregWeekdayEn { get; set; }
    public string GregHaftaninGunuKisa { get; set; }
    public string GregHaftaninGunuUzun { get; set; }
    public int GregMonthNumber { get; set; }
    public string GregMonthEn { get; set; }
    public string GregAylar { get; set; }
    public string GregYear { get; set; }
    public string HijriDate { get; set; }
    public int HijriDay { get; set; }
    public string HijriWeekdayEn { get; set; }
    public int HijriMonthNumber { get; set; }
    public string HijriMonthEn { get; set; }
    public string HijriYear { get; set; }

}

public class NamazVaktiApi
{               // namaz vakitleri verilerinin internetten api olarak çekileceği, çekilen verileri dosyaya yazma ve dosyadan okuma işlemini yapacak methodların bulunduğu sınıf

    private static string city; //hangi şehir için api isteğinin gönderileceği string türünde değişken 

    private int month=0;//hangi ay için api isteğinin gönderileceği int türünde değişken

    private int year=2022;//hangi yıl için api isteğinin gönderileceği int türünde değişken(standart 2022)

    private int currentMonth = 0;//şu an hangi ay olduğunu int türünde tutan (0-12), sayıyı dosyadan alan değişken

    private int currentYear = 0;//şu an hangi yıl olduğunu int türünde tutan (0-12), sayıyı dosyadan alan değişken
    private string currentCity;//şu an hangi şehir için dosyada verilerin tutulduğunu gösteren string türünde değişken

    private string DosyaYolu;// Verilerin tutulduğu *.txt dosyasının hangi klasörde saklandığını tutan string türünde değişken
   
    private bool mevcutDosya;//dosyanın mevcut olup olmadığını bool türünde tutan değişken

    public string City
    {
        get { return city; } //city değişkeni için get ve set methodları
        set { city = value; }
    }
    public int Year
    {
        get { return year; } //year değişkeni için get ve set methodları
        set { year = value; }
    }
    public int Month
    {
        get { return month; } //month değişkeni için get ve set methodları
        set { month = value; }
    }
    public bool MevcutDosya
    {
        get { return mevcutDosya; }//mevcutDosya değişkeni için get ve set methodları
        set { mevcutDosya = value; }
    }
    public int CurrentMonth
    {
        get { return currentMonth; }//currentMonth değişkeni için get ve set methodları
        set { currentMonth = value; }
    }
    public int CurrentYear
    {
        get { return currentYear; }//currentyear değişkeni için get ve set methodları
        set { currentYear = value; }
    }
    public string CurrentCity
    {
        get { return currentCity; }//currentcity değişkeni için get ve set methodları
        set { currentCity = value; }
    }
    public static string PlaceUri(string Sehir,int yil,int ay)
    {
       return $"http://api.aladhan.com/v1/calendarByCity?city={Sehir}&country=Turkey&method=13&month={ay}&year={yil}";
     //Sehir,ay ve yil parametreleri ile namaz vakitleri verilerinin çekileceği linki string olarak döndüren fonksiyon
    }
    public static string DirectoryName(string Sehir, int yil)
    {
        return $"{Sehir}/{yil}"; //Sehir ve ay isimleri ile ayrı ayrı oluşturulan klasör yolu
    }
    public static string FileName(string Sehir,int yil,int ay)
    {
        return $"/_{Sehir}_{yil}_{ay}.txt"; //gaziantep_2022_12.txt şeklinde oluşturulan txt dosyasının adı
    }
    private async Task<PrayerTime> EzanApi()
    {  //namaz vakitleri için api isteği gönderecek ve gelen verileri PrayerTime sınıfına yollayacak method
        var PrayerTimeApi=PlaceUri(city,year,month); //şehir yıl ay bilgileri ile PlaceUri methodundan string olarak döndürülen linki string olarak tutacak değişken
        var httpService = new CLientModel(); //Picasso.Services namespacenden ClientModel() sınıfı nesnesi oluşturuldu
        var result=await httpService.ProcessApi<PrayerTime>(PrayerTimeApi); //api isteği gönderildi, veriler prayertime türünde geldi
        return result; //sonuç prayertime sınıf türüne geri döndürüldü
    }
    public async Task EzanFileInput()//verilerin api ile serverden çekip dosyaya yazdıran async Task türünde method
    {
        string[] Aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayis","Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasim", "Aralik" };//ay isimlerini string olarak tutan dizi 
        string[] GunlerKisa = { "Pzt", "Sal", "Çar", "Per", "Cum", "Cmt", "Paz" };//haftanın günlerinin kısaltılmış isimlerini tutan dizi
        string[] GunlerUzun = { "Pazartesi", "Sali", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };//haftanın günlerinin isimlerini tutan dizi
        string gunUzun = "";//gün ismini tutan string değişken
            string gunKisa="";//kısaltılmış gün ismini tutan string değişken 
        
        var res = await EzanApi(); //EzanApi fonksiyonu await anahtar sözcüğü ile çağrılıyor.cevabın geri döndürülmesi beklenerek res isimli değişkene atanıyor
        String FilePath;


            if (!Directory.Exists(@"C:\Program Files\EzanVakti"))//C:\Program Files\EzanVakti dosya yolunda EzanVakti isimli klasörün var olup olmadığı kontrol ediliyor, klasör mevcut değilse yeni klasör oluşturuluyor.
        {
                Directory.CreateDirectory(@"C:\Program Files\EzanVakti");
            }
            var DirectoryPath = @"C:\Program Files\EzanVakti\" + DirectoryName(city, year);
            if (!Directory.Exists(DirectoryPath))
        {////C:\Program Files\EzanVakti\sehir\yil dosya yolundaki klasörlerin var olup olmadığı kontrol ediliyor, klasör mevcut değilse yeni klasör oluşturuluyor.
            Directory.CreateDirectory(DirectoryPath);
            }
            using (FileStream setting = new FileStream(@"C:\Program Files\EzanVakti\ayar.txt", FileMode.Create))
            {  //FileStream sınıfı ile ayar.txt dosyası oluşturuldu 
               
            
                StreamWriter setsw = new StreamWriter(setting); //oluşturulan dosya streamwriter sınıfına tanımlandı
                FilePath = DirectoryPath + FileName(city, year, month); //mevcut dosyanın saklanacağı klasörün dosya yolu filepath isimli string değişkene atandı
         
              await setsw.WriteLineAsync(FilePath); //mevcut dosyanın dosya yolu string olarak dosyaya async olarak await anahtar sözcüğü ile dosyaya yazma işlemi bekleniyor
                await setsw.WriteLineAsync(city);////mevcut şehrin ismi string olarak dosyaya async olarak await anahtar sözcüğü ile dosyaya yazma işlemi bekleniyor
            await setsw.WriteLineAsync(year.ToString());//mevcut yıl dosyaya async olarak await anahtar sözcüğü ile dosyaya yazma işlemi bekleniyor
            await setsw.WriteLineAsync(month.ToString());//mevcut ay dosyaya async olarak await anahtar sözcüğü ile dosyaya yazma işlemi bekleniyor

            setsw.Close();//dosyaya yazma işlemi bitti dosya kapatılıyor
                
     
            }

            using (FileStream fs = new FileStream(FilePath, FileMode.Create))
            {
                //filestream sınıfı ile filepath değişkeninde tutulan mevcut dosya yoluna txt dosyası oluşturuluyor
        
                StreamWriter bw = new StreamWriter(fs);//oluşturulan dosya streamwriter sınıfına tanımlandı
                foreach (var ezan in res.data) //PrayerTime sınıfındaki veriler liste olarak foreach ile sıralanıyor.
                {

                    await bw.WriteLineAsync(ezan.Timings.Fajr.Remove(5, 6)); //namaz vakitleri bilgileri asenkron olarak await anahtar sözcüğü ile txt dosyasına yazdırılıyor
                    await bw.WriteLineAsync(ezan.Timings.Sunrise.Remove(5, 6));
                    await bw.WriteLineAsync(ezan.Timings.Dhuhr.Remove(5, 6));
                    await bw.WriteLineAsync(ezan.Timings.Asr.Remove(5, 6));
                    await bw.WriteLineAsync(ezan.Timings.Sunset.Remove(5, 6));
                    await bw.WriteLineAsync(ezan.Timings.Isha.Remove(5, 6));
                    await bw.WriteLineAsync(ezan.Date.Readable);
                    await bw.WriteLineAsync(ezan.Date.Gregorian.Date);
                    await bw.WriteLineAsync(ezan.Date.Gregorian.Day);
                    
                    await bw.WriteLineAsync(ezan.Date.Gregorian.Weekday.En);
                    if (ezan.Date.Gregorian.Weekday.En == "Monday")
                    {
                        gunKisa = GunlerKisa[0];  //api den çekilen haftanın günleri ingilizce olduğu için türkçeye çevrilerek dosyaya türkçe olarak yazdırılıyor.
                        gunUzun = GunlerUzun[0];
                    }
                    else if (ezan.Date.Gregorian.Weekday.En == "Tuesday")
                    {
                        gunKisa = GunlerKisa[1];
                        gunUzun = GunlerUzun[1];
                    }
                    else if (ezan.Date.Gregorian.Weekday.En == "Wednesday")
                    {
                        gunKisa = GunlerKisa[2];
                        gunUzun = GunlerUzun[2];
                    }
                    else if (ezan.Date.Gregorian.Weekday.En == "Thursday")
                    {
                        gunKisa = GunlerKisa[3];
                        gunUzun = GunlerUzun[3];
                    }
                    else if (ezan.Date.Gregorian.Weekday.En == "Friday")
                    {
                        gunKisa = GunlerKisa[4];
                        gunUzun = GunlerUzun[4];
                    }
                    else if (ezan.Date.Gregorian.Weekday.En == "Saturday")
                    {
                        gunKisa = GunlerKisa[5];
                        gunUzun = GunlerUzun[5];
                    }
                    else if (ezan.Date.Gregorian.Weekday.En == "Sunday")
                    {
                        gunKisa = GunlerKisa[6];
                        gunUzun = GunlerUzun[6];
                    }
                    await bw.WriteLineAsync(gunKisa);
                    await bw.WriteLineAsync(gunUzun);
                    await bw.WriteLineAsync(ezan.Date.Gregorian.Month.Number.ToString());
                    await bw.WriteLineAsync(ezan.Date.Gregorian.Month.En);
                    await bw.WriteLineAsync(Aylar[(ezan.Date.Gregorian.Month.Number) - 1]); 
                    await bw.WriteLineAsync(ezan.Date.Gregorian.Year);
                    await bw.WriteLineAsync(ezan.Date.Hijri.Date);
                    await bw.WriteLineAsync(ezan.Date.Hijri.Day);
                
                    await bw.WriteLineAsync(ezan.Date.Hijri.Weekday.En);
                    await bw.WriteLineAsync(ezan.Date.Hijri.Month.Number.ToString());
                    await bw.WriteLineAsync(ezan.Date.Hijri.Month.En);
                    await bw.WriteLineAsync(ezan.Date.Hijri.Year);

                }
                bw.Close();
   
            }
        
        
    }
    public void EzanFileCheck()
    {   //dosyanın mevcut olup olmadığını kontrol eden void method
        
        if(!File.Exists(@"C:\Program Files\EzanVakti\ayar.txt"))
        { //dosya mevcut değil ise bu sınıftaki mevcutDosya bool değişkeni true değeri alır
            this.mevcutDosya = true;
        }

        else{ //
            using (FileStream ayar = new FileStream(@"C:\Program Files\EzanVakti\ayar.txt", FileMode.Open))
            {  //dosya mevcut ise dosyada yazan dosya yolu bu sınıftaki Dosyayolu değişkenine atanır
                StreamReader sett = new StreamReader(ayar);
                this.DosyaYolu = sett.ReadLine();
                this.currentCity = sett.ReadLine();//dosyada yazan mevcut şehir ismi currentCity değişkenine atanır
                this.currentYear = Int32.Parse(sett.ReadLine());//mevcut yıl currentyear değişkenine atanır
                this.currentMonth = Int32.Parse(sett.ReadLine());//mevcut ay currentmonth değişkenine atanır
                sett.Close(); //dosya kapanır.
       
            }
         
            if (!File.Exists(this.DosyaYolu))
            { //mevcut dosya yolundaki dosya mevcut değil ise mevcutDosya değişkeni true değeri alır.
                this.mevcutDosya = true;
            }
            else
            {  //mevcut dosya yolundaki dosya mevcut ise mevcutDosya değişkeni true değeri alır.
                this.mevcutDosya = false;


            }
        }
    }
    public void EzanFileOutput(List<EzanListe> listitem) //txt dosyasındaki verileri EzanListe sınıfına liste olarak atayan List<EzanListe> parametreli method
    {
        if (!File.Exists(@"C:\Program Files\EzanVakti\ayar.txt"))
        {    //C:\Program Files\EzanVakti\ klasöründeki ayar.txt dosyası mevcut değilse mevcutDosya değişkeni true değeri alır
            this.mevcutDosya = true;
        }
        else
        {//dosya mevcut

           

            List<EzanListe> abc = new List<EzanListe>();//EzanListe sınıfına liste olarak nesne oluşturuldu.
            using(FileStream ayar = new FileStream(@"C:\Program Files\EzanVakti\ayar.txt", FileMode.Open))
            {//filestream ile ayar.txt dosyası açılıyor.
                StreamReader sett = new StreamReader(ayar); //açılan dosya streamreader değişkenine atandı.
                this.DosyaYolu = sett.ReadLine(); //dosyadan bir satır dosyayolu string değeri belleğe alındı
                this.currentCity = sett.ReadLine();//mevcut şehir string değeri dosyadan okunup belleğe alındı.
                this.currentYear = Int32.Parse(sett.ReadLine());//mevcut yıl int değeri dosyadan okunup belleğe alındı.
                this.currentMonth = Int32.Parse(sett.ReadLine());//mevcut ay int değeri dosyadan okunup belleğe alındı.
                sett.Close();//dosyayı kapat.
          
            }
    
            if (!File.Exists(this.DosyaYolu))
            { //ayar.txt dosyasından alınan mevcut dosya yolu kontrol edip dosya mevcut değilse mevcutDosya değeri truue döndür
                this.mevcutDosya = true;
            }
            else
            {//dosya mevcut.


                using (FileStream fs = new FileStream(this.DosyaYolu, FileMode.Open))
                {  //dosyaYolunda tutulan mevcut dosya yolundaki .txt dosyasını filestream ile aç.

                    StreamReader br = new StreamReader(fs); //filestream ile açılan dosyayı streamreader ata.

                    while (!br.EndOfStream) //dosya sonuna kadar ilerle.
                    {
                        listitem.Add(new EzanListe() //dosyadan 21 satır ezan bilgilerini oku. 21 adet veriyi EzanListe sınıfında bir düğüme aktar.
                        {
                            imsak = br.ReadLine(),
                            gunes = br.ReadLine(),
                            ogle = br.ReadLine(),
                            ikindi = br.ReadLine(),
                            aksam = br.ReadLine(),
                            yatsi = br.ReadLine(),
                            readable = br.ReadLine(),
                            GregDate = br.ReadLine(),
                            GregDay = int.Parse(br.ReadLine()),
                            GregWeekdayEn = br.ReadLine(),
                            GregHaftaninGunuKisa = br.ReadLine(),
                            GregHaftaninGunuUzun = br.ReadLine(),
                            GregMonthNumber = int.Parse(br.ReadLine()),
                            GregMonthEn = br.ReadLine(),
                            GregAylar = br.ReadLine(),
                            GregYear = br.ReadLine(),
                            HijriDate = br.ReadLine(),
                            HijriDay = int.Parse(br.ReadLine()),
                            HijriWeekdayEn = br.ReadLine(),
                            HijriMonthNumber = int.Parse(br.ReadLine()),
                            HijriMonthEn = br.ReadLine(),
                            HijriYear = br.ReadLine(),
                        });
 
                    }
                    br.Close(); //dosyayı kapat.
        
                }
            }
        }
    }
    
    
    
 
}