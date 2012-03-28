using System;
using System.Collections.Generic;
using System.Web;
using Zxtlbs.Model;
using IBatisNet.DataMapper;

namespace Zxtlbs.Web
{
    public partial class single : System.Web.UI.Page
    {
        protected string VarInit;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request["id"];
            if (!string.IsNullOrEmpty(id))
            {
                //AUser user = (AUser)Session["AUser"];
                DeviceState ds = new DeviceState();
                ds.DEVICE_ID = id;
                IList<DeviceState> list = Mapper.Instance().QueryForList<DeviceState>("GetStatusByDeviceIDs", ds);
                if (list.Count > 0)
                {
                    this.Title = list[0].DEVICE_NAME;
                    VarInit = string.Format("var id='{0}',name='{1}',lat={2},lng={3},sim='{4}',status='{5}',speed='{6}',direction='{7}',licheng='{8}',logintime='{9}',icon='1/01.png';",
                        id, list[0].DEVICE_NAME, list[0].LAT, list[0].LON, list[0].DEVICE_SIM, list[0].CUR_STATUS, list[0].SPEED, list[0].DIRECTION, list[0].LICHENG, list[0].LOGINTIME);
                }
                else
                {
                    VarInit = "window.location='login.html';";
                }
            }
            else
            {
                VarInit = "window.location='login.html';";
            }
        }
    }
}