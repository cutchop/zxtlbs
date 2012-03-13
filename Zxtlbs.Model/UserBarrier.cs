using System;
namespace Zxtlbs.Model
{
	/// <summary>
	/// 电子围栏主表
	/// </summary>
    public class UserBarrier : BaseModel
	{
        public UserBarrier()
		{}
		#region Model
		private string _rw_id;
		private decimal? _id;
		private string _ba_name;
		private string _ba_type;
		private decimal? _showflag;
		private decimal? _rad;
		private DateTime? _createtime;
		private string _groupid;
		/// <summary>
		/// 记录ID
		/// </summary>
		public string RW_ID
		{
			set{ _rw_id=value;}
			get{return _rw_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 围栏名称
		/// </summary>
		public string BA_NAME
		{
			set{ _ba_name=value;}
			get{return _ba_name;}
		}
		/// <summary>
		/// 围栏类型(1圆形  2矩形  3多边形  4线)
		/// </summary>
		public string BA_TYPE
		{
			set{ _ba_type=value;}
			get{return _ba_type;}
		}
		/// <summary>
		/// 有效标志
		/// </summary>
		public decimal? SHOWFLAG
		{
			set{ _showflag=value;}
			get{return _showflag;}
		}
		/// <summary>
		/// 范围
		/// </summary>
		public decimal? RAD
		{
			set{ _rad=value;}
			get{return _rad;}
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
		/// 公司ID
		/// </summary>
		public string GROUPID
		{
			set{ _groupid=value;}
			get{return _groupid;}
		}
		#endregion Model

	}
}

