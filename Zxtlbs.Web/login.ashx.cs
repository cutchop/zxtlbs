using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using IBatisNet.DataMapper;
using Zxtlbs.Model;

namespace Zxtlbs.Web
{
    /// <summary>
    /// 登录验证
    /// </summary>
    public class login : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Session["AUser"] = null;
            if (context.Request["action"] == "p")
            {
                AUser user = new AUser();
                user.USERID = context.Request["u"];
                if (!string.IsNullOrEmpty(user.USERID))
                {
                    user.PASSWORD = context.Request["p"];
                    if (!string.IsNullOrEmpty(user.PASSWORD))
                    {
                        user.PASSWORD = Zxtlbs.Business.Common.GetMD5Hash(user.PASSWORD);
                        user = Mapper.Instance().QueryForObject<AUser>("GetUserByPassword", user);
                        if (user != null)
                        {
                            context.Session["AUser"] = user;
                            context.Response.Cookies["userid"].Value = user.USERID;
                            if (!string.IsNullOrEmpty(context.Request["r"]))
                            {
                                context.Response.Cookies["remember"].Value = "true";
                            }
                            else
                            {
                                context.Response.Cookies["remember"].Value = "false";
                            }
                            context.Response.Write("success");
                        }
                        else
                        {
                            context.Response.Write("帐号或密码错误");
                        }
                    }
                    else
                    {
                        context.Response.Write("请填写密码");
                    }
                }
                else
                {
                    context.Response.Write("请填写帐号");
                }
            }
            else
            {
                if (context.Request.Cookies["remember"] != null)
                {
                    string remember = context.Request.Cookies["remember"].Value;
                    if (remember == "true")
                    {
                        if (context.Request.Cookies["userid"] != null)
                        {
                            string userid = context.Request.Cookies["userid"].Value;
                            if (!string.IsNullOrEmpty(userid))
                            {
                                context.Response.Write(userid);
                            }
                        }
                    }
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