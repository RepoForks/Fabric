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

namespace Retrofit2
{
    public partial interface ICall<T>
    {
        bool IsCanceled { get; }

        bool IsExecuted { get; }
        void Cancel();
        ICall<T> Clone();
        void Enqueue(global::Retrofit2.ICallback p0);
        global::Retrofit2.Response Execute();
        global::Okhttp3.Request Request();
    }

    public partial interface ICallback<T>
    {
        void OnFailure(global::Retrofit2.ICall<T> p0, global::Java.Lang.Throwable p1);

        void OnResponse(global::Retrofit2.ICall<T> p0, global::Retrofit2.Response p1);
    }

    public partial class Response
    {

    }
}