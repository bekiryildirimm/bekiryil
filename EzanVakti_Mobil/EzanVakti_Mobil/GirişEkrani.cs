using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using EzanVakti_Mobil.Resources;
using EzanVakti_Mobil.Resources.AlarmAyarlari;
using Java.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
namespace EzanVakti_Mobil
{
    [Activity(Label = "GirişEkrani")]
    public class GirişEkrani : AppCompatActivity
    {
        CancellationTokenSource cts;
        VakitOncesiAlarmAyarlari vakitOncesi;
        VakitOncesiAlarmDatabase vakitOncesiDatabase;
        VaktindeAlarmAyarlari vaktinde;
        VaktindeAlarmDatabase vaktindeDatabase;
        public static string enlem;
        public static string boylam;
        public static int ay;
        public static int yil;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_first_screen);
            FindViewById<Button>(Resource.Id.btnOk).Click += async delegate
            {
                DateTime dt=DateTime.Now;
               
              var location =await GetCurrentLocation();
                namazVaktiApi.enlem = location.Latitude.ToString();
                namazVaktiApi.boylam = location.Longitude.ToString();
                namazVaktiApi.ay = dt.Month;
                namazVaktiApi.yil = dt.Year;
                namazVaktiApi namazVakti = new namazVaktiApi(location.Latitude.ToString(), location.Longitude.ToString());
                await vakitOncesiDataBaseOlustur();
                await vaktindeDatabaseOlustur();
               await namazVakti.EzanSqlite();
                namazVakti.CurrentInsertTable();
                namazVakti.LocationInsertTable();
                DateTime plusOne = dt.AddMonths(1);
                namazVaktiApi.ay = plusOne.Month;
                await namazVakti.EzanSqlite();
              

                StartActivity(new Intent(ApplicationContext, typeof(MainActivity)));
                this.Finish();
            };
           
            // Create your application here
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
        public Task vaktindeDatabaseOlustur()
        {
            vaktinde = new VaktindeAlarmAyarlari();
            vaktindeDatabase=new VaktindeAlarmDatabase();
            vaktindeDatabase.createDataBaseVaktindeAlarm();
            vaktinde.imsakAlarm = false;
            vaktinde.gunesAlarm= false;
            vaktinde.ogleAlarm= false;
            vaktinde.ikindiAlarm = false;
            vaktinde.aksamAlarm = false;
            vaktinde.yatsiAlarm = false;
            vaktindeDatabase.InsertIntoTableVaktindeAlarm(vaktinde);
            return Task.CompletedTask;
        }
        public Task vakitOncesiDataBaseOlustur()
        {
            vakitOncesi = new VakitOncesiAlarmAyarlari();
            vakitOncesiDatabase=new VakitOncesiAlarmDatabase();
            vakitOncesiDatabase.createDataBaseVaktindeAlarm();
            vakitOncesi.imsakAlarm = false;
            vakitOncesi.gunesAlarm = false;
            vakitOncesi.ogleAlarm=false;
            vakitOncesi.ikindiAlarm = false;
            vakitOncesi.aksamAlarm = false;
            vakitOncesi.yatsiAlarm = false;
            vakitOncesi.imsakdkOncesi = 30;
            vakitOncesi.gunesdkOncesi= 30;
            vakitOncesi.ogledkOncesi = 30;
            vakitOncesi.ikindidkOncesi = 30;
            vakitOncesi.aksamdkOncesi = 30;
            vakitOncesi.yatsidkOncesi= 30;
            vakitOncesiDatabase.InsertIntoTableVaktindeAlarm(vakitOncesi);
            return Task.CompletedTask;
        }

    }
}