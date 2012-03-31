using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using Zxtlbs.Model;
using Zxtlbs.Business;
using IBatisNet.DataMapper;
using System.Text;

namespace Zxtlbs.Web.report
{
    /// <summary>
    /// 历史轨迹报表
    /// </summary>
    public class history : IHttpHandler, IRequiresSessionState
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
            DeviceHisTrack dht = new DeviceHisTrack();
            dht.PageStart = int.Parse(context.Request["iDisplayStart"]);
            dht.PageEnd = int.Parse(context.Request["iDisplayStart"]) + int.Parse(context.Request["iDisplayLength"]);
            dht.DEVICE_ID = context.Request["device_id"];
            dht.StartDate = DateTime.Parse(context.Request["d1"] + " 00:00:00");
            dht.EndDate = DateTime.Parse(context.Request["d2"] + " 23:59:59");
            int total = Mapper.Instance().QueryForObject<int>("GetTrackListTotalByDevice", dht);
            IList<DeviceHisTrack> list = Mapper.Instance().QueryForList<DeviceHisTrack>("GetTrackListByDevice", dht);
            StringBuilder data = new StringBuilder();
            foreach (DeviceHisTrack d in list)
            {
                data.AppendFormat("[\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\"],", d.DEVICE_ID, d.DEVICE_NAME,
                    d.LOGINTIME, d.STATUS, d.SPEED, d.DIRECTION, d.LICHENG, d.V_LON + "," + d.V_LAT, "点击查看详细位置");
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