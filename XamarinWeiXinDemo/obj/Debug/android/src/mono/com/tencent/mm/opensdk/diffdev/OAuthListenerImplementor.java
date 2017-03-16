package mono.com.tencent.mm.opensdk.diffdev;


public class OAuthListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.tencent.mm.opensdk.diffdev.OAuthListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAuthFinish:(Lcom/tencent/mm/opensdk/diffdev/OAuthErrCode;Ljava/lang/String;)V:GetOnAuthFinish_Lcom_tencent_mm_opensdk_diffdev_OAuthErrCode_Ljava_lang_String_Handler:Com.Tencent.MM.Opensdk.Diffdev.IOAuthListenerInvoker, XamarinWeiXinSDKBindingDemo\n" +
			"n_onAuthGotQrcode:(Ljava/lang/String;[B)V:GetOnAuthGotQrcode_Ljava_lang_String_arrayBHandler:Com.Tencent.MM.Opensdk.Diffdev.IOAuthListenerInvoker, XamarinWeiXinSDKBindingDemo\n" +
			"n_onQrcodeScanned:()V:GetOnQrcodeScannedHandler:Com.Tencent.MM.Opensdk.Diffdev.IOAuthListenerInvoker, XamarinWeiXinSDKBindingDemo\n" +
			"";
		mono.android.Runtime.register ("Com.Tencent.MM.Opensdk.Diffdev.IOAuthListenerImplementor, XamarinWeiXinSDKBindingDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OAuthListenerImplementor.class, __md_methods);
	}


	public OAuthListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OAuthListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Tencent.MM.Opensdk.Diffdev.IOAuthListenerImplementor, XamarinWeiXinSDKBindingDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAuthFinish (com.tencent.mm.opensdk.diffdev.OAuthErrCode p0, java.lang.String p1)
	{
		n_onAuthFinish (p0, p1);
	}

	private native void n_onAuthFinish (com.tencent.mm.opensdk.diffdev.OAuthErrCode p0, java.lang.String p1);


	public void onAuthGotQrcode (java.lang.String p0, byte[] p1)
	{
		n_onAuthGotQrcode (p0, p1);
	}

	private native void n_onAuthGotQrcode (java.lang.String p0, byte[] p1);


	public void onQrcodeScanned ()
	{
		n_onQrcodeScanned ();
	}

	private native void n_onQrcodeScanned ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
