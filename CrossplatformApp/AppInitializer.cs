using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CrossplatformWestBendApp
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
				return ConfigureApp.Android.ApkFile("D:\\DUMMY\\EAXamarinAPP\\CrossplatformApp\\app-debug.apk").StartApp();
			}

			return ConfigureApp
                .iOS
                .StartApp();
		}
	}
}