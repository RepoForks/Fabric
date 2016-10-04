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
using Java.Lang;
using Com.Twitter.Sdk.Android.Core.Models;

namespace Com.Twitter.Sdk.Android.Core
{
    public partial class GuestSession
    {
        public partial class Serializer
        {
            [Register("serialize", "(Lcom/twitter/sdk/android/core/GuestSession;)Ljava/lang/String;", "GetSerialize_Lcom_twitter_sdk_android_core_GuestSession_Handler")]
            public virtual unsafe string Serialize(Java.Lang.Object input)
            {
                return Serialize((GuestSession)input);
            }
        }
    }

    public partial class AuthTokenAdapter
    {
        [Register("serialize", "(Lcom/twitter/sdk/android/core/models/BindingValues;Ljava/lang/reflect/Type;Lcom/google/gson/JsonSerializationContext;)Lcom/google/gson/JsonElement;", "GetSerialize_Lcom_twitter_sdk_android_core_models_BindingValues_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_Handler")]
        public virtual unsafe Com.Google.Gson.JsonElement Serialize(global::Java.Lang.Object p0, global::Java.Lang.Reflect.IType p1, global::Com.Google.Gson.IJsonSerializationContext p2)
        {
            return Serialize((AuthToken)p0, p1, p2);
        }
    }
}
namespace Com.Twitter.Sdk.Android.Core.Models
{ 
    public partial class BindingValuesAdapter
    {
        [Register("serialize", "(Lcom/twitter/sdk/android/core/models/BindingValues;Ljava/lang/reflect/Type;Lcom/google/gson/JsonSerializationContext;)Lcom/google/gson/JsonElement;", "GetSerialize_Lcom_twitter_sdk_android_core_models_BindingValues_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_Handler")]
        public virtual unsafe Com.Google.Gson.JsonElement Serialize(global::Java.Lang.Object p0, global::Java.Lang.Reflect.IType p1, global::Com.Google.Gson.IJsonSerializationContext p2)
        {
            return Serialize((BindingValues)p0, p1, p2);
        }
    }
}