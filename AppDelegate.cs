#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Foundation;
using UIKit;
using Pendo;

namespace SampleBrowser
{
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
        #region properties

        public override UIWindow Window { get; set; }

		#endregion

		#region methods


		//pendo kodları
		public override bool OpenUrl(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
		{
			if (url.Scheme.Contains("pendo"))
			{
				Pendo.PendoManager.SharedManager().InitWithUrl(url);
				return true;
			}

			// your code here...

			return true;
		}




		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{
            this.Window = new UIWindow(UIScreen.MainScreen.Bounds);


			//Pendo kodları 2
			Pendo.PendoInitParams initParams = new Pendo.PendoInitParams();
			initParams.VisitorId = "Caner NAYKI";
			initParams.VisitorData = new NSDictionary("Age", 27, "Country", "USA", "Gender", "Male");
			initParams.AccountId = "ACME";
			initParams.AccountData = new NSDictionary("Tier", 1, "Timezone", "EST", "Size", "Enterprise");

			Pendo.PendoManager.SharedManager().InitSDK("eyJhbGciOiJSUzI1NiIsImtpZCI6IiIsInR5cCI6IkpXVCJ9.eyJkYXRhY2VudGVyIjoidXMiLCJrZXkiOiJhOGIzYmQwNTliYjc0MDUyM2I3ZjExMzAwZDgyNjVmNzBkZjI4MGVlODQzMjcwNWY4MzVmNWY0OGI5M2FjNTcwYzQ2OGY5ZGI0NTVhN2E3NGI3YWU1ZTg1M2NiM2E1OWI4OGM4YjQwMmRlMWQ0ZTJiMDA5MGIyMjAwNTFhNjJmNC5iZjUyZTQ3Y2JjNDExYzRjNDVmMjlkZDIzY2RmZDI3OC4wYzA2NWEwNzIxMjVkZWM0MjJjNTVhNDM0OGQ5Y2VlNTU0NDRhNzZiNTk4MjJmNjg2ZTBmMzJmOGRiNDc4YzFkIn0.JRXm5BT50T9t_R8jrgS4Vo0mjrrmRGjlEfbXeQEx6WkFPL4nm58_qU7Ezcp4oaH49HIgDqRrmodhO4d-86ejzw0ZajOv_Nd2kFx2FidgOuS1Lt8zuI_rmaaHm1VNozm8Jv7jnsC8V1M_VdH4cSwFS1jSw2gAVrchZ7bXsweZMcI",
														 initParams);



			NSUserDefaults.StandardUserDefaults.SetString("18.1.0.42", "VersionNumber");
			NSUserDefaults.StandardUserDefaults.Synchronize();

			UINavigationController controller = new UINavigationController(new HomeViewController());

			UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes()
			{
				TextColor = UIColor.White
			});

			controller.NavigationBar.BarTintColor = Utility.ThemeColor;

			controller.NavigationBar.TintColor = UIColor.White;

			application.StatusBarHidden = false;
			application.StatusBarStyle = UIStatusBarStyle.LightContent;

			this.Window.RootViewController = controller;
			this.Window.MakeKeyAndVisible();

			return true;
		}

		public override void OnResignActivation(UIApplication application)
		{
		}

		public override void DidEnterBackground(UIApplication application)
		{
		}

		public override void WillEnterForeground(UIApplication application)
		{
		}

		public override void OnActivated(UIApplication application)
		{
		}

		public override void WillTerminate(UIApplication application)
		{
		}

        #endregion
    }
}
