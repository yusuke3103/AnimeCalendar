using System;
using System.Collections.Generic;
using System.Linq;
using AnimeCalendar.iOS.Services;
using AnimeCalendar.Services;
using Foundation;
using Microsoft.Practices.Unity;
using Prism.Unity;
using UIKit;

namespace AnimeCalendar.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App(new iOSInitializer()));

			return base.FinishedLaunching(app, options);
		}

		public class iOSInitializer : IPlatformInitializer
		{
			public void RegisterTypes(IUnityContainer container)
			{
				container.RegisterType<ISQLiteConnectionProvider, SQLiteConnectionProvider>
				(new ContainerControlledLifetimeManager());
			}
		}
	}
}
