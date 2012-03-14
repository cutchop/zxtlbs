using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using IBatisNet.DataMapper;
using Zxtlbs.Model;

namespace Zxtlbs.Web
{
    /// <summary>
    /// 返回当前用户所属单位下的所有设备
    /// </summary>
    public class devicelist : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(Mapper.Instance().QueryForList<DeviceInfo>("GetDeviceListByGroup", 130).Count.ToString());
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