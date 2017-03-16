package md5f195cbef8d056370cecf337396b9f46b;


public class WXPayEntryActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		com.tencent.mm.opensdk.openapi.IWXAPIEventHandler
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onNewIntent:(Landroid/content/Intent;)V:GetOnNewIntent_Landroid_content_Intent_Handler\n" +
			"n_onReq:(Lcom/tencent/mm/opensdk/modelbase/BaseReq;)V:GetOnReq_Lcom_tencent_mm_opensdk_modelbase_BaseReq_Handler:Com.Tencent.MM.Opensdk.Openapi.IWXAPIEventHandlerInvoker, XamarinWeiXinSDKBindingDemo\n" +
			"n_onResp:(Lcom/tencent/mm/opensdk/modelbase/BaseResp;)V:GetOnResp_Lcom_tencent_mm_opensdk_modelbase_BaseResp_Handler:Com.Tencent.MM.Opensdk.Openapi.IWXAPIEventHandlerInvoker, XamarinWeiXinSDKBindingDemo\n" +
			"";
		mono.android.Runtime.register ("XamarinWeiXinDemo.WXPayEntryActivity, XamarinWeiXinDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", WXPayEntryActivity.class, __md_methods);
	}


	public WXPayEntryActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == WXPayEntryActivity.class)
			mono.android.TypeManager.Activate ("XamarinWeiXinDemo.WXPayEntryActivity, XamarinWeiXinDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onNewIntent (android.content.Intent p0)
	{
		n_onNewIntent (p0);
	}

	private native void n_onNewIntent (android.content.Intent p0);


	public void onReq (com.tencent.mm.opensdk.modelbase.BaseReq p0)
	{
		n_onReq (p0);
	}

	private native void n_onReq (com.tencent.mm.opensdk.modelbase.BaseReq p0);


	public void onResp (com.tencent.mm.opensdk.modelbase.BaseResp p0)
	{
		n_onResp (p0);
	}

	private native void n_onResp (com.tencent.mm.opensdk.modelbase.BaseResp p0);

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
