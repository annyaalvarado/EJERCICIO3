using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EJERCICIO3.Controllers;
using System.IO;

namespace EJERCICIO3
{
    public partial class App : Application
    {
        static EmpleController databaseemple;

        public static EmpleController DataBaseEmple
        {
            get
            {
                if(databaseemple == null)
                {
                    databaseemple = new Controllers.EmpleController(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Emple.db3"));
                }
                return databaseemple;
            }
            
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Listado());
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
