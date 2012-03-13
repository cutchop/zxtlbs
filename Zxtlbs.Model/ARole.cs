using System;
namespace Zxtlbs.Model
{
	/// <summary>
	/// 角色信息表
	/// </summary>
    public class ARole : BaseModel
	{
        public ARole()
		{}
		#region Model
		private string _roleid;
		private string _parentid;
		private string _rolename;
		private decimal? _rolelevel;
		private decimal _enabled;
		private string _remark;
		private string _creator;
		private DateTime? _createtime;
		private string _modifier;
		private DateTime? _modifytime;
		private decimal? _o;
		/// <summary>
		/// 角色ID
		/// </summary>
		public string ROLEID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 父级角色id
		/// </summary>
		public string PARENTID
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 角色名称
		/// </summary>
		public string ROLENAME
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// 角色等级
		/// </summary>
		public decimal? ROLELEVEL
		{
			set{ _rolelevel=value;}
			get{return _rolelevel;}
		}
		/// <summary>
		/// 激活(启用标记)
		/// </summary>
		public decimal ENABLED
		{
			set{ _enabled=value;}
			get{return _enabled;}
		}
		/// <summary>
		/// 备注说明
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 创建人员
		/// </summary>
		public string CREATOR
		{
			set{ _creator=value;}
			get{return _creator;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATETIME
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 修改人
		/// </summary>
		public string MODIFIER
		{
			set{ _modifier=value;}
			get{return _modifier;}
		}
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime? MODIFYTIME
		{
			set{ _modifytime=value;}
			get{return _modifytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? O
		{
			set{ _o=value;}
			get{return _o;}
		}
		#endregion Model

	}
}

