﻿using System;
using SQLite;
using System.IO;
using Xamarin.Forms;
using System.Linq;
using Microsoft.AppCenter;
<<<<<<< HEAD
using MyHasaby.Categories.Data;

=======
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Analytics;
>>>>>>> e3d0996f4d657ca68edcb3f470a0af6bccc04d0b
namespace MyHasaby
{
    //new testy
    public partial class App : Application
    {
       
        static Database database;
        static Uesrs database1;
        static AcountUes useAcount;
        static Categories1 categories;

        public static Categories1 User22
        {
            get
            {
                if (categories == null)
                {
                    categories = new Categories1(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
                }
                return categories;
            }
        }
        public static AcountUes acountUes
        {
            get
            {
                if (useAcount == null)
                {
                    useAcount = new AcountUes(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
                }
                return useAcount;
            }
        }
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
        public static Uesrs User1
        {
            get
            {
                if (database1 == null)
                {
                    database1 = new Uesrs(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
                }
                return database1;
            }
        }
       
     
        public static string DataBasePath;
       
        public App(string path)
        {
            InitializeComponent();
            DataBasePath = path;
            string _dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3");

            var db = new SQLiteConnection(_dbpath);

<<<<<<< HEAD
                    //if (Settings.FirstRun)
                    //{
                    //    Person person = new Person();
                    //    if (person.ID == 0  ) { 
                    //        Settings.FirstRun = true;

                    //    MainPage = new ShellPage();
                    //    }

                    //    Settings.FirstRun = false;
                    //}
            if (Settings.FirstRun)
            {
                TestClass person1 = new TestClass();
                person1.ID = 1;
                person1.dateTime = DateTime.Now.AddDays(20);
                App.acountUes.SaveAcontactAsync1(person1);
                DateTime mr = DateTime.Now;

                var wr = App.acountUes.GetItemAsync1(1).Result;
                DateTime or1 = wr.dateTime;
                if (mr <= or1)
                {
                    Settings.FirstRun = true;
                    MainPage = new ShellPage();
=======
            if (Settings.FirstRun)
            {
                Person person = new Person();
                if (person.ID == 0) { Settings.FirstRun = true; }
                App.Current.MainPage = new ShellPage();
                Settings.FirstRun = false;
            }
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>

            {
>>>>>>> e3d0996f4d657ca68edcb3f470a0af6bccc04d0b

                }
            }
                        //    Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>

<<<<<<< HEAD
                        //{
                        //    Person person = new Person();
                        //    if (person != null)
                        //    {
                        //        var result1 = db.Table<Person>().ToList();

                        //        var anass2 = App.User.GetPeopleAsync();
                        //        var all2 = anass2.Result.Count();
                        //        var all = (from emp in result1.AsEnumerable() select emp.ID).Count();
                        //        var ally = App.acountUes.GetAcontactAsync().Result;
                        //        var alhmed = ally.Count();

                        //        if (all2 <= 3)
                        //        { MainPage = new ShellPage(); }
                        //        else if (alhmed != 0)
                        //        {

                        //            App.Current.MainPage = new ShellPage();

                        //        }
                        //        else
                        //        {

                        //            MainPage = new CreativePage();
                        //        }

                        //    }
=======
                var result1 = db.Table<Person>().ToList();

                var anass2 = App.User.GetPeopleAsync();
                var all2 = anass2.Result.Count();
                var all = (from emp in result1.AsEnumerable() select emp.ID).Count();
                var ally = App.acountUes.GetAcontactAsync().Result;
                var alhmed = ally.Count();

                if (all2 <= 3)
                { MainPage = new ShellPage(); }
                else if (alhmed != 0)
                {
>>>>>>> e3d0996f4d657ca68edcb3f470a0af6bccc04d0b

                    App.Current.MainPage = new ShellPage();

                       //});

<<<<<<< HEAD
            else
                    {

                            MainPage = new CreativePage();
                     }
=======

                }
                else
                {

                    MainPage = new AcontactPage();
                }
            });
>>>>>>> e3d0996f4d657ca68edcb3f470a0af6bccc04d0b
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
