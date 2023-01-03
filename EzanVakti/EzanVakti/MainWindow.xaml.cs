using Picasso.EzanVakitleri;
using Picasso.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Picasso;
using System.Threading;
using System.IO;
using System.Net.Http;

namespace EzanVakti
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()//pencere ilk çalışmaya başladığında devreye giren fonksiyon.
        {
            InitializeComponent();
            baglantiyoklabel.Visibility = Visibility.Hidden;//bağlantiyok labelin görünürlüğünü kaldır.
            Kapat.Visibility=Visibility.Hidden;//Kapat butonun görünürlüğünü kaldır.

        }


  

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }


        private async void SehirSec_Click(object sender, RoutedEventArgs e)//SehirSec butonuna click event fonksiyonu. butona basıldığında aşağıdaki işlemler yapılacak.
        {
            DateTime dt1 = DateTime.Now;//Datetime sınıfından datetime.now nesnesi oluştur.
            List<EzanListe> lst = new List<EzanListe>();//EzanListe sınıfından List nesnesi oluştur.
            NamazVaktiApi ezanvakti = new NamazVaktiApi();//NamazVaktiApi sınıfından nesne oluştur.

            ComboBoxItem deger = (ComboBoxItem)sehir.SelectedItem;//Comboboxta bulunan 81 il seçeneğinden seçilen ögeyi al. Örn:Adana.
            ezanvakti.City = deger.Content.ToString();//Comboboxta seçilen ögeyi stringe çevir. NamazVaktiApi sınıfındaki city değişkenine ata.
            ezanvakti.Year = dt1.Year;//datetime.now dan alınan şu anki yıl bilgisini year değişkenine ata.
            ezanvakti.Month = dt1.Month;//datetime.now dan alınan şu an ki ay integer değerini Month değişkenine ata.


            try
            {//olası exception hatası için try anahtar kelimesi
                await ezanvakti.EzanFileInput();//await anahtar kelimesi ile asenkron olarak mevcut tarih bilgisi ve mevcut şehir için api isteği gönder. Gelen verileri txt dosyasına yazdır.

                Window1 window1 = new Window1();//dosyaya güncel verilerin yazılması bittikten sonra Window1 penceresini aç.
                window1.Show();
                this.Close();
            }
            catch (HttpRequestException) //internet bağlantısı yok HttpRequestException atıldı.
            {
                viewboxResim.Stretch = Stretch.None;//viewbox stretch özelliğini UniformToFill den None olarak belirle
                arkaplanresmi.Source = new BitmapImage(new Uri(@"/no-wifi.png", UriKind.RelativeOrAbsolute));//arkaplan resmini değiştir.
                baglantiyoklabel.Visibility = Visibility.Visible;//internet bağlantısı yok. metnini yazan label görünür yap.
                Kapat.Visibility = Visibility.Visible;//pencereyi kapatmak Kapat butonunu görünür yap.
                sehirseclabel.Visibility = Visibility.Hidden;//Bir şehir Seçiniz Label'ın görünürlüğünü kaldır.
                sehir.Visibility = Visibility.Hidden;//sehir combobox görünürlüğünü kaldır.
                SehirSec.Visibility = Visibility.Hidden;//SehirSec butonun görünürlüğünü kaldır.
            }
        }

        private void Kapat_Click(object sender, RoutedEventArgs e)//Kapat butonu click event.
        {
            this.Close();//butona basıldığında bu pencereyi kapat.
        }
    }
}
