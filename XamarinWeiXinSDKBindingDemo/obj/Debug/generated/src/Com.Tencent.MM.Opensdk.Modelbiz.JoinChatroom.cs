using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Modelbiz {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JoinChatroom']"
	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelbiz/JoinChatroom", DoNotGenerateAcw=true)]
	public partial class JoinChatroom : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JoinChatroom.Req']"
		[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelbiz/JoinChatroom$Req", DoNotGenerateAcw=true)]
		public partial class Req : global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq {


			static IntPtr chatroomNickName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JoinChatroom.Req']/field[@name='chatroomNickName']"
			[Register ("chatroomNickName")]
			public string ChatroomNickName {
				get {
					if (chatroomNickName_jfieldId == IntPtr.Zero)
						chatroomNickName_jfieldId = JNIEnv.GetFieldID (class_ref, "chatroomNickName", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, chatroomNickName_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (chatroomNickName_jfieldId == IntPtr.Zero)
						chatroomNickName_jfieldId = JNIEnv.GetFieldID (class_ref, "chatroomNickName", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chatroomNickName_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr extMsg_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JoinChatroom.Req']/field[@name='extMsg']"
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

			static IntPtr groupId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JoinChatroom.Req']/field[@name='groupId']"
			[Register ("groupId")]
			public string GroupId {
				get {
					if (groupId_jfieldId == IntPtr.Zero)
						groupId_jfieldId = JNIEnv.GetFieldID (class_ref, "groupId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, groupId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (groupId_jfieldId == IntPtr.Zero)
						groupId_jfieldId = JNIEnv.GetFieldID (class_ref, "groupId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, groupId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelbiz/JoinChatroom$Req", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JoinChatroom.Req']/constructor[@name='JoinChatroom.Req' and count(parameter)=0]"
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
				global::Com.Tencent.MM.Opensdk.Modelbiz.JoinChatroom.Req __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbiz.JoinChatroom.Req> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type;
			}
#pragma warning restore 0169

			static IntPtr id_getType;
			public override unsafe int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JoinChatroom.Req']/method[@name='getType' and count(parameter)=0]"
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
				global::Com.Tencent.MM.Opensdk.Modelbiz.JoinChatroom.Req __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbiz.JoinChatroom.Req> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckArgs ();
			}
#pragma warning restore 0169

			static IntPtr id_checkArgs;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JoinChatroom.Req']/method[@name='checkArgs' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JoinChatroom.Resp']"
		[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelbiz/JoinChatroom$Resp", DoNotGenerateAcw=true)]
		public partial class Resp : global::Com.Tencent.MM.Opensdk.Modelbase.BaseResp {


			static IntPtr extMsg_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JoinChatroom.Resp']/field[@name='extMsg']"
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
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelbiz/JoinChatroom$Resp", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Resp); }
			}

			protected Resp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JoinChatroom.Resp']/constructor[@name='JoinChatroom.Resp' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Resp ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Resp)) {
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JoinChatroom.Resp']/constructor[@name='JoinChatroom.Resp' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register (".ctor", "(Landroid/os/Bundle;)V", "")]
			public unsafe Resp (global::Android.OS.Bundle p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Resp)) {
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
				global::Com.Tencent.MM.Opensdk.Modelbiz.JoinChatroom.Resp __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbiz.JoinChatroom.Resp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type;
			}
#pragma warning restore 0169

			static IntPtr id_getType;
			public override unsafe int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JoinChatroom.Resp']/method[@name='getType' and count(parameter)=0]"
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
				global::Com.Tencent.MM.Opensdk.Modelbiz.JoinChatroom.Resp __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbiz.JoinChatroom.Resp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckArgs ();
			}
#pragma warning restore 0169

			static IntPtr id_checkArgs;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='JoinChatroom.Resp']/method[@name='checkArgs' and count(parameter)=0]"
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

		protected JoinChatroom (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
