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

namespace Picasso.Kible
{
  
    public class Data
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double direction { get; set; }
    }

    public class Root
    {
        public int code { get; set; }
        public string status { get; set; }
        public Data data { get; set; }
    }


}