using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Openapi {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.mm.opensdk.openapi']/interface[@name='IWXAPI']"
	[Register ("com/tencent/mm/opensdk/openapi/IWXAPI", "", "Com.Tencent.MM.Opensdk.Openapi.IWXAPIInvoker")]
	public partial interface IWXAPI : IJavaObject {

		bool IsWXAppInstalled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.openapi']/interface[@name='IWXAPI']/method[@name='isWXAppInstalled' and count(parameter)=0]"
			[Register ("isWXAppInstalled", "()Z", "GetIsWXAppInstalledHandler:Com.Tencent.MM.Opensdk.Openapi.IWXAPIInvoker, XamarinWeiXinSDKBindingDemo")] get;
		}

		bool IsWXAppSupportAPI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.openapi']/interface[@name='IWXAPI']/method[@name='isWXAppSupportAPI' and count(parameter)=0]"
			[Register ("isWXAppSupportAPI", "()Z", "GetIsWXAppSupportAPIHandler:Com.Tencent.MM.Opensdk.Openapi.IWXAPIInvoker, XamarinWeiXinSDKBindingDemo")] get;
		}

		int WXAppSupportAPI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.openapi']/interface[@name='IWXAPI']/method[@name='getWXAppSupportAPI' and count(parameter)=0]"
			[Register ("getWXAppSupportAPI", "()I", "GetGetWXAppSupportAPIHandler:Com.Tencent.MM.Opensdk.Openapi.IWXAPIInvoker, XamarinWeiXinSDKBindingDemo")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.openapi']/interface[@name='IWXAPI']/method[@name='detach' and count(parameter)=0]"
		[Register ("detach", "()V", "GetDetachHandler:Com.Tencent.MM.Opensdk.Openapi.IWXAPIInvoker, XamarinWeiXinSDKBindingDemo")]
		void Detach ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.openapi']/interface[@name='IWXAPI']/method[@name='handleIntent' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.tencent.mm.opensdk.openapi.IWXAPIEventHandler']]"
		[Register ("handleIntent", "(Landroid/content/Intent;Lcom/tencent/mm/opensdk/openapi/IWXAPIEventHandler;)Z", "GetHandleIntent_Landroid_content_Intent_Lcom_tencent_mm_opensdk_openapi_IWXAPIEventHandler_Handler:Com.Tencent.MM.Opensdk.Openapi.IWXAPIInvoker, XamarinWeiXinSDKBindingDemo")]
		bool HandleIntent (global::Android.Content.Intent p0, global::Com.Tencent.MM.Opensdk.Openapi.IWXAPIEventHandler p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.openapi']/interface[@name='IWXAPI']/method[@name='openWXApp' and count(parameter)=0]"
		[Register ("openWXApp", "()Z", "GetOpenWXAppHandler:Com.Tencent.MM.Opensdk.Openapi.IWXAPIInvoker, XamarinWeiXinSDKBindingDemo")]
		bool OpenWXApp ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.openapi']/interface[@name='IWXAPI']/method[@name='registerApp' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerApp", "(Ljava/lang/String;)Z", "GetRegisterApp_Ljava_lang_String_Handler:Com.Tencent.MM.Opensdk.Openapi.IWXAPIInvoker, XamarinWeiXinSDKBindingDemo")]
		bool RegisterApp (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.openapi']/interface[@name='IWXAPI']/method[@name='registerApp' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("registerApp", "(Ljava/lang/String;J)Z", "GetRegisterApp_Ljava_lang_String_JHandler:Com.Tencent.MM.Opensdk.Openapi.IWXAPIInvoker, XamarinWeiXinSDKBindingDemo")]
		bool RegisterApp (string p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.openapi']/interface[@name='IWXAPI']/method[@name='sendReq' and count(parameter)=1 and parameter[1][@type='com.tencent.mm.opensdk.modelbase.BaseReq']]"
		[Register ("sendReq", "(Lcom/tencent/mm/opensdk/modelbase/BaseReq;)Z", "GetSendReq_Lcom_tencent_mm_opensdk_modelbase_BaseReq_Handler:Com.Tencent.MM.Opensdk.Openapi.IWXAPIInvoker, XamarinWeiXinSDKBindingDemo")]
		bool SendReq (global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.openapi']/interface[@name='IWXAPI']/method[@name='sendResp' and count(parameter)=1 and parameter[1][@type='com.tencent.mm.opensdk.modelbase.BaseResp']]"
		[Register ("sendResp", "(Lcom/tencent/mm/opensdk/modelbase/BaseResp;)Z", "GetSendResp_Lcom_tencent_mm_opensdk_modelbase_BaseResp_Handler:Com.Tencent.MM.Opensdk.Openapi.IWXAPIInvoker, XamarinWeiXinSDKBindingDemo")]
		bool SendResp (global::Com.Tencent.MM.Opensdk.Modelbase.BaseResp p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.openapi']/interface[@name='IWXAPI']/method[@name='unregisterApp' and count(parameter)=0]"
		[Register ("unregisterApp", "()V", "GetUnregisterAppHandler:Com.Tencent.MM.Opensdk.Openapi.IWXAPIInvoker, XamarinWeiXinSDKBindingDemo")]
		void UnregisterApp ();

	}

	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/openapi/IWXAPI", DoNotGenerateAcw=true)]
	internal class IWXAPIInvoker : global::Java.Lang.Object, IWXAPI {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/mm/opensdk/openapi/IWXAPI");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IWXAPIInvoker); }
		}

		IntPtr class_ref;

		public static IWXAPI GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWXAPI> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.mm.opensdk.openapi.IWXAPI"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWXAPIInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isWXAppInstalled;
#pragma warning disable 0169
		static Delegate GetIsWXAppInstalledHandler ()
		{
			if (cb_isWXAppInstalled == null)
				cb_isWXAppInstalled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsWXAppInstalled);
			return cb_isWXAppInstalled;
		}

		static bool n_IsWXAppInstalled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWXAppInstalled;
		}
#pragma warning restore 0169

		IntPtr id_isWXAppInstalled;
		public unsafe bool IsWXAppInstalled {
			get {
				if (id_isWXAppInstalled == IntPtr.Zero)
					id_isWXAppInstalled = JNIEnv.GetMethodID (class_ref, "isWXAppInstalled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isWXAppInstalled);
			}
		}

		static Delegate cb_isWXAppSupportAPI;
#pragma warning disable 0169
		static Delegate GetIsWXAppSupportAPIHandler ()
		{
			if (cb_isWXAppSupportAPI == null)
				cb_isWXAppSupportAPI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsWXAppSupportAPI);
			return cb_isWXAppSupportAPI;
		}

		static bool n_IsWXAppSupportAPI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWXAppSupportAPI;
		}
#pragma warning restore 0169

		IntPtr id_isWXAppSupportAPI;
		public unsafe bool IsWXAppSupportAPI {
			get {
				if (id_isWXAppSupportAPI == IntPtr.Zero)
					id_isWXAppSupportAPI = JNIEnv.GetMethodID (class_ref, "isWXAppSupportAPI", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isWXAppSupportAPI);
			}
		}

		static Delegate cb_getWXAppSupportAPI;
#pragma warning disable 0169
		static Delegate GetGetWXAppSupportAPIHandler ()
		{
			if (cb_getWXAppSupportAPI == null)
				cb_getWXAppSupportAPI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWXAppSupportAPI);
			return cb_getWXAppSupportAPI;
		}

		static int n_GetWXAppSupportAPI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WXAppSupportAPI;
		}
#pragma warning restore 0169

		IntPtr id_getWXAppSupportAPI;
		public unsafe int WXAppSupportAPI {
			get {
				if (id_getWXAppSupportAPI == IntPtr.Zero)
					id_getWXAppSupportAPI = JNIEnv.GetMethodID (class_ref, "getWXAppSupportAPI", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWXAppSupportAPI);
			}
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
			global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_handleIntent_Landroid_content_Intent_Lcom_tencent_mm_opensdk_openapi_IWXAPIEventHandler_;
#pragma warning disable 0169
		static Delegate GetHandleIntent_Landroid_content_Intent_Lcom_tencent_mm_opensdk_openapi_IWXAPIEventHandler_Handler ()
		{
			if (cb_handleIntent_Landroid_content_Intent_Lcom_tencent_mm_opensdk_openapi_IWXAPIEventHandler_ == null)
				cb_handleIntent_Landroid_content_Intent_Lcom_tencent_mm_opensdk_openapi_IWXAPIEventHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_HandleIntent_Landroid_content_Intent_Lcom_tencent_mm_opensdk_openapi_IWXAPIEventHandler_);
			return cb_handleIntent_Landroid_content_Intent_Lcom_tencent_mm_opensdk_openapi_IWXAPIEventHandler_;
		}

		static bool n_HandleIntent_Landroid_content_Intent_Lcom_tencent_mm_opensdk_openapi_IWXAPIEventHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.MM.Opensdk.Openapi.IWXAPIEventHandler p1 = (global::Com.Tencent.MM.Opensdk.Openapi.IWXAPIEventHandler)global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Openapi.IWXAPIEventHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleIntent (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_handleIntent_Landroid_content_Intent_Lcom_tencent_mm_opensdk_openapi_IWXAPIEventHandler_;
		public unsafe bool HandleIntent (global::Android.Content.Intent p0, global::Com.Tencent.MM.Opensdk.Openapi.IWXAPIEventHandler p1)
		{
			if (id_handleIntent_Landroid_content_Intent_Lcom_tencent_mm_opensdk_openapi_IWXAPIEventHandler_ == IntPtr.Zero)
				id_handleIntent_Landroid_content_Intent_Lcom_tencent_mm_opensdk_openapi_IWXAPIEventHandler_ = JNIEnv.GetMethodID (class_ref, "handleIntent", "(Landroid/content/Intent;Lcom/tencent/mm/opensdk/openapi/IWXAPIEventHandler;)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_handleIntent_Landroid_content_Intent_Lcom_tencent_mm_opensdk_openapi_IWXAPIEventHandler_, __args);
			return __ret;
		}

		static Delegate cb_openWXApp;
#pragma warning disable 0169
		static Delegate GetOpenWXAppHandler ()
		{
			if (cb_openWXApp == null)
				cb_openWXApp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OpenWXApp);
			return cb_openWXApp;
		}

		static bool n_OpenWXApp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OpenWXApp ();
		}
#pragma warning restore 0169

		IntPtr id_openWXApp;
		public unsafe bool OpenWXApp ()
		{
			if (id_openWXApp == IntPtr.Zero)
				id_openWXApp = JNIEnv.GetMethodID (class_ref, "openWXApp", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_openWXApp);
		}

		static Delegate cb_registerApp_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterApp_Ljava_lang_String_Handler ()
		{
			if (cb_registerApp_Ljava_lang_String_ == null)
				cb_registerApp_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterApp_Ljava_lang_String_);
			return cb_registerApp_Ljava_lang_String_;
		}

		static bool n_RegisterApp_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterApp (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_registerApp_Ljava_lang_String_;
		public unsafe bool RegisterApp (string p0)
		{
			if (id_registerApp_Ljava_lang_String_ == IntPtr.Zero)
				id_registerApp_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "registerApp", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_registerApp_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_registerApp_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetRegisterApp_Ljava_lang_String_JHandler ()
		{
			if (cb_registerApp_Ljava_lang_String_J == null)
				cb_registerApp_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, bool>) n_RegisterApp_Ljava_lang_String_J);
			return cb_registerApp_Ljava_lang_String_J;
		}

		static bool n_RegisterApp_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterApp (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_registerApp_Ljava_lang_String_J;
		public unsafe bool RegisterApp (string p0, long p1)
		{
			if (id_registerApp_Ljava_lang_String_J == IntPtr.Zero)
				id_registerApp_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "registerApp", "(Ljava/lang/String;J)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_registerApp_Ljava_lang_String_J, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_sendReq_Lcom_tencent_mm_opensdk_modelbase_BaseReq_;
#pragma warning disable 0169
		static Delegate GetSendReq_Lcom_tencent_mm_opensdk_modelbase_BaseReq_Handler ()
		{
			if (cb_sendReq_Lcom_tencent_mm_opensdk_modelbase_BaseReq_ == null)
				cb_sendReq_Lcom_tencent_mm_opensdk_modelbase_BaseReq_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SendReq_Lcom_tencent_mm_opensdk_modelbase_BaseReq_);
			return cb_sendReq_Lcom_tencent_mm_opensdk_modelbase_BaseReq_;
		}

		static bool n_SendReq_Lcom_tencent_mm_opensdk_modelbase_BaseReq_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendReq (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sendReq_Lcom_tencent_mm_opensdk_modelbase_BaseReq_;
		public unsafe bool SendReq (global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq p0)
		{
			if (id_sendReq_Lcom_tencent_mm_opensdk_modelbase_BaseReq_ == IntPtr.Zero)
				id_sendReq_Lcom_tencent_mm_opensdk_modelbase_BaseReq_ = JNIEnv.GetMethodID (class_ref, "sendReq", "(Lcom/tencent/mm/opensdk/modelbase/BaseReq;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_sendReq_Lcom_tencent_mm_opensdk_modelbase_BaseReq_, __args);
			return __ret;
		}

		static Delegate cb_sendResp_Lcom_tencent_mm_opensdk_modelbase_BaseResp_;
#pragma warning disable 0169
		static Delegate GetSendResp_Lcom_tencent_mm_opensdk_modelbase_BaseResp_Handler ()
		{
			if (cb_sendResp_Lcom_tencent_mm_opensdk_modelbase_BaseResp_ == null)
				cb_sendResp_Lcom_tencent_mm_opensdk_modelbase_BaseResp_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SendResp_Lcom_tencent_mm_opensdk_modelbase_BaseResp_);
			return cb_sendResp_Lcom_tencent_mm_opensdk_modelbase_BaseResp_;
		}

		static bool n_SendResp_Lcom_tencent_mm_opensdk_modelbase_BaseResp_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.MM.Opensdk.Modelbase.BaseResp p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbase.BaseResp> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendResp (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sendResp_Lcom_tencent_mm_opensdk_modelbase_BaseResp_;
		public unsafe bool SendResp (global::Com.Tencent.MM.Opensdk.Modelbase.BaseResp p0)
		{
			if (id_sendResp_Lcom_tencent_mm_opensdk_modelbase_BaseResp_ == IntPtr.Zero)
				id_sendResp_Lcom_tencent_mm_opensdk_modelbase_BaseResp_ = JNIEnv.GetMethodID (class_ref, "sendResp", "(Lcom/tencent/mm/opensdk/modelbase/BaseResp;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_sendResp_Lcom_tencent_mm_opensdk_modelbase_BaseResp_, __args);
			return __ret;
		}

		static Delegate cb_unregisterApp;
#pragma warning disable 0169
		static Delegate GetUnregisterAppHandler ()
		{
			if (cb_unregisterApp == null)
				cb_unregisterApp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterApp);
			return cb_unregisterApp;
		}

		static void n_UnregisterApp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Openapi.IWXAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterApp ();
		}
#pragma warning restore 0169

		IntPtr id_unregisterApp;
		public unsafe void UnregisterApp ()
		{
			if (id_unregisterApp == IntPtr.Zero)
				id_unregisterApp = JNIEnv.GetMethodID (class_ref, "unregisterApp", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterApp);
		}

	}

}
