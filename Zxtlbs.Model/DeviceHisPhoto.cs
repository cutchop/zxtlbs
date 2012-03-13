using System;
namespace Zxtlbs.Model
{
	/// <summary>
	/// 历史信息表结构示例（按天分库，100个表）
	/// </summary>
    public class DeviceHisPhoto : BaseModel
	{
        public DeviceHisPhoto()
		{}
		#region Model
		private string _rw_id;
		private string _device_id;
		private DateTime? _logintime;
		private decimal? _ph_type;
		private string _file_name;
		private string _file_url;
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
		/// 拍照时间
		/// </summary>
		public DateTime? LOGINTIME
		{
			set{ _logintime=value;}
			get{return _logintime;}
		}
		/// <summary>
		/// 类型(图片/短片）
		/// </summary>
		public decimal? PH_TYPE
		{
			set{ _ph_type=value;}
			get{return _ph_type;}
		}
		/// <summary>
		/// 文件名
		/// </summary>
		public string FILE_NAME
		{
			set{ _file_name=value;}
			get{return _file_name;}
		}
		/// <summary>
		/// 文件URL访问地址
		/// </summary>
		public string FILE_URL
		{
			set{ _file_url=value;}
			get{return _file_url;}
		}
		#endregion Model

	}
}

