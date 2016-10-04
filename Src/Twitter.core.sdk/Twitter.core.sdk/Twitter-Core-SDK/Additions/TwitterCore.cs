using Android.Runtime;

namespace Com.Twitter.Sdk.Android.Core
{
    public partial class TwitterCore
    {
        [Register("doInBackground", "()Ljava/lang/Object;", "GetDoInBackgroundHandler")]
        protected override unsafe global::Java.Lang.Object DoInBackground()
        {
            return DoInBackgroun();
        }

        public override unsafe int CompareTo(Java.Lang.Object another)
        {
            return 0;
        }
    }

    //public abstract partial class Callback<T> : Retrofit2.ICallback<T>
    //{
    //    public void onFailure(ICall<T> call, Throwable t)
    //    {

    //    }

    //    public void onResponse(ICall<T> call, Response<T> response)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
