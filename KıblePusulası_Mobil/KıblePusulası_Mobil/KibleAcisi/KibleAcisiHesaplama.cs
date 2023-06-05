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

namespace KıblePusulası_Mobil.KibleAciHesaplama
{
    public class KibleAcisiHesaplama
    {
        //public static double enlem;
       // public static double boylam;
        public static double KibleAcisiHesapla(double enlem,double boylam)
        {
            //double lat, lon;
      
         //   lat = double.Parse(Console.ReadLine());
    
   //         lon = double.Parse(Console.ReadLine());

            double latRad = deg2rad(enlem);
            double lonRad = deg2rad(boylam);
            double kaabaLatRad = deg2rad(21.4225);
            double kaabaLonRad = deg2rad(39.8262);

            double dLon = kaabaLonRad - lonRad;

            double y = Math.Sin(dLon) * Math.Cos(kaabaLatRad);
            double x = Math.Cos(latRad) * Math.Sin(kaabaLatRad)
                - Math.Sin(latRad) * Math.Cos(kaabaLatRad) * Math.Cos(dLon);

            double azimuth = Math.Atan2(y, x);

            double kibleAcisi = rad2deg(azimuth);
            if (Convert.ToDouble(kibleAcisi) < 0)
            {
                return (360 + kibleAcisi);
            //    Console.WriteLine("Kıble açısı: " + (360 + kibleAcisi) + "°");
            }
            else
            {
                return kibleAcisi;
               // Console.WriteLine("Kıble açısı: " + kibleAcisi + "°");
            }

        }

       private static double deg2rad(double deg)
        {
            return deg * (Math.PI / 180);
        }

        private static double rad2deg(double rad)
        {
            return rad * (180 / Math.PI);
        }
    }
}