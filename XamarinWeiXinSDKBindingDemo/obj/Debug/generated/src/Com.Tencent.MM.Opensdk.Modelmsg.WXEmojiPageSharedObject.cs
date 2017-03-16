using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Modelmsg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXEmojiPageSharedObject']"
	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/modelmsg/WXEmojiPageSharedObject", DoNotGenerateAcw=true)]
	public partial class WXEmojiPageSharedObject : global::Java.Lang.Object, global::Com.Tencent.MM.Opensdk.Modelmsg.WXMediaMessage.IMediaObject {


		static IntPtr desc_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXEmojiPageSharedObject']/field[@name='desc']"
		[Register ("desc")]
		public string Desc {
			get {
				if (desc_jfieldId == IntPtr.Zero)
					desc_jfieldId = JNIEnv.GetFieldID (class_ref, "desc", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, desc_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (desc_jfieldId == IntPtr.Zero)
					desc_jfieldId = JNIEnv.GetFieldID (class_ref, "desc", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, desc_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr iconUrl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXEmojiPageSharedObject']/field[@name='iconUrl']"
		[Register ("iconUrl")]
		public string IconUrl {
			get {
				if (iconUrl_jfieldId == IntPtr.Zero)
					iconUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "iconUrl", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, iconUrl_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (iconUrl_jfieldId == IntPtr.Zero)
					iconUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "iconUrl", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, iconUrl_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr pageType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXEmojiPageSharedObject']/field[@name='pageType']"
		[Register ("pageType")]
		public int PageType {
			get {
				if (pageType_jfieldId == IntPtr.Zero)
					pageType_jfieldId = JNIEnv.GetFieldID (class_ref, "pageType", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, pageType_jfieldId);
			}
			set {
				if (pageType_jfieldId == IntPtr.Zero)
					pageType_jfieldId = JNIEnv.GetFieldID (class_ref, "pageType", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pageType_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr secondUrl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXEmojiPageSharedObject']/field[@name='secondUrl']"
		[Register ("secondUrl")]
		public string SecondUrl {
			get {
				if (secondUrl_jfieldId == IntPtr.Zero)
					secondUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "secondUrl", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, secondUrl_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (secondUrl_jfieldId == IntPtr.Zero)
					secondUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "secondUrl", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, secondUrl_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr tid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXEmojiPageSharedObject']/field[@name='tid']"
		[Register ("tid")]
		public int Tid {
			get {
				if (tid_jfieldId == IntPtr.Zero)
					tid_jfieldId = JNIEnv.GetFieldID (class_ref, "tid", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, tid_jfieldId);
			}
			set {
				if (tid_jfieldId == IntPtr.Zero)
					tid_jfieldId = JNIEnv.GetFieldID (class_ref, "tid", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tid_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr title_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXEmojiPageSharedObject']/field[@name='title']"
		[Register ("title")]
		public string Title {
			get {
				if (title_jfieldId == IntPtr.Zero)
					title_jfieldId = JNIEnv.GetFieldID (class_ref, "title", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, title_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (title_jfieldId == IntPtr.Zero)
					title_jfieldId = JNIEnv.GetFieldID (class_ref, "title", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, title_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr url_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXEmojiPageSharedObject']/field[@name='url']"
		[Register ("url")]
		public string Url {
			get {
				if (url_jfieldId == IntPtr.Zero)
					url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, url_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (url_jfieldId == IntPtr.Zero)
					url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, url_jfieldId, native_value);
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
				return JNIEnv.FindClass ("com/tencent/mm/opensdk/modelmsg/WXEmojiPageSharedObject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WXEmojiPageSharedObject); }
		}

		protected WXEmojiPageSharedObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXEmojiPageSharedObject']/constructor[@name='WXEmojiPageSharedObject' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WXEmojiPageSharedObject ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (WXEmojiPageSharedObject)) {
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

		static IntPtr id_ctor_IILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXEmojiPageSharedObject']/constructor[@name='WXEmojiPageSharedObject' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='int'] and parameter[8][@type='java.lang.String']]"
		[Register (".ctor", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", "")]
		public unsafe WXEmojiPageSharedObject (int p0, int p1, string p2, string p3, string p4, string p5, int p6, string p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (native_p7);
				if (((object) this).GetType () != typeof (WXEmojiPageSharedObject)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_IILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_IILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p7);
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
			global::Com.Tencent.MM.Opensdk.Modelmsg.WXEmojiPageSharedObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelmsg.WXEmojiPageSharedObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckArgs ();
		}
#pragma warning restore 0169

		static IntPtr id_checkArgs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXEmojiPageSharedObject']/method[@name='checkArgs' and count(parameter)=0]"
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
			global::Com.Tencent.MM.Opensdk.Modelmsg.WXEmojiPageSharedObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelmsg.WXEmojiPageSharedObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Serialize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_serialize_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXEmojiPageSharedObject']/method[@name='serialize' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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
			global::Com.Tencent.MM.Opensdk.Modelmsg.WXEmojiPageSharedObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelmsg.WXEmojiPageSharedObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type ();
		}
#pragma warning restore 0169

		static IntPtr id_type;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXEmojiPageSharedObject']/method[@name='type' and count(parameter)=0]"
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
			global::Com.Tencent.MM.Opensdk.Modelmsg.WXEmojiPageSharedObject __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.MM.Opensdk.Modelmsg.WXEmojiPageSharedObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Unserialize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unserialize_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.modelmsg']/class[@name='WXEmojiPageSharedObject']/method[@name='unserialize' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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
