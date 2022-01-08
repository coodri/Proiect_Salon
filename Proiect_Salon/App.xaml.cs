using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Proiect_Salon.Data;
using System.IO;

namespace Proiect_Salon
{
    public partial class App : Application
    {
        static SalonDataBase database;
        public static SalonDataBase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   SalonDataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "Recenzii.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListEntryPage())
            { BarBackgroundColor = Color.Pink };
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
