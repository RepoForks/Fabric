using Android.App;
using Android.Widget;
using Android.OS;
using Com.Digits.Sdk.Android;
using Android.Content;
using Android.Runtime;
using System;
using IO.Fabric.Sdk.Android;
using Com.Twitter.Sdk.Android.Core;
using Com.Digits.Sdk.Android.Models;

namespace Digits_Demo
{
    [Activity(Label = "Digits_Demo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, IAuthCallback
    {
        int count = 1;

        private const string TWITTER_KEY = "AJFiFHfvcGdPVD1FQsEvYPggH";
        private const string TWITTER_SECRET = "bYxCuSQnfou2Aa7xGagFnXHeGHe8yCXp6MYTZWHGrY0MwG70T9";
        private const int NUM_OF_CONTACTS = 3;
        private Button logoutbtn, adressBook;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            TwitterAuthConfig authConfig = new TwitterAuthConfig(TWITTER_KEY, TWITTER_SECRET);
            Fabric.With(this, new TwitterCore(authConfig), new Digits.Builder().Build());

            var authButton = FindViewById<DigitsAuthButton>(Resource.Id.auth_button);

            authButton.SetCallback(this);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += Button_Click;
            
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            Digits.UploadContacts();
            Digits.FindFriends(new FindFriendsCallback(BaseContext));
        }

        public void Failure(DigitsException failureException)
        {
            Toast.MakeText(this.BaseContext, "Failure", ToastLength.Short);
        }

        public void Success(DigitsSession session, string phoneNumber)
        {
            Toast.MakeText(this.BaseContext, "Success", ToastLength.Short);
        }
    }

    public class FindFriendsCallback : ContactsCallback
    {
        private Context context;

        public FindFriendsCallback(Context contxt)
        {
            context = contxt;
        }

        public override void Failure(TwitterException failureException)
        {
            //throw new NotImplementedException();
        }

        public override void Success(Com.Twitter.Sdk.Android.Core.Result successMessage)
        {
            var userList = (successMessage.Data as Contacts).Users;
            foreach (var item in userList)
            {
                Toast.MakeText(context, item.ToString(), ToastLength.Short).Show();
            }
            System.Diagnostics.Debug.WriteLine(successMessage.Response);
        }
    }

    [BroadcastReceiver(Name = "mono.samples.Receiver")]
    public class MyResultReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            if (ContactsUploadService.UploadComplete.Equals(intent.Action))
            {
                var data = intent.GetParcelableExtra(ContactsUploadService.UploadCompleteExtra);
                Toast.MakeText(context, data.ToString(), ToastLength.Long).Show();
            }
        }
    }
}

