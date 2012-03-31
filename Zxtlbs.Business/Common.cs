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

        /// <summary>
        /// 获取MD5加密后的字符串
        /// </summary>
        /// <param name="input">需要加密的字符串</param>
        /// <returns></returns>
        public static string GetMD5Hash(string input)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();
        }
    }
}
