using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Diffdev {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/interface[@name='OAuthListener']"
	[Register ("com/tencent/mm/opensdk/diffdev/OAuthListener", "", "Com.Tencent.MM.Opensdk.Diffdev.IOAuthListenerInvoker")]
	public partial interface IOAuthListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/interface[@name='OAuthListener']/method[@name='onAuthFinish' and count(parameter)=2 and parameter[1][@type='com.tencent.mm.opensdk.diffdev.OAuthErrCode'] and parameter[2][@type='java.lang.String']]"
		[Register ("onAuthFinish", "(Lcom/tencent/mm/opensdk/diffdev/OAuthErrCode;Ljava/lang/String;)V", "GetOnAuthFinish_Lcom_tencent_mm_opensdk_diffdev_OAuthErrCode_Ljava_lang_String_Handler:Com.Tencent.MM.Opensdk.Diffdev.IOAuthListenerInvoker, XamarinWeiXinSDKBindingDemo")]
		void OnAuthFinish (global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/interface[@name='OAuthListener']/method[@name='onAuthGotQrcode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("onAuthGotQrcode", "(Ljava/lang/String;[B)V", "GetOnAuthGotQrcode_Ljava_lang_String_arrayBHandler:Com.Tencent.MM.Opensdk.Diffdev.IOAuthListenerInvoker, XamarinWeiXinSDKBindingDemo")]
		void OnAuthGotQrcode (string p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/interface[@name='OAuthListener']/method[@name='onQrcodeScanned' and count(parameter)=0]"
		[Register ("onQrcodeScanned", "()V", "GetOnQrcodeScannedHandler:Com.Tencent.MM.Opensdk.Diffdev.IOAuthListenerInvoker, XamarinWeiXinSDKBindingDemo")]
		void OnQrcodeScanned ();

	}

	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/diffdev/OAuthListener", DoNotGenerateAcw=true)]
	internal class IOAuthListenerInvoker : global::Java.Lang.Object, IOAuthListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/mm/opensdk/diffdev/OAuthListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOAuthListenerInvoker); }
		}

		IntPtr class_ref;

		public static IOAuthListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOAuthListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.mm.opensdk.diffdev.OAuthListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOAuthListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAuthFinish_Lcom_tencent_mm_opensdk_diffdev_OAuthErrCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAuthFinish_Lcom_tencent_mm_opensdk_diffdev_OAuthErrCode_Ljava_lang_String_Handler ()
		{
			if (cb_onAuthFinish_Lcom_tencent_mm_opensdk_diffdev_OAuthErrCode_Ljava_lang_String_ == null)
				cb_onAuthFinish_Lcom_tencent_mm_opensdk_diffdev_OAuthErrCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAuthFinish_Lcom_tencent_mm_opensdk_diffdev_OAuthErrCode_Ljava_lang_String_);
			return cb_onAuthFinish_Lcom_tencent_mm_opensdk_diffdev_OAuthErrCode_Ljava_lang_String_;
		}

		static void n_OnAuthFinish_Lcom_tencent_mm_opensdk_diffdev_OAuthErrCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAuthFinish (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAuthFinish_Lcom_tencent_mm_opensdk_diffdev_OAuthErrCode_Ljava_lang_String_;
		public unsafe void OnAuthFinish (global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode p0, string p1)
		{
			if (id_onAuthFinish_Lcom_tencent_mm_opensdk_diffdev_OAuthErrCode_Ljava_lang_String_ == IntPtr.Zero)
				id_onAuthFinish_Lcom_tencent_mm_opensdk_diffdev_OAuthErrCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAuthFinish", "(Lcom/tencent/mm/opensdk/diffdev/OAuthErrCode;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAuthFinish_Lcom_tencent_mm_opensdk_diffdev_OAuthErrCode_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onAuthGotQrcode_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetOnAuthGotQrcode_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_onAuthGotQrcode_Ljava_lang_String_arrayB == null)
				cb_onAuthGotQrcode_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAuthGotQrcode_Ljava_lang_String_arrayB);
			return cb_onAuthGotQrcode_Ljava_lang_String_arrayB;
		}

		static void n_OnAuthGotQrcode_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnAuthGotQrcode (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onAuthGotQrcode_Ljava_lang_String_arrayB;
		public unsafe void OnAuthGotQrcode (string p0, byte[] p1)
		{
			if (id_onAuthGotQrcode_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_onAuthGotQrcode_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "onAuthGotQrcode", "(Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAuthGotQrcode_Ljava_lang_String_arrayB, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onQrcodeScanned;
#pragma warning disable 0169
		static Delegate GetOnQrcodeScannedHandler ()
		{
			if (cb_onQrcodeScanned == null)
				cb_onQrcodeScanned = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnQrcodeScanned);
			return cb_onQrcodeScanned;
		}

		static void n_OnQrcodeScanned (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnQrcodeScanned ();
		}
#pragma warning restore 0169

		IntPtr id_onQrcodeScanned;
		public unsafe void OnQrcodeScanned ()
		{
			if (id_onQrcodeScanned == IntPtr.Zero)
				id_onQrcodeScanned = JNIEnv.GetMethodID (class_ref, "onQrcodeScanned", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onQrcodeScanned);
		}

	}

	public partial class AuthFinishEventArgs : global::System.EventArgs {

		public AuthFinishEventArgs (global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode p0;
		public global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	public partial class AuthGotQrcodeEventArgs : global::System.EventArgs {

		public AuthGotQrcodeEventArgs (string p0, byte[] p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		byte[] p1;
		public byte[] P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/tencent/mm/opensdk/diffdev/OAuthListenerImplementor")]
	internal sealed partial class IOAuthListenerImplementor : global::Java.Lang.Object, IOAuthListener {

		object sender;

		public IOAuthListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/mm/opensdk/diffdev/OAuthListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AuthFinishEventArgs> OnAuthFinishHandler;
#pragma warning restore 0649

		public void OnAuthFinish (global::Com.Tencent.MM.Opensdk.Diffdev.OAuthErrCode p0, string p1)
		{
			var __h = OnAuthFinishHandler;
			if (__h != null)
				__h (sender, new AuthFinishEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<AuthGotQrcodeEventArgs> OnAuthGotQrcodeHandler;
#pragma warning restore 0649

		public void OnAuthGotQrcode (string p0, byte[] p1)
		{
			var __h = OnAuthGotQrcodeHandler;
			if (__h != null)
				__h (sender, new AuthGotQrcodeEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler OnQrcodeScannedHandler;
#pragma warning restore 0649

		public void OnQrcodeScanned ()
		{
			var __h = OnQrcodeScannedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IOAuthListenerImplementor value)
		{
			return value.OnAuthFinishHandler == null && value.OnAuthGotQrcodeHandler == null && value.OnQrcodeScannedHandler == null;
		}
	}

}
