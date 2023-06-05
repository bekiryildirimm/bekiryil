using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EzanVakti_Mobil.Resources.EzanVakitleri
{
    public class Date
    {
        public string readable { get; set; }
        public string timestamp { get; set; }
        public Gregorian gregorian { get; set; }
        public Hijri hijri { get; set; }
    }

    public class Datum
    {
        public Timings timings { get; set; }
        public Date date { get; set; }
        public Meta meta { get; set; }
    }

    public class Designation
    {
        public string abbreviated { get; set; }
        public string expanded { get; set; }
    }

    public class Gregorian
    {
        public string date { get; set; }
        public string format { get; set; }
        public string day { get; set; }
        public Weekday weekday { get; set; }
        public Month month { get; set; }
        public string year { get; set; }
        public Designation designation { get; set; }
    }

    public class Hijri
    {
        public string date { get; set; }
        public string format { get; set; }
        public string day { get; set; }
        public Weekday weekday { get; set; }
        public Month month { get; set; }
        public string year { get; set; }
        public Designation designation { get; set; }
        public List<string> holidays { get; set; }
    }

    public class Location
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class Meta
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string timezone { get; set; }
        public Method method { get; set; }
        public string latitudeAdjustmentMethod { get; set; }
        public string midnightMode { get; set; }
        public string school { get; set; }
        public Offset offset { get; set; }
    }

    public class Method
    {
        public int id { get; set; }
        public string name { get; set; }
        public Params @params { get; set; }
        public Location location { get; set; }
    }

    public class Month
    {
        public int number { get; set; }
        public string en { get; set; }
        public string ar { get; set; }
    }

    public class Offset
    {
        public int Imsak { get; set; }
        public int Fajr { get; set; }
        public string Sunrise { get; set; }
        public string Dhuhr { get; set; }
        public string Asr { get; set; }
        public string Maghrib { get; set; }
        public string Sunset { get; set; }
        public int Isha { get; set; }
        public int Midnight { get; set; }
    }

    public class Params
    {
        public int Fajr { get; set; }
        public int Isha { get; set; }
    }

    public class EzanVakti
    {
        public int code { get; set; }
        public string status { get; set; }
        public List<Datum> data { get; set; }
    }

    public class Timings
    {
        public string Fajr { get; set; }
        public string Sunrise { get; set; }
        public string Dhuhr { get; set; }
        public string Asr { get; set; }
        public string Sunset { get; set; }
        public string Maghrib { get; set; }
        public string Isha { get; set; }
        public string Imsak { get; set; }
        public string Midnight { get; set; }
        public string Firstthird { get; set; }
        public string Lastthird { get; set; }
    }

    public class Weekday
    {
        public string en { get; set; }
        public string ar { get; set; }
    }

}