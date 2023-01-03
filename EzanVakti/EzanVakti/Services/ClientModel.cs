using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System;

namespace Picasso.Services
{
    public class CLientModel
    {
        private readonly HttpClient client; //http isteği göndermek için HttpClient sınıfından client isimli değişken

        public CLientModel() //kurucu fonksiyon
        {
            client = new HttpClient(); //parametresiz nesne oluşturulduğunda client değişkeni HttpClient sınıfına atanır.
        }
        public async Task<T> ProcessApi<T>(string url) //api verilerini çekmek için string parametreli generic tipine geri dönen method Örn:Task<Prayertime> 
        {
            var uri = new Uri(url); //uri sınıfından nesne oluşturuldu
            T result; //T türünden değişken
            using var streamTask = await client.GetStreamAsync(uri); //streamTask isminde api isteği gönderen ve verileri asenkron olarak alan değişken
            T data = default(T); //data ismin verilerin json serisi olarak saklandığı değişken

            data = await JsonSerializer.DeserializeAsync<T>(streamTask); //json serisi olarak saklanan veriler seri halden çıkarılıyor.
            result = data; //seri halden çıkarılan veriler T türüne atanıyor.
            return result; 


        }
    }
}
