using System;
using System.Collections.Generic;
using System.Web;

namespace Zxtlbs.Web
{
    /// <summary>
    /// 返回当前用户所属单位下的所有设备
    /// </summary>
    public class devicelist : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
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