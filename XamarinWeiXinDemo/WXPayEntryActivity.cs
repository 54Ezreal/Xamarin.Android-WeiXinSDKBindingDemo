using System;
using Android.App;
using Android.Content;
using Android.OS;
using Com.Tencent.MM.Opensdk.Modelbase;
using Com.Tencent.MM.Opensdk.Openapi;
using Android.Util;
using Android.Widget;
using Com.Tencent.MM.Opensdk.Constants;

namespace XamarinWeiXinDemo
{
    /// <summary>
    /// 微信支付回调Activity
    /// </summary>
    public class WXPayEntryActivity : Activity, IWXAPIEventHandler
    {

        private IWXAPI api;

        public void onCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //SetContentView(R.layout.pay_result);
            //布局是可以自定义
            api = WXAPIFactory.CreateWXAPI(this, "App_ID");
            api.HandleIntent(Intent, this);
        }

        protected override void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);
            Intent = intent;
            api.HandleIntent(intent, this);
        }

        public void OnReq(BaseReq p0)
        {

        }

        public void OnResp(BaseResp p0)
        {
            Log.Debug("微信支付回调", "onPayFinish, errCode = " + p0.errCode);
            
            if (p0.Type == ConstantsAPI.CommandPayByWx)
            {
                //0   成功 展示成功页面
                //-1  错误 可能的原因：签名错误、未注册APPID、项目设置APPID不正确、注册的APPID与设置的不匹配、其他异常等。
                //-2  用户取消 无需处理。发生场景：用户不支付了，点击取消，返回APP。
                if (p0.errCode == 0)
                {
                    //支付成功逻辑
                    Toast.MakeText(this, "支付成功", ToastLength.Long).Show();
                }
                else
                {
                    //支付失败
                    Toast.MakeText(this, "支付失败", ToastLength.Long).Show();
                }
                Finish();
            }

        }


    }



}