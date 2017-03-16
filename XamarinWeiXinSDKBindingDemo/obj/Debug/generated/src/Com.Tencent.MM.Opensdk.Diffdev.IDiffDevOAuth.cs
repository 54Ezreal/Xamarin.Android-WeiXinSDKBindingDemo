using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Diffdev {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/interface[@name='IDiffDevOAuth']"
	[Register ("com/tencent/mm/opensdk/diffdev/IDiffDevOAuth", "", "Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuthInvoker")]
	public partial interface IDiffDevOAuth : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/interface[@name='IDiffDevOAuth']/method[@name='addListener' and count(parameter)=1 and parameter[1][@type='com.tencent.mm.opensdk.diffdev.OAuthListener']]"
		[Register ("addListener", "(Lcom/tencent/mm/opensdk/diffdev/OAuthListener;)V", "GetAddListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_Handler:Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuthInvoker, XamarinWeiXinSDKBindingDemo")]
		void AddListener (global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/interface[@name='IDiffDevOAuth']/method[@name='auth' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.tencent.mm.opensdk.diffdev.OAuthListener']]"
		[Register ("auth", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/mm/opensdk/diffdev/OAuthListener;)Z", "GetAuth_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_Handler:Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuthInvoker, XamarinWeiXinSDKBindingDemo")]
		bool Auth (string p0, string p1, string p2, string p3, string p4, global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/interface[@name='IDiffDevOAuth']/method[@name='detach' and count(parameter)=0]"
		[Register ("detach", "()V", "GetDetachHandler:Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuthInvoker, XamarinWeiXinSDKBindingDemo")]
		void Detach ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/interface[@name='IDiffDevOAuth']/method[@name='removeAllListeners' and count(parameter)=0]"
		[Register ("removeAllListeners", "()V", "GetRemoveAllListenersHandler:Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuthInvoker, XamarinWeiXinSDKBindingDemo")]
		void RemoveAllListeners ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/interface[@name='IDiffDevOAuth']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='com.tencent.mm.opensdk.diffdev.OAuthListener']]"
		[Register ("removeListener", "(Lcom/tencent/mm/opensdk/diffdev/OAuthListener;)V", "GetRemoveListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_Handler:Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuthInvoker, XamarinWeiXinSDKBindingDemo")]
		void RemoveListener (global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/interface[@name='IDiffDevOAuth']/method[@name='stopAuth' and count(parameter)=0]"
		[Register ("stopAuth", "()Z", "GetStopAuthHandler:Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuthInvoker, XamarinWeiXinSDKBindingDemo")]
		bool StopAuth ();

	}

	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/diffdev/IDiffDevOAuth", DoNotGenerateAcw=true)]
	internal class IDiffDevOAuthInvoker : global::Java.Lang.Object, IDiffDevOAuth {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/mm/opensdk/diffdev/IDiffDevOAuth");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDiffDevOAuthInvoker); }
		}

		IntPtr class_ref;

		public static IDiffDevOAuth GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDiffDevOAuth> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.mm.opensdk.diffdev.IDiffDevOAuth"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDiffDevOAuthInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_addListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_Handler ()
		{
			if (cb_addListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_ == null)
				cb_addListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_);
			return cb_addListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_;
		}

		static void n_AddListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener p0 = (global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_addListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_;
		public unsafe void AddListener (global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener p0)
		{
			if (id_addListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_ == IntPtr.Zero)
				id_addListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Lcom/tencent/mm/opensdk/diffdev/OAuthListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_, __args);
		}

		static Delegate cb_auth_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_;
#pragma warning disable 0169
		static Delegate GetAuth_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_Handler ()
		{
			if (cb_auth_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_ == null)
				cb_auth_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Auth_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_);
			return cb_auth_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_;
		}

		static bool n_Auth_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener p5 = (global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener> (native_p5, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Auth (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_auth_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_;
		public unsafe bool Auth (string p0, string p1, string p2, string p3, string p4, global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener p5)
		{
			if (id_auth_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_ == IntPtr.Zero)
				id_auth_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_ = JNIEnv.GetMethodID (class_ref, "auth", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/mm/opensdk/diffdev/OAuthListener;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (p5);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_auth_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static Delegate cb_detach;
#pragma warning disable 0169
		static Delegate GetDetachHandler ()
		{
			if (cb_detach == null)
				cb_detach = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Detach);
			return cb_detach;
		}

		static void n_Detach (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Detach ();
		}
#pragma warning restore 0169

		IntPtr id_detach;
		public unsafe void Detach ()
		{
			if (id_detach == IntPtr.Zero)
				id_detach = JNIEnv.GetMethodID (class_ref, "detach", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detach);
		}

		static Delegate cb_removeAllListeners;
#pragma warning disable 0169
		static Delegate GetRemoveAllListenersHandler ()
		{
			if (cb_removeAllListeners == null)
				cb_removeAllListeners = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllListeners);
			return cb_removeAllListeners;
		}

		static void n_RemoveAllListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllListeners ();
		}
#pragma warning restore 0169

		IntPtr id_removeAllListeners;
		public unsafe void RemoveAllListeners ()
		{
			if (id_removeAllListeners == IntPtr.Zero)
				id_removeAllListeners = JNIEnv.GetMethodID (class_ref, "removeAllListeners", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAllListeners);
		}

		static Delegate cb_removeListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_Handler ()
		{
			if (cb_removeListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_ == null)
				cb_removeListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_);
			return cb_removeListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_;
		}

		static void n_RemoveListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener p0 = (global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_;
		public unsafe void RemoveListener (global::Com.Tencent.MM.Opensdk.Diffdev.IOAuthListener p0)
		{
			if (id_removeListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_ == IntPtr.Zero)
				id_removeListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Lcom/tencent/mm/opensdk/diffdev/OAuthListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeListener_Lcom_tencent_mm_opensdk_diffdev_OAuthListener_, __args);
		}

		static Delegate cb_stopAuth;
#pragma warning disable 0169
		static Delegate GetStopAuthHandler ()
		{
			if (cb_stopAuth == null)
				cb_stopAuth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StopAuth);
			return cb_stopAuth;
		}

		static bool n_StopAuth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StopAuth ();
		}
#pragma warning restore 0169

		IntPtr id_stopAuth;
		public unsafe bool StopAuth ()
		{
			if (id_stopAuth == IntPtr.Zero)
				id_stopAuth = JNIEnv.GetMethodID (class_ref, "stopAuth", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_stopAuth);
		}

	}

}
