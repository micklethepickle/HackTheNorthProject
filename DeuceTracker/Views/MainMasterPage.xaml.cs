using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DeuceTracker
{
	public partial class MainMasterPage : ContentPage
	{
		public ListView ListView
		{
			get{return listView;}
		}

		public MainMasterPage()
		{
			InitializeComponent();
			var masterPageItems = new List<MasterPageItem>();
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Home",
				IconSource = "PooButton.png",
				TargetType = typeof(DeuceTrackerPage)
			});

			listView.ItemsSource = masterPageItems;

		}
	}
}
