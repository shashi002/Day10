using Android.App;
using Android.OS;
using Xamarin.Forms.Platform.Android;

namespace SparshBIOCart.Droid
{
    [Activity(Label = "SparshBIOCart"
        , MainLauncher = true
        //, Theme = @"@style/AppTheme"
        )]
    public class MainActivity : AndroidActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Xamarin.Forms.Forms.Init(this, bundle);
            App.Init(new DroidSetup());
            SetPage(App.StartupPage);
        }
    }
}