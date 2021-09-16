﻿using MyHasaby.Views;
using System;
using SQLite;
using System.IO;
using Xamarin.Forms;
using System.Linq;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

namespace MyHasaby
{
    public partial class App : Application
    {
       
        static Database database;
        static Uesr database1;
        public static Database User
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
                }
                return database;
            }
        }
        public static Uesr User1
        {
            get
            {
                if (database1 == null)
                {
                    database1 = new Uesr(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
                }
                return database1;
            }
        }
        public static string DataBasePath;
        string _dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3");

        public App(string path)
        {
            InitializeComponent();
            DataBasePath = path;
            var db = new SQLiteConnection(_dbpath);
           
             //var result1 = db.Table<Person>();
           
              App.User.SavePersonAsync(new Person
              {
                   ID=1,
                  Name = "omar",
                  Phone = "012048750"
              });
            var result1 = db.Table<Person>().ToList();
            if (result1!= null) {
                 
                if ((from emp in result1 select emp.ID).Count() < 5)
                {
                    MainPage = new ShellPage();

                }
                else

                {

                    App.Current.MainPage = new AcontactPage();
                }



            }


        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
