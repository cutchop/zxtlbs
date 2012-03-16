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
    /// 输出当前用户下的设备列表HTML
    /// </summary>
    public class mapleft : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            //string orgid = ((AUser)context.Session["User"]).ORGID;
            string orgid = "001";

            IList<AOrg> listOrg = OrgChildren(orgid);
            IList<DeviceInfo> listDevice = OrgDevices(orgid);

            StringBuilder html = new StringBuilder();
            html.Append("<div class=\"z-tree\"><span class=\"z-tree-bg\">&nbsp;</span>");
            html.Append("<ul class=\"z-tree-root\">");
            html.Append("<li class=\"z-tree-li\">");
            html.AppendFormat("<h3><a href=\"#\" class=\"z-tree-active\">{0}</a></h3>", listOrg[0].ORGNAME);
            html.Append("<ul style=\"display:block;\" class=\"z-tree-ul\">");
            for (int i = 1; i < listOrg.Count; i++)
            {
                html.Append("<li class=\"z-tree-li\">");
                html.AppendFormat("<h3><a href=\"#\" class=\"z-tree-active\">{0}</a></h3>", listOrg[i].ORGNAME);
                html.Append("<ul style=\"display:block;\" class=\"z-tree-ul\">");
                for (int j = i + 1; j < listOrg.Count; j++)
                {
                    if (listOrg[j].PARENTID.Trim() == listOrg[i].ORGID.Trim())
                    {
                        html.Append("<li class=\"z-tree-li\">");
                        html.AppendFormat("<h3><a href=\"#\" class=\"z-tree-active\">{0}</a></h3>", listOrg[j].ORGNAME);
                        html.Append("<ul style=\"display:block;\" class=\"z-tree-ul\">");
                        for (int k = j + 1; k < listOrg.Count; k++)
                        {
                            if (listOrg[k].PARENTID.Trim() == listOrg[j].ORGID.Trim())
                            {
                                html.Append("<li class=\"z-tree-li\">");
                                html.AppendFormat("<h3><a href=\"#\" class=\"z-tree-active\">{0}</a></h3>", listOrg[k].ORGNAME);
                                html.Append("<ul style=\"display:block;\" class=\"z-tree-ul\">");
                                for (int l = k + 1; l < listOrg.Count; l++)
                                {
                                    if (listOrg[l].PARENTID.Trim() == listOrg[k].ORGID.Trim())
                                    {
                                        html.Append("<li class=\"z-tree-li\">");
                                        html.AppendFormat("<h3><a href=\"#\" class=\"z-tree-active\">{0}</a></h3>", listOrg[l].ORGNAME);
                                        html.Append("</li>");
                                        for (int m = 0; m < listDevice.Count; m++)
                                        {
                                            if (listDevice[m].BELONG_GROUPID.Trim() == listOrg[l].ORGID.Trim())
                                            {
                                                html.AppendFormat("<li class=\"z-tree-li z-tree-leaf\"><a class=\"zxt-d-s-{5}\" href=\"#\" id=\"zxt-d-{0}|{3},{4}\">{1} [{2}]</a></li>", listDevice[m].DEVICE_ID, listDevice[m].DEVICE_NAME, listDevice[m].CUR_STATUS, listDevice[m].LON, listDevice[m].LAT, ColorClass(listDevice[m].CUR_STATUS));
                                                listDevice.RemoveAt(m);
                                                m--;
                                            }
                                        }
                                        listOrg.RemoveAt(l);
                                        l--;
                                    }
                                }
                                for (int l = 0; l < listDevice.Count; l++)
                                {
                                    if (listDevice[l].BELONG_GROUPID.Trim() == listOrg[k].ORGID.Trim())
                                    {
                                        html.AppendFormat("<li class=\"z-tree-li z-tree-leaf\"><a class=\"zxt-d-s-{5}\" href=\"#\" id=\"zxt-d-{0}|{3},{4}\">{1} [{2}]</a></li>", listDevice[l].DEVICE_ID, listDevice[l].DEVICE_NAME, listDevice[l].CUR_STATUS, listDevice[l].LON, listDevice[l].LAT, ColorClass(listDevice[l].CUR_STATUS));
                                        listDevice.RemoveAt(l);
                                        l--;
                                    }
                                }
                                html.Append("</ul>");
                                html.Append("</li>");
                                listOrg.RemoveAt(k);
                                k--;
                            }
                        }
                        for (int k = 0; k < listDevice.Count; k++)
                        {
                            if (listDevice[k].BELONG_GROUPID.Trim() == listOrg[j].ORGID.Trim())
                            {
                                html.AppendFormat("<li class=\"z-tree-li z-tree-leaf\"><a class=\"zxt-d-s-{5}\" href=\"#\" id=\"zxt-d-{0}|{3},{4}\">{1} [{2}]</a></li>", listDevice[k].DEVICE_ID, listDevice[k].DEVICE_NAME, listDevice[k].CUR_STATUS, listDevice[k].LON, listDevice[k].LAT, ColorClass(listDevice[k].CUR_STATUS));
                                listDevice.RemoveAt(k);
                                k--;
                            }
                        }
                        html.Append("</ul>");
                        html.Append("</li>");
                        listOrg.RemoveAt(j);
                        j--;
                    }
                }
                for (int j = 0; j < listDevice.Count; j++)
                {
                    if (listDevice[j].BELONG_GROUPID.Trim() == listOrg[i].ORGID.Trim())
                    {
                        html.AppendFormat("<li class=\"z-tree-li z-tree-leaf\"><a class=\"zxt-d-s-{5}\" href=\"#\" id=\"zxt-d-{0}|{3},{4}\">{1} [{2}]</a></li>", listDevice[j].DEVICE_ID, listDevice[j].DEVICE_NAME, listDevice[j].CUR_STATUS, listDevice[j].LON, listDevice[j].LAT, ColorClass(listDevice[j].CUR_STATUS));
                        listDevice.RemoveAt(j);
                        j--;
                    }
                }
                html.Append("</ul>");
                html.Append("</li>");
                listOrg.RemoveAt(i);
                i--;
            }
            for (int i = 0; i < listDevice.Count; i++)
            {
                if (listDevice[i].BELONG_GROUPID.Trim() == listOrg[0].ORGID.Trim())
                {
                    html.AppendFormat("<li class=\"z-tree-li z-tree-leaf\"><a class=\"zxt-d-s-{5}\" href=\"#\" id=\"zxt-d-{0}|{3},{4}\">{1} [{2}]</a></li>", listDevice[i].DEVICE_ID, listDevice[i].DEVICE_NAME, listDevice[i].CUR_STATUS, listDevice[i].LON, listDevice[i].LAT, ColorClass(listDevice[i].CUR_STATUS));
                    listDevice.RemoveAt(i);
                    i--;
                }
            }
            html.Append("</ul>");
            html.Append("</li>");
            html.Append("</ul>");
            html.Append("</div>");
            context.Response.ContentType = "text/html";
            context.Response.Write(html.ToString());
        }

        private IList<AOrg> OrgChildren(string orgid)
        {
            return Mapper.Instance().QueryForList<AOrg>("GetOrgListLikeID", orgid + "%");
        }

        private IList<DeviceInfo> OrgDevices(string orgid)
        {
            return Mapper.Instance().QueryForList<DeviceInfo>("GetDeviceListWithStatusByGroups", orgid + "%");
        }

        private string ColorClass(string status)
        {
            switch (status)
            {
                case "在线":
                case "正常":
                case "行驶":
                    return "online";
                case "停车":
                    return "stop";
                case "熄火":
                    return "turnoff";
                default:
                    return "offline";
            }
        }

        private bool HasChildOrg(IList<AOrg> list, string orgid)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].PARENTID.Trim() == orgid.Trim())
                {
                    return true;
                }
            }
            return false;
        }

        private bool HasChildDevice(IList<DeviceInfo> list, string orgid)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].BELONG_GROUPID.Trim() == orgid.Trim())
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