using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using IBatisNet.DataMapper;
using Zxtlbs.Model;
using System.Text;

namespace Zxtlbs.Web.map
{
    /// <summary>
    /// 历史轨迹JSON数据
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
            dht.DEVICE_ID = context.Request["device_id"];
            dht.StartDate = DateTime.Parse(context.Request["d1"] + " 00:00:00");
            dht.EndDate = DateTime.Parse(context.Request["d2"] + " 23:59:59");
            IList<DeviceHisTrack> list = Mapper.Instance().QueryForList<DeviceHisTrack>("GetAllTrackListByDevice", dht);
            StringBuilder data = new StringBuilder();
            foreach (DeviceHisTrack d in list)
            {
                data.AppendFormat("[\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\"],", d.LOGINTIME, d.STATUS, d.SPEED, d.DIRECTION, d.LICHENG, d.V_LON ,d.V_LAT);
            }
            if (data.Length > 0)
            {
                data.Remove(data.Length - 1, 1);
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