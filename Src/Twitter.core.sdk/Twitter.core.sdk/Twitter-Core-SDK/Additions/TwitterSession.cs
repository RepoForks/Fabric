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
using IO.Fabric.Sdk.Android.Services.Persistence;

namespace Com.Twitter.Sdk.Android.Core
{
    public partial class TwitterSession
    {
        public partial class Serializer : ISerializationStrategy
        {
            [Register("deserialize", "Ljava/lang/Object", "GetDeserialize_Ljava_lang_String_Handler")]
            public virtual unsafe global::Java.Lang.Object DeserializeObject(string input)
            {
                return (global::Java.Lang.Object)Deserialize(input);
            }

            Java.Lang.Object ISerializationStrategy.Deserialize(string input)
            {
                return DeserializeObject(input);
            }
        }
    }
}