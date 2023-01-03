using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace EzanVakti
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private async void Application_Startup(object sender, StartupEventArgs e)
        {// bu sınıf ve Application_Startup fonksiyonu uygulamanın ilk açılma esnasında çalışır.
            NamazVaktiApi namaz=new NamazVaktiApi();//NamazVaktiApi sınıfından bir nesne oluştur.
            DateTime date = DateTime.Now;//şu anki zaman için Datetime sınıfından datetime.now nesnesi oluştur.
            namaz.EzanFileCheck();//NamazVAktiApi sınıfındaki EzanFileCheck fonksiyonu ile masaüstü bilgisayarında ezan vakitleri bilgilerini tutan txt dosyasının mevcut olup olmadığını kontrol et dosya mevcutsa false değeri döndür. mevcut değilse true değeri döndür
            if(namaz.MevcutDosya==false)
            {//masaüstünde dosya mevcut.
                if (date.Year == namaz.CurrentYear && date.Month == namaz.CurrentMonth) //dosyada bulunan yıl ve ay bilgisini şu an ki tarihle karşılaştır.
                { //dosyada bulunan yıl ve ay bilgileri şu anki tarihle eşleşiyorsa Window1 penceresini aç.
                    Window1 window1 = new Window1();
                    window1.Show();
                }
                else
                {//dosyada bulunan yıl ve ay bilgileri şu anki tarihle eşleşmiyor.

                    namaz.City = namaz.CurrentCity;//NamazVakti sınıfındakiCurrentCity değişkenindeki şehir bilgisini city değişkenine ata
                    namaz.Year = date.Year;//NamazVakti sınıfındaki CurrentYear değişkenindeki mevcut yıl bilgisini year değişkenine ata
                    namaz.Month = date.Month;//NamazVakti sınıfındaki CurrentMonth değişkenindeki mevcut ay bilgisini month değişkenine ata
                    try
                    { //olası exception hatası için try anahtar kelimesi
                        await namaz.EzanFileInput(); //await anahtar kelimesi ile asenkron olarak mevcut tarih bilgisi ve mevcut şehir için api isteği gönder. Gelen verileri txt dosyasına yazdır.

                        Window1 window2 = new Window1();//dosyaya güncel verilerin yazılması bittikten sonra Window1 penceresini aç.
                        window2.Show();
                    }
                    catch (HttpRequestException)
                    { //internet bağlantısı yok HttpRequestException atıldı.
                        MainWindow mainWindow = (Application.Current.MainWindow as MainWindow); //MainWindow penceresi aç
                        mainWindow.Show();
                        mainWindow.viewboxResim.Stretch = Stretch.None;//viewbox stretch özelliğini UniformToFill den None olarak belirle
                        mainWindow.arkaplanresmi.Source = new BitmapImage(new Uri(@"/no-wifi.png", UriKind.RelativeOrAbsolute));//arkaplan resmini değiştir.
                        mainWindow.baglantiyoklabel.Visibility = Visibility.Visible;//internet bağlantısı yok. metnini yazan label görünür yap.
                        mainWindow.Kapat.Visibility = Visibility.Visible;//pencereyi kapatmak Kapat butonunu görünür yap.
                        mainWindow.sehirseclabel.Visibility = Visibility.Hidden;//Bir şehir Seçiniz Label'ın görünürlüğünü kaldır.
                        mainWindow.sehir.Visibility = Visibility.Hidden;//sehir combobox görünürlüğünü kaldır.
                        mainWindow.SehirSec.Visibility = Visibility.Hidden;//SehirSec butonun görünürlüğünü kaldır.
                    }
                }
            }
            else if(namaz.MevcutDosya==true)
            {//dosya mevcut değil o halde MainWindow Penceresini aç.
                MainWindow window = new MainWindow();
                window.Show();
            }

        }
    }
}
