using Xamarin.Forms;

namespace DeuceTracker
{
	public partial class App : Application
	{
		public static string DbPath { get; private set;}
		public static DeuceRepository DeuceRepo { get; private set; }

		public App(string dbpath)
		{
			InitializeComponent();
			DbPath = dbpath;
			DeuceRepo = new DeuceRepository(dbpath);
			MainPage = new MainMasterDetailPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
