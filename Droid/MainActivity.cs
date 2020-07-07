using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using MealDB.Droid.MealList;


namespace MealDB.Droid
{
    [Activity(Label = "MealDB", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            RunOnUiThread(async () => {

                await Task.Delay(1500);
                MealListRouter.StartMealList(this,typeof(MealListActivity));
            });
        }
    }
}

