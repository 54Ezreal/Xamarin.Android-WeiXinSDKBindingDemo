using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Modelbiz {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage']"
	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelbiz/AddCardToWXCardPackage", DoNotGenerateAcw=true)]
	public partial class AddCardToWXCardPackage : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage.Req']"
		[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelbiz/AddCardToWXCardPackage$Req", DoNotGenerateAcw=true)]
		public partial class Req : global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq {


			static IntPtr cardArrary_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage.Req']/field[@name='cardArrary']"
			[Register ("cardArrary")]
			public global::System.Collections.IList CardArrary {
				get {
					if (cardArrary_jfieldId == IntPtr.Zero)
						cardArrary_jfieldId = JNIEnv.GetFieldID (class_ref, "cardArrary", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cardArrary_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (cardArrary_jfieldId == IntPtr.Zero)
						cardArrary_jfieldId = JNIEnv.GetFieldID (class_ref, "cardArrary", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cardArrary_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelbiz/AddCardToWXCardPackage$Req", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage.Req']/constructor[@name='AddCardToWXCardPackage.Req' and count(parameter)=0]"
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
				global::Com.Tencent.MM.Opensdk.Modelbiz.AddCardToWXCardPackage.Req __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbiz.AddCardToWXCardPackage.Req> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type;
			}
#pragma warning restore 0169

			static IntPtr id_getType;
			public override unsafe int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage.Req']/method[@name='getType' and count(parameter)=0]"
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
				global::Com.Tencent.MM.Opensdk.Modelbiz.AddCardToWXCardPackage.Req __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbiz.AddCardToWXCardPackage.Req> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckArgs ();
			}
#pragma warning restore 0169

			static IntPtr id_checkArgs;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage.Req']/method[@name='checkArgs' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage.Resp']"
		[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelbiz/AddCardToWXCardPackage$Resp", DoNotGenerateAcw=true)]
		public partial class Resp : global::Com.Tencent.MM.Opensdk.Modelbase.BaseResp {


			static IntPtr cardArrary_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage.Resp']/field[@name='cardArrary']"
			[Register ("cardArrary")]
			public global::System.Collections.IList CardArrary {
				get {
					if (cardArrary_jfieldId == IntPtr.Zero)
						cardArrary_jfieldId = JNIEnv.GetFieldID (class_ref, "cardArrary", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cardArrary_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (cardArrary_jfieldId == IntPtr.Zero)
						cardArrary_jfieldId = JNIEnv.GetFieldID (class_ref, "cardArrary", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cardArrary_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelbiz/AddCardToWXCardPackage$Resp", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage.Resp']/constructor[@name='AddCardToWXCardPackage.Resp' and count(parameter)=0]"
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage.Resp']/constructor[@name='AddCardToWXCardPackage.Resp' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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
				global::Com.Tencent.MM.Opensdk.Modelbiz.AddCardToWXCardPackage.Resp __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbiz.AddCardToWXCardPackage.Resp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type;
			}
#pragma warning restore 0169

			static IntPtr id_getType;
			public override unsafe int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage.Resp']/method[@name='getType' and count(parameter)=0]"
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
				global::Com.Tencent.MM.Opensdk.Modelbiz.AddCardToWXCardPackage.Resp __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbiz.AddCardToWXCardPackage.Resp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckArgs ();
			}
#pragma warning restore 0169

			static IntPtr id_checkArgs;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage.Resp']/method[@name='checkArgs' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage.WXCardItem']"
		[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelbiz/AddCardToWXCardPackage$WXCardItem", DoNotGenerateAcw=true)]
		public sealed partial class WXCardItem : global::Java.Lang.Object {


			static IntPtr cardExtMsg_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage.WXCardItem']/field[@name='cardExtMsg']"
			[Register ("cardExtMsg")]
			public string CardExtMsg {
				get {
					if (cardExtMsg_jfieldId == IntPtr.Zero)
						cardExtMsg_jfieldId = JNIEnv.GetFieldID (class_ref, "cardExtMsg", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cardExtMsg_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (cardExtMsg_jfieldId == IntPtr.Zero)
						cardExtMsg_jfieldId = JNIEnv.GetFieldID (class_ref, "cardExtMsg", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cardExtMsg_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr cardId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage.WXCardItem']/field[@name='cardId']"
			[Register ("cardId")]
			public string CardId {
				get {
					if (cardId_jfieldId == IntPtr.Zero)
						cardId_jfieldId = JNIEnv.GetFieldID (class_ref, "cardId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cardId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (cardId_jfieldId == IntPtr.Zero)
						cardId_jfieldId = JNIEnv.GetFieldID (class_ref, "cardId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cardId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr cardState_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage.WXCardItem']/field[@name='cardState']"
			[Register ("cardState")]
			public int CardState {
				get {
					if (cardState_jfieldId == IntPtr.Zero)
						cardState_jfieldId = JNIEnv.GetFieldID (class_ref, "cardState", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, cardState_jfieldId);
				}
				set {
					if (cardState_jfieldId == IntPtr.Zero)
						cardState_jfieldId = JNIEnv.GetFieldID (class_ref, "cardState", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cardState_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelbiz/AddCardToWXCardPackage$WXCardItem", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (WXCardItem); }
			}

			internal WXCardItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage.WXCardItem']/constructor[@name='AddCardToWXCardPackage.WXCardItem' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe WXCardItem ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (WXCardItem)) {
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelbiz/AddCardToWXCardPackage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AddCardToWXCardPackage); }
		}

		protected AddCardToWXCardPackage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='AddCardToWXCardPackage']/constructor[@name='AddCardToWXCardPackage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AddCardToWXCardPackage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AddCardToWXCardPackage)) {
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
