using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Modelbase {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbase']/class[@name='BaseReq']"
	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelbase/BaseReq", DoNotGenerateAcw=true)]
	public abstract partial class BaseReq : global::Java.Lang.Object {


		static IntPtr openId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbase']/class[@name='BaseReq']/field[@name='openId']"
		[Register ("openId")]
		public string OpenId {
			get {
				if (openId_jfieldId == IntPtr.Zero)
					openId_jfieldId = JNIEnv.GetFieldID (class_ref, "openId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, openId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (openId_jfieldId == IntPtr.Zero)
					openId_jfieldId = JNIEnv.GetFieldID (class_ref, "openId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, openId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr transaction_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbase']/class[@name='BaseReq']/field[@name='transaction']"
		[Register ("transaction")]
		public string Transaction {
			get {
				if (transaction_jfieldId == IntPtr.Zero)
					transaction_jfieldId = JNIEnv.GetFieldID (class_ref, "transaction", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, transaction_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (transaction_jfieldId == IntPtr.Zero)
					transaction_jfieldId = JNIEnv.GetFieldID (class_ref, "transaction", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, transaction_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelbase/BaseReq", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseReq); }
		}

		protected BaseReq (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbase']/class[@name='BaseReq']/constructor[@name='BaseReq' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseReq ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BaseReq)) {
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
			global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		public abstract int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbase']/class[@name='BaseReq']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")] get;
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
			global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckArgs ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbase']/class[@name='BaseReq']/method[@name='checkArgs' and count(parameter)=0]"
		[Register ("checkArgs", "()Z", "GetCheckArgsHandler")]
		public abstract bool CheckArgs ();

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
			global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FromBundle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_fromBundle_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbase']/class[@name='BaseReq']/method[@name='fromBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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
			global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ToBundle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_toBundle_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbase']/class[@name='BaseReq']/method[@name='toBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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

	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelbase/BaseReq", DoNotGenerateAcw=true)]
	internal partial class BaseReqInvoker : BaseReq {

		public BaseReqInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseReqInvoker); }
		}

		static IntPtr id_getType;
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbase']/class[@name='BaseReq']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getType);
				} finally {
				}
			}
		}

		static IntPtr id_checkArgs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbase']/class[@name='BaseReq']/method[@name='checkArgs' and count(parameter)=0]"
		[Register ("checkArgs", "()Z", "GetCheckArgsHandler")]
		public override unsafe bool CheckArgs ()
		{
			if (id_checkArgs == IntPtr.Zero)
				id_checkArgs = JNIEnv.GetMethodID (class_ref, "checkArgs", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkArgs);
			} finally {
			}
		}

	}

}
