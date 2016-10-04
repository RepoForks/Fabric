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
using Retrofit2;
using Retrofit2.Http;

namespace Retrofit2
{
    public partial interface ICallback<T>
    {
        void onResponse(ICall<T> call, Response<T> response);

        void onFailure(ICall<T> call, Java.Lang.Throwable t);
    }

    public partial interface ICall<T>
    {

    }

    public partial class Response<T>
    {

    }
}