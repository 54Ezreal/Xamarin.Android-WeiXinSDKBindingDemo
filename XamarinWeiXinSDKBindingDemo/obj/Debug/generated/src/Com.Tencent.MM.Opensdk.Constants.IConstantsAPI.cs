using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.MM.Opensdk.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.AppSupportContentFlag']"
	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/constants/ConstantsAPI$AppSupportContentFlag", DoNotGenerateAcw=true)]
	public sealed partial class ConstantsAPIAppSupportContentFlag : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.AppSupportContentFlag']/field[@name='MMAPP_SUPPORT_AUDIO']"
		[Register ("MMAPP_SUPPORT_AUDIO")]
		public const long MmappSupportAudio = (long) 16L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.AppSupportContentFlag']/field[@name='MMAPP_SUPPORT_DOC']"
		[Register ("MMAPP_SUPPORT_DOC")]
		public const long MmappSupportDoc = (long) 64L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.AppSupportContentFlag']/field[@name='MMAPP_SUPPORT_DOCX']"
		[Register ("MMAPP_SUPPORT_DOCX")]
		public const long MmappSupportDocx = (long) 128L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.AppSupportContentFlag']/field[@name='MMAPP_SUPPORT_LOCATION']"
		[Register ("MMAPP_SUPPORT_LOCATION")]
		public const long MmappSupportLocation = (long) 4L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.AppSupportContentFlag']/field[@name='MMAPP_SUPPORT_PDF']"
		[Register ("MMAPP_SUPPORT_PDF")]
		public const long MmappSupportPdf = (long) 4096L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.AppSupportContentFlag']/field[@name='MMAPP_SUPPORT_PICTURE']"
		[Register ("MMAPP_SUPPORT_PICTURE")]
		public const long MmappSupportPicture = (long) 2L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.AppSupportContentFlag']/field[@name='MMAPP_SUPPORT_PPT']"
		[Register ("MMAPP_SUPPORT_PPT")]
		public const long MmappSupportPpt = (long) 256L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.AppSupportContentFlag']/field[@name='MMAPP_SUPPORT_PPTX']"
		[Register ("MMAPP_SUPPORT_PPTX")]
		public const long MmappSupportPptx = (long) 512L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.AppSupportContentFlag']/field[@name='MMAPP_SUPPORT_TEXT']"
		[Register ("MMAPP_SUPPORT_TEXT")]
		public const long MmappSupportText = (long) 1L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.AppSupportContentFlag']/field[@name='MMAPP_SUPPORT_VIDEO']"
		[Register ("MMAPP_SUPPORT_VIDEO")]
		public const long MmappSupportVideo = (long) 8L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.AppSupportContentFlag']/field[@name='MMAPP_SUPPORT_WEBPAGE']"
		[Register ("MMAPP_SUPPORT_WEBPAGE")]
		public const long MmappSupportWebpage = (long) 32L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.AppSupportContentFlag']/field[@name='MMAPP_SUPPORT_XLS']"
		[Register ("MMAPP_SUPPORT_XLS")]
		public const long MmappSupportXls = (long) 1024L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.AppSupportContentFlag']/field[@name='MMAPP_SUPPORT_XLSX']"
		[Register ("MMAPP_SUPPORT_XLSX")]
		public const long MmappSupportXlsx = (long) 2048L;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/opensdk/constants/ConstantsAPI$AppSupportContentFlag", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConstantsAPIAppSupportContentFlag); }
		}

		internal ConstantsAPIAppSupportContentFlag (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.AppSupportContentFlag']/constructor[@name='ConstantsAPI.AppSupportContentFlag' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConstantsAPIAppSupportContentFlag ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConstantsAPIAppSupportContentFlag)) {
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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.Token']"
	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/constants/ConstantsAPI$Token", DoNotGenerateAcw=true)]
	public sealed partial class ConstantsAPIToken : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.Token']/field[@name='WX_LAUNCH_PARAM_KEY']"
		[Register ("WX_LAUNCH_PARAM_KEY")]
		public const string WxLaunchParamKey = (string) "launchParam";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.Token']/field[@name='WX_TOKEN_KEY']"
		[Register ("WX_TOKEN_KEY")]
		public const string WxTokenKey = (string) "wx_token_key";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.Token']/field[@name='WX_TOKEN_PLATFORMID_KEY']"
		[Register ("WX_TOKEN_PLATFORMID_KEY")]
		public const string WxTokenPlatformidKey = (string) "platformId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.Token']/field[@name='WX_TOKEN_PLATFORMID_VALUE']"
		[Register ("WX_TOKEN_PLATFORMID_VALUE")]
		public const string WxTokenPlatformidValue = (string) "wechat";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.Token']/field[@name='WX_TOKEN_VALUE_MSG']"
		[Register ("WX_TOKEN_VALUE_MSG")]
		public const string WxTokenValueMsg = (string) "com.tencent.mm.openapi.token";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/opensdk/constants/ConstantsAPI$Token", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConstantsAPIToken); }
		}

		internal ConstantsAPIToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.Token']/constructor[@name='ConstantsAPI.Token' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConstantsAPIToken ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConstantsAPIToken)) {
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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.WXApp']"
	[global::Android.Runtime.Register ("com/tencent/mm/opensdk/constants/ConstantsAPI$WXApp", DoNotGenerateAcw=true)]
	public sealed partial class ConstantsAPIWXApp : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.WXApp']/field[@name='WXAPP_BROADCAST_PERMISSION']"
		[Register ("WXAPP_BROADCAST_PERMISSION")]
		public const string WxappBroadcastPermission = (string) "com.tencent.mm.permission.MM_MESSAGE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.WXApp']/field[@name='WXAPP_MSG_ENTRY_CLASSNAME']"
		[Register ("WXAPP_MSG_ENTRY_CLASSNAME")]
		public const string WxappMsgEntryClassname = (string) "com.tencent.mm.plugin.base.stub.WXEntryActivity";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.WXApp']/field[@name='WXAPP_PACKAGE_NAME']"
		[Register ("WXAPP_PACKAGE_NAME")]
		public const string WxappPackageName = (string) "com.tencent.mm";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mm/opensdk/constants/ConstantsAPI$WXApp", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConstantsAPIWXApp); }
		}

		internal ConstantsAPIWXApp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/class[@name='ConstantsAPI.WXApp']/constructor[@name='ConstantsAPI.WXApp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConstantsAPIWXApp ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConstantsAPIWXApp)) {
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

	[Register ("com/tencent/mm/opensdk/constants/ConstantsAPI", DoNotGenerateAcw=true)]
	public abstract class ConstantsAPI : Java.Lang.Object {

		internal ConstantsAPI ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='ACTION_HANDLE_APP_REGISTER']"
		[Register ("ACTION_HANDLE_APP_REGISTER")]
		public const string ActionHandleAppRegister = (string) "com.tencent.mm.plugin.openapi.Intent.ACTION_HANDLE_APP_REGISTER";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='ACTION_HANDLE_APP_UNREGISTER']"
		[Register ("ACTION_HANDLE_APP_UNREGISTER")]
		public const string ActionHandleAppUnregister = (string) "com.tencent.mm.plugin.openapi.Intent.ACTION_HANDLE_APP_UNREGISTER";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='ACTION_REFRESH_WXAPP']"
		[Register ("ACTION_REFRESH_WXAPP")]
		public const string ActionRefreshWxapp = (string) "com.tencent.mm.plugin.openapi.Intent.ACTION_REFRESH_WXAPP";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='APP_PACKAGE']"
		[Register ("APP_PACKAGE")]
		public const string AppPackage = (string) "_mmessage_appPackage";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='APP_SUPORT_CONTENT_TYPE']"
		[Register ("APP_SUPORT_CONTENT_TYPE")]
		public const string AppSuportContentType = (string) "_mmessage_support_content_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='CHECK_SUM']"
		[Register ("CHECK_SUM")]
		public const string CheckSum = (string) "_mmessage_checksum";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_ADD_CARD_TO_EX_CARD_PACKAGE']"
		[Register ("COMMAND_ADD_CARD_TO_EX_CARD_PACKAGE")]
		public const int CommandAddCardToExCardPackage = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_CHOOSE_CARD_FROM_EX_CARD_PACKAGE']"
		[Register ("COMMAND_CHOOSE_CARD_FROM_EX_CARD_PACKAGE")]
		public const int CommandChooseCardFromExCardPackage = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_CREATE_CHATROOM']"
		[Register ("COMMAND_CREATE_CHATROOM")]
		public const int CommandCreateChatroom = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_GETMESSAGE_FROM_WX']"
		[Register ("COMMAND_GETMESSAGE_FROM_WX")]
		public const int CommandGetmessageFromWx = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_JOIN_CHATROOM']"
		[Register ("COMMAND_JOIN_CHATROOM")]
		public const int CommandJoinChatroom = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_JUMP_BIZ_TEMPSESSION']"
		[Register ("COMMAND_JUMP_BIZ_TEMPSESSION")]
		public const int CommandJumpBizTempsession = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_JUMP_BIZ_WEBVIEW']"
		[Register ("COMMAND_JUMP_BIZ_WEBVIEW")]
		public const int CommandJumpBizWebview = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_JUMP_TO_BIZ_PROFILE']"
		[Register ("COMMAND_JUMP_TO_BIZ_PROFILE")]
		public const int CommandJumpToBizProfile = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_LAUNCH_BY_WX']"
		[Register ("COMMAND_LAUNCH_BY_WX")]
		public const int CommandLaunchByWx = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_OPEN_BUSI_LUCKY_MONEY']"
		[Register ("COMMAND_OPEN_BUSI_LUCKY_MONEY")]
		public const int CommandOpenBusiLuckyMoney = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_OPEN_RANK_LIST']"
		[Register ("COMMAND_OPEN_RANK_LIST")]
		public const int CommandOpenRankList = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_OPEN_WEBVIEW']"
		[Register ("COMMAND_OPEN_WEBVIEW")]
		public const int CommandOpenWebview = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_PAY_BY_WX']"
		[Register ("COMMAND_PAY_BY_WX")]
		public const int CommandPayByWx = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_SENDAUTH']"
		[Register ("COMMAND_SENDAUTH")]
		public const int CommandSendauth = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_SENDMESSAGE_TO_WX']"
		[Register ("COMMAND_SENDMESSAGE_TO_WX")]
		public const int CommandSendmessageToWx = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_SHOWMESSAGE_FROM_WX']"
		[Register ("COMMAND_SHOWMESSAGE_FROM_WX")]
		public const int CommandShowmessageFromWx = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='COMMAND_UNKNOWN']"
		[Register ("COMMAND_UNKNOWN")]
		public const int CommandUnknown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='CONTENT']"
		[Register ("CONTENT")]
		public const string Content = (string) "_mmessage_content";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mm.opensdk.constants']/interface[@name='ConstantsAPI']/field[@name='SDK_VERSION']"
		[Register ("SDK_VERSION")]
		public const string SdkVersion = (string) "_mmessage_sdkVersion";
	}

	[Register ("com/tencent/mm/opensdk/constants/ConstantsAPI", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'ConstantsAPI' type. This type will be removed in a future release.")]
	public abstract class ConstantsAPIConsts : ConstantsAPI {

		private ConstantsAPIConsts ()
		{
		}
	}

}
