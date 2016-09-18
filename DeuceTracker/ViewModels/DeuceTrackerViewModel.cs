using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Linq;
using Xamarin.Forms;
using System.Diagnostics;

namespace DeuceTracker
{
	public class DeuceTrackerViewModel : MainViewModel
	{
		int lengthOfDeuce;
		DeuceTrackerModel deuceTrackerModel;
		Stopwatch shitCounter = new Stopwatch();
		public ICommand OnPoo { get; set; }
		public ICommand OnSavePoo { get; set; }

		public DeuceTrackerViewModel()
		{
			deuceTrackerModel = new DeuceTrackerModel();
			OnPoo = new Command(Pooing);
			OnSavePoo = new Command(async () => await SavePoo());
		}

		public string CurrentBathroomAction
		{
			get { return deuceTrackerModel.CurrentBathroomAction; }
			set { deuceTrackerModel.CurrentBathroomAction = value; RaisePropertyChanged(); }
		}
		public bool SaveButtonEnabled
		{
			get { return deuceTrackerModel.SaveButtonEnabled;}
			set { deuceTrackerModel.SaveButtonEnabled = value; RaisePropertyChanged(); }
		}
		public void Pooing()
		{
			if (shitCounter.IsRunning)
			{
				lengthOfDeuce = (int)(shitCounter.ElapsedMilliseconds/1000);
				CurrentBathroomAction = lengthOfDeuce + "";
				shitCounter.Stop();
				shitCounter.Reset();
				SaveButtonEnabled = true;
			}
			else
			{
				shitCounter.Start();
				CurrentBathroomAction = "Deucing...";
				SaveButtonEnabled = false;
			}
		}
		public async Task SavePoo()
		{
			Debug.WriteLine(DateTime.Now.ToString(@"MM\/dd\/yyyy HH:mm"));
			Debug.WriteLine(lengthOfDeuce + "");    
			await App.DeuceRepo.AddNewDeuceAsync(
				DateTime.Now.ToString(@"MM\/dd\/yyyy HH:mm"),
				lengthOfDeuce + "");
			await SqlDeuceHistory.GetDeuceHistoryFromSql();
			Debug.WriteLine(SqlDeuceHistory.DeuceHistory.Count + "");
			SaveButtonEnabled = false;
		}
	}
}
