using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Modelmsg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXImageObject']"
	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelmsg/WXImageObject", DoNotGenerateAcw=true)]
	public partial class WXImageObject : global::Java.Lang.Object, global::Com.Tencent.MM.Opensdk.Modelmsg.WXMediaMessage.IMediaObject {


		static IntPtr imageData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXImageObject']/field[@name='imageData']"
		[Register ("imageData")]
		public IList<byte> ImageData {
			get {
				if (imageData_jfieldId == IntPtr.Zero)
					imageData_jfieldId = JNIEnv.GetFieldID (class_ref, "imageData", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, imageData_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (imageData_jfieldId == IntPtr.Zero)
					imageData_jfieldId = JNIEnv.GetFieldID (class_ref, "imageData", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, imageData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr imagePath_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXImageObject']/field[@name='imagePath']"
		[Register ("imagePath")]
		public string ImagePath {
			get {
				if (imagePath_jfieldId == IntPtr.Zero)
					imagePath_jfieldId = JNIEnv.GetFieldID (class_ref, "imagePath", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, imagePath_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (imagePath_jfieldId == IntPtr.Zero)
					imagePath_jfieldId = JNIEnv.GetFieldID (class_ref, "imagePath", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, imagePath_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: com.tencent.mm.opensdk.modelmsg.WXMediaMessage.IMediaObject

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_APPBRAND']"
			[Register ("TYPE_APPBRAND")]
			public const int TypeAppbrand = (int) 33;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_APPDATA']"
			[Register ("TYPE_APPDATA")]
			public const int TypeAppdata = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_CARD_SHARE']"
			[Register ("TYPE_CARD_SHARE")]
			public const int TypeCardShare = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_DESIGNER_SHARED']"
			[Register ("TYPE_DESIGNER_SHARED")]
			public const int TypeDesignerShared = (int) 25;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_DEVICE_ACCESS']"
			[Register ("TYPE_DEVICE_ACCESS")]
			public const int TypeDeviceAccess = (int) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_EMOJI']"
			[Register ("TYPE_EMOJI")]
			public const int TypeEmoji = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_EMOJILIST_SHARED']"
			[Register ("TYPE_EMOJILIST_SHARED")]
			public const int TypeEmojilistShared = (int) 27;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_EMOTICON_GIFT']"
			[Register ("TYPE_EMOTICON_GIFT")]
			public const int TypeEmoticonGift = (int) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_EMOTICON_SHARED']"
			[Register ("TYPE_EMOTICON_SHARED")]
			public const int TypeEmoticonShared = (int) 15;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_EMOTIONLIST_SHARED']"
			[Register ("TYPE_EMOTIONLIST_SHARED")]
			public const int TypeEmotionlistShared = (int) 26;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_FILE']"
			[Register ("TYPE_FILE")]
			public const int TypeFile = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_GIFTCARD']"
			[Register ("TYPE_GIFTCARD")]
			public const int TypeGiftcard = (int) 34;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_IMAGE']"
			[Register ("TYPE_IMAGE")]
			public const int TypeImage = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_LOCATION']"
			[Register ("TYPE_LOCATION")]
			public const int TypeLocation = (int) 30;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_LOCATION_SHARE']"
			[Register ("TYPE_LOCATION_SHARE")]
			public const int TypeLocationShare = (int) 17;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_MALL_PRODUCT']"
			[Register ("TYPE_MALL_PRODUCT")]
			public const int TypeMallProduct = (int) 13;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_MUSIC']"
			[Register ("TYPE_MUSIC")]
			public const int TypeMusic = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_NOTE']"
			[Register ("TYPE_NOTE")]
			public const int TypeNote = (int) 24;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_OLD_TV']"
			[Register ("TYPE_OLD_TV")]
			public const int TypeOldTv = (int) 14;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_PRODUCT']"
			[Register ("TYPE_PRODUCT")]
			public const int TypeProduct = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_RECORD']"
			[Register ("TYPE_RECORD")]
			public const int TypeRecord = (int) 19;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_TEXT']"
			[Register ("TYPE_TEXT")]
			public const int TypeText = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_TV']"
			[Register ("TYPE_TV")]
			public const int TypeTv = (int) 20;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_UNKNOWN']"
			[Register ("TYPE_UNKNOWN")]
			public const int TypeUnknown = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_URL']"
			[Register ("TYPE_URL")]
			public const int TypeUrl = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/interface[@name='WXMediaMessage.IMediaObject']/field[@name='TYPE_VIDEO']"
			[Register ("TYPE_VIDEO")]
			public const int TypeVideo = (int) 4;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelmsg/WXImageObject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WXImageObject); }
		}

		protected WXImageObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXImageObject']/constructor[@name='WXImageObject' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;)V", "")]
		public unsafe WXImageObject (global::Android.Graphics.Bitmap p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (WXImageObject)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXImageObject']/constructor[@name='WXImageObject' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe WXImageObject (byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (WXImageObject)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXImageObject']/constructor[@name='WXImageObject' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WXImageObject ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (WXImageObject)) {
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
			global::Com.Tencent.MM.Opensdk.Modelmsg.WXImageObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelmsg.WXImageObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckArgs ();
		}
#pragma warning restore 0169

		static IntPtr id_checkArgs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXImageObject']/method[@name='checkArgs' and count(parameter)=0]"
		[Register ("checkArgs", "()Z", "GetCheckArgsHandler")]
		public virtual unsafe bool CheckArgs ()
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

		static Delegate cb_serialize_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSerialize_Landroid_os_Bundle_Handler ()
		{
			if (cb_serialize_Landroid_os_Bundle_ == null)
				cb_serialize_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Serialize_Landroid_os_Bundle_);
			return cb_serialize_Landroid_os_Bundle_;
		}

		static void n_Serialize_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.MM.Opensdk.Modelmsg.WXImageObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelmsg.WXImageObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Serialize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_serialize_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXImageObject']/method[@name='serialize' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("serialize", "(Landroid/os/Bundle;)V", "GetSerialize_Landroid_os_Bundle_Handler")]
		public virtual unsafe void Serialize (global::Android.OS.Bundle p0)
		{
			if (id_serialize_Landroid_os_Bundle_ == IntPtr.Zero)
				id_serialize_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "serialize", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_serialize_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "serialize", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setImagePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImagePath_Ljava_lang_String_Handler ()
		{
			if (cb_setImagePath_Ljava_lang_String_ == null)
				cb_setImagePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImagePath_Ljava_lang_String_);
			return cb_setImagePath_Ljava_lang_String_;
		}

		static void n_SetImagePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.MM.Opensdk.Modelmsg.WXImageObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelmsg.WXImageObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetImagePath (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setImagePath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXImageObject']/method[@name='setImagePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setImagePath", "(Ljava/lang/String;)V", "GetSetImagePath_Ljava_lang_String_Handler")]
		public virtual unsafe void SetImagePath (string p0)
		{
			if (id_setImagePath_Ljava_lang_String_ == IntPtr.Zero)
				id_setImagePath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setImagePath", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImagePath_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImagePath", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_type;
#pragma warning disable 0169
		static Delegate GetTypeHandler ()
		{
			if (cb_type == null)
				cb_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Type);
			return cb_type;
		}

		static int n_Type (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.MM.Opensdk.Modelmsg.WXImageObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelmsg.WXImageObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type ();
		}
#pragma warning restore 0169

		static IntPtr id_type;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXImageObject']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()I", "GetTypeHandler")]
		public virtual unsafe int Type ()
		{
			if (id_type == IntPtr.Zero)
				id_type = JNIEnv.GetMethodID (class_ref, "type", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_type);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "type", "()I"));
			} finally {
			}
		}

		static Delegate cb_unserialize_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetUnserialize_Landroid_os_Bundle_Handler ()
		{
			if (cb_unserialize_Landroid_os_Bundle_ == null)
				cb_unserialize_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Unserialize_Landroid_os_Bundle_);
			return cb_unserialize_Landroid_os_Bundle_;
		}

		static void n_Unserialize_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.MM.Opensdk.Modelmsg.WXImageObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelmsg.WXImageObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Unserialize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unserialize_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXImageObject']/method[@name='unserialize' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("unserialize", "(Landroid/os/Bundle;)V", "GetUnserialize_Landroid_os_Bundle_Handler")]
		public virtual unsafe void Unserialize (global::Android.OS.Bundle p0)
		{
			if (id_unserialize_Landroid_os_Bundle_ == IntPtr.Zero)
				id_unserialize_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "unserialize", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unserialize_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unserialize", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

	}
}
