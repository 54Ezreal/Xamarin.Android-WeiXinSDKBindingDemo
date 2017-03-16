using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Modelpay {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayResp']"
	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelpay/PayResp", DoNotGenerateAcw=true)]
	public partial class PayResp : global::Com.Tencent.MM.Opensdk.Modelbase.BaseResp {


		static IntPtr extData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayResp']/field[@name='extData']"
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

		static IntPtr prepayId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayResp']/field[@name='prepayId']"
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

		static IntPtr returnKey_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayResp']/field[@name='returnKey']"
		[Register ("returnKey")]
		public string ReturnKey {
			get {
				if (returnKey_jfieldId == IntPtr.Zero)
					returnKey_jfieldId = JNIEnv.GetFieldID (class_ref, "returnKey", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, returnKey_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (returnKey_jfieldId == IntPtr.Zero)
					returnKey_jfieldId = JNIEnv.GetFieldID (class_ref, "returnKey", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, returnKey_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelpay/PayResp", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayResp); }
		}

		protected PayResp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayResp']/constructor[@name='PayResp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PayResp ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PayResp)) {
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

		static IntPtr id_ctor_Landroid_os_Bundle_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayResp']/constructor[@name='PayResp' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register (".ctor", "(Landroid/os/Bundle;)V", "")]
		public unsafe PayResp (global::Android.OS.Bundle p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PayResp)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Bundle;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Bundle;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Bundle_ == IntPtr.Zero)
					id_ctor_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Bundle;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Bundle_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Bundle_, __args);
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
			global::Com.Tencent.MM.Opensdk.Modelpay.PayResp __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelpay.PayResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayResp']/method[@name='getType' and count(parameter)=0]"
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
			global::Com.Tencent.MM.Opensdk.Modelpay.PayResp __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelpay.PayResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckArgs ();
		}
#pragma warning restore 0169

		static IntPtr id_checkArgs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelpay']/class[@name='PayResp']/method[@name='checkArgs' and count(parameter)=0]"
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
