using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.ServiceModel.Channels;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Media;
using System.Security.Cryptography;

namespace EzanVakti
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {    
       public EzanListe ezan1=new EzanListe(); //EzanListe sınıfından Global nesne oluştur.
        public EzanListe ezan2 = new EzanListe();//EzanListe sınıfından Global nesne oluştur.
        private string Sehir { get; set; }//Global Sehir string değişkeni
        public Window1()
        {
            InitializeComponent();
           
            DispatcherTimer timer=new DispatcherTimer();//DispatcherTimer sınıfından nesne oluştur.
      
            timer.Interval = TimeSpan.FromSeconds(1);//timer olayı 1 saniye aralıklarla çalışacak.
            timer.Tick += timer_Tick;//timer_Tick fonksiyonu 1 saniyede bir çalıştır.
            timer.Tick += vakit_check;//vakit_check fonksiyonu 1 saniyede bir çalıştır.
            timer.Tick += bildirim;//bildirim fonksiyonu 1 saniyede bir çalıştır.
            timer.Start();//timer olayını başlat.
            
            DateTime bugun=DateTime.Now;//datetime sınıfından datetime.now nesnesi oluştur.
            NamazVaktiApi namaz = new NamazVaktiApi();//NamazVAktiApi sınıfından nesne oluştur.
            List<EzanListe> liste = new List<EzanListe>();//EzanListe sınıfından List nesnesi oluştur.
            EzanListe ezan = new EzanListe();//EzanListe sınıfından nesne oluştur.
            namaz.EzanFileOutput(liste);//NamazVaktiApi sınıfındaki EzanFileOutput fonksiyonunu List<EzanListe> parametresi ile çalıştır.
 

            foreach (var item in liste) //List<EzanListe> listenin son düğümüne kadar döngüyü çalıştır.
            {
                if(item.GregDay==bugun.Day)//item.GregDay değişkeninde tutulan int değeri datetime.Now.day değişkeniyle karşılaştır.
                {   //Eşleşiyorsa.
                    ezan=item;// döngüdeki List<EzanListe> item düğümünü,EzanListe nesnesine ata.
                    ezan1 = item;// döngüdeki List<EzanListe> item düğümünü, Global scope'taki EzanListe nesnesine ata.
                    gun1.Content = item.GregHaftaninGunuKisa;//değeri gun1 label içeriğine tanımla
                    imsak1.Text = item.imsak;//değeri imsak1 textblock içeriğine tanımla
                    gunes1.Text = item.gunes;//değeri gunes1 textblock içeriğine tanımla.
                    ogle1.Text = item.ogle;//değeri ogle1 textblock içeriğine tanımla.
                    ikindi1.Text = item.ikindi;//değeri ikindi1 textblock içeriğine tanımla.
                    aksam1.Text = item.aksam;//değeri aksam1 textblock içeriğine tanımla.
                    yatsi1.Text = item.yatsi;//değeri yatsi1 textblock içeriğine tanımla.
  
                   
                }
                else if(item.GregDay==bugun.Day+1)//item.Gregday değişkeninde tutulan int değeri şu anki günden itibaren 1 gün sonrası ile eşleşiyormu kontrol et.
                {//Eşleşiyorsa.
                    ezan2 = item;// döngüdeki List<EzanListe> item düğümünü, Global scope'taki EzanListe nesnesine ata.
                    gun2.Content=item.GregHaftaninGunuKisa;//değeri gun2 label içeriğine tanımla.
                    imsak2.Text = item.imsak;//değeri imsak2 textblock içeriğine tanımla.
                    gunes2.Text = item.gunes;//değeri gunes2 textblock içeriğine tanımla.
                    ogle2.Text = item.ogle;//değeri ogle2 textblock içeriğine tanımla.
                    ikindi2.Text = item.ikindi;//değeri ikindi2 textblock içeriğine tanımla.
                    aksam2.Text = item.aksam;//değeri aksam2 textblock içeriğine tanımla.
                    yatsi2.Text = item.yatsi;//değeri yatsi2 textblock içeriğine tanımla.
                }
                else if (item.GregDay == bugun.Day + 2)//item.Gregday değişkeninde tutulan int değeri şu anki günden itibaren 1 gün sonrası ile eşleşiyormu kontrol et.
                {//Eşleşiyorsa..
                    gun3.Content = item.GregHaftaninGunuKisa;
                    imsak3.Text = item.imsak;
                    gunes3.Text = item.gunes;
                    ogle3.Text = item.ogle;
                    ikindi3.Text = item.ikindi;
                    aksam3.Text = item.aksam;
                    yatsi3.Text = item.yatsi;
                }
                else if (item.GregDay == bugun.Day + 3)
                {
                    gun4.Content = item.GregHaftaninGunuKisa;
                    imsak4.Text = item.imsak;
                    gunes4.Text = item.gunes;
                    ogle4.Text = item.ogle;
                    ikindi4.Text = item.ikindi;
                    aksam4.Text = item.aksam;
                    yatsi4.Text = item.yatsi;
                }
                else if (item.GregDay == bugun.Day + 4)
                {
                    gun5.Content = item.GregHaftaninGunuKisa;
                    imsak5.Text = item.imsak;
                    gunes5.Text = item.gunes;
                    ogle5.Text = item.ogle;
                    ikindi5.Text = item.ikindi;
                    aksam5.Text = item.aksam;
                    yatsi5.Text = item.yatsi;
                }
                else if (item.GregDay == bugun.Day + 5)
                {
                    gun6.Content = item.GregHaftaninGunuKisa;
                    imsak6.Text = item.imsak;
                    gunes6.Text = item.gunes;
                    ogle6.Text = item.ogle;
                    ikindi6.Text = item.ikindi;
                    aksam6.Text = item.aksam;
                    yatsi6.Text = item.yatsi;
                }
                else if (item.GregDay == bugun.Day + 6)
                {
                    gun7.Content = item.GregHaftaninGunuKisa;
                    imsak7.Text = item.imsak;
                    gunes7.Text = item.gunes;
                    ogle7.Text = item.ogle;
                    ikindi7.Text = item.ikindi;
                    aksam7.Text = item.aksam;
                    yatsi7.Text = item.yatsi;
                    break;
                }

            }
            GregLabel.Content ="  " +ezan.GregDay + "\n" + ezan.GregAylar + "\n" + ezan.GregYear;//Tarih bilgisini Greglabel label içeriğine tanımla Örn çıktı. 22 Aralık 2022
           HijriLabel.Content = namaz.CurrentCity;//mevcut şehir string değerini HijriLabel label içeriğine tanımla.
      
            havadurumuapi(namaz.CurrentCity);//havadurumuapi fonksiyonunu NamazVaktiApi sınıfındaki mevcut şehir string değişkeni parametreli olarak çağır.
          
        
            AksamVakti.Content = ezan.aksam;//EzanListe sınıfındaki string değeri AksamVakti label içeriğine tanımla.
            imsakvakti.Content = ezan.imsak;//EzanListe sınıfındaki string değeri imsakvakti label içeriğine tanımla.
            gunesvakti.Content = ezan.gunes;//EzanListe sınıfındaki string değeri gunesvakti label içeriğine tanımla.
            ogleVakti.Content = ezan.ogle;//EzanListe sınıfındaki string değeri ogleVakti label içeriğine tanımla.
            ikindiVakti.Content = ezan.ikindi;//EzanListe sınıfındaki string değeri ikindiVakti label içeriğine tanımla.
            yatsiVakti.Content = ezan.yatsi;//EzanListe sınıfındaki string değeri yatsiVakti label içeriğine tanımla.


        }
         public async void havadurumuapi(String sehir) //string parametreli void async fonksiyon.
        {
            HavaDurumuApi havadurumu = new HavaDurumuApi(sehir); //HavaDurumuApi sınıfı kurucu parametreli nesne oluştur.
            
          
            try
            {
             var result= await havadurumu.WeatherApi(); //await anahtar kelimesi ile HavaDurumuApi sınıfındaki WeatherApi() fonksiyonunu çağır. Api isteği gönder gelen cevabı result değişkenine ata.

                    foreach (var item in result.weather)//json arrayda bulunan weather ögesini foreach ile döndür.
                    {
                        HavaDurumu.Text ="     "+ result.main.temp + "° \n" + item.description; //main.temp değişkeni ile item.description değerini HavaDurumu textblock içeriğine tanımla. Örn Çıktı: 18° Sisli
                }
            }
            catch(HttpRequestException)//internet bağlantısı yoksa exception hatası at.
            { 
          
            }
            catch(JsonException)//json parse işleminde hata oluştuysa JsonException at.
            {

            }
            catch(Exception)//exception at.
            {

            }
        }
        public void sescal()
        {
            SoundPlayer ses1 = new SoundPlayer(@"C:\Users\manas\Desktop\ezanvakti github1\EzanVakti\EzanVakti\AllahuEkberBildirimSesi1.wav");
            ses1.LoadAsync();
            ses1.Play();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            YerelSaatLabel.Content="Yerel saat\n  "+DateTime.Now.ToString("HH:mm");
        }
        void bildirim(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            if (simdi.Hour == Int32.Parse(ezan1.imsak.Remove(2)) && simdi.Minute == Int32.Parse(ezan1.imsak.Remove(0, 3))&&simdi.Second==0)
            {

                ToastContentBuilder toastContent = new ToastContentBuilder();
                toastContent.AddArgument("İmsak vakti");
                toastContent.AddText("İmsak vakti");
                toastContent.Show();
                sescal();
            }
           else if (simdi.Hour == Int32.Parse(ezan1.gunes.Remove(2)) && simdi.Minute == Int32.Parse(ezan1.gunes.Remove(0, 3)) && simdi.Second == 0)
            {

                ToastContentBuilder toastContent = new ToastContentBuilder();
                toastContent.AddArgument("Güneş vakti");
                toastContent.AddText("Güneş vakti");
                toastContent.Show();
                sescal();
            }
            else if (simdi.Hour == Int32.Parse(ezan1.ogle.Remove(2)) && simdi.Minute == Int32.Parse(ezan1.ogle.Remove(0, 3)) && simdi.Second == 0)
            {

                ToastContentBuilder toastContent = new ToastContentBuilder();
                toastContent.AddArgument("Öğle vakti");
                toastContent.AddText("Öğle vakti");
                toastContent.Show();
                sescal();
            }
            else if (simdi.Hour == Int32.Parse(ezan1.ikindi.Remove(2)) && simdi.Minute == Int32.Parse(ezan1.ikindi.Remove(0, 3)) && simdi.Second == 0)
            {

                ToastContentBuilder toastContent = new ToastContentBuilder();
                toastContent.AddArgument("İkindi vakti");
                toastContent.AddText("İkindi vakti");
                toastContent.Show();
                sescal();
            }
            else if (simdi.Hour == Int32.Parse(ezan1.aksam.Remove(2)) && simdi.Minute == Int32.Parse(ezan1.aksam.Remove(0, 3)) && simdi.Second == 0)
            {

                ToastContentBuilder toastContent = new ToastContentBuilder();
                toastContent.AddArgument("Akşam vakti");
                toastContent.AddText("Akşam vakti");
                toastContent.Show();
                sescal();
            }
            else if (simdi.Hour == Int32.Parse(ezan1.yatsi.Remove(2)) && simdi.Minute == Int32.Parse(ezan1.yatsi.Remove(0, 3)) && simdi.Second == 0)
            {

                ToastContentBuilder toastContent = new ToastContentBuilder();
                toastContent.AddArgument("Yatsı vakti");
                toastContent.AddText("Yatsı vakti");
                toastContent.Show();
                sescal();
            }
        }
        void vakit_check(object sender,EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            if(simdi.Hour<=Int32.Parse(ezan1.imsak.Remove(2))&&(simdi.Hour < Int32.Parse(ezan1.imsak.Remove(2)) || simdi.Minute<Int32.Parse(ezan1.imsak.Remove(0,3))))
                    {
                vakit.Content = "İMSAK VAKTİNE KALAN";
                TimeSpan d = DateTime.Parse(ezan1.imsak).Subtract(DateTime.Parse(simdi.ToString("HH:mm:ss tt")));
                kalanZaman.Content = d;
                rectYatsi.Stroke = System.Windows.Media.Brushes.Orange;
                rectYatsi.Fill.Opacity = 1.0;
                KareYatsi.Foreground = System.Windows.Media.Brushes.Orange;
                yatsiVakti.Foreground = System.Windows.Media.Brushes.Orange;
                yatsiresim.Source = new BitmapImage(new Uri(@"yatsiOrange.png", UriKind.RelativeOrAbsolute));
                arkaplanresmi.Source = new BitmapImage(new Uri("yatsiImg.jpg", UriKind.RelativeOrAbsolute));

            }
               else if(simdi.Hour <= Int32.Parse(ezan1.gunes.Remove(2))&&(simdi.Hour < Int32.Parse(ezan1.gunes.Remove(2)) || simdi.Minute < Int32.Parse(ezan1.gunes.Remove(0, 3))))
               {
                vakit.Content = "GÜNES VAKTİNE KALAN";
                TimeSpan d = DateTime.Parse(ezan1.gunes).Subtract(DateTime.Parse(simdi.ToString("HH:mm:ss tt")));
                kalanZaman.Content = d;
                rectImsak.Stroke = System.Windows.Media.Brushes.Orange;
                rectImsak.Fill.Opacity = 1.0;
                KareImsak.Foreground = System.Windows.Media.Brushes.Orange;
                imsakvakti.Foreground= System.Windows.Media.Brushes.Orange;
                imsakresim.Source= new BitmapImage(new Uri(@"imsakOrange.png", UriKind.RelativeOrAbsolute));
                arkaplanresmi.Source = new BitmapImage(new Uri("imsakImg.jpg", UriKind.RelativeOrAbsolute));

                rectYatsi.Stroke = System.Windows.Media.Brushes.DarkGray;
                rectYatsi.Fill.Opacity = 0.4;
                KareYatsi.Foreground = System.Windows.Media.Brushes.White;
                yatsiVakti.Foreground = System.Windows.Media.Brushes.White;
                yatsiresim.Source = new BitmapImage(new Uri(@"yatsiWhite.png", UriKind.RelativeOrAbsolute));
            }
            else if (simdi.Hour <= Int32.Parse(ezan1.ogle.Remove(2)) && (simdi.Hour < Int32.Parse(ezan1.ogle.Remove(2)) || simdi.Minute < Int32.Parse(ezan1.ogle.Remove(0, 3))))
            {
                vakit.Content = "ÖĞLE EZANINA KALAN";
                TimeSpan d = DateTime.Parse(ezan1.ogle).Subtract(DateTime.Parse(simdi.ToString("HH:mm:ss tt")));
                kalanZaman.Content = d;
                rectGunes.Stroke = System.Windows.Media.Brushes.Orange;
                rectGunes.Fill.Opacity = 1.0;
                KareGunes.Foreground = System.Windows.Media.Brushes.Orange;
                gunesvakti.Foreground = System.Windows.Media.Brushes.Orange;
                gunesresim.Source = new BitmapImage(new Uri(@"gunesturuncu.png", UriKind.RelativeOrAbsolute));
                arkaplanresmi.Source = new BitmapImage(new Uri(@"gunesImg.jpg", UriKind.RelativeOrAbsolute));

                rectImsak.Stroke = System.Windows.Media.Brushes.DarkGray;
                rectImsak.Fill.Opacity = 0.4;
                KareImsak.Foreground = System.Windows.Media.Brushes.White;
                imsakvakti.Foreground = System.Windows.Media.Brushes.White;
                imsakresim.Source = new BitmapImage(new Uri(@"imsakWhite.png", UriKind.RelativeOrAbsolute));
  

            }
            else if (simdi.Hour <= Int32.Parse(ezan1.ikindi.Remove(2)) && (simdi.Hour < Int32.Parse(ezan1.ikindi.Remove(2)) || simdi.Minute < Int32.Parse(ezan1.ikindi.Remove(0, 3))))
            {
                vakit.Content = "İKİNDİ EZANINA KALAN";
                TimeSpan d = DateTime.Parse(ezan1.ikindi).Subtract(DateTime.Parse(simdi.ToString("HH:mm:ss tt")));
                kalanZaman.Content = d;


                rectOgle.Stroke = System.Windows.Media.Brushes.Orange;
                rectOgle.Fill.Opacity = 1.0;
                KareOgle.Foreground = System.Windows.Media.Brushes.Orange;
                ogleVakti.Foreground= System.Windows.Media.Brushes.Orange;
                ogleresim.Source = new BitmapImage(new Uri(@"ogleOrange3.png", UriKind.RelativeOrAbsolute));
                arkaplanresmi.Source = new BitmapImage(new Uri(@"ogleImg.jpg", UriKind.RelativeOrAbsolute));

                rectGunes.Stroke = System.Windows.Media.Brushes.DarkGray;
                rectGunes.Fill.Opacity = 0.5;
                KareGunes.Foreground = System.Windows.Media.Brushes.White;
                gunesvakti.Foreground = System.Windows.Media.Brushes.White;
                gunesresim.Source = new BitmapImage(new Uri(@"gunesBeyaz.png", UriKind.RelativeOrAbsolute));

            }
            else if (simdi.Hour <= Int32.Parse(ezan1.aksam.Remove(2)) && (simdi.Hour < Int32.Parse(ezan1.aksam.Remove(2)) || simdi.Minute < Int32.Parse(ezan1.aksam.Remove(0, 3))))
            {
                vakit.Content = "AKŞAM EZANINA KALAN";
                TimeSpan d = DateTime.Parse(ezan1.aksam).Subtract(DateTime.Parse(simdi.ToString("HH:mm:ss tt")));
                kalanZaman.Content = d;
                rectIkındı.Stroke = System.Windows.Media.Brushes.Orange;
                rectIkındı.Fill.Opacity= 1.0;
                KareIkindi.Foreground = System.Windows.Media.Brushes.Orange;
                ikindiVakti.Foreground = System.Windows.Media.Brushes.Orange;
                ikindiresim.Source = new BitmapImage(new Uri(@"/ikindiOrange.png", UriKind.RelativeOrAbsolute));
                arkaplanresmi.Source = new BitmapImage(new Uri(@"/ikindiImg.jpg", UriKind.RelativeOrAbsolute));
               
                rectOgle.Stroke = System.Windows.Media.Brushes.DarkGray;
                rectOgle.Fill.Opacity = 0.5;
                KareOgle.Foreground = System.Windows.Media.Brushes.White;
                ogleVakti.Foreground = System.Windows.Media.Brushes.White;                
                ogleresim.Source = new BitmapImage(new Uri(@"ogleWhite.png", UriKind.RelativeOrAbsolute));
                

            }
            else if (simdi.Hour <= Int32.Parse(ezan1.yatsi.Remove(2)) && (simdi.Hour < Int32.Parse(ezan1.yatsi.Remove(2)) || simdi.Minute < Int32.Parse(ezan1.yatsi.Remove(0, 3))))
            {
                vakit.Content = "YATSI EZANINA KALAN";
                TimeSpan d = DateTime.Parse(ezan1.yatsi).Subtract(DateTime.Parse(simdi.ToString("HH:mm:ss tt")));
                kalanZaman.Content = d;
                rectAksam.Stroke = System.Windows.Media.Brushes.Orange;
                rectAksam.Fill.Opacity = 1.0;
                KareAksam.Foreground = System.Windows.Media.Brushes.Orange;
                AksamVakti.Foreground= System.Windows.Media.Brushes.Orange;
                aksamresim.Source = new BitmapImage(new Uri(@"aksamOrange.png", UriKind.RelativeOrAbsolute));
                arkaplanresmi.Source = new BitmapImage(new Uri(@"aksamImg.jpg", UriKind.RelativeOrAbsolute));

                rectIkındı.Stroke = System.Windows.Media.Brushes.DarkGray;
                rectIkındı.Fill.Opacity = 0.5;
                KareIkindi.Foreground = System.Windows.Media.Brushes.White;
                ikindiVakti.Foreground = System.Windows.Media.Brushes.White;
                ikindiresim.Source = new BitmapImage(new Uri(@"ikindiWhite.png", UriKind.RelativeOrAbsolute));
            }
            else
            {
                DateTime saat = new DateTime(simdi.Year, simdi.Month, simdi.Day, 0, 0, 0);
                DateTime saat1 = new DateTime(simdi.Year, simdi.Month, simdi.Day, 23, 59, 59);

                 TimeSpan d = (DateTime.Parse(ezan1.imsak).Subtract(DateTime.Parse(saat.ToString("HH:mm:ss tt")))).Add(DateTime.Parse(saat1.ToString("HH:mm:ss tt")).Subtract(DateTime.Parse(simdi.ToString("HH:mm:ss tt"))));
                kalanZaman.Content = d;
                vakit.Content = "İMSAK VAKTİNE KALAN";
                rectYatsi.Stroke = System.Windows.Media.Brushes.Orange;
                rectYatsi.Fill.Opacity= 1.0;
                
                KareYatsi.Foreground = System.Windows.Media.Brushes.Orange;
                yatsiVakti.Foreground = System.Windows.Media.Brushes.Orange;
                yatsiresim.Source = new BitmapImage(new Uri(@"yatsiOrange.png", UriKind.RelativeOrAbsolute));
                arkaplanresmi.Source = new BitmapImage(new Uri("yatsiImg.jpg", UriKind.RelativeOrAbsolute));

                rectAksam.Stroke = System.Windows.Media.Brushes.DarkGray;
                rectAksam.Fill.Opacity = 0.5;
                KareAksam.Foreground = System.Windows.Media.Brushes.White;
                AksamVakti.Foreground = System.Windows.Media.Brushes.White;
                aksamresim.Source = new BitmapImage(new Uri(@"aksamWhite.png", UriKind.RelativeOrAbsolute));
                
            }
            
            
            
        }

        private void Menubutton_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
private void Menubutton_MouseEnter(object sender, MouseEventArgs e)
        {
           
        }
    }
}
