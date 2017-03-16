using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Modelbiz {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizWebview']"
	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelbiz/JumpToBizWebview", DoNotGenerateAcw=true)]
	public sealed partial class JumpToBizWebview : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizWebview.Req']"
		[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelbiz/JumpToBizWebview$Req", DoNotGenerateAcw=true)]
		public partial class Req : global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq {


			static IntPtr extMsg_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizWebview.Req']/field[@name='extMsg']"
			[Register ("extMsg")]
			public string ExtMsg {
				get {
					if (extMsg_jfieldId == IntPtr.Zero)
						extMsg_jfieldId = JNIEnv.GetFieldID (class_ref, "extMsg", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, extMsg_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (extMsg_jfieldId == IntPtr.Zero)
						extMsg_jfieldId = JNIEnv.GetFieldID (class_ref, "extMsg", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, extMsg_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr scene_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizWebview.Req']/field[@name='scene']"
			[Register ("scene")]
			public int Scene {
				get {
					if (scene_jfieldId == IntPtr.Zero)
						scene_jfieldId = JNIEnv.GetFieldID (class_ref, "scene", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, scene_jfieldId);
				}
				set {
					if (scene_jfieldId == IntPtr.Zero)
						scene_jfieldId = JNIEnv.GetFieldID (class_ref, "scene", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, scene_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr toUserName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizWebview.Req']/field[@name='toUserName']"
			[Register ("toUserName")]
			public string ToUserName {
				get {
					if (toUserName_jfieldId == IntPtr.Zero)
						toUserName_jfieldId = JNIEnv.GetFieldID (class_ref, "toUserName", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, toUserName_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (toUserName_jfieldId == IntPtr.Zero)
						toUserName_jfieldId = JNIEnv.GetFieldID (class_ref, "toUserName", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, toUserName_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr webType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizWebview.Req']/field[@name='webType']"
			[Register ("webType")]
			public int WebType {
				get {
					if (webType_jfieldId == IntPtr.Zero)
						webType_jfieldId = JNIEnv.GetFieldID (class_ref, "webType", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, webType_jfieldId);
				}
				set {
					if (webType_jfieldId == IntPtr.Zero)
						webType_jfieldId = JNIEnv.GetFieldID (class_ref, "webType", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, webType_jfieldId, value);
					} finally {
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelbiz/JumpToBizWebview$Req", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Req); }
			}

			protected Req (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizWebview.Req']/constructor[@name='JumpToBizWebview.Req' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Req ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Req)) {
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
				global::Com.Tencent.MM.Opensdk.Modelbiz.JumpToBizWebview.Req __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbiz.JumpToBizWebview.Req> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type;
			}
#pragma warning restore 0169

			static IntPtr id_getType;
			public override unsafe int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizWebview.Req']/method[@name='getType' and count(parameter)=0]"
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
				global::Com.Tencent.MM.Opensdk.Modelbiz.JumpToBizWebview.Req __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbiz.JumpToBizWebview.Req> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckArgs ();
			}
#pragma warning restore 0169

			static IntPtr id_checkArgs;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizWebview.Req']/method[@name='checkArgs' and count(parameter)=0]"
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelbiz/JumpToBizWebview", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JumpToBizWebview); }
		}

		internal JumpToBizWebview (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizWebview']/constructor[@name='JumpToBizWebview' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JumpToBizWebview ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (JumpToBizWebview)) {
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

	}
}
