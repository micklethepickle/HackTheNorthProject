using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace DeuceTracker.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			string dbpath = FileAcessHelper.GetLocalFilePath("deucetracker.db");
			LoadApplication(new App(dbpath));

			return base.FinishedLaunching(app, options);
		}
	}
}
