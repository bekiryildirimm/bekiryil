using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using Picasso.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KıblePusulası_Mobil.Resources
{











      public class Address
      {
          public string neighbourhood { get; set; }
        public string road { get; set; }
        public string suburb { get; set; }
        public string village { get; set; }
        public string city { get; set; }
          public string town { get; set; }
        public string borough { get; set; }
        public string province { get; set; }

          [JsonProperty("ISO3166-2-lvl4")]
          public string ISO31662lvl4 { get; set; }
          public string region { get; set; }
          public string postcode { get; set; }
          public string country { get; set; }
          public string country_code { get; set; }
      }

      public class openStreet
      {
          public int place_id { get; set; }
          public string licence { get; set; }
          public string osm_type { get; set; }
          public int osm_id { get; set; }
          public string lat { get; set; }
          public string lon { get; set; }
          public int place_rank { get; set; }
          public string category { get; set; }
          public string type { get; set; }
          public double importance { get; set; }
          public string addresstype { get; set; }
          public object name { get; set; }
          public string display_name { get; set; }
          public Address address { get; set; }
          public List<string> boundingbox { get; set; }
      }

    public class konumApi
    {
        public static string fulladres;
        public static string sehir;
        public static string ilce;
        private static string AdresApi(string enlem, string boylam)
        {
            return $"https://nominatim.openstreetmap.org/reverse.php?lat={enlem}&lon={boylam}&zoom=18&format=jsonv2";
      
        }
        public static async Task<openStreet> streetApi(string enlem,string boylam)
        {
            var sehirapi = AdresApi(enlem.Replace(",", "."), boylam.Replace(",", "."));
            var httpService = new CLientModel();
            var streetRes = await httpService.ProcessApi<openStreet>(sehirapi);
            fulladres = streetRes.display_name;


            konumApi.sehir = streetRes.address.city;
       
            if (streetRes.address.town != null)
            {
                konumApi.ilce = streetRes.address.town;
            }
            else if (streetRes.address.borough != null)
            {
                konumApi.ilce = streetRes.address.borough;
            }


            return streetRes;
        }
    }

}