using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Modelbiz {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage']"
	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelbiz/ChooseCardFromWXCardPackage", DoNotGenerateAcw=true)]
	public partial class ChooseCardFromWXCardPackage : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Req']"
		[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelbiz/ChooseCardFromWXCardPackage$Req", DoNotGenerateAcw=true)]
		public partial class Req : global::Com.Tencent.MM.Opensdk.Modelbase.BaseReq {


			static IntPtr appId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Req']/field[@name='appId']"
			[Register ("appId")]
			public string AppId {
				get {
					if (appId_jfieldId == IntPtr.Zero)
						appId_jfieldId = JNIEnv.GetFieldID (class_ref, "appId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, appId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (appId_jfieldId == IntPtr.Zero)
						appId_jfieldId = JNIEnv.GetFieldID (class_ref, "appId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, appId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr canMultiSelect_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Req']/field[@name='canMultiSelect']"
			[Register ("canMultiSelect")]
			public string CanMultiSelect {
				get {
					if (canMultiSelect_jfieldId == IntPtr.Zero)
						canMultiSelect_jfieldId = JNIEnv.GetFieldID (class_ref, "canMultiSelect", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, canMultiSelect_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (canMultiSelect_jfieldId == IntPtr.Zero)
						canMultiSelect_jfieldId = JNIEnv.GetFieldID (class_ref, "canMultiSelect", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, canMultiSelect_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr cardId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Req']/field[@name='cardId']"
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

			static IntPtr cardSign_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Req']/field[@name='cardSign']"
			[Register ("cardSign")]
			public string CardSign {
				get {
					if (cardSign_jfieldId == IntPtr.Zero)
						cardSign_jfieldId = JNIEnv.GetFieldID (class_ref, "cardSign", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cardSign_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (cardSign_jfieldId == IntPtr.Zero)
						cardSign_jfieldId = JNIEnv.GetFieldID (class_ref, "cardSign", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cardSign_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr cardType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Req']/field[@name='cardType']"
			[Register ("cardType")]
			public string CardType {
				get {
					if (cardType_jfieldId == IntPtr.Zero)
						cardType_jfieldId = JNIEnv.GetFieldID (class_ref, "cardType", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cardType_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (cardType_jfieldId == IntPtr.Zero)
						cardType_jfieldId = JNIEnv.GetFieldID (class_ref, "cardType", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cardType_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr locationId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Req']/field[@name='locationId']"
			[Register ("locationId")]
			public string LocationId {
				get {
					if (locationId_jfieldId == IntPtr.Zero)
						locationId_jfieldId = JNIEnv.GetFieldID (class_ref, "locationId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, locationId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (locationId_jfieldId == IntPtr.Zero)
						locationId_jfieldId = JNIEnv.GetFieldID (class_ref, "locationId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, locationId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr nonceStr_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Req']/field[@name='nonceStr']"
			[Register ("nonceStr")]
			public string NonceStr {
				get {
					if (nonceStr_jfieldId == IntPtr.Zero)
						nonceStr_jfieldId = JNIEnv.GetFieldID (class_ref, "nonceStr", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, nonceStr_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (nonceStr_jfieldId == IntPtr.Zero)
						nonceStr_jfieldId = JNIEnv.GetFieldID (class_ref, "nonceStr", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nonceStr_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr signType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Req']/field[@name='signType']"
			[Register ("signType")]
			public string SignType {
				get {
					if (signType_jfieldId == IntPtr.Zero)
						signType_jfieldId = JNIEnv.GetFieldID (class_ref, "signType", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, signType_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (signType_jfieldId == IntPtr.Zero)
						signType_jfieldId = JNIEnv.GetFieldID (class_ref, "signType", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, signType_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr timeStamp_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Req']/field[@name='timeStamp']"
			[Register ("timeStamp")]
			public string TimeStamp {
				get {
					if (timeStamp_jfieldId == IntPtr.Zero)
						timeStamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timeStamp", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, timeStamp_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (timeStamp_jfieldId == IntPtr.Zero)
						timeStamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timeStamp", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timeStamp_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelbiz/ChooseCardFromWXCardPackage$Req", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Req']/constructor[@name='ChooseCardFromWXCardPackage.Req' and count(parameter)=0]"
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
				global::Com.Tencent.MM.Opensdk.Modelbiz.ChooseCardFromWXCardPackage.Req __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbiz.ChooseCardFromWXCardPackage.Req> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type;
			}
#pragma warning restore 0169

			static IntPtr id_getType;
			public override unsafe int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Req']/method[@name='getType' and count(parameter)=0]"
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
				global::Com.Tencent.MM.Opensdk.Modelbiz.ChooseCardFromWXCardPackage.Req __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbiz.ChooseCardFromWXCardPackage.Req> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckArgs ();
			}
#pragma warning restore 0169

			static IntPtr id_checkArgs;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Req']/method[@name='checkArgs' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Resp']"
		[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelbiz/ChooseCardFromWXCardPackage$Resp", DoNotGenerateAcw=true)]
		public partial class Resp : global::Com.Tencent.MM.Opensdk.Modelbase.BaseResp {


			static IntPtr cardItemList_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Resp']/field[@name='cardItemList']"
			[Register ("cardItemList")]
			public string CardItemList {
				get {
					if (cardItemList_jfieldId == IntPtr.Zero)
						cardItemList_jfieldId = JNIEnv.GetFieldID (class_ref, "cardItemList", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cardItemList_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (cardItemList_jfieldId == IntPtr.Zero)
						cardItemList_jfieldId = JNIEnv.GetFieldID (class_ref, "cardItemList", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cardItemList_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelbiz/ChooseCardFromWXCardPackage$Resp", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Resp']/constructor[@name='ChooseCardFromWXCardPackage.Resp' and count(parameter)=0]"
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Resp']/constructor[@name='ChooseCardFromWXCardPackage.Resp' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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
				global::Com.Tencent.MM.Opensdk.Modelbiz.ChooseCardFromWXCardPackage.Resp __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbiz.ChooseCardFromWXCardPackage.Resp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type;
			}
#pragma warning restore 0169

			static IntPtr id_getType;
			public override unsafe int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Resp']/method[@name='getType' and count(parameter)=0]"
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
				global::Com.Tencent.MM.Opensdk.Modelbiz.ChooseCardFromWXCardPackage.Resp __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelbiz.ChooseCardFromWXCardPackage.Resp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckArgs ();
			}
#pragma warning restore 0169

			static IntPtr id_checkArgs;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage.Resp']/method[@name='checkArgs' and count(parameter)=0]"
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
				return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelbiz/ChooseCardFromWXCardPackage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChooseCardFromWXCardPackage); }
		}

		protected ChooseCardFromWXCardPackage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelbiz']/class[@name='ChooseCardFromWXCardPackage']/constructor[@name='ChooseCardFromWXCardPackage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChooseCardFromWXCardPackage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ChooseCardFromWXCardPackage)) {
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
