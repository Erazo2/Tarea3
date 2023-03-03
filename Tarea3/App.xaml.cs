using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace Tarea3
{
    public partial class App : Application
    {
        static Controllers.PersonaControllers database;

        public static Controllers.PersonaControllers Database
        {
            get
            {
                if (database == null)
                {
                    var pathdatabase = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    var dbname = "person.db3";
                    var fullpath = Path.Combine(pathdatabase, dbname);
                    database = new Controllers.PersonaControllers(fullpath);
                }
                return database;
            }
        }


        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
