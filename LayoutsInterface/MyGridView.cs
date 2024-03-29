﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace LayoutsInterface
{
    [Activity(Label = "MyGridView")]
    public class MyGridView : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.my_grid_view);

            var gridview = FindViewById<GridView>(Resource.Id.gridview);
            gridview.Adapter = new ImageAdapter(this);

            gridview.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args) {
                Toast.MakeText(this, args.Position.ToString(), ToastLength.Short).Show();
            };
        }
    }
}