using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Diffdev {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/class[@name='OAuthErrCode']"
	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/diffdev/OAuthErrCode", DoNotGenerateAcw=true)]
	public sealed partial class OAuthErrCode : global::Java.Lang.Enum {


		static IntPtr WechatAuth_Err_Auth_Stopped_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/class[@name='OAuthErrCode']/field[@name='WechatAuth_Err_Auth_Stopped']"
		[Register ("WechatAuth_Err_Auth_Stopped")]
		public static global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode WechatAuthErrAuthStopped {
			get {
				if (WechatAuth_Err_Auth_Stopped_jfieldId == IntPtr.Zero)
					WechatAuth_Err_Auth_Stopped_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WechatAuth_Err_Auth_Stopped", "Lcom/tencent/mm/opensdk/diffdev/OAuthErrCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WechatAuth_Err_Auth_Stopped_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WechatAuth_Err_Cancel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/class[@name='OAuthErrCode']/field[@name='WechatAuth_Err_Cancel']"
		[Register ("WechatAuth_Err_Cancel")]
		public static global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode WechatAuthErrCancel {
			get {
				if (WechatAuth_Err_Cancel_jfieldId == IntPtr.Zero)
					WechatAuth_Err_Cancel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WechatAuth_Err_Cancel", "Lcom/tencent/mm/opensdk/diffdev/OAuthErrCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WechatAuth_Err_Cancel_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WechatAuth_Err_JsonDecodeErr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/class[@name='OAuthErrCode']/field[@name='WechatAuth_Err_JsonDecodeErr']"
		[Register ("WechatAuth_Err_JsonDecodeErr")]
		public static global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode WechatAuthErrJsonDecodeErr {
			get {
				if (WechatAuth_Err_JsonDecodeErr_jfieldId == IntPtr.Zero)
					WechatAuth_Err_JsonDecodeErr_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WechatAuth_Err_JsonDecodeErr", "Lcom/tencent/mm/opensdk/diffdev/OAuthErrCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WechatAuth_Err_JsonDecodeErr_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WechatAuth_Err_NetworkErr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/class[@name='OAuthErrCode']/field[@name='WechatAuth_Err_NetworkErr']"
		[Register ("WechatAuth_Err_NetworkErr")]
		public static global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode WechatAuthErrNetworkErr {
			get {
				if (WechatAuth_Err_NetworkErr_jfieldId == IntPtr.Zero)
					WechatAuth_Err_NetworkErr_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WechatAuth_Err_NetworkErr", "Lcom/tencent/mm/opensdk/diffdev/OAuthErrCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WechatAuth_Err_NetworkErr_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WechatAuth_Err_NormalErr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/class[@name='OAuthErrCode']/field[@name='WechatAuth_Err_NormalErr']"
		[Register ("WechatAuth_Err_NormalErr")]
		public static global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode WechatAuthErrNormalErr {
			get {
				if (WechatAuth_Err_NormalErr_jfieldId == IntPtr.Zero)
					WechatAuth_Err_NormalErr_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WechatAuth_Err_NormalErr", "Lcom/tencent/mm/opensdk/diffdev/OAuthErrCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WechatAuth_Err_NormalErr_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WechatAuth_Err_OK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/class[@name='OAuthErrCode']/field[@name='WechatAuth_Err_OK']"
		[Register ("WechatAuth_Err_OK")]
		public static global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode WechatAuthErrOK {
			get {
				if (WechatAuth_Err_OK_jfieldId == IntPtr.Zero)
					WechatAuth_Err_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WechatAuth_Err_OK", "Lcom/tencent/mm/opensdk/diffdev/OAuthErrCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WechatAuth_Err_OK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WechatAuth_Err_Timeout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/class[@name='OAuthErrCode']/field[@name='WechatAuth_Err_Timeout']"
		[Register ("WechatAuth_Err_Timeout")]
		public static global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode WechatAuthErrTimeout {
			get {
				if (WechatAuth_Err_Timeout_jfieldId == IntPtr.Zero)
					WechatAuth_Err_Timeout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WechatAuth_Err_Timeout", "Lcom/tencent/mm/opensdk/diffdev/OAuthErrCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WechatAuth_Err_Timeout_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/opensdk/diffdev/OAuthErrCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuthErrCode); }
		}

		internal OAuthErrCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCode;
		public unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/class[@name='OAuthErrCode']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()I", "GetGetCodeHandler")]
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCode);
				} finally {
				}
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/class[@name='OAuthErrCode']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/class[@name='OAuthErrCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/tencent/mm/opensdk/diffdev/OAuthErrCode;", "")]
		public static unsafe global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/tencent/mm/opensdk/diffdev/OAuthErrCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/class[@name='OAuthErrCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/tencent/mm/opensdk/diffdev/OAuthErrCode;", "")]
		public static unsafe global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/tencent/mm/opensdk/diffdev/OAuthErrCode;");
			try {
				return (global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode));
			} finally {
			}
		}

	}
}
