using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CustomPlatform.UITest
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
				return ConfigureApp.Android.InstalledApp("com.companyname").StartApp();

            }

			return ConfigureApp.iOS.StartApp();
		}
	}
}