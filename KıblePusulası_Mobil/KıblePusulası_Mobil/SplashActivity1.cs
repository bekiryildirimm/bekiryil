using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using KıblePusulası_Mobil;
using KıblePusulası_Mobil.KibleAciHesaplama;
using KıblePusulası_Mobil.Resources;
using Picasso.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace EzanVakti_Mobil
{
    [Activity(Label = "@string/app_name", MainLauncher =true , Theme ="@style/SplashScreen", NoHistory =true)]
    public class SplashActivity1 : Activity
    {
        public static double derece;
        DateTime dt = DateTime.Now;
        CancellationTokenSource cts;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
        protected override async void OnResume()
        {
            base.OnResume();
            await SimulateStartup();
        }

        async Task SimulateStartup()
        {
            var location = await GetCurrentLocation();
         //   var res = await ApiKible(location.Latitude.ToString(), location.Longitude.ToString());
           var adResult = await konumApi.streetApi(location.Latitude.ToString(), location.Longitude.ToString());

            //derece = res.data.direction;
            //await Task.Delay(TimeSpan.FromSeconds(1));
          derece=KibleAcisiHesaplama.KibleAcisiHesapla(location.Latitude,location.Longitude);
                
                

            StartActivity(new Intent(ApplicationContext, typeof(MainActivity)));

            
        }
        public static async Task<Picasso.Kible.Root> ApiKible(string lat, string lgt)
        {
            var KibleApi = $"https://api.aladhan.com/v1/qibla/{lat}/{lgt}";
            var httpService = new CLientModel();
            var result = await httpService.ProcessApi<Picasso.Kible.Root>(KibleApi);
            return result;
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
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}