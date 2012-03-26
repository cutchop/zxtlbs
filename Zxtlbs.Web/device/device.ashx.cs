using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using Zxtlbs.Model;
using IBatisNet.DataMapper;
using System.Text;
using Zxtlbs.Business;

namespace Zxtlbs.Web.device
{
    /// <summary>
    /// 设备管理
    /// </summary>
    public class device : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            AUser user = (AUser)context.Session["AUser"];
            context.Response.ContentType = "text/plain";
            string action = context.Request["action"];
            if (string.IsNullOrEmpty(action) || action == "q")
            {//查询
                DeviceInfo di = new DeviceInfo();
                di.PageStart = int.Parse(context.Request["iDisplayStart"]);
                di.PageEnd = int.Parse(context.Request["iDisplayStart"]) + int.Parse(context.Request["iDisplayLength"]);
                di.DEVICE_NAME = context.Request["name"];
                di.BELONG_GROUPID = context.Request["groupid"];
                if (string.IsNullOrEmpty(di.BELONG_GROUPID))
                {
                    di.BELONG_GROUPID = user.ORGID;
                }
                int total = Mapper.Instance().QueryForObject<int>("GetDeviceTotalByGroups", di);
                IList<DeviceInfo> list = Mapper.Instance().QueryForList<DeviceInfo>("GetDeviceListPage", di);
                StringBuilder data = new StringBuilder();
                for (int i = 0; i < list.Count; i++)
                {
                    DeviceInfo d = list[i];
                    data.AppendFormat("[\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\",\"{12}\",\"{13}\",\"{14}\",\"{15}\",\"{16}\",\"{17}\",\"{18}\",\"{19}\",\"{20}\",\"{21}\",\"{22}\"],",
                        i, d.DEVICE_ID, d.DEVICE_NAME, d.DEVICE_SIM, d.DEVICE_TYPE, d.COM_MODE, d.BELONG_GROUPNAME, d.LINKPHONE, ((DateTime)d.INSTALL_DATE).ToString("yyyy-MM-dd"), d.LOGINTIME,
                        d.ICO_NUM, d.BELONG_GROUPID, d.INITIAL_COURSE, d.ENGINE_NUMBER, d.FRAME_NUMBER, d.LINKPHONE, d.PLATE_COLOR, d.VEHICLE_COLOR, d.IS_OIL_SENSOR, d.IS_CAMERA, d.IS_TEMP_SENSOR, d.IS_IS_RELAY, d.DEVICE_REMARK);
                }
                if (data.Length > 0)
                {
                    data.Remove(data.Length - 1, 1);
                }
                context.Response.Write(Common.DatatablesJson(context.Request["sEcho"], total, data.ToString()));
            }
            else if (action == "a")
            {//新增
                DeviceInfo di = new DeviceInfo();
                di.DEVICE_ID = context.Request["device_id"];
                if (!string.IsNullOrEmpty(Mapper.Instance().QueryForObject<string>("IsExistDeviceID", di.DEVICE_ID)))
                {
                    context.Response.Write("该设备号码已存在");
                }
                else
                {
                    di.DEVICE_NAME = context.Request["device_name"];
                    di.DEVICE_SIM = context.Request["device_sim"];
                    di.BELONG_GROUPID = context.Request["belong_groupid"];
                    di.COM_MODE = context.Request["com_mode"];
                    di.DEVICE_TYPE = context.Request["device_type"];
                    di.LINKPHONE = context.Request["linkphone"];
                    di.INSTALL_DATE = Convert.ToDateTime(context.Request["install_date"]);
                    try
                    {
                        Mapper.Instance().Insert("InsertDevice", di);
                        context.Response.Write("success");
                    }
                    catch (Exception ex)
                    {
                        context.Response.Write("操作出现异常,请重试<br />" + ex.Message);
                    }
                }
            }
            else if (action == "e")
            {//修改
                DeviceInfo di = new DeviceInfo();
                di.DEVICE_ID = context.Request["device_id"];
                di.DEVICE_NAME = context.Request["device_name"];
                di.DEVICE_SIM = context.Request["device_sim"];
                di.BELONG_GROUPID = context.Request["belong_groupid"];
                di.COM_MODE = context.Request["com_mode"];
                di.DEVICE_TYPE = context.Request["device_type"];
                di.LINKPHONE = context.Request["linkphone"];
                di.INSTALL_DATE = Convert.ToDateTime(context.Request["install_date"]);
                try
                {
                    Mapper.Instance().Update("UpdateDevice", di);
                    context.Response.Write("success");
                }
                catch (Exception ex)
                {
                    context.Response.Write("操作出现异常,请重试<br />" + ex.Message);
                }
            }
            else if (action == "d")
            {//删除
                string device_id = context.Request["device_id"];
                try
                {
                    Mapper.Instance().Delete("DeleteDevice", device_id);
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