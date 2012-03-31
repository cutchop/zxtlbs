using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using IBatisNet.DataMapper;
using Zxtlbs.Model;
using System.Text;

namespace Zxtlbs.Web
{
    /// <summary>
    /// 获取设备状态
    /// </summary>
    public class devicestatus : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            AUser user = null;
            if (context.Session["AUser"] == null)
            {
                user = new AUser();
                user.USERID = context.Request.Cookies["userid"].Value;
                user = Mapper.Instance().QueryForObject<AUser>("GetUserById", user.USERID);
                context.Session["AUser"] = user;
            }
            else
            {
                user = (AUser)context.Session["AUser"];
            }
            StringBuilder data = new StringBuilder();
            if (!string.IsNullOrEmpty(context.Request["device_id"]))
            {
                DeviceState ds = new DeviceState();
                ds.DEVICE_ID = context.Request["device_id"];
                ds.DEVICE_ID = ds.DEVICE_ID.Replace(",", "','");
                IList<DeviceState> list = Mapper.Instance().QueryForList<DeviceState>("GetStatusByDeviceIDs", ds);
                foreach (DeviceState d in list)
                {
                    data.AppendFormat("[\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\"],", d.DEVICE_ID, d.LOGINTIME, d.CUR_STATUS, d.SPEED, d.DIRECTION, d.LICHENG, d.LON, d.LAT, d.DEVICE_SIM);
                }
                if (data.Length > 0)
                {
                    data.Remove(data.Length - 1, 1);
                }
            }
            else
            {
                DeviceInfo di = new DeviceInfo();
                if (!string.IsNullOrEmpty(context.Request["group_id"]))
                {
                    di.BELONG_GROUPID = context.Request["group_id"];
                }
                else
                {
                    di.BELONG_GROUPID = user.ORGID;
                }
                IList<DeviceState> list = Mapper.Instance().QueryForList<DeviceState>("GetStatusByGroupID", di);
                foreach (DeviceState d in list)
                {
                    data.AppendFormat("[\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\"],", d.DEVICE_ID, d.LOGINTIME, d.CUR_STATUS, d.SPEED, d.DIRECTION, d.LICHENG, d.LON, d.LAT, d.DEVICE_SIM);
                }
                if (data.Length > 0)
                {
                    data.Remove(data.Length - 1, 1);
                }
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write("[" + data.ToString() + "]");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}