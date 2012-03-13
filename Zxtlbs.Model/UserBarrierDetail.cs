using System;
namespace Zxtlbs.Model
{
	/// <summary>
	/// 电子围栏从表
	/// </summary>
    public class UserBarrierDetail : BaseModel
	{
        public UserBarrierDetail()
		{}
		#region Model
		private string _rw_id;
		private decimal? _id;
		private decimal? _line;
		private decimal? _lon;
		private decimal? _lat;
		/// <summary>
		/// 记录ID
		/// </summary>
		public string RW_ID
		{
			set{ _rw_id=value;}
			get{return _rw_id;}
		}
		/// <summary>
		/// 围栏ID
		/// </summary>
		public decimal? ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 行号
		/// </summary>
		public decimal? LINE
		{
			set{ _line=value;}
			get{return _line;}
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
		#endregion Model

	}
}

