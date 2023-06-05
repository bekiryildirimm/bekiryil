using Android;
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

namespace KıblePusulası_Mobil
{
    [Activity(Label = "MenuActivity",Theme = "@style/AppTheme.CustomTheme")]
    public class MenuActivity : AppCompatActivity
    {
        LinearLayoutCompat settingbtn,locationbtn,miladibtn,dinigunlerbtn;
        RelativeLayout closebtn;
        View v;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
         SetContentView(Resource.Layout.activity_menu);
            // Create your application here
            closebtn = FindViewById<RelativeLayout>(Resource.Id.menuRlytCloseBtn);
      
             locationbtn= FindViewById<LinearLayoutCompat>(Resource.Id.menuLlytLocationsBtn);
             dinigunlerbtn= FindViewById<LinearLayoutCompat>(Resource.Id.menuLlytReligiousDaysBtn);
          

            dinigunlerbtn.Click += delegate
            {
                diniGunClick(v);
            };

            locationbtn.Click += delegate
                         {
                             onLocationClick(v);
                         };
            closebtn.Click += delegate
            {
                onMenuClick(v);
            };

          
        }

       
        public void diniGunClick(View v)
        {
            Intent intent = new Intent();
            intent.PutExtra("menu", "dinigun");
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

    }
}