using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using Zxtlbs.Model;
using IBatisNet.DataMapper;
using System.Text;
using Zxtlbs.Business;

namespace Zxtlbs.Web.setting
{
    /// <summary>
    /// 分组管理
    /// </summary>
    public class group : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            AUser user = (AUser)context.Session["AUser"];
            context.Response.ContentType = "text/plain";
            string action = context.Request["action"];
            if (string.IsNullOrEmpty(action) || action == "q")
            {//查询
                AOrg org = new AOrg();
                org.PageStart = int.Parse(context.Request["iDisplayStart"]);
                org.PageEnd = int.Parse(context.Request["iDisplayStart"]) + int.Parse(context.Request["iDisplayLength"]);
                org.ORGNAME = context.Request["name"];
                org.ORGID = user.ORGID;
                int total = Mapper.Instance().QueryForObject<int>("GetOrgTotal", org);
                IList<AOrg> list = Mapper.Instance().QueryForList<AOrg>("GetOrgListPage", org);
                StringBuilder data = new StringBuilder();
                for (int i = 0; i < list.Count; i++)
                {
                    AOrg o = list[i];
                    data.AppendFormat("[\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\"],", i, o.ORGNAME, o.PARENTNAME, o.REMARK, o.ORGID, o.PARENTID);
                }
                if (data.Length > 0)
                {
                    data.Remove(data.Length - 1, 1);
                }
                context.Response.Write(Common.DatatablesJson(context.Request["sEcho"], total, data.ToString()));
            }
            else if (action == "a")
            {//新增
                AOrg org = new AOrg();
                org.PARENTID = context.Request["parentid"];
                org.ORGNAME = context.Request["orgname"];
                org.REMARK = context.Request["remark"];
                try
                {
                    Mapper.Instance().Insert("InsertAOrg", org);
                    context.Response.Write("success");
                }
                catch (Exception ex)
                {
                    context.Response.Write("操作出现异常,请重试<br />" + ex.Message);
                }
            }
            else if (action == "e")
            {//修改
                AOrg org = new AOrg();
                org.ORGID = context.Request["orgid"];
                org.ORGNAME = context.Request["orgname"];
                org.REMARK = context.Request["remark"];
                try
                {
                    Mapper.Instance().Update("UpdateAOrg", org);
                    context.Response.Write("success");
                }
                catch (Exception ex)
                {
                    context.Response.Write("操作出现异常,请重试<br />" + ex.Message);
                }
            }
            else if (action == "d")
            {//删除
                string orgid = context.Request["orgid"];
                try
                {
                    Mapper.Instance().Delete("DeleteAOrg", orgid);
                    context.Response.Write("success");
                }
                catch (Exception ex)
                {
                    context.Response.Write("操作出现异常,请重试<br />" + ex.Message);
                }
            }
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