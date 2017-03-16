using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Modelpay {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq']"
	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelpay/PayReq", DoNotGenerateAcw=true)]
	public partial class PayReq : global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq {


		static IntPtr appId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq']/field[@name='appId']"
		[Register ("appId")]
		public string AppId {
			get {
				if (appId_jfieldId == IntPtr.Zero)
					appId_jfieldId = JNIEnv.GetFieldID (class_ref, "appId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, appId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (appId_jfieldId == IntPtr.Zero)
					appId_jfieldId = JNIEnv.GetFieldID (class_ref, "appId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, appId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr extData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq']/field[@name='extData']"
		[Register ("extData")]
		public string ExtData {
			get {
				if (extData_jfieldId == IntPtr.Zero)
					extData_jfieldId = JNIEnv.GetFieldID (class_ref, "extData", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, extData_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (extData_jfieldId == IntPtr.Zero)
					extData_jfieldId = JNIEnv.GetFieldID (class_ref, "extData", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, extData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr nonceStr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq']/field[@name='nonceStr']"
		[Register ("nonceStr")]
		public string NonceStr {
			get {
				if (nonceStr_jfieldId == IntPtr.Zero)
					nonceStr_jfieldId = JNIEnv.GetFieldID (class_ref, "nonceStr", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, nonceStr_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (nonceStr_jfieldId == IntPtr.Zero)
					nonceStr_jfieldId = JNIEnv.GetFieldID (class_ref, "nonceStr", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nonceStr_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr packageValue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq']/field[@name='packageValue']"
		[Register ("packageValue")]
		public string PackageValue {
			get {
				if (packageValue_jfieldId == IntPtr.Zero)
					packageValue_jfieldId = JNIEnv.GetFieldID (class_ref, "packageValue", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, packageValue_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (packageValue_jfieldId == IntPtr.Zero)
					packageValue_jfieldId = JNIEnv.GetFieldID (class_ref, "packageValue", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, packageValue_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr partnerId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq']/field[@name='partnerId']"
		[Register ("partnerId")]
		public string PartnerId {
			get {
				if (partnerId_jfieldId == IntPtr.Zero)
					partnerId_jfieldId = JNIEnv.GetFieldID (class_ref, "partnerId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, partnerId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (partnerId_jfieldId == IntPtr.Zero)
					partnerId_jfieldId = JNIEnv.GetFieldID (class_ref, "partnerId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, partnerId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr prepayId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq']/field[@name='prepayId']"
		[Register ("prepayId")]
		public string PrepayId {
			get {
				if (prepayId_jfieldId == IntPtr.Zero)
					prepayId_jfieldId = JNIEnv.GetFieldID (class_ref, "prepayId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, prepayId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (prepayId_jfieldId == IntPtr.Zero)
					prepayId_jfieldId = JNIEnv.GetFieldID (class_ref, "prepayId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, prepayId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sign_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq']/field[@name='sign']"
		[Register ("sign")]
		public string Sign {
			get {
				if (sign_jfieldId == IntPtr.Zero)
					sign_jfieldId = JNIEnv.GetFieldID (class_ref, "sign", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, sign_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sign_jfieldId == IntPtr.Zero)
					sign_jfieldId = JNIEnv.GetFieldID (class_ref, "sign", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sign_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr signType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq']/field[@name='signType']"
		[Register ("signType")]
		public string SignType {
			get {
				if (signType_jfieldId == IntPtr.Zero)
					signType_jfieldId = JNIEnv.GetFieldID (class_ref, "signType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, signType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (signType_jfieldId == IntPtr.Zero)
					signType_jfieldId = JNIEnv.GetFieldID (class_ref, "signType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, signType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr timeStamp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq']/field[@name='timeStamp']"
		[Register ("timeStamp")]
		public string TimeStamp {
			get {
				if (timeStamp_jfieldId == IntPtr.Zero)
					timeStamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timeStamp", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, timeStamp_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (timeStamp_jfieldId == IntPtr.Zero)
					timeStamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timeStamp", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timeStamp_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq.Options']"
		[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelpay/PayReq$Options", DoNotGenerateAcw=true)]
		public partial class Options : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq.Options']/field[@name='INVALID_FLAGS']"
			[Register ("INVALID_FLAGS")]
			public const int InvalidFlags = (int) -1;

			static IntPtr callbackClassName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq.Options']/field[@name='callbackClassName']"
			[Register ("callbackClassName")]
			public string CallbackClassName {
				get {
					if (callbackClassName_jfieldId == IntPtr.Zero)
						callbackClassName_jfieldId = JNIEnv.GetFieldID (class_ref, "callbackClassName", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, callbackClassName_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (callbackClassName_jfieldId == IntPtr.Zero)
						callbackClassName_jfieldId = JNIEnv.GetFieldID (class_ref, "callbackClassName", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, callbackClassName_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr callbackFlags_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq.Options']/field[@name='callbackFlags']"
			[Register ("callbackFlags")]
			public int CallbackFlags {
				get {
					if (callbackFlags_jfieldId == IntPtr.Zero)
						callbackFlags_jfieldId = JNIEnv.GetFieldID (class_ref, "callbackFlags", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, callbackFlags_jfieldId);
				}
				set {
					if (callbackFlags_jfieldId == IntPtr.Zero)
						callbackFlags_jfieldId = JNIEnv.GetFieldID (class_ref, "callbackFlags", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, callbackFlags_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelpay/PayReq$Options", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Options); }
			}

			protected Options (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq.Options']/constructor[@name='PayReq.Options' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Options ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Options)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

			static Delegate cb_fromBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetFromBundle_Landroid_os_Bundle_Handler ()
			{
				if (cb_fromBundle_Landroid_os_Bundle_ == null)
					cb_fromBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FromBundle_Landroid_os_Bundle_);
				return cb_fromBundle_Landroid_os_Bundle_;
			}

			static void n_FromBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.MM.Opensdk.Modelpay.PayReq.Options __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelpay.PayReq.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.FromBundle (p0);
			}
#pragma warning restore 0169

			static IntPtr id_fromBundle_Landroid_os_Bundle_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq.Options']/method[@name='fromBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("fromBundle", "(Landroid/os/Bundle;)V", "GetFromBundle_Landroid_os_Bundle_Handler")]
			public virtual unsafe void FromBundle (global::Android.OS.Bundle p0)
			{
				if (id_fromBundle_Landroid_os_Bundle_ == IntPtr.Zero)
					id_fromBundle_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "fromBundle", "(Landroid/os/Bundle;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fromBundle_Landroid_os_Bundle_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromBundle", "(Landroid/os/Bundle;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_toBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetToBundle_Landroid_os_Bundle_Handler ()
			{
				if (cb_toBundle_Landroid_os_Bundle_ == null)
					cb_toBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ToBundle_Landroid_os_Bundle_);
				return cb_toBundle_Landroid_os_Bundle_;
			}

			static void n_ToBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.MM.Opensdk.Modelpay.PayReq.Options __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelpay.PayReq.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ToBundle (p0);
			}
#pragma warning restore 0169

			static IntPtr id_toBundle_Landroid_os_Bundle_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq.Options']/method[@name='toBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("toBundle", "(Landroid/os/Bundle;)V", "GetToBundle_Landroid_os_Bundle_Handler")]
			public virtual unsafe void ToBundle (global::Android.OS.Bundle p0)
			{
				if (id_toBundle_Landroid_os_Bundle_ == IntPtr.Zero)
					id_toBundle_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "toBundle", "(Landroid/os/Bundle;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toBundle_Landroid_os_Bundle_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toBundle", "(Landroid/os/Bundle;)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelpay/PayReq", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayReq); }
		}

		protected PayReq (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq']/constructor[@name='PayReq' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PayReq ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PayReq)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.MM.Opensdk.Modelpay.PayReq __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelpay.PayReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_checkArgs;
#pragma warning disable 0169
		static Delegate GetCheckArgsHandler ()
		{
			if (cb_checkArgs == null)
				cb_checkArgs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckArgs);
			return cb_checkArgs;
		}

		static bool n_CheckArgs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.MM.Opensdk.Modelpay.PayReq __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelpay.PayReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckArgs ();
		}
#pragma warning restore 0169

		static IntPtr id_checkArgs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayReq']/method[@name='checkArgs' and count(parameter)=0]"
		[Register ("checkArgs", "()Z", "GetCheckArgsHandler")]
		public override unsafe bool CheckArgs ()
		{
			if (id_checkArgs == IntPtr.Zero)
				id_checkArgs = JNIEnv.GetMethodID (class_ref, "checkArgs", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkArgs);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkArgs", "()Z"));
			} finally {
			}
		}

	}
}
