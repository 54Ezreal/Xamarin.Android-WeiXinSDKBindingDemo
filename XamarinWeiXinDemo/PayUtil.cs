using Android.Content;
using Com.Tencent.MM.Opensdk.Openapi;
using Com.Tencent.MM.Opensdk.Modelpay;
namespace XamarinWeiXinDemo
{
    public class PayUtil
    {
        /// <summary>
        /// 调起支付
        /// </summary>
        /// <param name="context"></param>
        /// <param name="AppId">微信开放平台审核通过的应用APPID</param>
        /// <param name="partnerId">微信支付分配的商户号</param>
        /// <param name="prepayId">调用接口提交的终端设备号</param>
        /// <param name="nonceStr">随机字符串，不长于32位</param>
        /// <param name="timeStamp">时间戳</param>
        /// <param name="sign">签名</param>
        /// <returns></returns>
        public bool Pay(Context context,string AppId,string partnerId,string prepayId,string nonceStr,string timeStamp,string sign)
        {
            var api = WXAPIFactory.CreateWXAPI(context, AppId);
            api.RegisterApp("APP_ID");

            PayReq payRequest = new PayReq();

            payRequest.AppId = AppId;

            payRequest.PartnerId = partnerId;

            payRequest.PrepayId = prepayId;

            payRequest.PackageValue = "Sign=WXPay";

            payRequest.NonceStr = nonceStr;

            payRequest.TimeStamp = timeStamp;

            payRequest.Sign = sign;

            return api.SendReq(payRequest);

        }
    }
}