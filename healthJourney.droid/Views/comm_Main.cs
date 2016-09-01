using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace healthJourney.droid.Views
{
    [Activity(Label = "comm_Main")]
    public class comm_Main : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.comm_main);

            Button commbutton = FindViewById<Button>(Resource.Id.healthJourney);
            commbutton.Click += delegate {
                StartActivity(typeof(FirstView));
            };
        }
    }
}