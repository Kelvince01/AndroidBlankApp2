using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace AndroidBlankApp2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            //Create the user interface in code 

            var aButton = FindViewById<Button> (Resource.Id.aButton); 
            var aLabel = FindViewById<TextView> (Resource.Id.helloLabel); 
            aButton.Click += (sender, e) => { aLabel.Text = "Hello from the button"; }; 
            
            AppCenter.Start("10f25bd1-6eeb-4a8e-ad9b-afe4535485a1",
                typeof(Analytics), typeof(Crashes));
        }
    }
}
