using System;
using System.Collections.Generic;
using System.Text;

namespace Zxtlbs.Business
{
    public class Common
    {
        /// <summary>
        /// 输出DataTables需要的json格式
        /// </summary>
        /// <param name="sEcho">编号</param>
        /// <param name="iTotalRecords">总记录数</param>
        /// <param name="aaData">当前页码的记录</param>
        /// <returns></returns>
        public static string DatatablesJson(string sEcho,int iTotalRecords,string aaData)
        {
            return "{\"sEcho\": " + sEcho 
                + ", \"iTotalRecords\": " + iTotalRecords
                + ", \"iTotalDisplayRecords\": " + iTotalRecords 
                + ", \"aaData\": [" + aaData + "]}";
        }
    }
}
