using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EzanVakti_Mobil
{
    [Activity(Label = "MenuActivity",Theme = "@style/AppTheme.CustomTheme")]
    public class MenuActivity : AppCompatActivity
    {
        LinearLayoutCompat settingbtn,locationbtn,miladibtn,hicribtn,kuranbtn;
        RelativeLayout closebtn;
        View v;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
     SetContentView(Resource.Layout.activity_menu);
            // Create your application here
            closebtn = FindViewById<RelativeLayout>(Resource.Id.menuRlytCloseBtn);
            settingbtn = FindViewById<LinearLayoutCompat>(Resource.Id.menuLlytSettingsBtn);
             locationbtn= FindViewById<LinearLayoutCompat>(Resource.Id.menuLlytLocationsBtn);
            miladibtn= FindViewById<LinearLayoutCompat>(Resource.Id.menuLlytMiladibtn);
            hicribtn= FindViewById<LinearLayoutCompat>(Resource.Id.menuLlytHijriBtn);

            kuranbtn=FindViewById<LinearLayoutCompat>(Resource.Id.menuLlytMosquesBtn);
            kuranbtn.Click += delegate
            {
                onKuranClick(v);
            };
            miladibtn.Click += delegate
            {
                onMenuMiladiClick(v);
            };
            hicribtn.Click += delegate
                         {
                             onMenuHicriClick(v);
                         };
            locationbtn.Click += delegate
                         {
                             onLocationClick(v);
                         };
            closebtn.Click += delegate
            {
                onMenuClick(v);
            };
            settingbtn.Click += delegate
            {
                onSettingClick(v);
            };

        }

       public void onKuranClick(View v)
        {
            Intent intent = new Intent();
            intent.PutExtra("menu", "kuran");
            SetResult(Result.Ok, intent);
            Finish();
        }
        public void onMenuMiladiClick(View v)
        {
            Intent intent = new Intent();
            intent.PutExtra("menu", "miladi");
            SetResult(Result.Ok, intent);
            Finish();
        }
        public void onMenuHicriClick(View v)
        {
            Intent intent = new Intent();
            intent.PutExtra("menu", "hicri");
            SetResult(Result.Ok, intent);
            Finish();
        }
        public void onLocationClick(View v)
        {
            Intent intent = new Intent();
            intent.PutExtra("menu", "konum");
            SetResult(Result.Ok, intent);
            Finish();
        }
        public void onMenuClick(View v) {
            Intent intent = new Intent();
     
            SetResult(Result.Canceled, intent);
            this.Finish();
        }
        public void onSettingClick(View v)
        {
            Intent intent = new Intent();
            intent.PutExtra("menu", "ayarlar");
            SetResult(Result.Ok, intent);
            Finish();
           


        }
    }
}