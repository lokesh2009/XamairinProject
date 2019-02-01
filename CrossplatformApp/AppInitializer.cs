using CrossplatformApp.Utility;
using Xamarin.UITest;

namespace CrossplatformApp
//namespace CrossplatformWestBendApp
{
    public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
          
			if (platform == Platform.Android)
			{
				return ConfigureApp.Android.ApkFile("./app-release.apk").StartApp();
			}

			return ConfigureApp
                .iOS
                .StartApp();
		}
	}
}