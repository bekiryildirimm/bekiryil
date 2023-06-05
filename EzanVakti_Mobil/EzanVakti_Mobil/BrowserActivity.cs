using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using AndroidX.AppCompat.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EzanVakti_Mobil
{
    [Activity(Label = "BrowserActivity")]
    public class BrowserActivity : Activity
    {
        AppCompatImageView browserclosebtn;
        AppCompatTextView browserTitle;
        WebView browserWebview;
        ProgressBar Progress;
        View v;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_browser);
            // Create your application here
            browserWebview = FindViewById<WebView>(Resource.Id.browserWebView);
            Progress = FindViewById<ProgressBar>(Resource.Id.browserProgressBar);
            browserclosebtn = FindViewById<AppCompatImageView>(Resource.Id.browserImgCloseBtn);
            browserclosebtn.Click += delegate
            {
                onBrowserClick(v);
            };

            browserWebview.SetWebViewClient(new Baglanti());
            browserWebview.LoadUrl("https://kuran.diyanet.gov.tr/mushaf/kuran-meal-1/fatiha-suresi-1/ayet-1/diyanet-isleri-baskanligi-meali-1");
            WebSettings webSettings =browserWebview.Settings;
            webSettings.JavaScriptEnabled = true;
            Progress.Visibility = ViewStates.Gone;
            browserWebview.Visibility = ViewStates.Visible;
        }
       public void onBrowserClick(View v)
        {
            this.Finish();
        }
    }
}