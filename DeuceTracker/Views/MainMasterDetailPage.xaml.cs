using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DeuceTracker
{
	public partial class MainMasterDetailPage : MasterDetailPage
	{
		public MainMasterDetailPage()
		{
			InitializeComponent();
			masterPage.ListView.ItemSelected += OnItemSelected;
		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null)
			{
				Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
				masterPage.ListView.SelectedItem = null;
				IsPresented = false;
			}
		}
	}
}
