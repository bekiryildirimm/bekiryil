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
    public class ViewHolder:Java.Lang.Object
    {
        public TextView HaftaninGunu { get; set; }
        public TextView weeklyImsak { get; set; }
        public TextView weeklyGunes { get; set; }
        public TextView weeklyOgle { get; set; }
        public TextView weeklyIkindi { get; set; }
        public TextView weeklyAksam { get; set; }
        public TextView weeklyYatsi { get; set; }

    }


    public class RecyclerViewAdapter : BaseAdapter
    {
        private Activity activity;
        private List<namazVaktiData> data;

        public RecyclerViewAdapter(Activity activity, List<namazVaktiData> data)
        {
            this.activity = activity;
            this.data = data;
        }

        public override int Count
        {
            get { return data.Count; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            throw null;
        }

        public override long GetItemId(int position)
        {
            return data[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view=convertView??activity.LayoutInflater.Inflate(Resource.Layout.item_weekly_prayer_time,parent,false);
            var HaftaninGunu = view.FindViewById<TextView>(Resource.Id.itemWeeklyGun);
            var weeklyImsak=view.FindViewById<TextView>(Resource.Id.itemWeeklyImsak);
            var weeklyGunes=view.FindViewById<TextView>(Resource.Id.itemWeeklyGunes);
            var weeklyOgle=view.FindViewById<TextView>(Resource.Id.itemWeeklyOgle);
            var weeklyIkindi=view.FindViewById<TextView>(Resource.Id.itemWeeklyIkindi);
            var weeklyAksam=view.FindViewById<TextView>(Resource.Id.itemWeeklyAksam);
            var weeklyYatsi=view.FindViewById<TextView>(Resource.Id.itemWeeklyYatsi);
            HaftaninGunu.Text=data[position].GregHaftaninGunuKisa;
            weeklyImsak.Text = data[position].imsak;
            weeklyGunes.Text = data[position].gunes;
            weeklyOgle.Text=data[position].ogle;
            weeklyIkindi.Text = data[position].ikindi;
            weeklyAksam.Text = data[position].aksam;
            weeklyYatsi.Text = data[position].yatsi;
            return view;

        }
    }


}