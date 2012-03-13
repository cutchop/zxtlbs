using System;
namespace Zxtlbs.Model
{
	/// <summary>
	/// 角色授权表
	/// </summary>
    public class ARolePrivilege : BaseModel
	{
        public ARolePrivilege()
		{}
		#region Model
		private string _roleid;
		private string _domain;
		private decimal _type;
		private string _rid;
		private string _pid;
		/// <summary>
		/// 角色ID
		/// </summary>
		public string ROLEID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 所属应用域
		/// </summary>
		public string DOMAIN
		{
			set{ _domain=value;}
			get{return _domain;}
		}
		/// <summary>
		/// 类型(1 页面 2 按键)
		/// </summary>
		public decimal TYPE
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 对象ID
		/// </summary>
		public string RID
		{
			set{ _rid=value;}
			get{return _rid;}
		}
		/// <summary>
		/// 权限
		/// </summary>
		public string PID
		{
			set{ _pid=value;}
			get{return _pid;}
		}
		#endregion Model

	}
}

