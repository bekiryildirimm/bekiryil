using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Android.Icu.Text.CaseMap;

namespace EzanVakti_Mobil
{
    [BroadcastReceiver]
    public class MyAlarmReceiver : BroadcastReceiver
    {
        static string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public async override void OnReceive(Context context, Intent intent)
        {
            // Android.Net.Uri notification = RingtoneManager.GetDefaultUri(RingtoneType.Notification);
            //Ringtone r = RingtoneManager.GetRingtone(context, notification);
           // Android.Net.Uri notification = RingtoneManager.
           Android.Net.Uri uri=Android.Net.Uri.Parse(System.IO.Path.Combine(folder, "ezan1.mp3"));
            Ringtone r = RingtoneManager.GetRingtone(context,uri);
            r.Play();

            Toast.MakeText(context, "Haydi Namaza!", ToastLength.Short).Show();
            
        }
    }
}