using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace LayoutsInterface
{
    [Activity(Label = "LayoutsInterface", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.main);

            Button buttonToLinearLayout = FindViewById<Button>(Resource.Id.button_to_linear_layout);
            Button buttonToRelativeLayout = FindViewById<Button>(Resource.Id.button_to_relative_layout);
            Button buttonToTableLayout = FindViewById<Button>(Resource.Id.button_to_table_layout);
            Button buttonToRecyclerLayout = FindViewById<Button>(Resource.Id.button_to_recycler_view);
            Button buttonToListView = FindViewById<Button>(Resource.Id.button_to_list_view);
            Button buttonToGridView = FindViewById<Button>(Resource.Id.button_to_grid_view);
            Button buttonToGridLayout = FindViewById<Button>(Resource.Id.button_to_grid_layout);
            Button buttonToTabbedLayout = FindViewById<Button>(Resource.Id.button_to_tabbed_layout);

            buttonToLinearLayout.Click += OnSomeButtonClicked;
            buttonToRelativeLayout.Click += OnSomeButtonClicked;
            buttonToTableLayout.Click += OnSomeButtonClicked;
            buttonToRecyclerLayout.Click += OnSomeButtonClicked;
            buttonToListView.Click += OnSomeButtonClicked;
            buttonToGridView.Click += OnSomeButtonClicked;
            buttonToGridLayout.Click += OnSomeButtonClicked;
            buttonToTabbedLayout.Click += OnSomeButtonClicked;
        }

        private void OnSomeButtonClicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            //Toast.MakeText(this, b.Text, ToastLength.Long).Show();
            switch(b.Text)
            {
                case "Linear Layout Sample": StartActivity(typeof(MyLinearLayout)); break;
                case "Relative Layout Sample": StartActivity(typeof(MyRelativeLayout)); break;
                case "Table Layout Sample": StartActivity(typeof(MyTableLayout)); break;
                case "Recycler View Sample": StartActivity(typeof(MyRecycleView)); break;
                case "List View Sample": StartActivity(typeof(MyListView)); break;
                case "Grid View Sample": StartActivity(typeof(MyGridView)); break;
                case "Grid Layout Sample": StartActivity(typeof(MyGridLayout)); break;
                case "Tabbed Layout Sample": StartActivity(typeof(MyTabbedLayout)); break;
            }
            
        }
    }
}

