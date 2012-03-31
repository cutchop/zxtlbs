using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using System.Text;
using Zxtlbs.Model;
using IBatisNet.DataMapper;

namespace Zxtlbs.Web
{
    /// <summary>
    /// 输出当前用户下的分组列表HTML
    /// </summary>
    public class grouplisthtml : IHttpHandler, IRequiresSessionState
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
            IList<AOrg> listOrg = OrgChildren(user.ORGID);

            StringBuilder html = new StringBuilder();
            html.Append("<div class=\"z-tree\"><span class=\"z-tree-bg\">&nbsp;</span>");
            html.Append("<ul class=\"z-tree-root\">");
            html.AppendFormat("<li class=\"z-tree-li z-tree-leaf\"><a href=\"#\" id=\"zxt-g-{0}\">{1}</a></li>", listOrg[0].ORGID, listOrg[0].ORGNAME);
            if (listOrg.Count > 1)
            {
                html.Append("<li class=\"z-tree-li\">");
                html.AppendFormat("<h3><a href=\"#\" class=\"z-tree-active\">{0}</a></h3>", listOrg[0].ORGNAME);
                html.Append("<ul style=\"display:block;\" class=\"z-tree-ul\">");
                for (int i = 1; i < listOrg.Count; i++)
                {
                    html.AppendFormat("<li class=\"z-tree-li z-tree-leaf\"><a href=\"#\" id=\"zxt-g-{0}\">{1}</a></li>", listOrg[i].ORGID, listOrg[i].ORGNAME);
                    if (HasChildOrg(listOrg, listOrg[i].ORGID))
                    {
                        html.Append("<li class=\"z-tree-li\">");
                        html.AppendFormat("<h3><a href=\"#\" class=\"z-tree-active\">{0}</a></h3>", listOrg[i].ORGNAME);
                        html.Append("<ul style=\"display:block;\" class=\"z-tree-ul\">");
                        for (int j = i + 1; j < listOrg.Count; j++)
                        {
                            if (listOrg[j].PARENTID.Trim() == listOrg[i].ORGID.Trim())
                            {
                                html.AppendFormat("<li class=\"z-tree-li z-tree-leaf\"><a href=\"#\" id=\"zxt-g-{0}\">{1}</a></li>", listOrg[j].ORGID, listOrg[j].ORGNAME);
                                if (HasChildOrg(listOrg, listOrg[j].ORGID))
                                {
                                    html.Append("<li class=\"z-tree-li\">");
                                    html.AppendFormat("<h3><a href=\"#\" class=\"z-tree-active\">{0}</a></h3>", listOrg[j].ORGNAME);
                                    html.Append("<ul style=\"display:block;\" class=\"z-tree-ul\">");
                                    for (int k = j + 1; k < listOrg.Count; k++)
                                    {
                                        if (listOrg[k].PARENTID.Trim() == listOrg[j].ORGID.Trim())
                                        {
                                            html.AppendFormat("<li class=\"z-tree-li z-tree-leaf\"><a href=\"#\" id=\"zxt-g-{0}\">{1}</a></li>", listOrg[k].ORGID, listOrg[k].ORGNAME);
                                            if (HasChildOrg(listOrg, listOrg[k].ORGID))
                                            {
                                                html.Append("<li class=\"z-tree-li\">");
                                                html.AppendFormat("<h3><a href=\"#\" class=\"z-tree-active\">{0}</a></h3>", listOrg[k].ORGNAME);
                                                html.Append("<ul style=\"display:block;\" class=\"z-tree-ul\">");
                                                for (int l = k + 1; l < listOrg.Count; l++)
                                                {
                                                    if (listOrg[l].PARENTID.Trim() == listOrg[k].ORGID.Trim())
                                                    {
                                                        html.AppendFormat("<li class=\"z-tree-li z-tree-leaf\"><a href=\"#\" id=\"zxt-g-{0}\">{1}</a></li>", listOrg[l].ORGID, listOrg[l].ORGNAME);
                                                        listOrg.RemoveAt(l);
                                                        l--;
                                                    }
                                                }
                                                html.Append("</ul>");
                                                html.Append("</li>");
                                            }
                                            listOrg.RemoveAt(k);
                                            k--;
                                        }
                                    }
                                    html.Append("</ul>");
                                    html.Append("</li>");
                                }
                                listOrg.RemoveAt(j);
                                j--;
                            }
                        }
                        html.Append("</ul>");
                        html.Append("</li>");
                    }
                    listOrg.RemoveAt(i);
                    i--;
                }
                html.Append("</ul>");
                html.Append("</li>");
            }
            html.Append("</ul>");
            html.Append("</div>");
            context.Response.ContentType = "text/html";
            context.Response.Write(html.ToString());
        }

        private IList<AOrg> OrgChildren(string orgid)
        {
            return Mapper.Instance().QueryForList<AOrg>("GetOrgListLikeID", orgid);
        }

        private bool HasChildOrg(IList<AOrg> list, string orgid)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].PARENTID.Trim() == orgid.Trim())
                {
                    return true;
                }
            }
            return false;
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