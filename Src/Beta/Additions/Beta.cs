using Android.Runtime;

namespace Com.Crashlytics.Android.Beta
{
    public partial class Beta
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

    public partial class DeviceTokenLoader
    {
        public virtual unsafe string Loads(global::Android.Content.Context p0)
        {
            return Load(p0).ToString();
        }
    }
}
