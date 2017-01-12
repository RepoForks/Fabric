using Android.Content;
using Com.Digits.Sdk.Android;
using Com.Twitter.Sdk.Android.Core;
using Com.Digits.Sdk.Android.Models;
using Android.Widget;

namespace Xamarin_DigitsDemo.Activities
{
    public class FindFriendsCallback : ContactsCallback
    {
        private Context context;

        public FindFriendsCallback(Context contxt)
        {
            context = contxt;
        }

        public override void Failure(TwitterException failureException)
        {
            Toast.MakeText(context, context.GetString(Resource.String.uploadContactsError), ToastLength.Short).Show();
        }

        public override void Success(Result successMessage)
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
    