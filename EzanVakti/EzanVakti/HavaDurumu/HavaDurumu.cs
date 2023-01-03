using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Picasso.HavaDurumu
{
    public class Clouds
    {
        [JsonPropertyName("all")]
        public int all { get; set; }
    }

    public class Coord
    {
        [JsonPropertyName("lon")]
        public double lon { get; set; }
        [JsonPropertyName("lat")]
        public double lat { get; set; }
    }

    public class Main
    {
        [JsonPropertyName("temp")]
        public double temp { get; set; }
        [JsonPropertyName("feels_like")]
        public double feels_like { get; set; }
        [JsonPropertyName("temp_min")]
        public double temp_min { get; set; }
        [JsonPropertyName("temp_max")]
        public double temp_max { get; set; }
        [JsonPropertyName("pressure")]
        public int pressure { get; set; }
        [JsonPropertyName("humidity")]
        public int humidity { get; set; }
    }

    public class Rain
    {
        [JsonPropertyName("1h")]
        public double _1h { get; set; }
    }

    public class Weather
    {
        [JsonPropertyName("coord")]
        public Coord coord { get; set; }
        [JsonPropertyName("weather")]
        public List<Forecast> weather { get; set; }
        [JsonPropertyName("base")]
        public string @base { get; set; }
        [JsonPropertyName("main")]
        public Main main { get; set; }
        [JsonPropertyName("visibility")]
        public int visibility { get; set; }
        [JsonPropertyName("wind")]
        public Wind wind { get; set; }
        [JsonPropertyName("Rain")]
        public Rain rain { get; set; }
        [JsonPropertyName("clouds")]
        public Clouds clouds { get; set; }
        [JsonPropertyName("dt")]
        public int dt { get; set; }
        [JsonPropertyName("sys")]
        public Sys sys { get; set; }
        [JsonPropertyName("timezone")]
        public int timezone { get; set; }
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("name")]
        public string name { get; set; }
        [JsonPropertyName("cod")]
        public int cod { get; set; }
    }

    public class Sys
    {
        [JsonPropertyName("type")]
        public int type { get; set; }
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("country")]
        public string country { get; set; }
        [JsonPropertyName("sunrise")]
        public int sunrise { get; set; }
        [JsonPropertyName("sunset")]
        public int sunset { get; set; }
    }

    public class Forecast
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("main")]
        public string main { get; set; }
        [JsonPropertyName("description")]
        public string description { get; set; }
        [JsonPropertyName("icon")]
        public string icon { get; set; }
    }

    public class Wind
    {
        [JsonPropertyName("speed")]
        public double speed { get; set; }
        [JsonPropertyName("deg")]
        public int deg { get; set; }
    }


}
