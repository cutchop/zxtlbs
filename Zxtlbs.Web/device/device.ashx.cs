using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using Zxtlbs.Model;
using IBatisNet.DataMapper;
using System.Text;
using Zxtlbs.Business;

namespace Zxtlbs.Web.device
{
    /// <summary>
    /// 设备管理列表
    /// </summary>
    public class device : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            AUser user = (AUser)context.Session["AUser"];
            DeviceInfo di = new DeviceInfo();
            di.PageStart = int.Parse(context.Request["iDisplayStart"]);
            di.PageEnd = int.Parse(context.Request["iDisplayStart"]) + int.Parse(context.Request["iDisplayLength"]);
            di.DEVICE_NAME = context.Request["name"];
            di.BELONG_GROUPID = context.Request["groupid"];
            if (string.IsNullOrEmpty(di.BELONG_GROUPID))
            {
                di.BELONG_GROUPID = user.ORGID;
            }
            int total = Mapper.Instance().QueryForObject<int>("GetDeviceTotalByGroups", di);
            IList<DeviceInfo> list = Mapper.Instance().QueryForList<DeviceInfo>("GetDeviceListPage", di);
            StringBuilder data = new StringBuilder();
            foreach (DeviceInfo d in list)
            {
                data.AppendFormat("[\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\"],", d.DEVICE_ID, d.DEVICE_NAME,
                    d.DEVICE_SIM, d.DEVICE_TYPE, d.COM_MODE, d.BELONG_GROUPNAME, d.LINKPHONE, d.INSTALL_DATE, d.LOGINTIME);
            }
            if (data.Length > 0)
            {
                data.Remove(data.Length - 1, 1);
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(Common.DatatablesJson(context.Request["sEcho"], total, data.ToString()));
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