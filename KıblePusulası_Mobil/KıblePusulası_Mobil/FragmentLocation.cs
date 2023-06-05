using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.Widget;
using EzanVakti_Mobil;
using Google.Android.Material.BottomSheet;
using KıblePusulası_Mobil.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KıblePusulası_Mobil
{
    public class FragmentLocation : BottomSheetDialogFragment
    {
        AppCompatTextView KibleTvDegree;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetStyle(BottomSheetDialogFragment.StyleNormal, Resource.Style.BottomSheetFragmentStyle);
            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.fragment_bottomsheet_location, container, false);
            view.FindViewById<AppCompatTextView>(Resource.Id.CurrentLocationtxt).Text = konumApi.fulladres.Replace(", ", "/");
            view.FindViewById<AppCompatTextView>(Resource.Id.KibleTvDegree).Text = "Kıble Açısı:" + SplashActivity1.derece.ToString("0.#");
            return view;
        }
    }
}