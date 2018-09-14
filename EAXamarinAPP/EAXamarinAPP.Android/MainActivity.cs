using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter; 
using Microsoft.AppCenter.Analytics; 
using Microsoft.AppCenter.Crashes;

namespace EAXamarinAPP.Droid
{
    [Activity(Label = "EAXamarinAPP", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {


            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            AppCenter.Start("6ca30c04-62ae-4beb-9961-9fd80c534f1b",
                   typeof(Analytics), typeof(Crashes));
            AppCenter.Start("6ca30c04-62ae-4beb-9961-9fd80c534f1b", typeof(Analytics), typeof(Crashes));

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

