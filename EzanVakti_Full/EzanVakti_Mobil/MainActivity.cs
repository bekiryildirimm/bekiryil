using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using EzanVakti_Mobil.Resources;
using EzanVakti_Mobil.Resources.VeriTabani;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Xamarin.Essentials;
using static System.Net.Mime.MediaTypeNames;
using AndroidX.RecyclerView.Widget;
using System.Timers;
using AndroidX.AppCompat.Widget;
using HtmlAgilityPack;
using System.Net.Http;
using AndroidX.ConstraintLayout.Widget;
using Android.Views;
using Android.Graphics.Drawables;
using Java.Interop;
using Android.Renderscripts;
using AndroidX.Transitions;
using EzanVakti_Mobil.Resources.AlarmAyarlari;
using Java.Lang;
using Android.Media;
using Android.Content.Res;
using System.Runtime.Remoting.Contexts;
using Java.Security;
using AndroidX.Core.Content;
using System.Drawing;
using Android.Graphics;
using Android.Graphics.Drawables.Shapes;
using Java.Time.Format;


namespace EzanVakti_Mobil
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        // Api Adresi--> https://api.aladhan.com/v1/calendar/2023/4?latitude=37.017448347669024&longitude=37.34085951963926&&month=4&year=2023&tune=0,0,-7,5,4,6,6,0
        CancellationTokenSource cts;
        RecyclerView rcData;
        RecycleAdapter ada;
        List<namazVaktiData> data,weeklydata,alarmweeklydata,alarmdata;
        veritabani veriTabani;
        DateTime bugun = DateTime.Now;
        namazVaktiData ezan,ezan1;
        TextView kalanVakit,kalanZaman;
        AppCompatTextView diyanet,ayetTitle,hicritxt,miladitxt,dhurur,imsakTitle,gunesTitle, ogleTitle, ikindiTitle, aksamTitle, yatsiTitle,imsakTv, gunesTv, ogleTv, ikindiTv, aksamTv, yatsiTv;
        ConstraintLayout gunesclyt, imsakclyt, ogleclyt, ikindiclyt, aksamclyt, yatsiclyt;
        AppCompatImageView imgImsak, imgGunes, imgOgle, imgIkindi, imgAksam, imgYatsi,vakitimg;
        RelativeLayout menubtn;
        View v;
        LinearLayout mainllyt;
       System.Timers.Timer timer;


        VakitOncesiAlarmAyarlari vakitOncesi;
        VakitOncesiAlarmDatabase vakitOncesiDatabase;
        VaktindeAlarmAyarlari vaktinde;
        VaktindeAlarmDatabase vaktindeDatabase;
        static string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);


        string[] vakit = {
        "İMSAK VAKTİNE KALAN ",
        " GÜNEŞ VAKTİNE KALAN ",
        "ÖĞLE EZANINA KALAN ",
        " İKİNDİ EZANINA KALAN ",
        "AKŞAM EZANINA KALAN ",
         "YATSI EZANINA KALAN"
    };

        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            miladitxt = FindViewById<AppCompatTextView>(Resource.Id.AnaSayfaTarih);
            kalanVakit = FindViewById<TextView>(Resource.Id.KalanVakit);
            kalanZaman = FindViewById<TextView>(Resource.Id.KalanZaman);
            hicritxt = FindViewById<AppCompatTextView>(Resource.Id.mainHicriTakvim);
            menubtn = FindViewById<RelativeLayout>(Resource.Id.mainRlytMenuBtn);
            imsakclyt = FindViewById<ConstraintLayout>(Resource.Id.clytFajr);
            gunesclyt = FindViewById<ConstraintLayout>(Resource.Id.clytSun);
            ogleclyt = FindViewById<ConstraintLayout>(Resource.Id.clytDhuhr);
            ikindiclyt = FindViewById<ConstraintLayout>(Resource.Id.clytAsr);
            aksamclyt = FindViewById<ConstraintLayout>(Resource.Id.clytMaghrib);
            yatsiclyt = FindViewById<ConstraintLayout>(Resource.Id.clytIsha);
            imgImsak = FindViewById<AppCompatImageView>(Resource.Id.imgFajrIc);
           imgGunes = FindViewById<AppCompatImageView>(Resource.Id.imgSunIc);
            imgOgle= FindViewById<AppCompatImageView>(Resource.Id.imgDhuhrIc);
            imgIkindi= FindViewById<AppCompatImageView>(Resource.Id.imgAsrIc);
            imgAksam= FindViewById<AppCompatImageView>(Resource.Id.imgMaghribIc);
           
         //  vakitimg = FindViewById<AppCompatImageView>(Resource.Id.mainvakitimg);

            imgYatsi = FindViewById<AppCompatImageView>(Resource.Id.imgIshaIc);
           imsakTitle = FindViewById<AppCompatTextView>(Resource.Id.tvFajrTitle);
             gunesTitle= FindViewById<AppCompatTextView>(Resource.Id.tvSunTitle);
             ogleTitle= FindViewById<AppCompatTextView>(Resource.Id.tvDhuhrTitle);
             ikindiTitle= FindViewById<AppCompatTextView>(Resource.Id.tvAsrTitle);
             aksamTitle= FindViewById<AppCompatTextView>(Resource.Id.tvMaghribTitle);
            yatsiTitle = FindViewById<AppCompatTextView>(Resource.Id.tvIshaTitle);
           imsakTv = FindViewById<AppCompatTextView>(Resource.Id.tvImsak);
            gunesTv= FindViewById<AppCompatTextView>(Resource.Id.tvGunes);
            ogleTv= FindViewById<AppCompatTextView>(Resource.Id.tvOgle);
           ikindiTv = FindViewById<AppCompatTextView>(Resource.Id.tvIkindi);
            aksamTv= FindViewById<AppCompatTextView>(Resource.Id.tvAksam);
            yatsiTv = FindViewById<AppCompatTextView>(Resource.Id.tvYatsi);
            mainllyt = FindViewById<LinearLayout>(Resource.Id.mainLlyt);
           
           /* using (var inputstream = Assets.Open("sounds/sela.mp3"))
            using (var outputstream = this.ApplicationContext.OpenFileOutput("sela.mp3", FileCreationMode.Private))
            {
                inputstream.CopyTo(outputstream);
            }
           string ali= ApplicationContext.GetFileStreamPath("uyaritonu.mp3").ToString();*/
            //System.IO.Path.Combine(folder, "VakitOncesiAlarmAyarlari.db")
            imsakclyt.Click += delegate
            {
                imsakClick(v);

            };
            gunesclyt.Click += delegate
             {
                 gunesClick(v);

             };
            ogleclyt.Click += delegate
             {
                 ogleClick(v);

             };
            ikindiclyt.Click += delegate
             {
                 ikindiClick(v);

             };
            aksamclyt.Click += delegate
             {
                 aksamClick(v);

             };

            yatsiclyt.Click += delegate
            {
                yatsiClick(v);

            };
            menubtn.Click += delegate
            {
                onMainClick(v);

            };

            hicritxt.Click += delegate
            {
                onHijriClick(v);
            };
            miladitxt.Click += delegate
            {
                onMiladiClick(v);
            };

            DateTime dt = DateTime.Now;


            ezan = new namazVaktiData();
            data = new List<namazVaktiData>();

            veriTabani = new veritabani();
            data = veriTabani.selectTable("NamazVakti.db");



            foreach (var item in data)
            {
                if (item.GregDay == bugun.Day && item.GregMonthNumber == bugun.Month)
                {
                    ezan = item;
                    ezan1 = item;
                }
            }

            miladitxt.Text = "  " + ezan.GregDay + "\n" + ezan.GregAylar + "\n" + ezan.GregYear;
            FindViewById<TextView>(Resource.Id.tvImsak).Text = ezan.imsak;
            FindViewById<TextView>(Resource.Id.tvGunes).Text = ezan.gunes;
            FindViewById<TextView>(Resource.Id.tvOgle).Text = ezan.ogle;
            FindViewById<TextView>(Resource.Id.tvIkindi).Text = ezan.ikindi;
            FindViewById<TextView>(Resource.Id.tvAksam).Text = ezan.aksam;
            FindViewById<TextView>(Resource.Id.tvYatsi).Text = ezan.yatsi;

            hicritxt.Text = " " + ezan.HijriDay + "\n" + ezan.HijriMonthTr + "\n" + ezan.HijriYear;
            rcData = FindViewById<RecyclerView>(Resource.Id.recyclerViewHaftalikVakitler);


            LoadHaftalikEzanVakti();
            VaktindeSetAlarm();
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += EzanTimer;
            timer.Start();
            //  mainllyt.SetBackgroundResource(Resource.Drawable.ogle);
            try
            {
                Diyanet diyanetWeb = new Diyanet();
                await diyanetWeb.CallWeather();
                FindViewById<AppCompatTextView>(Resource.Id.havaDurumuDerece).Text = diyanetWeb.WeatherDerece;
                FindViewById<AppCompatTextView>(Resource.Id.havaDurumuDeger).Text = diyanetWeb.WeatherDeger;
                FindViewById<LinearLayoutCompat>(Resource.Id.frgLocLlytWeather).Visibility= ViewStates.Visible;
            }
            catch(System.Exception ecce)
            {

            }
              try
               {

                   Diyanet diyanetWeb = new Diyanet();

                   await diyanetWeb.CallBirAyet();



                   FindViewById<AppCompatTextView>(Resource.Id.frgLocTvVerseContent).Text = diyanetWeb.BirAyet;
                   FindViewById<AppCompatTextView>(Resource.Id.frgLocTvVerseSource).Text = diyanetWeb.titleAyet;




                   ayetTitle = FindViewById<AppCompatTextView>(Resource.Id.frgLocTvVerseTitle);
                   ayetTitle.Visibility = Android.Views.ViewStates.Visible;


                   FindViewById<ConstraintLayout>(Resource.Id.clytBirAyet).Visibility = Android.Views.ViewStates.Visible;



               }
               catch (System.Exception ex)
               {
               }

            try
            {
                Diyanet diyanetWeb = new Diyanet();
                await diyanetWeb.CallBirHadis();
                if(diyanetWeb.BirHadis==null||diyanetWeb.titleHadis==null)
                {
                    await diyanetWeb.CallBirHadis2();
                }
                FindViewById<AppCompatTextView>(Resource.Id.frgLocTvHadithContent).Text = diyanetWeb.BirHadis;
                FindViewById<AppCompatTextView>(Resource.Id.frgLocTvHadithSource).Text = diyanetWeb.titleHadis;
                FindViewById<ConstraintLayout>(Resource.Id.clytBirHadis).Visibility = Android.Views.ViewStates.Visible;
            }
            catch (System.Exception ex)
            {
 
            }
            try
            {
                Diyanet diyanetWeb = new Diyanet();
                await diyanetWeb.CallTakvimArka();
                FindViewById<AppCompatTextView>(Resource.Id.frgLocTvCalendarBackTitle).Text = diyanetWeb.titleTakvimarka;
                FindViewById<AppCompatTextView>(Resource.Id.frgLocTvCalendarBackContent).Text = diyanetWeb.TakvimArka;
              
                diyanet = FindViewById<AppCompatTextView>(Resource.Id.frgLocTvCalendarBack);
                
                FindViewById<ConstraintLayout>(Resource.Id.clytTakvimArka).Visibility = Android.Views.ViewStates.Visible;
                diyanet.Visibility = Android.Views.ViewStates.Visible;
                if(diyanetWeb.TakvimOn!=null)
                {
                    FindViewById<AppCompatTextView>(Resource.Id.frgLocTvCalendarFront).Text = diyanetWeb.TakvimOn;
                    FindViewById<ConstraintLayout>(Resource.Id.clytTakvimOn).Visibility = Android.Views.ViewStates.Visible;
                }


            }
            catch(System.Exception e)
            {
/*                FindViewById<AppCompatTextView>(Resource.Id.frgLocTvCalendarBackContent).Text = e.Message;

                diyanet = FindViewById<AppCompatTextView>(Resource.Id.frgLocTvCalendarBack);

                FindViewById<ConstraintLayout>(Resource.Id.clytTakvimArka).Visibility = Android.Views.ViewStates.Visible;
                diyanet.Visibility = Android.Views.ViewStates.Visible;*/
            }


            try
            {
                Diyanet diyanetWeb = new Diyanet();
                await diyanetWeb.CallBirDua();
                FindViewById<AppCompatTextView>(Resource.Id.frgLocTvPrayerContent).Text = diyanetWeb.BirDua;
                FindViewById<AppCompatTextView>(Resource.Id.frgLocTvPrayerSource).Text = diyanetWeb.titleDua;
                FindViewById<ConstraintLayout>(Resource.Id.clytBirDua).Visibility = Android.Views.ViewStates.Visible;
            }
            catch (System.Exception ex)
            {

            }
           
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if(data.GetStringExtra("menu")=="miladi")
            {
                            Bundle bundle = new Bundle();
            bundle.PutBoolean("status", true);
            
            FragmentMonthly aylikfragment = new FragmentMonthly();
            AndroidX.Fragment.App.FragmentManager manager = this.SupportFragmentManager;
            aylikfragment.Arguments = bundle;
            aylikfragment.Show(manager, "dialog");
            }
            else if (data.GetStringExtra("menu") == "hicri")
            {
                Bundle bundle = new Bundle();
                bundle.PutBoolean("status", false);

                FragmentMonthly aylikfragment = new FragmentMonthly();
                AndroidX.Fragment.App.FragmentManager manager = this.SupportFragmentManager;
                aylikfragment.Arguments = bundle;
                aylikfragment.Show(manager, "dialog");
            }
            else if (data.GetStringExtra("menu") == "konum")
            {
                Bundle bundle = new Bundle();
                bundle.PutBoolean("status", false);

                FragmentLocation aylikfragment = new FragmentLocation();
                AndroidX.Fragment.App.FragmentManager manager = this.SupportFragmentManager;
                aylikfragment.Arguments = bundle;
                aylikfragment.Show(manager, "dialog");
            }
            else if (data.GetStringExtra("menu") == "kuran")
            {
                /* Bundle bundle = new Bundle();
                 bundle.PutBoolean("status", true);
                 StartActivity(new Intent(ApplicationContext, typeof(BrowserActivity)));*/
                Bundle bundle = new Bundle();
                bundle.PutBoolean("status", true);
                Intent intent = new Intent(ApplicationContext, typeof(BrowserActivity));
                intent.PutExtra("browser", "kuranbrowser");
                //StartActivity(new Intent(ApplicationContext, typeof(BrowserActivity)));
                StartActivity(intent);

            }
            else if (data.GetStringExtra("menu") == "pusula")
            {
                Bundle bundle = new Bundle();
                bundle.PutBoolean("status", true);
                StartActivity(new Intent(ApplicationContext, typeof(CompassActivity)));

            }
            else if (data.GetStringExtra("menu") == "dinigun")
            {
                Bundle bundle = new Bundle();
                bundle.PutBoolean("status", true);
                Intent intent = new Intent(ApplicationContext,typeof(BrowserActivity));
                intent.PutExtra("browser", "dinigunler");
                //StartActivity(new Intent(ApplicationContext, typeof(BrowserActivity)));
                StartActivity(intent);
            }
        }
        public void imsakClick(View v)
        {
            Bundle bundle = new Bundle();
            bundle.PutString("vakit", "imsak");
            FragmentAlarm fragmentAlarm = new FragmentAlarm();
            AndroidX.Fragment.App.FragmentManager manager = this.SupportFragmentManager;
            fragmentAlarm.Arguments = bundle;
            fragmentAlarm.Show(manager, "dialog");
        }


        
        public void gunesClick(View v)
        {
            Bundle bundle = new Bundle();
            bundle.PutString("vakit", "güneş");
            FragmentAlarm fragmentAlarm = new FragmentAlarm();
            AndroidX.Fragment.App.FragmentManager manager = this.SupportFragmentManager;
            fragmentAlarm.Arguments = bundle;
            fragmentAlarm.Show(manager, "dialog");
        }
        public void ogleClick(View v)
        {
            Bundle bundle = new Bundle();
            bundle.PutString("vakit", "öğle");
            FragmentAlarm fragmentAlarm = new FragmentAlarm();
            AndroidX.Fragment.App.FragmentManager manager = this.SupportFragmentManager;
            fragmentAlarm.Arguments = bundle;
            fragmentAlarm.Show(manager, "dialog");
           
        }
        public void ikindiClick(View v)
        {
            Bundle bundle = new Bundle();
            bundle.PutString("vakit", "ikindi");
            FragmentAlarm fragmentAlarm = new FragmentAlarm();
            AndroidX.Fragment.App.FragmentManager manager = this.SupportFragmentManager;
            fragmentAlarm.Arguments = bundle;
            fragmentAlarm.Show(manager, "dialog");
           
        }
        public void aksamClick(View v)
        {
            Bundle bundle = new Bundle();
            bundle.PutString("vakit", "akşam");
            FragmentAlarm fragmentAlarm = new FragmentAlarm();
            AndroidX.Fragment.App.FragmentManager manager = this.SupportFragmentManager;
            fragmentAlarm.Arguments = bundle;
            fragmentAlarm.Show(manager, "dialog");
        }
        public void yatsiClick(View v)
        {
            Bundle bundle = new Bundle();
            bundle.PutString("vakit", "yatsı");
            FragmentAlarm fragmentAlarm = new FragmentAlarm();
            AndroidX.Fragment.App.FragmentManager manager = this.SupportFragmentManager;
            fragmentAlarm.Arguments = bundle;
            fragmentAlarm.Show(manager, "dialog");
        }
        public void onMiladiClick(View v)
        {
            Bundle bundle = new Bundle();
            bundle.PutBoolean("status", true);
            
            FragmentMonthly aylikfragment = new FragmentMonthly();
            AndroidX.Fragment.App.FragmentManager manager = this.SupportFragmentManager;
            aylikfragment.Arguments = bundle;
            aylikfragment.Show(manager, "dialog");
        }


        public Task vaktindeDatabaseOlustur()
        {
            vaktinde = new VaktindeAlarmAyarlari();
            vaktindeDatabase = new VaktindeAlarmDatabase();
        
            vaktinde.imsakAlarm = false;
            vaktinde.gunesAlarm = false;
            vaktinde.ogleAlarm = false;
            vaktinde.ikindiAlarm = false;
            vaktinde.aksamAlarm = false;
            vaktinde.yatsiAlarm = false;
            vaktindeDatabase.InsertIntoTableVaktindeAlarm(vaktinde);
            return Task.CompletedTask;
        }
        public Task vakitOncesiDataBaseOlustur()
        {
            vakitOncesi = new VakitOncesiAlarmAyarlari();
            vakitOncesiDatabase = new VakitOncesiAlarmDatabase();
            vakitOncesiDatabase.createDataBaseVaktindeAlarm();
            vakitOncesi.imsakAlarm = false;
            vakitOncesi.gunesAlarm = false;
            vakitOncesi.ogleAlarm = false;
            vakitOncesi.ikindiAlarm = false;
            vakitOncesi.aksamAlarm = false;
            vakitOncesi.yatsiAlarm = false;
            vakitOncesi.imsakdkOncesi = 5;
            vakitOncesi.gunesdkOncesi = 5;
            vakitOncesi.ogledkOncesi = 5;
            vakitOncesi.ikindidkOncesi = 5;
            vakitOncesi.aksamdkOncesi = 5;
            vakitOncesi.yatsidkOncesi = 5;
            vakitOncesiDatabase.InsertIntoTableVaktindeAlarm(vakitOncesi);
            return Task.CompletedTask;
        }
        public void onHijriClick(View v)
        {
            Bundle bundle = new Bundle();
            bundle.PutBoolean("status", false);

            FragmentMonthly aylikfragment = new FragmentMonthly();
            AndroidX.Fragment.App.FragmentManager manager = this.SupportFragmentManager;
            aylikfragment.Arguments = bundle;
            aylikfragment.Show(manager, "dialog");


        }
        public void onMainClick(View v)
        {

            StartActivityForResult(new Intent(ApplicationContext, typeof(MenuActivity)), 12);

        }

        private void VaktindeSetAlarm2()
        {
            vaktinde = new VaktindeAlarmAyarlari();
            vaktinde = VaktindeAlarmDatabase.selectTable();
            DateTime dt = new DateTime(Int32.Parse(ezan.GregYear), ezan1.GregMonthNumber,ezan1.GregDay, Int32.Parse(ezan1.ikindi.Remove(2)), Int32.Parse(ezan1.ikindi.Remove(0, 3)), 0);
            DateTimeOffset dateOffsetValue = DateTimeOffset.Parse(dt.ToString());
            var am = GetSystemService(Android.Content.Context.AlarmService) as AlarmManager;
            var millisec = dateOffsetValue.ToUnixTimeMilliseconds();
            var requestCod = (int)millisec / 1000;
            var textTimer = new StringBuilder();
            var intent=new Intent(ApplicationContext, typeof(MyAlarmReceiver));
      
            intent.AddFlags(ActivityFlags.IncludeStoppedPackages);
            intent.AddFlags(ActivityFlags.ReceiverForeground);
            var pi = PendingIntent.GetBroadcast(this, requestCod, intent, 0);
            if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.M)
                am.SetExactAndAllowWhileIdle(AlarmType.RtcWakeup, millisec, pi);
            else
                am.SetExact(AlarmType.RtcWakeup,millisec, pi);
           
        }
        public long date2mSecond(int yil,int ay,int gun,int saat,int dakika,int saniye)
        {
            DateTime dt1 = new DateTime(yil, ay, gun, saat, dakika, saniye);
            DateTime simdi = DateTime.Now;
           if(simdi.CompareTo(dt1)>0)
            {
                return 0;
            }
            else
            {
                DateTimeOffset dateOffsetValue1 = DateTimeOffset.Parse(dt1.ToString());

                return dateOffsetValue1.ToUnixTimeMilliseconds();
            }

        }
        public long date2mSecond(int yil, int ay, int gun, int saat, int dakika, int saniye,int minusdk)
        {
            DateTime dt1 = new DateTime(yil, ay, gun, saat, dakika, saniye);

            DateTime simdi = DateTime.Now;
            if(simdi.CompareTo(dt1.Subtract(TimeSpan.FromMinutes((double)minusdk))) >0)
            {
                return 0;
            }
            else
            {
                DateTimeOffset dateOffsetValue1 = DateTimeOffset.Parse(dt1.Subtract(TimeSpan.FromMinutes((double)minusdk)).ToString());

                return dateOffsetValue1.ToUnixTimeMilliseconds();
            }


        }
        public void VaktindeSetAlarm()
        {
            vaktinde = new VaktindeAlarmAyarlari();
            vaktinde = VaktindeAlarmDatabase.selectTable();
            vakitOncesi = new VakitOncesiAlarmAyarlari();
            vakitOncesi=VakitOncesiAlarmDatabase.selectTable();
            alarmdata = new List<namazVaktiData>();
            alarmweeklydata = new List<namazVaktiData>();
            veriTabani = new veritabani();
            alarmdata = veriTabani.selectTable("NamazVakti.db");
            int i = 0;
            foreach (var item in alarmdata)
            {
                /*if (bugun.Day <= item.GregDay && bugun.Day + 6 >= item.GregDay && bugun.Month == item.GregMonthNumber)
                    alarmweeklydata.Add(item);*/
                if ((bugun.Day <= item.GregDay && bugun.Day + 6 >= item.GregDay && bugun.Month == item.GregMonthNumber) || (i < 7 && i != 0))
                {
                    alarmweeklydata.Add(item);
                    i++;
                }
            }
            i = 0;
            foreach (var ezan1 in alarmweeklydata)
                {


                
                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.imsak.Remove(2)), Int32.Parse(ezan1.imsak.Remove(0, 3)), 0), vaktinde.imsakAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.gunes.Remove(2)), Int32.Parse(ezan1.gunes.Remove(0, 3)), 0), vaktinde.gunesAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.ogle.Remove(2)), Int32.Parse(ezan1.ogle.Remove(0, 3)), 0), vaktinde.ogleAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.ikindi.Remove(2)), Int32.Parse(ezan1.ikindi.Remove(0, 3)), 0), vaktinde.ikindiAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.yatsi.Remove(2)), Int32.Parse(ezan1.yatsi.Remove(0, 3)), 0), vaktinde.yatsiAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.aksam.Remove(2)), Int32.Parse(ezan1.aksam.Remove(0, 3)), 0), vaktinde.aksamAlarm);




                

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.imsak.Remove(2)), (Int32.Parse(ezan1.imsak.Remove(0, 3))), 0,vakitOncesi.imsakdkOncesi), vakitOncesi.imsakAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.gunes.Remove(2)), Int32.Parse(ezan1.gunes.Remove(0, 3)), 0,vakitOncesi.gunesdkOncesi), vakitOncesi.gunesAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.ogle.Remove(2)), Int32.Parse(ezan1.ogle.Remove(0, 3)), 0,vakitOncesi.ogledkOncesi), vakitOncesi.ogleAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.ikindi.Remove(2)), Int32.Parse(ezan1.ikindi.Remove(0, 3)), 0,vakitOncesi.ikindidkOncesi), vakitOncesi.ikindiAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.yatsi.Remove(2)), Int32.Parse(ezan1.yatsi.Remove(0, 3)), 0,vakitOncesi.aksamdkOncesi) , vakitOncesi.yatsiAlarm);

                setAlarm(date2mSecond(Int32.Parse(ezan1.GregYear), ezan1.GregMonthNumber, ezan1.GregDay, Int32.Parse(ezan1.aksam.Remove(2)), Int32.Parse(ezan1.aksam.Remove(0, 3)), 0,vakitOncesi.yatsidkOncesi) , vakitOncesi.aksamAlarm);
                





            }





        }

        public void currentPrayerTimebg(int icon,ConstraintLayout vakitClyt,AppCompatTextView title, AppCompatTextView tv,AppCompatImageView iconsrc)
        {
            iconsrc.SetImageResource(icon);
            Drawable shape2 = vakitClyt.Background;
            Android.Graphics.Color colorPrm = new Android.Graphics.Color(ContextCompat.GetColor(this.ApplicationContext, Resource.Color.colorPrimary));
            Android.Graphics.Color colorPrmDark = new Android.Graphics.Color(ContextCompat.GetColor(this.ApplicationContext, Resource.Color.colorPrimaryDark));
            var shape = vakitClyt.Background as GradientDrawable;
           shape2= shape.Mutate();
            title.SetTextColor(colorPrm);
            tv.SetTextColor(colorPrm);
            int dark = Resource.Color.colorPrimaryDark;
            int[] color = new int[3] { dark, dark, dark };



            shape.SetStroke(2, colorPrm);

    

            shape.SetColors(color);
  
        }
        public void pastPrayerTimebg(int icon, ConstraintLayout vakitClyt, AppCompatTextView title, AppCompatTextView tv, AppCompatImageView iconsrc)
        {
            iconsrc.SetImageResource(icon);
    
            Android.Graphics.Color colorPrm = new Android.Graphics.Color(ContextCompat.GetColor(this.ApplicationContext, Resource.Color.clrPrayerTimePastIcon));
            Android.Graphics.Color colorPrmDark = new Android.Graphics.Color(ContextCompat.GetColor(this.ApplicationContext, Resource.Color.colorPrimaryDark));
        
            title.SetTextColor(colorPrm);
            tv.SetTextColor(colorPrm);
            int dark = Resource.Color.colorPrimaryDark;
            int[] color = new int[3] { dark, dark, dark };


            vakitClyt.SetBackgroundResource(Resource.Drawable.bg_background_prayer);
    
        }

        private void setAlarm(long millisec,bool kontrol)
        {

            DateTime a = DateTime.Now;
           
            int requestCod = (int)millisec / 1000;
            StringBuilder textTimer = new StringBuilder();
            
            Intent intent = new Intent(ApplicationContext, typeof(MyAlarmReceiver));
          
            intent.AddFlags(ActivityFlags.IncludeStoppedPackages);
            intent.AddFlags(ActivityFlags.ReceiverForeground);
            var pi = PendingIntent.GetBroadcast(this, requestCod, intent, 0);
            AlarmManager am = GetSystemService(Android.Content.Context.AlarmService) as AlarmManager;
            if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.M)
                am.SetExactAndAllowWhileIdle(AlarmType.RtcWakeup, millisec, pi);
            else
                am.SetExact(AlarmType.RtcWakeup, millisec, pi);
            if (!kontrol||millisec==0)
                am.Cancel(pi);
        }
        void EzanTimer(object sender, EventArgs e)
        {
   
            FindViewById<AppCompatTextView>(Resource.Id.mainYerelSaat).Text = DateTime.Now.ToString("HH:mm");

            DateTime simdi = DateTime.Now;
            if (simdi.Hour <= Int32.Parse(ezan1.imsak.Remove(2)) && (simdi.Hour < Int32.Parse(ezan1.imsak.Remove(2)) || simdi.Minute < Int32.Parse(ezan1.imsak.Remove(0, 3))))
            {
                kalanVakit.Text ="İMSAK VAKTİNE KALAN";
                TimeSpan d = DateTime.Parse(ezan1.imsak).Subtract(DateTime.Parse(simdi.ToString("HH:mm:ss tt")));
                kalanZaman.Text = d.ToString();
                currentPrayerTimebg(Resource.Drawable.ic_prayer_time_isha_primary_color, yatsiclyt, yatsiTitle, yatsiTv,imgYatsi);
                if (mainllyt.Background != GetDrawable(Resource.Drawable.yatsi))
                    mainllyt.SetBackgroundResource(Resource.Drawable.yatsi);
            }
            else if (simdi.Hour <= Int32.Parse(ezan1.gunes.Remove(2)) && (simdi.Hour < Int32.Parse(ezan1.gunes.Remove(2)) || simdi.Minute < Int32.Parse(ezan1.gunes.Remove(0, 3))))
            {
                kalanVakit.Text = "GÜNES VAKTİNE KALAN";
                TimeSpan d = DateTime.Parse(ezan1.gunes).Subtract(DateTime.Parse(simdi.ToString("HH:mm:ss tt")));
                kalanZaman.Text = d.ToString();

                if (mainllyt.Background != GetDrawable(Resource.Drawable.imsak))
                    mainllyt.SetBackgroundResource(Resource.Drawable.imsak);

                pastPrayerTimebg(Resource.Drawable.ic_prayer_time_isha, yatsiclyt, yatsiTitle, yatsiTv, imgYatsi);
                currentPrayerTimebg(Resource.Drawable.ic_prayer_time_fajr_primary_color, imsakclyt, imsakTitle, imsakTv, imgImsak);
            }
            else if (simdi.Hour <= Int32.Parse(ezan1.ogle.Remove(2)) && (simdi.Hour < Int32.Parse(ezan1.ogle.Remove(2)) || simdi.Minute < Int32.Parse(ezan1.ogle.Remove(0, 3))))
            {
                kalanVakit.Text = "ÖĞLE EZANINA KALAN";
                TimeSpan d = DateTime.Parse(ezan1.ogle).Subtract(DateTime.Parse(simdi.ToString("HH:mm:ss tt")));
                kalanZaman.Text = d.ToString();
                if (mainllyt.Background != GetDrawable(Resource.Drawable.gunes))
                    mainllyt.SetBackgroundResource(Resource.Drawable.gunes);

                pastPrayerTimebg(Resource.Drawable.ic_prayer_time_fajr_past, imsakclyt, imsakTitle, imsakTv, imgImsak);
                currentPrayerTimebg(Resource.Drawable.ic_prayer_time_sun_primary_color, gunesclyt, gunesTitle, gunesTv, imgGunes);
            }
            else if (simdi.Hour <= Int32.Parse(ezan1.ikindi.Remove(2)) && (simdi.Hour < Int32.Parse(ezan1.ikindi.Remove(2)) || simdi.Minute < Int32.Parse(ezan1.ikindi.Remove(0, 3))))
            {


                kalanVakit.Text = "İKİNDİ EZANINA KALAN";
                TimeSpan d = DateTime.Parse(ezan1.ikindi).Subtract(DateTime.Parse(simdi.ToString("HH:mm:ss tt")));
                kalanZaman.Text = d.ToString();


                pastPrayerTimebg(Resource.Drawable.ic_prayer_time_fajr_past, imsakclyt, imsakTitle, imsakTv, imgImsak);
                pastPrayerTimebg(Resource.Drawable.ic_prayer_time_sun_past, gunesclyt, gunesTitle, gunesTv, imgGunes);
                currentPrayerTimebg(Resource.Drawable.ic_prayer_time_dhuhr_primary_color,ogleclyt ,ogleTitle ,ogleTv,imgOgle );

                if (mainllyt.Background != GetDrawable(Resource.Drawable.ogle))
                    mainllyt.SetBackgroundResource(Resource.Drawable.ogle);
                //mainllyt.
               // Drawable drawable;
                //drawable.
            //  mainllyt.Background=new Drawable()
            
            }
            else if (simdi.Hour <= Int32.Parse(ezan1.aksam.Remove(2)) && (simdi.Hour < Int32.Parse(ezan1.aksam.Remove(2)) || simdi.Minute < Int32.Parse(ezan1.aksam.Remove(0, 3))))
            {
                kalanVakit.Text = "AKŞAM EZANINA KALAN";
                TimeSpan d = DateTime.Parse(ezan1.aksam).Subtract(DateTime.Parse(simdi.ToString("HH:mm:ss tt")));
                kalanZaman.Text = d.ToString();
                if (mainllyt.Background != GetDrawable(Resource.Drawable.ikindi))
                    mainllyt.SetBackgroundResource(Resource.Drawable.ikindi);

                pastPrayerTimebg(Resource.Drawable.ic_prayer_time_fajr_past, imsakclyt, imsakTitle, imsakTv, imgImsak);
                pastPrayerTimebg(Resource.Drawable.ic_prayer_time_sun_past, gunesclyt, gunesTitle, gunesTv, imgGunes);
                pastPrayerTimebg(Resource.Drawable.ic_prayer_time_dhuhr_past, ogleclyt, ogleTitle, ogleTv, imgOgle);
                currentPrayerTimebg(Resource.Drawable.ic_prayer_time_asr_primary_color, ikindiclyt, ikindiTitle, ikindiTv, imgIkindi);

            }
            else if (simdi.Hour <= Int32.Parse(ezan1.yatsi.Remove(2)) && (simdi.Hour < Int32.Parse(ezan1.yatsi.Remove(2)) || simdi.Minute < Int32.Parse(ezan1.yatsi.Remove(0, 3))))
            {
                kalanVakit.Text = "YATSI EZANINA KALAN";
                TimeSpan d = DateTime.Parse(ezan1.yatsi).Subtract(DateTime.Parse(simdi.ToString("HH:mm:ss tt")));
                kalanZaman.Text = d.ToString();
                if (mainllyt.Background != GetDrawable(Resource.Drawable.aksam))
                    mainllyt.SetBackgroundResource(Resource.Drawable.aksam);

                pastPrayerTimebg(Resource.Drawable.ic_prayer_time_fajr_past, imsakclyt, imsakTitle, imsakTv, imgImsak);
                pastPrayerTimebg(Resource.Drawable.ic_prayer_time_sun_past, gunesclyt, gunesTitle, gunesTv, imgGunes);
                pastPrayerTimebg(Resource.Drawable.ic_prayer_time_dhuhr_past, ogleclyt, ogleTitle, ogleTv, imgOgle);
                pastPrayerTimebg(Resource.Drawable.ic_prayer_time_asr_past, ikindiclyt, ikindiTitle, ikindiTv, imgIkindi);
                currentPrayerTimebg(Resource.Drawable.ic_prayer_time_maghrib_primary_color, aksamclyt, aksamTitle, aksamTv, imgAksam);
               
            }
            else
            {
                DateTime saat = new DateTime(simdi.Year, simdi.Month, simdi.Day, 0, 0, 0);
                DateTime saat1 = new DateTime(simdi.Year, simdi.Month, simdi.Day, 23, 59, 59);

                TimeSpan d = (DateTime.Parse(ezan1.imsak).Subtract(DateTime.Parse(saat.ToString("HH:mm:ss tt")))).Add(DateTime.Parse(saat1.ToString("HH:mm:ss tt")).Subtract(DateTime.Parse(simdi.ToString("HH:mm:ss tt"))));
              kalanZaman.Text = d.ToString();
                kalanVakit.Text = "İMSAK VAKTİNE KALAN";
                //Drawable resim = mainllyt.Background;
                if (mainllyt.Background != GetDrawable(Resource.Drawable.yatsi))
                    mainllyt.SetBackgroundResource(Resource.Drawable.yatsi);

             //   vakitimg.SetImageResource(Resource.Drawable.gunes);
                pastPrayerTimebg(Resource.Drawable.ic_prayer_time_sun_past, gunesclyt, gunesTitle, gunesTv, imgGunes);
                pastPrayerTimebg(Resource.Drawable.ic_prayer_time_dhuhr_past, ogleclyt, ogleTitle, ogleTv, imgOgle);
                pastPrayerTimebg(Resource.Drawable.ic_prayer_time_asr_past, ikindiclyt, ikindiTitle, ikindiTv, imgIkindi);
                pastPrayerTimebg(Resource.Drawable.ic_prayer_time_maghrib_past, aksamclyt, aksamTitle, aksamTv,imgAksam);
                currentPrayerTimebg(Resource.Drawable.ic_prayer_time_isha_primary_color, yatsiclyt, yatsiTitle, yatsiTv, imgYatsi);
                
            }


        }
        private void LoadHaftalikEzanVakti()
        {  
            weeklydata = new List<namazVaktiData>();
            int i = 0;

        foreach(var item in data)
            {
                if ((bugun.Day <= item.GregDay && bugun.Day + 6 >= item.GregDay && bugun.Month == item.GregMonthNumber) || (i < 7&&i!=0))
                {
                    weeklydata.Add(item);
                    i++;
                }
            }
            i = 0;
            ada = new RecycleAdapter(this, weeklydata);
            rcData.SetAdapter(ada);
        }
        protected async override void OnResume()
        {
            base.OnResume(); // Always call the superclass first.
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += EzanTimer;
          if(!timer.Enabled)
                timer.Start();
             /*  try
               {

                   Diyanet diyanetWeb = new Diyanet();

                   await diyanetWeb.CallBirAyet();



                   FindViewById<AppCompatTextView>(Resource.Id.frgLocTvVerseContent).Text = diyanetWeb.BirAyet;
                   FindViewById<AppCompatTextView>(Resource.Id.frgLocTvVerseSource).Text = diyanetWeb.titleAyet;




                   ayetTitle = FindViewById<AppCompatTextView>(Resource.Id.frgLocTvVerseTitle);
                   ayetTitle.Visibility = Android.Views.ViewStates.Visible;


                   FindViewById<ConstraintLayout>(Resource.Id.clytBirAyet).Visibility = Android.Views.ViewStates.Visible;

               

            }
               catch (System.Exception ex)
               {
               }

            timer.Start();
            */

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {

            FindViewById<TextView>(Resource.Id.mainYerelSaat).Text= DateTime.Now.ToString("HH:mm");
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        async Task<Location> GetCurrentLocation()
        {
 
                var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                cts = new CancellationTokenSource();
                var location = await Geolocation.GetLocationAsync(request, cts.Token);

        
                    return location;
                
 
            


        }
    }
}