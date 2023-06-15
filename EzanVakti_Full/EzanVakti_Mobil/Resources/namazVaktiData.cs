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
using SQLite;
namespace EzanVakti_Mobil.Resources
{
    [Table("NamazVakti")]
    public class namazVaktiData
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string imsak { get; set; }
        public string gunes { get; set; }
        public string ogle { get; set; }
        public string ikindi { get; set; }
        public string aksam { get; set; }

        public string yatsi { get; set; }
        public string readable { get; set; }
        public string GregDate { get; set; }
        public int GregDay { get; set; }
        public string GregWeekdayEn { get; set; }
        public string GregHaftaninGunuKisa { get; set; }
        public string GregHaftaninGunuUzun { get; set; }
        public int GregMonthNumber { get; set; }
        public string GregMonthEn { get; set; }
        public string GregAylar { get; set; }
        public string GregYear { get; set; }
        public string HijriDate { get; set; }
        public int HijriDay { get; set; }
        public string HijriWeekdayEn { get; set; }
        public int HijriMonthNumber { get; set; }
        public string HijriMonthEn { get; set; }
        public string HijriMonthTr { get; set; }
        public string HijriYear { get; set; }
    }
}