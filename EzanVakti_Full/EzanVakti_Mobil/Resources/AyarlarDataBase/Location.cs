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

namespace EzanVakti_Mobil.Resources.AyarlarDataBase
{
    [Table("Location")]
    public class Location
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Sehir { get; set; }

        public string ilce { get; set; }
        public string mahalle { get; set; }

        public string cadde { get; set; }

        public string full { get; set; }
    }
    public class LocationDatabase
    {
        static string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool createDataBaseLocation()
        {

            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Location.db")))
                {
                    connection.CreateTable<Location>();

                    return true;
                }
            }
            catch (SQLite.SQLiteException e)
            {
                Log.Info("SQLiteEx", e.Message);
                return false;
            }
        }
        public bool InsertIntoTableLocation(object namazVaktiDb)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Location.db")))
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
        public static Location selectTable()
        {



            using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Location.db")))
            {
                return connection.Table<Location>().First();
            }


        }
        public void UpdateTablelocation(Location current)
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Location.db")))
            {
                connection.Query<Location>("UPDATE Location set Sehir=?,ilce=?,mahalle=?,cadde=?,full=? where Id=1", current.Sehir, current.ilce, current.mahalle,current.cadde,current.full, current.Id);
            }
        }
        public static void selectTableLocation(Location current)
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Location.db")))
            {
              
                connection.Query<Location>("SELECT * from Location where Id=1");
            }
        }
        public static bool deleteFileTable()
        {
            try
            {
             
                var path = System.IO.Path.Combine(folder, "Location.db");
                
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
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Location.db")))
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