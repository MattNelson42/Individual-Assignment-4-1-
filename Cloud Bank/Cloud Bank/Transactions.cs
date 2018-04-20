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
    [Activity(Label = "TransactionActivity")]
    public class TransactionAtivity : Activity
    {
        ListView lstTransactions;
        Button btnLogout;
        Button btnBack;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Transactions);
            btnLogout = FindViewById<Button>(Resource.Id.btnLogout);
            btnLogout.Click += BtnLogout_Click;
            btnBack = FindViewById<Button>(Resource.Id.btnBack);
            btnBack.Click += BtnBack_Click;

            lstTransactions = FindViewById<ListView>(Resource.Id.lstTransactions);

            AddListView();
        }

        public Random date = new Random();
        DateTime RandomDay()
        {
            DateTime start = new DateTime(2018, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(date.Next(range));
        }

        private void AddListView()
        {
            List<string> transactions = new List<string>();

            for (int i = 0; i < 26; i++)
            {
                Random randomNumber = new Random();
                double transPrice = randomNumber.Next(25, 99);

                transactions.Add("Best Buy " + transPrice.ToString() + date);
            }
            lstTransactions.Adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, transactions);
        }
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Intent nextIntent = new Intent(this, typeof(MainActivity));
            StartActivity(nextIntent);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Intent nextIntent = new Intent(this, typeof(HomeActivity));
            StartActivity(nextIntent);
        }
    }
}