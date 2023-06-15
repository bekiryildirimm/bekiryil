using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EzanVakti_Mobil.Resources
{
    public class RecViewHolder:RecyclerView.ViewHolder
    {   
       
        public TextView HaftaninGunu { get; set; }
        public TextView weeklyImsak { get; set; }
        public TextView weeklyGunes { get; set; }
        public TextView weeklyOgle { get; set; }
        public TextView weeklyIkindi { get; set; }
        public TextView weeklyAksam { get; set; }
        public TextView weeklyYatsi { get; set; }
        public View cizgi { get; set; }
        public RecViewHolder(View view):base(view)
        {
     
             HaftaninGunu = view.FindViewById<TextView>(Resource.Id.itemWeeklyGun);
             weeklyImsak = view.FindViewById<TextView>(Resource.Id.itemWeeklyImsak);
             weeklyGunes = view.FindViewById<TextView>(Resource.Id.itemWeeklyGunes);
             weeklyOgle = view.FindViewById<TextView>(Resource.Id.itemWeeklyOgle);
             weeklyIkindi = view.FindViewById<TextView>(Resource.Id.itemWeeklyIkindi);
             weeklyAksam = view.FindViewById<TextView>(Resource.Id.itemWeeklyAksam);
            weeklyYatsi = view.FindViewById<TextView>(Resource.Id.itemWeeklyYatsi);
            cizgi= view.FindViewById<View>(Resource.Id.itemWeeklyLine);

        }
    }


    public class RecycleAdapter : RecyclerView.Adapter
    {
        private Activity activity;
        private List<namazVaktiData> data;

        public RecycleAdapter(Activity activity, List<namazVaktiData> data)
        {
            this.activity = activity;
            this.data = data;
        }
        public override int ItemCount
        {
            get { return data.Count; }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
           RecViewHolder r=holder as RecViewHolder;
            r.HaftaninGunu.Text = data[position].GregHaftaninGunuKisa;
            r.weeklyImsak.Text = data[position].imsak;
            r.weeklyGunes.Text = data[position].gunes;
            r.weeklyOgle.Text = data[position].ogle;
            r.weeklyIkindi.Text = data[position].ikindi;
            r.weeklyAksam.Text = data[position].aksam;
            r.weeklyYatsi.Text = data[position].yatsi;
            
            if (position == 0)
            {
                r.cizgi.Visibility = ViewStates.Visible;
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View v = activity.LayoutInflater.Inflate(Resource.Layout.item_weekly_prayer_time, parent, false);
            RecViewHolder holder = new RecViewHolder(v);
            return holder;
        }
    }
}