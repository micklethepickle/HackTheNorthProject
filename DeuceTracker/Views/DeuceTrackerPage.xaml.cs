using Xamarin.Forms;

namespace DeuceTracker
{
	public partial class DeuceTrackerPage : ContentPage
	{
		public DeuceTrackerPage()
		{
			InitializeComponent();
			BindingContext = new DeuceTrackerViewModel();
			Title = "Home";
			Icon = "PooButton.png";
		}
	}
}
