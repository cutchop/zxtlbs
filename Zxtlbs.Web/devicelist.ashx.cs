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
    /// 返回当前用户所属单位下的所有设备
    /// </summary>
    public class devicelist : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            //string orgid = ((AUser)context.Session["User"]).ORGID;
            string orgid = "001";
            context.Response.ContentType = "text/plain";
            switch (context.Request["action"])
            {
                case "o":
                    context.Response.Write(OrgData(orgid));
                    break;
                case "d":
                    context.Response.Write(DeviceData(orgid));
                    break;
            }
        }

        private string OrgData(string orgid)
        {
            StringBuilder data = new StringBuilder();
            IList<AOrg> list = OrgChildren(orgid);
            for (int i = 0; i < list.Count; i++)
            {
                data.AppendFormat("[\"{0}\",\"{1}\"],", list[i].ORGID, list[i].ORGNAME);
            }
            data.Remove(data.Length - 1, 1);
            return "[" + data + "]";
        }

        private string DeviceData(string orgid)
        {
            StringBuilder data = new StringBuilder();
            IList<DeviceInfo> list = OrgDevices(orgid);
            for (int i = 0; i < list.Count; i++)
            {
                data.AppendFormat("[\"{0}\",\"{1}\"],", list[i].DEVICE_ID, list[i].DEVICE_NAME);
            }
            data.Remove(data.Length - 1, 1);
            return "[" + data + "]";
        }

        private IList<AOrg> OrgChildren(string orgid)
        {
            return Mapper.Instance().QueryForList<AOrg>("GetOrgListLikeID", orgid + "%");      
        }

        private IList<DeviceInfo> OrgDevices(string orgid)
        {
            return Mapper.Instance().QueryForList<DeviceInfo>("GetDeviceListByGroups", orgid + "%");
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