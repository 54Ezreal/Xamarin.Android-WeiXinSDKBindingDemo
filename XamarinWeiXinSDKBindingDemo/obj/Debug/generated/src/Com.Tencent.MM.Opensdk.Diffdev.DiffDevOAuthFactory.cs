using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Diffdev {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/class[@name='DiffDevOAuthFactory']"
	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/diffdev/DiffDevOAuthFactory", DoNotGenerateAcw=true)]
	public partial class DiffDevOAuthFactory : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/class[@name='DiffDevOAuthFactory']/field[@name='MAX_SUPPORTED_VERSION']"
		[Register ("MAX_SUPPORTED_VERSION")]
		public const int MaxSupportedVersion = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/class[@name='DiffDevOAuthFactory']/field[@name='VERSION_1']"
		[Register ("VERSION_1")]
		public const int Version1 = (int) 1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/opensdk/diffdev/DiffDevOAuthFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiffDevOAuthFactory); }
		}

		protected DiffDevOAuthFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDiffDevOAuth;
		public static unsafe global::Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuth DiffDevOAuth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/class[@name='DiffDevOAuthFactory']/method[@name='getDiffDevOAuth' and count(parameter)=0]"
			[Register ("getDiffDevOAuth", "()Lcom/tencent/mm/opensdk/diffdev/IDiffDevOAuth;", "GetGetDiffDevOAuthHandler")]
			get {
				if (id_getDiffDevOAuth == IntPtr.Zero)
					id_getDiffDevOAuth = JNIEnv.GetStaticMethodID (class_ref, "getDiffDevOAuth", "()Lcom/tencent/mm/opensdk/diffdev/IDiffDevOAuth;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuth> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDiffDevOAuth), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDiffDevOAuth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.diffdev']/class[@name='DiffDevOAuthFactory']/method[@name='getDiffDevOAuth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDiffDevOAuth", "(I)Lcom/tencent/mm/opensdk/diffdev/IDiffDevOAuth;", "")]
		public static unsafe global::Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuth GetDiffDevOAuth (int p0)
		{
			if (id_getDiffDevOAuth_I == IntPtr.Zero)
				id_getDiffDevOAuth_I = JNIEnv.GetStaticMethodID (class_ref, "getDiffDevOAuth", "(I)Lcom/tencent/mm/opensdk/diffdev/IDiffDevOAuth;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Diffdev.IDiffDevOAuth> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDiffDevOAuth_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
