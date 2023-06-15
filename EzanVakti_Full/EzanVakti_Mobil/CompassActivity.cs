using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using EzanVakti_Mobil.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace EzanVakti_Mobil
{
    [Activity(Label = "CompassActivity")]
    public class CompassActivity : AppCompatActivity
    {
        CancellationTokenSource cts;
        AppCompatImageView a, b, c, d;
        AppCompatTextView txt1;
        RelativeLayout menubtnRlyt;
        LinearLayoutCompat compassprogres;
        View v;
       private double derece;
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_pusula);
            a = FindViewById<AppCompatImageView>(Resource.Id.compassRlytCompassTop);
            b = FindViewById<AppCompatImageView>(Resource.Id.compassRlytCompassArrow);
            d = FindViewById<AppCompatImageView>(Resource.Id.compassImgKaaba);
            txt1 = FindViewById<AppCompatTextView>(Resource.Id.compassTvDegree);

            compassprogres = FindViewById<LinearLayoutCompat>(Resource.Id.compassLlytLoading);
            var location = await GetCurrentLocation();
            derece=KibleAcisiHesaplama.KibleAcisiHesapla(location.Latitude, location.Longitude);
            compassprogres.Visibility = ViewStates.Gone;
            Compass.Start(SensorSpeed.Game,applyLowPassFilter:true);
            Compass.ReadingChanged += pusula;
            
            // Create your application here
        }
        protected override void OnPause()
        {
            base.OnPause();
            Compass.Stop();
            
        }
        protected override void OnStop()
        {
            base.OnStop();
            Compass.Stop();
        }
        public void pusula(object sender, CompassChangedEventArgs e)
        {
            var dt = e.Reading;
            a.Rotation = (360 - (float)dt.HeadingMagneticNorth);
            float opa = b.Rotation = (360 - (float)dt.HeadingMagneticNorth + (float)derece);
            int opac = (int)opa;
          
            double opcaty = System.Math.Cos(opa * (Math.PI / 180));
            if (opcaty >= 0.999999)
            {
                try
                {
                    var duration = TimeSpan.FromMilliseconds(300);
                    Vibration.Vibrate(duration);

                }
                catch (FeatureNotSupportedException ex1)
                {

                }
                catch (Exception ex)
                {

                }
            }
            d.Alpha = (float)opcaty;
            txt1.Text = Convert.ToInt32(dt.HeadingMagneticNorth).ToString() + "°";

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        async Task<Location> GetCurrentLocation()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                cts = new CancellationTokenSource();
                var location = await Geolocation.GetLocationAsync(request, cts.Token);

                return location;

            }

            catch (Exception ex)
            {
                return null;
                // Unable to get location
            }
        }
    }
}