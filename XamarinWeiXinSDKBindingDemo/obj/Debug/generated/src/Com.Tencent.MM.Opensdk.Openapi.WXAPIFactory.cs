using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Openapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.openapi']/class[@name='WXAPIFactory']"
	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/openapi/WXAPIFactory", DoNotGenerateAcw=true)]
	public partial class WXAPIFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/opensdk/openapi/WXAPIFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WXAPIFactory); }
		}

		protected WXAPIFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_createWXAPI_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.openapi']/class[@name='WXAPIFactory']/method[@name='createWXAPI' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("createWXAPI", "(Landroid/content/Context;Ljava/lang/String;)Lcom/tencent/mm/opensdk/openapi/IWXAPI;", "")]
		public static unsafe global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI CreateWXAPI (global::Android.Content.Context p0, string p1)
		{
			if (id_createWXAPI_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_createWXAPI_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createWXAPI", "(Landroid/content/Context;Ljava/lang/String;)Lcom/tencent/mm/opensdk/openapi/IWXAPI;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createWXAPI_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_createWXAPI_Landroid_content_Context_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.openapi']/class[@name='WXAPIFactory']/method[@name='createWXAPI' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("createWXAPI", "(Landroid/content/Context;Ljava/lang/String;Z)Lcom/tencent/mm/opensdk/openapi/IWXAPI;", "")]
		public static unsafe global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI CreateWXAPI (global::Android.Content.Context p0, string p1, bool p2)
		{
			if (id_createWXAPI_Landroid_content_Context_Ljava_lang_String_Z == IntPtr.Zero)
				id_createWXAPI_Landroid_content_Context_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "createWXAPI", "(Landroid/content/Context;Ljava/lang/String;Z)Lcom/tencent/mm/opensdk/openapi/IWXAPI;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createWXAPI_Landroid_content_Context_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
