using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace JodeWare
{
	public partial class App : Application
	{
        static LieferantDB database;
		public App ()
		{
			InitializeComponent();

            //MainPage = new JodeWare.MainPage();
            MainPage = new LieferantListPage();
		}

        public static LieferantDB Database
        {
            get
            {
                if (database == null)
                {
                    database = new LieferantDB(DependencyService.Get<ILocalFileHelper>().GetLocalFilePath("Lieferant.db3"));
                }
                return database;
            }
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
