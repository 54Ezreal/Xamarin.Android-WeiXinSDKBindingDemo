using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Modelbiz {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizTempSession']"
	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelbiz/JumpToBizTempSession", DoNotGenerateAcw=true)]
	public sealed partial class JumpToBizTempSession : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizTempSession']/field[@name='SHOW_CHAT']"
		[Register ("SHOW_CHAT")]
		public const int ShowChat = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizTempSession']/field[@name='SHOW_MENU']"
		[Register ("SHOW_MENU")]
		public const int ShowMenu = (int) 0;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizTempSession.Req']"
		[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelbiz/JumpToBizTempSession$Req", DoNotGenerateAcw=true)]
		public partial class Req : global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq {


			static IntPtr sessionFrom_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizTempSession.Req']/field[@name='sessionFrom']"
			[Register ("sessionFrom")]
			public string SessionFrom {
				get {
					if (sessionFrom_jfieldId == IntPtr.Zero)
						sessionFrom_jfieldId = JNIEnv.GetFieldID (class_ref, "sessionFrom", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, sessionFrom_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (sessionFrom_jfieldId == IntPtr.Zero)
						sessionFrom_jfieldId = JNIEnv.GetFieldID (class_ref, "sessionFrom", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sessionFrom_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr showType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizTempSession.Req']/field[@name='showType']"
			[Register ("showType")]
			public int ShowType {
				get {
					if (showType_jfieldId == IntPtr.Zero)
						showType_jfieldId = JNIEnv.GetFieldID (class_ref, "showType", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, showType_jfieldId);
				}
				set {
					if (showType_jfieldId == IntPtr.Zero)
						showType_jfieldId = JNIEnv.GetFieldID (class_ref, "showType", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, showType_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr toUserName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizTempSession.Req']/field[@name='toUserName']"
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
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelbiz/JumpToBizTempSession$Req", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizTempSession.Req']/constructor[@name='JumpToBizTempSession.Req' and count(parameter)=0]"
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
				global::Com.Tencent.MM.Opensdk.Modelbiz.JumpToBizTempSession.Req __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbiz.JumpToBizTempSession.Req> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type;
			}
#pragma warning restore 0169

			static IntPtr id_getType;
			public override unsafe int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizTempSession.Req']/method[@name='getType' and count(parameter)=0]"
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
				global::Com.Tencent.MM.Opensdk.Modelbiz.JumpToBizTempSession.Req __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbiz.JumpToBizTempSession.Req> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckArgs ();
			}
#pragma warning restore 0169

			static IntPtr id_checkArgs;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizTempSession.Req']/method[@name='checkArgs' and count(parameter)=0]"
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
				return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelbiz/JumpToBizTempSession", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JumpToBizTempSession); }
		}

		internal JumpToBizTempSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JumpToBizTempSession']/constructor[@name='JumpToBizTempSession' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JumpToBizTempSession ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (JumpToBizTempSession)) {
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
