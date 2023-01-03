using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Picasso.Services;
using Picasso.HavaDurumu;

namespace EzanVakti
{
    public class HavaDurumuApi
    {
        private string city;
       public HavaDurumuApi()
        {

        }
        public HavaDurumuApi(string city)
        {
            this.city = city;
        }
        public static string PlaceUri(string Sehir)
        {
            return $"https://api.openweathermap.org/data/2.5/weather?q={Sehir}&mode=json&lang=tr&units=metric&appid=f0a46c1cf8fe28d014ed0783f9884b23";
        }
        public async Task<Weather> WeatherApi()
        {
            var WeatherForecastApi = PlaceUri(city);
            var httpService = new CLientModel();
            var result = await httpService.ProcessApi<Weather>(WeatherForecastApi);

            return result;
        }
    }
}
