using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EzanVakti_Mobil.Resources.AlarmAyarlari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Android.Icu.Util.Calendar;

namespace EzanVakti_Mobil.Resources
{
    public class Alarmlar
    {
      /*  public long date2mSecond(int yil, int ay, int gun, int saat, int dakika, int saniye)
        {
            DateTime dt1 = new DateTime(yil, ay, gun, saat, dakika, saniye);
            DateTimeOffset dateOffsetValue1 = DateTimeOffset.Parse(dt1.ToString());

            return dateOffsetValue1.ToUnixTimeMilliseconds();
        }
        public long date2mSecond(int yil, int ay, int gun, int saat, int dakika, int saniye, int minusdk)
        {
            DateTime dt1 = new DateTime(yil, ay, gun, saat, dakika, saniye);
            //  DateTime.Parse(dt1).Subtract(TimeSpan.FromMinutes((double)minusdk));
            //DateTime.Parse(.ToString("HH:mm:ss tt")));

            DateTimeOffset dateOffsetValue1 = DateTimeOffset.Parse(dt1.Subtract(TimeSpan.FromMinutes((double)minusdk)).ToString());

            return dateOffsetValue1.ToUnixTimeMilliseconds();
        }
        private void VaktindeSetAlarm()
        {
            vaktinde = new VaktindeAlarmAyarlari();
            vaktinde = VaktindeAlarmDatabase.selectTable();
            vakitOncesi = new VakitOncesiAlarmAyarlari();
            vakitOncesi = VakitOncesiAlarmDatabase.selectTable();
            foreach (var ezan1 in weeklydata)
            {
                // DateTime imsakDate = new DateTime(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.imsak.Remove(2)), Int32.Parse(ezan1.imsak.Remove(0, 3)), 0);
                // DateTimeOffset imsakOffset = DateTimeOffset.Parse(imsakDate.ToString());
                //long imsakMs = imsakOffset.ToUnixTimeMilliseconds();


                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.imsak.Remove(2)), Int32.Parse(ezan1.imsak.Remove(0, 3)), 0), vaktinde.imsakAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.gunes.Remove(2)), Int32.Parse(ezan1.gunes.Remove(0, 3)), 0), vaktinde.gunesAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.ogle.Remove(2)), Int32.Parse(ezan1.ogle.Remove(0, 3)), 0), vaktinde.ogleAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.ikindi.Remove(2)), Int32.Parse(ezan1.ikindi.Remove(0, 3)), 0), vaktinde.ikindiAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.yatsi.Remove(2)), Int32.Parse(ezan1.yatsi.Remove(0, 3)), 0), vaktinde.yatsiAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.aksam.Remove(2)), Int32.Parse(ezan1.aksam.Remove(0, 3)), 0), vaktinde.aksamAlarm);






                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.imsak.Remove(2)), (Int32.Parse(ezan1.imsak.Remove(0, 3))), 0, vakitOncesi.imsakdkOncesi), vakitOncesi.imsakAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.gunes.Remove(2)), Int32.Parse(ezan1.gunes.Remove(0, 3)), 0, vakitOncesi.gunesdkOncesi), vakitOncesi.gunesAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.ogle.Remove(2)), Int32.Parse(ezan1.ogle.Remove(0, 3)), 0, vakitOncesi.ogledkOncesi), vakitOncesi.ogleAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.ikindi.Remove(2)), Int32.Parse(ezan1.ikindi.Remove(0, 3)), 0, vakitOncesi.ikindidkOncesi), vakitOncesi.ikindiAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.yatsi.Remove(2)), Int32.Parse(ezan1.yatsi.Remove(0, 3)), 0, vakitOncesi.aksamdkOncesi), vakitOncesi.yatsiAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.aksam.Remove(2)), Int32.Parse(ezan1.aksam.Remove(0, 3)), 0, vakitOncesi.yatsidkOncesi), vakitOncesi.aksamAlarm);
                */




                /* DateTime gunesDate = new DateTime(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.gunes.Remove(2)), Int32.Parse(ezan1.gunes.Remove(0, 3)), 0);
                 DateTimeOffset gunesOffset = DateTimeOffset.Parse(gunesDate.ToString());
                 long gunesMs = gunesOffset.ToUnixTimeMilliseconds();


                 DateTime ogleDate = new DateTime(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.ogle.Remove(2)), Int32.Parse(ezan1.ogle.Remove(0, 3)), 0);
                 DateTimeOffset ogleOffset = DateTimeOffset.Parse(ogleDate.ToString());
                 long ogleMs = ogleOffset.ToUnixTimeMilliseconds();
                 setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.ogle.Remove(2)), Int32.Parse(ezan1.ogle.Remove(0, 3)), 0), vaktinde.ogleAlarm);

                 DateTime ikindiDate = new DateTime(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.ikindi.Remove(2)), Int32.Parse(ezan1.ikindi.Remove(0, 3)), 0);
                 DateTimeOffset ikindiOffset = DateTimeOffset.Parse(ikindiDate.ToString());
                 long ikindiMs = ikindiOffset.ToUnixTimeMilliseconds();


                 DateTime aksamDate = new DateTime(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.aksam.Remove(2)), Int32.Parse(ezan1.aksam.Remove(0, 3)), 0);
                 DateTimeOffset aksamOffset = DateTimeOffset.Parse(aksamDate.ToString());
                 long aksamMs = aksamOffset.ToUnixTimeMilliseconds();
                 setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.aksam.Remove(2)), Int32.Parse(ezan1.aksam.Remove(0, 3)), 0), vaktinde.aksamAlarm);

                 DateTime yatsiDate = new DateTime(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.yatsi.Remove(2)), Int32.Parse(ezan1.yatsi.Remove(0, 3)), 0);
                 DateTimeOffset yatsiOffset = DateTimeOffset.Parse(yatsiDate.ToString());
                 long yatsiMs = yatsiOffset.ToUnixTimeMilliseconds();



                 date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.gunes.Remove(2)), Int32.Parse(ezan1.gunes.Remove(0, 3)), 0);
                 date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.ogle.Remove(2)), Int32.Parse(ezan1.ogle.Remove(0, 3)), 0);
                 date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.ikindi.Remove(2)), Int32.Parse(ezan1.ikindi.Remove(0, 3)), 0);
                 date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.aksam.Remove(2)), Int32.Parse(ezan1.aksam.Remove(0, 3)), 0);
                 date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.yatsi.Remove(2)), Int32.Parse(ezan1.yatsi.Remove(0, 3)), 0);
                  * DateTime dt1 = new DateTime(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.gunes.Remove(2)), Int32.Parse(ezan1.gunes.Remove(0, 3)), 0);
                  DateTimeOffset dateOffsetValue1 = DateTimeOffset.Parse(dt1.ToString());
                  var am1 = GetSystemService(Android.Content.Context.AlarmService) as AlarmManager;
                  var millisec1 = dateOffsetValue1.ToUnixTimeMilliseconds();
                  var requestCod1 = (int)millisec1 / 1000;
                  var textTimer1 = new StringBuilder();
                  var intent1 = new Intent(ApplicationContext, typeof(MyAlarmReceiver));
                  //intent.PutExtra("Request_Code", requestCod);
                  intent.AddFlags(ActivityFlags.IncludeStoppedPackages);
                  intent.AddFlags(ActivityFlags.ReceiverForeground);
                  var pi1 = PendingIntent.GetBroadcast(this, requestCod1, intent1, 0);
                  if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.M)
                      am1.SetExactAndAllowWhileIdle(AlarmType.RtcWakeup, millisec1, pi1);
                  else
                      am1.SetExact(AlarmType.RtcWakeup, millisec1, pi1);
                  if (!vaktinde.gunesAlarm)
                      am1.Cancel(pi1);

                  DateTime dt2 = new DateTime(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.ogle.Remove(2)), Int32.Parse(ezan1.ogle.Remove(0, 3)), 0);
                  DateTimeOffset dateOffsetValue2 = DateTimeOffset.Parse(dt2.ToString());
                  var am2 = GetSystemService(Android.Content.Context.AlarmService) as AlarmManager;
                  var millisec2 = dateOffsetValue2.ToUnixTimeMilliseconds();
                  var requestCod2 = (int)millisec2 / 1000;
                  var textTimer2 = new StringBuilder();
                  var intent2 = new Intent(ApplicationContext, typeof(MyAlarmReceiver));
                  //intent.PutExtra("Request_Code", requestCod);
                  intent2.AddFlags(ActivityFlags.IncludeStoppedPackages);
                  intent2.AddFlags(ActivityFlags.ReceiverForeground);
                  var pi2 = PendingIntent.GetBroadcast(this, requestCod2, intent2, 0);
                  if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.M)
                      am2.SetExactAndAllowWhileIdle(AlarmType.RtcWakeup, millisec2, pi2);
                  else
                      am2.SetExact(AlarmType.RtcWakeup, millisec2, pi2);
                  if (!vaktinde.ogleAlarm)
                      am2.Cancel(pi2);

                  DateTime dt3 = new DateTime(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.ikindi.Remove(2)), Int32.Parse(ezan1.ikindi.Remove(0, 3)), 0);
                  DateTimeOffset dateOffsetValue3 = DateTimeOffset.Parse(dt3.ToString());
                  long millisec3 = dateOffsetValue3.ToUnixTimeMilliseconds();
                  var requestCod3 = (int)millisec3 / 1000;
                  var am3 = GetSystemService(Android.Content.Context.AlarmService) as AlarmManager;
                  var textTimer3 = new StringBuilder();
                  var intent3 = new Intent(ApplicationContext, typeof(MyAlarmReceiver));
                  //intent.PutExtra("Request_Code", requestCod);
                  intent3.AddFlags(ActivityFlags.IncludeStoppedPackages);
                  intent3.AddFlags(ActivityFlags.ReceiverForeground);
                  var pi3 = PendingIntent.GetBroadcast(this, requestCod3, intent3, 0);
                  if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.M)
                      am3.SetExactAndAllowWhileIdle(AlarmType.RtcWakeup, millisec, pi);
                  else
                      am3.SetExact(AlarmType.RtcWakeup, millisec3, pi3);
                  if (!vaktinde.ikindiAlarm)
                      am3.Cancel(pi3);*/

                /*  DateTime dt3 = new DateTime(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.aksam.Remove(2)), Int32.Parse(ezan1.ikindi.Remove(0, 3)), 0);
                  DateTimeOffset dateOffsetValue3 = DateTimeOffset.Parse(dt3.ToString());
                  var millisec3 = dateOffsetValue.ToUnixTimeMilliseconds();
                  setAlarm()

                  var am3 = GetSystemService(Android.Content.Context.AlarmService) as AlarmManager;
                  long millisec3 = dateOffsetValue.ToUnixTimeMilliseconds();
                  var requestCod3 = (int)millisec / 1000;
                  var textTimer3 = new StringBuilder();
                  var intent3 = new Intent(ApplicationContext, typeof(MyAlarmReceiver));
                  //intent.PutExtra("Request_Code", requestCod);
                  intent3.AddFlags(ActivityFlags.IncludeStoppedPackages);
                  intent3.AddFlags(ActivityFlags.ReceiverForeground);
                  var pi3 = PendingIntent.GetBroadcast(this, requestCod3, intent3, 0);
                  if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.M)
                      am3.SetExactAndAllowWhileIdle(AlarmType.RtcWakeup, millisec, pi);
                  else
                      am3.SetExact(AlarmType.RtcWakeup, millisec3, pi3);
                  if (!vaktinde.ikindiAlarm)
                      am3.Cancel(pi3);*/

            }



         /*    DateTime dt = new DateTime(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.ikindi.Remove(2)), Int32.Parse(ezan1.ikindi.Remove(0, 3)), 0);
             DateTimeOffset dateOffsetValue = DateTimeOffset.Parse(dt.ToString());
             var am = GetSystemService(Android.Content.Context.AlarmService) as AlarmManager;
             var millisec = dateOffsetValue.ToUnixTimeMilliseconds();
             var requestCod = (int)millisec / 1000;
             var textTimer = new StringBuilder();
             var intent = new Intent(ApplicationContext, typeof(MyAlarmReceiver));
             //intent.PutExtra("Request_Code", requestCod);
             intent.AddFlags(ActivityFlags.IncludeStoppedPackages);
             intent.AddFlags(ActivityFlags.ReceiverForeground);
             var pi = PendingIntent.GetBroadcast(this, requestCod, intent, 0);
             if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.M)
                 am.SetExactAndAllowWhileIdle(AlarmType.RtcWakeup, millisec, pi);
             else
                 am.SetExact(AlarmType.RtcWakeup, millisec, pi);

        }

        public void setAlarm(long millisec, bool kontrol)
        {
            AlarmManager am = GetSystemService(Android.Content.Context.AlarmService) as AlarmManager;
           // var act = Android.Content.Context. as ContextWrapper;
            
            int requestCod = (int)millisec / 1000;
            StringBuilder textTimer = new StringBuilder();
            Intent intent = new Intent(Android.App.Application.Context, typeof(MyAlarmReceiver));
            //intent.PutExtra("Request_Code", requestCod);
            intent.AddFlags(ActivityFlags.IncludeStoppedPackages);
            intent.AddFlags(ActivityFlags.ReceiverForeground);
            var pi = PendingIntent.GetBroadcast(MainActivity, requestCod, intent, 0);
            if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.M)
                am.SetExactAndAllowWhileIdle(AlarmType.RtcWakeup, millisec, pi);
            else
                am.SetExact(AlarmType.RtcWakeup, millisec, pi);
            if (!kontrol)
                am.Cancel(pi);
        }*/
   // }
}