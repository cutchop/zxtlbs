using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using Zxtlbs.Model;
using IBatisNet.DataMapper;

namespace Zxtlbs.Web.report
{
    /// <summary>
    /// 历史轨迹报表
    /// </summary>
    public class history : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            AUser user = (AUser)context.Session["AUser"];
            IList<DeviceHisTrack> list = Mapper.Instance().QueryForList<DeviceHisTrack>("GetTrackListByDevice", "13000228350");
            context.Response.ContentType = "text/plain";
            context.Response.Write(list[0].DEVICE_NAME);
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