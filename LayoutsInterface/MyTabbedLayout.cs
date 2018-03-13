using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace LayoutsInterface
{
    [Activity(Label = "MyTabbedLayout")]
    public class MyTabbedLayout : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.my_tabbed_layout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.amazing_toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = "My Toolbar o/";
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            base.OnCreateOptionsMenu(menu);

            MenuInflater inflater = this.MenuInflater;
            inflater.Inflate(Resource.Menu.top_menu, menu);

            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            Toast.MakeText(this, "Action selected: " + item.TitleFormatted, ToastLength.Short).Show();
            return base.OnOptionsItemSelected(item);
        }
    }
}