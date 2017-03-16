using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='Build']"
	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/constants/Build", DoNotGenerateAcw=true)]
	public sealed partial class Build : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='Build']/field[@name='EMOJI_SUPPORTED_SDK_INT']"
		[Register ("EMOJI_SUPPORTED_SDK_INT")]
		public const int EmojiSupportedSdkInt = (int) 553844737;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='Build']/field[@name='FAVORITE_SUPPPORTED_SDK_INT']"
		[Register ("FAVORITE_SUPPPORTED_SDK_INT")]
		public const int FavoriteSuppportedSdkInt = (int) 570425345;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='Build']/field[@name='MESSAGE_ACTION_SUPPPORTED_SDK_INT']"
		[Register ("MESSAGE_ACTION_SUPPPORTED_SDK_INT")]
		public const int MessageActionSuppportedSdkInt = (int) 570490883;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='Build']/field[@name='MIN_SDK_INT']"
		[Register ("MIN_SDK_INT")]
		public const int MinSdkInt = (int) 553713665;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='Build']/field[@name='MUSIC_DATA_URL_SUPPORTED_SDK_INT']"
		[Register ("MUSIC_DATA_URL_SUPPORTED_SDK_INT")]
		public const int MusicDataUrlSupportedSdkInt = (int) 553910273;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='Build']/field[@name='OPENID_SUPPORTED_SDK_INT']"
		[Register ("OPENID_SUPPORTED_SDK_INT")]
		public const int OpenidSupportedSdkInt = (int) 570425345;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='Build']/field[@name='PAY_SUPPORTED_SDK_INT']"
		[Register ("PAY_SUPPORTED_SDK_INT")]
		public const int PaySupportedSdkInt = (int) 570425345;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='Build']/field[@name='SCAN_QRCODE_AUTH_SUPPORTED_SDK_INT']"
		[Register ("SCAN_QRCODE_AUTH_SUPPORTED_SDK_INT")]
		public const int ScanQrcodeAuthSupportedSdkInt = (int) 587268097;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='Build']/field[@name='SDK_INT']"
		[Register ("SDK_INT")]
		public const int SdkInt = (int) 603979778;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='Build']/field[@name='SDK_VERSION_NAME']"
		[Register ("SDK_VERSION_NAME")]
		public const string SdkVersionName = (string) "android 4.0.2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='Build']/field[@name='TIMELINE_SUPPORTED_SDK_INT']"
		[Register ("TIMELINE_SUPPORTED_SDK_INT")]
		public const int TimelineSupportedSdkInt = (int) 553779201;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/opensdk/constants/Build", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Build); }
		}

		internal Build (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getMajorVersion;
		public static unsafe int MajorVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='Build']/method[@name='getMajorVersion' and count(parameter)=0]"
			[Register ("getMajorVersion", "()I", "GetGetMajorVersionHandler")]
			get {
				if (id_getMajorVersion == IntPtr.Zero)
					id_getMajorVersion = JNIEnv.GetStaticMethodID (class_ref, "getMajorVersion", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getMajorVersion);
				} finally {
				}
			}
		}

		static IntPtr id_getMinorVersion;
		public static unsafe int MinorVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='Build']/method[@name='getMinorVersion' and count(parameter)=0]"
			[Register ("getMinorVersion", "()I", "GetGetMinorVersionHandler")]
			get {
				if (id_getMinorVersion == IntPtr.Zero)
					id_getMinorVersion = JNIEnv.GetStaticMethodID (class_ref, "getMinorVersion", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getMinorVersion);
				} finally {
				}
			}
		}

	}
}
