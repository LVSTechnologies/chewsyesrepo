using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ChewsYes.Droid.InputPrompt;
using FFImageLoading.Forms.Droid;

namespace ChewsYes.Droid
{
    [Activity(Label = "ChewsYes.Droid", Icon = "@drawable/chewsyes", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            //SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            //SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.abc_ic_menu_overflow_material);

            base.OnCreate(bundle);

            Xamarin.FormsMaps.Init(this, bundle);

            CachedImageRenderer.Init(enableFastRenderer: true);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            Xamarin.Forms.DependencyService.Register<Prompt>();

            ZXing.Net.Mobile.Forms.Android.Platform.Init();

            LoadApplication(new App());
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            global::ZXing.Net.Mobile.Android.PermissionsHandler.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

    }
}
