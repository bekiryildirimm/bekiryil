using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Android.Util;
using Android.Database.Sqlite;

namespace EzanVakti_Mobil.Resources.Ayarlar
{
    [Table("Current")]
    public class Current
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; } 
        public string Sehir { get; set; }
        public int month { get; set; }
        public int year { get; set; }


    }
    public class CurrentDatabase
    {
       static string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool createDataBaseCurrent()
        {

            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Current.db")))
                {
                    connection.CreateTable<Current>();
                    
                    return true;
                }
            }
            catch (SQLite.SQLiteException e)
            {
                Log.Info("SQLiteEx", e.Message);
                return false;
            }
        }
        public bool InsertIntoTableCurrent(object namazVaktiDb)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Current.db")))
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
        public static Current selectTable()
        {



            using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Current.db")))
            {
                return connection.Table<Current>().First();
            }


        }
        public void UpdateTableCurrent(Current current)
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Current.db")))
            {
                connection.Query<Current>("UPDATE Current set Sehir=?,month=?,year=? where Id=1", current.Sehir, current.month, current.year, current.Id);
            }
        }
        public static void selectTableCurrent(Current current)
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Current.db")))
            {
             
                connection.Query<Current>("SELECT * from Current where Id=1");
            }
        }
        public bool deleteTable(object obj, string dbName)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, dbName)))
                {
                    var path = System.IO.Path.Combine(folder, "Current.db");
                    connection.Delete(obj);
                    SQLiteDatabase.DeleteDatabase(new Java.IO.File(path));
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

                    var path = System.IO.Path.Combine(folder, "Current.db");
             
                    SQLiteDatabase.DeleteDatabase(new Java.IO.File(path));
                    return true;
          
            }

            catch (SQLite.SQLiteException e)
            {
                Log.Info("SQLite Ex", e.Message);
                return false;
            }
        }
    }
}