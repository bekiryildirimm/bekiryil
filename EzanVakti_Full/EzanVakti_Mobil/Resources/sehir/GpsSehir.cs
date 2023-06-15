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

namespace EzanVakti_Mobil.Resources.sehir
{
    public class LocalNames
    {

        public string es { get; set; }
        public string ca { get; set; }
        public string ar { get; set; }
        public string zh { get; set; }
        public string ka { get; set; }
        public string hy { get; set; }
        public string en { get; set; }
        public string ru { get; set; }
        public string tr { get; set; }
        public string pt { get; set; }
        public string ku { get; set; }
        public string ml { get; set; }
        public string fr { get; set; }
        public string de { get; set; }
        public string el { get; set; }
        public string hi { get; set; }

    }

    public class GpsSehir
    {
        public string name { get; set; }
        public LocalNames local_names { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string country { get; set; }
    }
}