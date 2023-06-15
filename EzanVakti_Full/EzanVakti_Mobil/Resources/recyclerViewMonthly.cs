using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.ConstraintLayout.Widget;
using AndroidX.RecyclerView.Widget;
using Google.Android.Material.BottomSheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

namespace EzanVakti_Mobil.Resources
{
    public class recMonthly : RecyclerView.ViewHolder
    {

        public TextView HaftaninGunu { get; set; }
        public TextView tarih { get; set; }
        public TextView aylikImsak { get; set; }
        public TextView aylikGunes { get; set; }
        public TextView aylikOgle { get; set; }
        public TextView aylikIkindi { get; set; }
        public TextView aylikAksam { get; set; }
        public TextView aylikYatsi { get; set; }
        
        public ConstraintLayout clytmont { get; set; }
        public View cizgi { get; set; }
        public recMonthly(View view) : base(view)
        {
 
            HaftaninGunu = view.FindViewById<TextView>(Resource.Id.itemMonthlyTvDay);
            tarih= view.FindViewById<TextView>(Resource.Id.itemMonthlyTvDate);
            aylikImsak = view.FindViewById<TextView>(Resource.Id.itemMonthlyTvFajr);
            aylikGunes = view.FindViewById<TextView>(Resource.Id.itemMonthlyTvSun);
            aylikOgle = view.FindViewById<TextView>(Resource.Id.itemMonthlyTvDhuhr);
            aylikIkindi = view.FindViewById<TextView>(Resource.Id.itemMonthlyTvAsr);
            aylikAksam = view.FindViewById<TextView>(Resource.Id.itemMonthlyTvMaghrib);
            aylikYatsi = view.FindViewById<TextView>(Resource.Id.itemMonthlyTvIsha);
           clytmont = view.FindViewById<ConstraintLayout>(Resource.Id.itemMonthlyClyt);
        }
    }


    public class recyclerViewMonthly : RecyclerView.Adapter
    {
        private BottomSheetDialogFragment fragment;
        private List<namazVaktiData> data;
        private bool hangi;
        public recyclerViewMonthly(BottomSheetDialogFragment fragment, List<namazVaktiData> data,bool hangi)
        {
            this.fragment = fragment;
            this.data = data;
            this.hangi = hangi;
        }
        public override int ItemCount
        {
            get { return data.Count; }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
             Android.Graphics.Color colorLightGray = new Android.Graphics.Color(AndroidX.Core.Content.ContextCompat.GetColor(Android.App.Application.Context, Resource.Color.clrLightGray));
            Android.Graphics.Color colorbottomsheetBG = new Android.Graphics.Color(AndroidX.Core.Content.ContextCompat.GetColor(Android.App.Application.Context, Resource.Color.clrBottomSheetBg));
            recMonthly r = holder as recMonthly;
            
            r.aylikImsak.Text = data[position].imsak;
            r.aylikGunes.Text = data[position].gunes;
            r.aylikOgle.Text = data[position].ogle;
            r.aylikIkindi.Text = data[position].ikindi;
            r.aylikAksam.Text = data[position].aksam;
            r.aylikYatsi.Text = data[position].yatsi;

         if(hangi)
            {
                r.tarih.Text = data[position].GregDay + " " + data[position].GregAylar + " " + data[position].GregYear;
                r.HaftaninGunu.Text = data[position].GregHaftaninGunuUzun;
            }
            else
            {
                r.tarih.Text = data[position].HijriDay + " " + data[position].HijriMonthTr + " " + data[position].HijriYear;
            }
         if(position%2==0)
            {
                r.clytmont.SetBackgroundColor(colorLightGray);
            }
         else
            {
                r.clytmont.SetBackgroundColor(colorbottomsheetBG);
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View v = fragment.LayoutInflater.Inflate(Resource.Layout.item_monthly_prayer_time, parent, false);
            recMonthly holder = new recMonthly(v);
            return holder;
        }
    }
}