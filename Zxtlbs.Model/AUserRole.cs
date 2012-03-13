using System;
namespace Zxtlbs.Model
{
	/// <summary>
	/// 用户角色表
	/// </summary>
    public class AUserRole : BaseModel
	{
        public AUserRole()
		{}
		#region Model
		private string _userid;
		private string _roleid;
		private decimal _hold;
		private DateTime? _expireddate;
		/// <summary>
		/// 用户编号
		/// </summary>
		public string USERID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 角色编号
		/// </summary>
		public string ROLEID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 拥有/排斥/间接
		/// </summary>
		public decimal HOLD
		{
			set{ _hold=value;}
			get{return _hold;}
		}
		/// <summary>
		/// 时间限制
		/// </summary>
		public DateTime? EXPIREDDATE
		{
			set{ _expireddate=value;}
			get{return _expireddate;}
		}
		#endregion Model

	}
}

