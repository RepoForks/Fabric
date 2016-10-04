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
using IO.Fabric.Sdk.Android.Services.Events;
using Java.Lang;

namespace Com.Twitter.Sdk.Android.Core.Internal.Scribe
{
    public partial class ScribeEvent
    {
        public partial class Transform
        {
            public virtual byte[] ToBytes(Java.Lang.Object p1)
            {
                return ToBytes((ScribeEvent)p1);
            }
        }
    }
}