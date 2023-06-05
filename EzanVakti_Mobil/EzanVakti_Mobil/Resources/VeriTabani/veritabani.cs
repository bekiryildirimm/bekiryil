using Android.App;
using Android.Content;
using Android.Database.Sqlite;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.Interop;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EzanVakti_Mobil.Resources.VeriTabani
{
    public class veritabani
    {
       static string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool createDataBase(string dbName)
        {
            
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, dbName)))
                {
                    connection.CreateTable<EzanVakti_Mobil.Resources.namazVaktiData>();
                    
                    return true;
                }
            }
            catch (SQLite.SQLiteException e)
            {
                Log.Info("SQLiteEx", e.Message);
                return false;
            }
        }
      public bool  InsertIntoTableEzanVakti(object namazVaktiDb, string dbName)
        {
            try
            {
                using(var connection = new SQLiteConnection(System.IO.Path.Combine(folder, dbName)))
                {
                    connection.Insert(namazVaktiDb);
                    return true;
                }
            }
            catch (SQLite.SQLiteException e)
            {
                Log.Info("SQLite Ex", e.Message);
                return false;
            }
        }
        public List<namazVaktiData> selectTable(string dbName)
        {
         


                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, dbName)))
                {
                    return connection.Table<namazVaktiData>().ToList();
                }
            

        }
        public bool updateTableNamazVakti(namazVaktiData namazVakti,string dbName)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, dbName)))
                {
                    connection.Query<namazVaktiData>("UPDATE NamazVakti set imsak=?,gunes=?,ogle=?,ikindi=?,aksam=?,yatsi=?,readable=?,GregDate=?,GregDay=?,GregWeekdayEn=?,GregHaftaninGunuKisa=?,GregHaftaninGunuUzun=?,GregMonthNumber=?,GregMonthEn=?,GregAylar=?,GregYear=?,HijriDate=?,HijriDay=?,HijriWeekdayEn=?,HijriMonthNumber=?,HijriMonthEn=?,HijriYear=? where Id=?", namazVakti.imsak, namazVakti.gunes, namazVakti.ogle, namazVakti.ikindi, namazVakti.aksam, namazVakti.yatsi, namazVakti.readable, namazVakti.GregDate, namazVakti.GregDay, namazVakti.GregWeekdayEn, namazVakti.GregHaftaninGunuKisa, namazVakti.GregHaftaninGunuUzun, namazVakti.GregMonthNumber, namazVakti.GregMonthEn, namazVakti.GregAylar, namazVakti.GregYear, namazVakti.HijriDate, namazVakti.HijriDay, namazVakti.HijriWeekdayEn, namazVakti.HijriMonthNumber, namazVakti.HijriMonthEn, namazVakti.HijriYear);
                    return true;
                }
            }
            catch (SQLite.SQLiteException e)
            {
                Log.Info("SQLite Ex", e.Message);
                return false;
            }
        }
        public static bool deleteFileTable()
        {
            try
            {

                var path = System.IO.Path.Combine(folder, "NamazVakti.db");

                SQLiteDatabase.DeleteDatabase(new Java.IO.File(path));
                return true;

            }

            catch (SQLite.SQLiteException e)
            {
                Log.Info("SQLite Ex", e.Message);
                return false;
            }
        }
        public bool deleteTable(object obj,string dbName)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, dbName)))
                {
                    connection.Delete(obj);
                    return true;
                }
            }
            catch (SQLite.SQLiteException e)
            {
                Log.Info("SQLite Ex", e.Message);
                return false;
            }
        }
    }
}