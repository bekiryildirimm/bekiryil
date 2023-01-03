using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Picasso.EzanVakitleri
{
    public class Data
    {
        [JsonPropertyName("timings")]
        public Timings Timings { get; set; }

        [JsonPropertyName("date")]
        public Date Date { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }
    public class Date
    {
        [JsonPropertyName("readable")]
        public string Readable { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        [JsonPropertyName("hijri")]
        public Hijri Hijri { get; set; }

        [JsonPropertyName("gregorian")]
        public Gregorian Gregorian { get; set; }
    }
    public class Designation
    {
        [JsonPropertyName("abbreviated")]
        public string Abbreviated { get; set; }

        [JsonPropertyName("expanded")]
        public string Expanded { get; set; }
    }
    public class Gregorian
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("day")]
        public string Day { get; set; }

        [JsonPropertyName("weekday")]
        public Weekday Weekday { get; set; }

        [JsonPropertyName("month")]
        public Month Month { get; set; }

        [JsonPropertyName("year")]
        public string Year { get; set; }

        [JsonPropertyName("designation")]
        public Designation Designation { get; set; }
    }
    public class Hijri
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("day")]
        public string Day { get; set; }

        [JsonPropertyName("weekday")]
        public Weekday Weekday { get; set; }

        [JsonPropertyName("month")]
        public Month Month { get; set; }

        [JsonPropertyName("year")]
        public string Year { get; set; }

        [JsonPropertyName("designation")]
        public Designation Designation { get; set; }

        [JsonPropertyName("holidays")]
        public List<object> Holidays { get; set; }
    }
    public class Location
    {
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }
    }
    public class Meta
    {
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("method")]
        public Method Method { get; set; }

        [JsonPropertyName("latitudeAdjustmentMethod")]
        public string LatitudeAdjustmentMethod { get; set; }

        [JsonPropertyName("midnightMode")]
        public string MidnightMode { get; set; }

        [JsonPropertyName("school")]
        public string School { get; set; }

        [JsonPropertyName("offset")]
        public Offset Offset { get; set; }
    }
    public class Method
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("params")]
        public Params Params { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }
    }
    public class Month
    {
        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("en")]
        public string En { get; set; }

        [JsonPropertyName("ar")]
        public string Ar { get; set; }
    }
    public class Offset
    {
        [JsonPropertyName("Imsak")]
        public int Imsak { get; set; }

        [JsonPropertyName("Fajr")]
        public int Fajr { get; set; }

        [JsonPropertyName("Sunrise")]
        public int Sunrise { get; set; }

        [JsonPropertyName("Dhuhr")]
        public int Dhuhr { get; set; }

        [JsonPropertyName("Asr")]
        public int Asr { get; set; }

        [JsonPropertyName("Maghrib")]
        public int Maghrib { get; set; }

        [JsonPropertyName("Sunset")]
        public int Sunset { get; set; }

        [JsonPropertyName("Isha")]
        public int Isha { get; set; }

        [JsonPropertyName("Midnight")]
        public int Midnight { get; set; }
    }
    public class Params
    {
        [JsonPropertyName("Fajr")]
        public double Fajr { get; set; }

        [JsonPropertyName("Isha")]
        public double Isha { get; set; }
    }
    public class PrayerTime
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("data")]
        public List<Data> data { get; set; }
    }
    public class Timings
    {
        [JsonPropertyName("Fajr")]
        public string Fajr { get; set; }

        [JsonPropertyName("Sunrise")]
        public string Sunrise { get; set; }

        [JsonPropertyName("Dhuhr")]
        public string Dhuhr { get; set; }

        [JsonPropertyName("Asr")]
        public string Asr { get; set; }

        [JsonPropertyName("Sunset")]
        public string Sunset { get; set; }

        [JsonPropertyName("Maghrib")]
        public string Maghrib { get; set; }

        [JsonPropertyName("Isha")]
        public string Isha { get; set; }

        [JsonPropertyName("Imsak")]
        public string Imsak { get; set; }

        [JsonPropertyName("Midnight")]
        public string Midnight { get; set; }

    }
    public class Weekday
    {
        [JsonPropertyName("en")]
        public string En { get; set; }

        [JsonPropertyName("ar")]
        public string Ar { get; set; }
    }
}