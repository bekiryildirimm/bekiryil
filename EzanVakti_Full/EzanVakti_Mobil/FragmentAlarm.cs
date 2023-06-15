using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using EzanVakti_Mobil.Resources;
using Google.Android.Material.BottomSheet;
using Java.Util.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Android;
using Google.Android.Material.Button;
using AndroidX.ConstraintLayout.Widget;
using AndroidX.AppCompat.Widget;
using EzanVakti_Mobil.Resources.AlarmAyarlari;

namespace EzanVakti_Mobil
{
    public class FragmentAlarm : BottomSheetDialogFragment
    {    
        string alarmName;
        AppCompatTextView vaktindeSeciliSes, vakitOncesiSeciliSes, vakitOncesiDk;
        MaterialButton vaktindeSessiz,vaktindeEzan,vaktindeZilSesi,vakitOncesiSessiz, vakitOncesiEzan, vakitOncesiZilSesi;
        ConstraintLayout vaktindeSesClyt;
        AppCompatImageButton vaktindeSesOynat,vakitOncesiSesOynat,vakitOncesibtnEksi, vakitOncesibtnArti;
        AppCompatCheckBox TumVakitlerCheckbox;
        AppCompatButton alarmIptal,alarmKaydet;

        VakitOncesiAlarmAyarlari vakitOncesi;
        VakitOncesiAlarmDatabase vakitOncesiDatabase;
        VaktindeAlarmAyarlari vaktinde;
        VaktindeAlarmDatabase vaktindeDatabase;
        int dkbtn=0, mevcutDk;
        string[] alarmDurum = { "Sessiz", "Bildirim Açık" };
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetStyle(BottomSheetDialogFragment.StyleNormal, Resource.Style.BottomSheetFragmentStyle);
            alarmName = Arguments.GetString("vakit");
            // Create your fragment here
            vaktinde = new VaktindeAlarmAyarlari();
            vaktindeDatabase=new VaktindeAlarmDatabase();
            vakitOncesi = new VakitOncesiAlarmAyarlari();
            vakitOncesiDatabase=new VakitOncesiAlarmDatabase();

            vaktinde = VaktindeAlarmDatabase.selectTable();
            vakitOncesi=VakitOncesiAlarmDatabase.selectTable();




        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

             base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.fragment_bottomsheet_set_alarms, container, false);


            string sehir;
            if (namazVaktiApi.ilce == null)
            {
                sehir = namazVaktiApi.city;
            }
            else
            {
                sehir = namazVaktiApi.city + "/" + namazVaktiApi.ilce;
            }
            view.FindViewById<AppCompatTextView>(Resource.Id.setAlarmTvDistrict).Text = sehir;
            view.FindViewById<AppCompatTextView>(Resource.Id.setAlarmTvPrayerTimeTitle).Text = alarmName.ToUpper();
            vaktindeSeciliSes = view.FindViewById<AppCompatTextView>(Resource.Id.setAlarmTvOnTimeSelectedSoundStr);
            vakitOncesiSeciliSes = view.FindViewById<AppCompatTextView>(Resource.Id.setAlarmTvBeforeTimeSelectedSoundStr);
            vakitOncesiDk = view.FindViewById<AppCompatTextView>(Resource.Id.setAlarmTvBeforeTimeMinutes);
           
            vaktindeSessiz = view.FindViewById<MaterialButton>(Resource.Id.setAlarmBtnOnTimeMuted);
            vaktindeEzan = view.FindViewById<MaterialButton>(Resource.Id.setAlarmBtnOnTimeAdhan);
           
            vakitOncesiSessiz = view.FindViewById<MaterialButton>(Resource.Id.setAlarmBtnBeforeTimeMuted);
            vakitOncesiEzan = view.FindViewById<MaterialButton>(Resource.Id.setAlarmBtnBeforeTimeAdhan);
        
          
            vaktindeSesOynat = view.FindViewById<AppCompatImageButton>(Resource.Id.setAlarmBtnOnTimePlay);
            vakitOncesiSesOynat = view.FindViewById<AppCompatImageButton>(Resource.Id.setAlarmBtnBeforeTimePlay);
            vakitOncesibtnEksi = view.FindViewById<AppCompatImageButton>(Resource.Id.setAlarmBtnBeforeTimeMinus);
            vakitOncesibtnArti = view.FindViewById<AppCompatImageButton>(Resource.Id.setAlarmBtnBeforeTimePlus);
            
            TumVakitlerCheckbox = view.FindViewById<AppCompatCheckBox>(Resource.Id.setAlarmCbSaveAll);
            alarmIptal = view.FindViewById<AppCompatButton>(Resource.Id.setAlarmBtnCancel);
            alarmKaydet = view.FindViewById<AppCompatButton>(Resource.Id.setAlarmBtnSave);

          

                if (alarmName == "imsak")
                {

              
                    mevcutDk = vakitOncesi.imsakdkOncesi;
                    vaktindeSessiz.Checked = !vaktinde.imsakAlarm;
                    vaktindeEzan.Checked = vaktinde.imsakAlarm;
                    vakitOncesiSessiz.Checked = !vakitOncesi.imsakAlarm;
                    vakitOncesiEzan.Checked = vakitOncesi.imsakAlarm;
                    vakitOncesiDk.Text = (vakitOncesi.imsakdkOncesi + dkbtn).ToString() + " dk";
                }
                else if (alarmName == "güneş")
                {
                    mevcutDk = vakitOncesi.gunesdkOncesi;
                    vaktindeSessiz.Checked = !vaktinde.gunesAlarm;
                    vaktindeEzan.Checked = vaktinde.gunesAlarm;
                    vakitOncesiSessiz.Checked = !vakitOncesi.gunesAlarm;
                    vakitOncesiEzan.Checked = vakitOncesi.gunesAlarm;
                    vakitOncesiDk.Text = vakitOncesi.gunesdkOncesi.ToString() + " dk";
                }
                else if (alarmName == "öğle")
                {
                    mevcutDk = vakitOncesi.ogledkOncesi;
                    vaktindeSessiz.Checked = !vaktinde.ogleAlarm;
                    vaktindeEzan.Checked = vaktinde.ogleAlarm;
                    vakitOncesiSessiz.Checked = !vakitOncesi.ogleAlarm;
                    vakitOncesiEzan.Checked = vakitOncesi.ogleAlarm;
                    vakitOncesiDk.Text = vakitOncesi.ogledkOncesi.ToString() + " dk";
                }
                else if (alarmName == "ikindi")
                {
                    mevcutDk = vakitOncesi.ikindidkOncesi;
                    vaktindeSessiz.Checked = !vaktinde.ikindiAlarm;
                    vaktindeEzan.Checked = vaktinde.ikindiAlarm;
                    vakitOncesiSessiz.Checked = !vakitOncesi.ikindiAlarm;
                    vakitOncesiEzan.Checked = vakitOncesi.ikindiAlarm;
                    vakitOncesiDk.Text = vakitOncesi.ikindidkOncesi.ToString() + " dk";
                }
                else if (alarmName == "akşam")
                {
                    mevcutDk = vakitOncesi.aksamdkOncesi;
                    vaktindeSessiz.Checked = !vaktinde.aksamAlarm;
                    vaktindeEzan.Checked = vaktinde.aksamAlarm;
                    vakitOncesiSessiz.Checked = !vakitOncesi.aksamAlarm;
                    vakitOncesiEzan.Checked = vakitOncesi.aksamAlarm;
                    vakitOncesiDk.Text = vakitOncesi.aksamdkOncesi.ToString() + " dk";
                }
                else
                {
                    mevcutDk = vakitOncesi.yatsidkOncesi;
                    vaktindeSessiz.Checked = !vaktinde.yatsiAlarm;
                    vaktindeEzan.Checked = vaktinde.yatsiAlarm;
                    vakitOncesiSessiz.Checked = !vakitOncesi.yatsiAlarm;
                    vakitOncesiEzan.Checked = vakitOncesi.yatsiAlarm;
                    vakitOncesiDk.Text = vakitOncesi.yatsidkOncesi.ToString() + " dk";
            
            }

            vaktindeSeciliSes.Text = alarmDurum[Convert.ToInt32(vaktindeEzan.Checked)];
            vakitOncesiSeciliSes.Text = alarmDurum[Convert.ToInt32(vakitOncesiEzan.Checked)];


            vaktindeSessiz.CheckedChange += delegate
            {
                vaktindeSeciliSes.Text = "Sessiz";
            
            };
            vaktindeEzan.CheckedChange += delegate
            {
                vaktindeSeciliSes.Text = "Bildirim Açık";

            };
            vakitOncesiSessiz.CheckedChange += delegate
            {
                vakitOncesiSeciliSes.Text = "Sessiz";
            };
            vakitOncesiEzan.CheckedChange += delegate
            {
                vakitOncesiSeciliSes.Text = "Bildirim Açık";
            };
                vakitOncesibtnEksi.Click += delegate
                {
                    if (mevcutDk != 5)
                        mevcutDk -= 5;

                    vakitOncesiDk.Text = (mevcutDk).ToString() + " dk";
                };
                vakitOncesibtnArti.Click += delegate
                {
                    if (mevcutDk != 60)
                        mevcutDk += 5;

                    vakitOncesiDk.Text = (mevcutDk).ToString() + " dk";
                };
                alarmIptal.Click += delegate
                {
                    Dismiss();
                };
                alarmKaydet.Click += delegate
                {   
                    if(TumVakitlerCheckbox.Checked)
                    {
                        vaktinde.imsakAlarm = vaktindeEzan.Checked;
                        vaktinde.gunesAlarm = vaktindeEzan.Checked;
                        vaktinde.ogleAlarm = vaktindeEzan.Checked;
                        vaktinde.ikindiAlarm = vaktindeEzan.Checked;
                        vaktinde.aksamAlarm = vaktindeEzan.Checked;
                        vaktinde.yatsiAlarm = vaktindeEzan.Checked;
                        vakitOncesi.imsakAlarm = vakitOncesiEzan.Checked;
                        vakitOncesi.gunesAlarm = vakitOncesiEzan.Checked;
                        vakitOncesi.ogleAlarm = vakitOncesiEzan.Checked;
                        vakitOncesi.ikindiAlarm = vakitOncesiEzan.Checked;
                        vakitOncesi.aksamAlarm = vakitOncesiEzan.Checked;
                        vakitOncesi.yatsiAlarm = vakitOncesiEzan.Checked;
                        vakitOncesi.imsakdkOncesi = mevcutDk;
                        vakitOncesi.gunesdkOncesi = mevcutDk;
                        vakitOncesi.ogledkOncesi = mevcutDk;
                        vakitOncesi.ikindidkOncesi = mevcutDk;
                        vakitOncesi.aksamdkOncesi = mevcutDk;
                        vakitOncesi.yatsidkOncesi = mevcutDk;
                    }
                   else if(alarmName=="imsak")
                    {
                        vaktinde.imsakAlarm = vaktindeEzan.Checked;
                        vakitOncesi.imsakAlarm = vakitOncesiEzan.Checked;
                        vakitOncesi.imsakdkOncesi=mevcutDk;
                        
                    }
                    else if(alarmName=="güneş")
                    {
                        vaktinde.gunesAlarm = vaktindeEzan.Checked;
                        vakitOncesi.gunesAlarm = vakitOncesiEzan.Checked;
                        vakitOncesi.gunesdkOncesi = mevcutDk;
                    }
                    else if(alarmName=="öğle")
                    {
                        vaktinde.ogleAlarm = vaktindeEzan.Checked;
                        vakitOncesi.ogleAlarm = vakitOncesiEzan.Checked;
                        vakitOncesi.ogledkOncesi = mevcutDk;
                    }
                    else if( alarmName=="ikindi")
                    {
                        vaktinde.ikindiAlarm = vaktindeEzan.Checked;
                        vakitOncesi.ikindiAlarm = vakitOncesiEzan.Checked;
                        vakitOncesi.ikindidkOncesi = mevcutDk;
                    }
                    else if(alarmName=="akşam")
                    {
                        vaktinde.aksamAlarm = vaktindeEzan.Checked;
                        vakitOncesi.aksamAlarm = vakitOncesiEzan.Checked;
                        vakitOncesi.aksamdkOncesi = mevcutDk;
                    }
                    else if(alarmName=="yatsı")
                    {
                        vaktinde.yatsiAlarm = vaktindeEzan.Checked;
                        vakitOncesi.yatsiAlarm = vakitOncesiEzan.Checked;
                        vakitOncesi.yatsidkOncesi = mevcutDk;
                    }
                    vaktindeDatabase.UpdateTableAll(vaktinde);
                    vakitOncesiDatabase.UpdateTableAll(vakitOncesi);
  
                    var mainac = (MainActivity)this.Activity;
                    mainac.VaktindeSetAlarm();
                   
                    Dismiss();
                };
              
            return view;
        }
        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            //  Dialog.Window.RequestFeature(WindowFeatures.NoTitle);
            base.OnActivityCreated(savedInstanceState);
            Dialog.Window.Attributes.WindowAnimations = Resource.Style.Animation_Design_BottomSheetDialog;

        }
    }
}