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

namespace Cloud_Bank
{
    [Activity(Label = "HomeActivity")]
    public class HomeActivity : Activity 
    {
        Button btnChecking;
        Button btnSavings;
        Button btnLogout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            btnChecking = FindViewById<Button>(Resource.Id.btnChecking);
            btnSavings = FindViewById<Button>(Resource.Id.btnSavings);
            btnLogout = FindViewById<Button>(Resource.Id.btnLogout);

            btnChecking.Click += BtnChecking_Click;
            btnSavings.Click += BtnSvings_Click;
            btnLogout.Click += BtnLogout_Click;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Intent nextIntent = new Intent(this, typeof(MainActivity));
            StartActivity(nextIntent);
        }

        private void BtnSvings_Click(object sender, EventArgs e)
        {
            Intent nextIntent = new Intent(this, typeof(TransactionAtivity));
            StartActivity(nextIntent);
        }

        private void BtnChecking_Click(object sender, EventArgs e)
        {
            Intent nextIntent = new Intent(this, typeof(TransactionAtivity));
            StartActivity(nextIntent);
        }
    }
}