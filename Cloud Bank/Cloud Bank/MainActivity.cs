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
    [Activity(Label = "Cloud_Bank", MainLauncher = true)]
    public class MainActivity : Activity
    {
        EditText txtUsername;
        EditText txtPassword;
        CheckBox checkBoxSave;
        Button btnLogin;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            txtUsername = FindViewById<EditText>(Resource.Id.txtUsername);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            checkBoxSave = FindViewById<CheckBox>(Resource.Id.checkBoxSave);
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);

            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.ToLower() == "clouduser" && txtPassword.Text == "318")
            {
                Intent nextIntent = new Intent(this, typeof(HomeActivity));
                StartActivity(nextIntent);
            }
        }
    }
}

