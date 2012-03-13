using System;
namespace Zxtlbs.Model
{
	/// <summary>
	/// 地物表
	/// </summary>
	public class UserMapLable : BaseModel
	{
        public UserMapLable()
		{}
		#region Model
		private string _rw_id;
		private string _lb_name;
		private decimal? _lb_type;
		private decimal? _lon;
		private decimal? _lat;
		private decimal? _onwer;
		private DateTime? _createtime;
		private string _remark;
		/// <summary>
		/// 记录ID
		/// </summary>
		public string RW_ID
		{
			set{ _rw_id=value;}
			get{return _rw_id;}
		}
		/// <summary>
		/// 地标名称
		/// </summary>
		public string LB_NAME
		{
			set{ _lb_name=value;}
			get{return _lb_name;}
		}
		/// <summary>
		/// 类型
		/// </summary>
		public decimal? LB_TYPE
		{
			set{ _lb_type=value;}
			get{return _lb_type;}
		}
		/// <summary>
		/// 经度
		/// </summary>
		public decimal? LON
		{
			set{ _lon=value;}
			get{return _lon;}
		}
		/// <summary>
		/// 纬度
		/// </summary>
		public decimal? LAT
		{
			set{ _lat=value;}
			get{return _lat;}
		}
		/// <summary>
		/// 所有者
		/// </summary>
		public decimal? ONWER
		{
			set{ _onwer=value;}
			get{return _onwer;}
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
		/// 备注
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

