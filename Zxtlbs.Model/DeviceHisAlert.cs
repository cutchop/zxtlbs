using System;
namespace Zxtlbs.Model
{
	/// <summary>
	/// 历史报警表（按天分库）
	/// </summary>
    public class DeviceHisAlert : BaseModel
	{
        public DeviceHisAlert()
		{}
		#region Model
		private string _rw_id;
		private string _device_id;
		private decimal? _lon;
		private decimal? _lat;
		private decimal? _alerttype;
		private DateTime? _logintime;
		private decimal? _alertflg;
		private decimal? _maxspeed;
		private decimal? _acc;
		private string _alertmemo;
		private string _direction;
		private string _details;
		/// <summary>
		/// 记录ID
		/// </summary>
		public string RW_ID
		{
			set{ _rw_id=value;}
			get{return _rw_id;}
		}
		/// <summary>
		/// 设备号码
		/// </summary>
		public string DEVICE_ID
		{
			set{ _device_id=value;}
			get{return _device_id;}
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
		/// 
		/// </summary>
		public decimal? ALERTTYPE
		{
			set{ _alerttype=value;}
			get{return _alerttype;}
		}
		/// <summary>
		/// 报警时间
		/// </summary>
		public DateTime? LOGINTIME
		{
			set{ _logintime=value;}
			get{return _logintime;}
		}
		/// <summary>
		/// 报警标记 0报警 1已处理
		/// </summary>
		public decimal? ALERTFLG
		{
			set{ _alertflg=value;}
			get{return _alertflg;}
		}
		/// <summary>
		/// 速度
		/// </summary>
		public decimal? MAXSPEED
		{
			set{ _maxspeed=value;}
			get{return _maxspeed;}
		}
		/// <summary>
		/// ACC状态
		/// </summary>
		public decimal? ACC
		{
			set{ _acc=value;}
			get{return _acc;}
		}
		/// <summary>
		/// 报警描述
		/// </summary>
		public string ALERTMEMO
		{
			set{ _alertmemo=value;}
			get{return _alertmemo;}
		}
		/// <summary>
		/// 方向
		/// </summary>
		public string DIRECTION
		{
			set{ _direction=value;}
			get{return _direction;}
		}
		/// <summary>
		/// 报警明细
		/// </summary>
		public string DETAILS
		{
			set{ _details=value;}
			get{return _details;}
		}
		#endregion Model

	}
}

