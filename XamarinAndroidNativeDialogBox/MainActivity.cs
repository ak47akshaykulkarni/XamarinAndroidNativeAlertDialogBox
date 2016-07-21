using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XamarinAndroidNativeDialogBox
{
    [Activity(Label = "XamarinAndroidNativeDialogBox", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate {
                AlertDialog.Builder alert = new AlertDialog.Builder(this);
                alert.SetTitle("Specify Action");
                alert.SetMessage("Do you want to add or substract?");
                alert.SetPositiveButton("Add", (senderAlert, args) =>
                {
                    count++;
                    button.Text = string.Format("{0} clicks!", count);
                });

                alert.SetNegativeButton("Substract", (senderAlert, args) =>
                {
                    count--;
                    button.Text = string.Format("{0} clicks!", count);
                });

                Dialog dialog = alert.Create();
                dialog.Show();

            };
        }
    }
}

