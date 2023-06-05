using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EzanVakti_Mobil.Resources.sehir
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

}