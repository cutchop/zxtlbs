using System;
namespace Zxtlbs.Model
{
	/// <summary>
	/// 机构信息表
	/// </summary>
    public class AOrg : BaseModel
	{
        public AOrg()
		{}
		#region Model
		private string _orgid;
		private string _parentid;
		private string _orgname;
		private string _orgtype;
		private decimal? _orglevel;
		private decimal? _o;
		private string _remark;
		private string _creator;
		private DateTime? _createtime;
		private string _modifier;
		private DateTime? _modifytime;
		/// <summary>
		/// 机构编号
		/// </summary>
		public string ORGID
		{
			set{ _orgid=value;}
			get{return _orgid;}
		}
		/// <summary>
		/// 父节点编号
		/// </summary>
		public string PARENTID
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 机构名称
		/// </summary>
		public string ORGNAME
		{
			set{ _orgname=value;}
			get{return _orgname;}
		}
		/// <summary>
		/// 机构类别
		/// </summary>
		public string ORGTYPE
		{
			set{ _orgtype=value;}
			get{return _orgtype;}
		}
		/// <summary>
		/// 机构级别
		/// </summary>
		public decimal? ORGLEVEL
		{
			set{ _orglevel=value;}
			get{return _orglevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? O
		{
			set{ _o=value;}
			get{return _o;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 创建人
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
		#endregion Model

	}
}

