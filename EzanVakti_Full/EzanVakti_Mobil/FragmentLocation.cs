using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.Widget;
using EzanVakti_Mobil.Resources;
using EzanVakti_Mobil.Resources.AlarmAyarlari;
using EzanVakti_Mobil.Resources.Ayarlar;
using EzanVakti_Mobil.Resources.AyarlarDataBase;
using EzanVakti_Mobil.Resources.VeriTabani;
using Google.Android.Material.BottomSheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EzanVakti_Mobil
{
    public class FragmentLocation : BottomSheetDialogFragment
    {
        AppCompatButton LGuncelle;
        View v;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetStyle(BottomSheetDialogFragment.StyleNormal, Resource.Style.BottomSheetFragmentStyle);
            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

             base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.fragment_bottomsheet_location, container, false);
            view.FindViewById<AppCompatTextView>(Resource.Id.CurrentLocationtxt).Text = namazVaktiApi.fulladres.Replace(", ", "/");
            LGuncelle=view.FindViewById<AppCompatButton>(Resource.Id.bsLocationsUpdateBtn);
            LGuncelle.Click += delegate
            {
                onLocationsEditClick(v);
            };
            return view;
        }
        public void onLocationsEditClick(View v)
        {
            CurrentDatabase.deleteFileTable();
            veritabani.deleteFileTable();
            VaktindeAlarmDatabase.deleteFileTable();
            VakitOncesiAlarmDatabase.deleteFileTable();
            LocationDatabase.deleteFileTable();
            StartActivity(new Intent(Context, typeof(SplashActivity1)));
           
        }
    }
}