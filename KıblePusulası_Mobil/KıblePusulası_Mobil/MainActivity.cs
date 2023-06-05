using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using System;
using Picasso.Services;
using Android.Widget;
using static System.Net.Mime.MediaTypeNames;
using EzanVakti_Mobil;
using Android.Views;
using Android.Content;

namespace KıblePusulası_Mobil
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        CancellationTokenSource cts;
        AppCompatImageView a,b,c,d;
        AppCompatTextView txt1;
        RelativeLayout menubtnRlyt;
        View v;
        double derece;
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_pusula);
            a = FindViewById<AppCompatImageView>(Resource.Id.compassRlytCompassTop);
            b = FindViewById<AppCompatImageView>(Resource.Id.compassRlytCompassArrow);
            d= FindViewById<AppCompatImageView>(Resource.Id.compassImgKaaba);
            txt1 = FindViewById<AppCompatTextView>(Resource.Id.compassTvDegree);
            menubtnRlyt = FindViewById<RelativeLayout>(Resource.Id.mainRlytMenuBtn);
            menubtnRlyt.Click += delegate
            {
                onMainClick(v);
            };

            Compass.Start(SensorSpeed.Game);
            Compass.ReadingChanged += pusula;

        }
        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (data.GetStringExtra("menu") == "dinigun")
            {
                Bundle bundle = new Bundle();
                bundle.PutBoolean("status", true);
                StartActivity(new Intent(ApplicationContext, typeof(BrowserActivity)));

            }

            else if (data.GetStringExtra("menu") == "konum")
            {
                Bundle bundle = new Bundle();
                bundle.PutBoolean("status", false);

                FragmentLocation aylikfragment = new FragmentLocation();
                AndroidX.Fragment.App.FragmentManager manager = this.SupportFragmentManager;
                aylikfragment.Arguments = bundle;
                aylikfragment.Show(manager, "dialog");
            }
        }
        public void pusula(object sender, CompassChangedEventArgs e)
        {   
            var dt = e.Reading;
            a.Rotation =(360-(float)dt.HeadingMagneticNorth);
            float opa=b.Rotation = (360 - (float)dt.HeadingMagneticNorth+(float)SplashActivity1.derece);
           int opac=(int)opa;
           
            double opcaty= System.Math.Cos(opa*(Math.PI/180));
            if(opcaty>=0.999999)
            {
                try
                {
                    var duration = TimeSpan.FromMilliseconds(300);
                    Vibration.Vibrate(duration);
                    
                }
                catch(FeatureNotSupportedException ex1)
                {

                }
                catch(Exception ex)
                {

                }
            }
            d.Alpha = (float)opcaty;
            txt1.Text = Convert.ToInt32(dt.HeadingMagneticNorth).ToString()+ "°";
            
        }
        public void onMainClick(View v)
        {
 
            StartActivityForResult(new Intent(ApplicationContext, typeof(MenuActivity)), 12);
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
        public static async Task<Picasso.Kible.Root> ApiKible(string lat, string lgt)
        {
            var KibleApi = $"https://api.aladhan.com/v1/qibla/{lat}/{lgt}";
            var httpService = new CLientModel();
            var result = await httpService.ProcessApi<Picasso.Kible.Root>(KibleApi);
            return result;
        }
    }
}