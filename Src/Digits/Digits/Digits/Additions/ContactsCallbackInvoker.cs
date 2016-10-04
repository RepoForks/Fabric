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

namespace Com.Digits.Sdk.Android
{
    public abstract partial class ContactsCallback
    {
        internal partial class ContactsCallbackInvoker
        {
            [Register("failure", "(Lcom/twitter/sdk/android/core/TwitterException;)V", "GetFailure_Lcom_twitter_sdk_android_core_TwitterException_Handler")]
            public virtual void Failure(Twitter.Sdk.Android.Core.TwitterException input)
                => Failure(input);

            [Register("success", "(Lcom/twitter/sdk/android/core/Result;)V", "GetSuccess_Lcom_twitter_sdk_android_core_Result_Handler")]
            public virtual void Success(Twitter.Sdk.Android.Core.Result input)
                => Success(input);
        }
    }
}