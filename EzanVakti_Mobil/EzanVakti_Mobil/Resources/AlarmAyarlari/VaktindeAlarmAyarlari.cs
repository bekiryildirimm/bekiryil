using Android.App;
using Android.Content;
using Android.Database.Sqlite;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using EzanVakti_Mobil.Resources.Ayarlar;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EzanVakti_Mobil.Resources.AlarmAyarlari
{
    [Table("VaktindeAlarmAyarlari")]
    public class VaktindeAlarmAyarlari
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }

        public bool imsakAlarm { get; set; }
        public bool gunesAlarm { get; set; }
        public bool ogleAlarm { get; set; }
        public bool ikindiAlarm { get; set; }
        public bool aksamAlarm { get; set; }
        public bool yatsiAlarm { get; set; }


    }

    public class VaktindeAlarmDatabase
    {
        static string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public bool createDataBaseVaktindeAlarm()
        {

   
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "VaktindeAlarmAyarlari.db")))
                {
                    connection.CreateTable<VaktindeAlarmAyarlari>();

                    return true;
                }
   
        }
        public bool InsertIntoTableVaktindeAlarm(object vaktindeAlarm)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "VaktindeAlarmAyarlari.db")))
                {
                    connection.Insert(vaktindeAlarm);
                    return true;
                }
            }
            catch (SQLite.SQLiteException e)
            {
                Log.Info("SQLite Ex", e.Message);
                return false;
            }
        }
        public static VaktindeAlarmAyarlari selectTable()
        {



            using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "VaktindeAlarmAyarlari.db")))
            {
                return connection.Table<VaktindeAlarmAyarlari>().First();
            }


        }
        public static void selectTableVaktindeAlarm(VaktindeAlarmAyarlari vaktindeAlarm)
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "VaktindeAlarmAyarlari.db")))
            {
               
                connection.Query<VaktindeAlarmAyarlari>("SELECT * from VaktindeAlarmAyarlari where Id=1");
            }
        }
        public void UpdateTableAll(VaktindeAlarmAyarlari vaktindeAlarm)
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "VaktindeAlarmAyarlari.db")))
            {
                connection.Query<VaktindeAlarmAyarlari>("UPDATE VaktindeAlarmAyarlari set imsakAlarm=?,gunesAlarm=?,ogleAlarm=?,ikindiAlarm=?,aksamAlarm=?,yatsiAlarm=? where Id=1", vaktindeAlarm.imsakAlarm, vaktindeAlarm.gunesAlarm, vaktindeAlarm.ogleAlarm, vaktindeAlarm.ikindiAlarm, vaktindeAlarm.aksamAlarm, vaktindeAlarm.yatsiAlarm);
            }
        }

        public static bool deleteFileTable()
        {
            try
            {

                var path = System.IO.Path.Combine(folder, "VaktindeAlarmAyarlari.db");

                SQLiteDatabase.DeleteDatabase(new Java.IO.File(path));
                return true;

            }

            catch (SQLite.SQLiteException e)
            {
                Log.Info("SQLite Ex", e.Message);
                return false;
            }
        }
        public bool deleteTable(object obj)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "VaktindeAlarmAyarlari.db")))
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