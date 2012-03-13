using System;
namespace Zxtlbs.Model
{
	/// <summary>
	/// 设备状态信息表
	/// </summary>
    public class DeviceState : BaseModel
	{
        public DeviceState()
		{}
		#region Model
		private string _rw_id;
		private string _device_id;
		private decimal? _lon;
		private decimal? _lat;
		private decimal? _height;
		private decimal? _speed;
		private DateTime? _logintime;
		private decimal? _direction;
		private decimal? _licheng;
		private string _acc;
		private string _device_status;
		private string _cur_status;
		private string _version;
		private string _cur_dev_ip;
		private string _cur_server_ip;
		private decimal? _cur_server_port;
		private decimal? _oid_quan;
		private decimal? _temp_s1;
		private decimal? _temp_s2;
		private decimal? _temp_s3;
		private decimal? _temp_s4;
		/// <summary>
		/// 记录ID
		/// </summary>
		public string RW_ID
		{
			set{ _rw_id=value;}
			get{return _rw_id;}
		}
		/// <summary>
		/// 车辆编号
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
		/// 高度
		/// </summary>
		public decimal? HEIGHT
		{
			set{ _height=value;}
			get{return _height;}
		}
		/// <summary>
		/// 行驶速度
		/// </summary>
		public decimal? SPEED
		{
			set{ _speed=value;}
			get{return _speed;}
		}
		/// <summary>
		/// 上传时间
		/// </summary>
		public DateTime? LOGINTIME
		{
			set{ _logintime=value;}
			get{return _logintime;}
		}
		/// <summary>
		/// 方向
		/// </summary>
		public decimal? DIRECTION
		{
			set{ _direction=value;}
			get{return _direction;}
		}
		/// <summary>
		/// 行驶里程数据
		/// </summary>
		public decimal? LICHENG
		{
			set{ _licheng=value;}
			get{return _licheng;}
		}
		/// <summary>
		/// 点火标记
		/// </summary>
		public string ACC
		{
			set{ _acc=value;}
			get{return _acc;}
		}
		/// <summary>
		/// 上传状态描述
		/// </summary>
		public string DEVICE_STATUS
		{
			set{ _device_status=value;}
			get{return _device_status;}
		}
		/// <summary>
		/// 当前状态(离线...)
		/// </summary>
		public string CUR_STATUS
		{
			set{ _cur_status=value;}
			get{return _cur_status;}
		}
		/// <summary>
		/// 设备版本
		/// </summary>
		public string VERSION
		{
			set{ _version=value;}
			get{return _version;}
		}
		/// <summary>
		/// 当前设备ip
		/// </summary>
		public string CUR_DEV_IP
		{
			set{ _cur_dev_ip=value;}
			get{return _cur_dev_ip;}
		}
		/// <summary>
		/// 连接服务器IP
		/// </summary>
		public string CUR_SERVER_IP
		{
			set{ _cur_server_ip=value;}
			get{return _cur_server_ip;}
		}
		/// <summary>
		/// 连接服务器端口
		/// </summary>
		public decimal? CUR_SERVER_PORT
		{
			set{ _cur_server_port=value;}
			get{return _cur_server_port;}
		}
		/// <summary>
		/// 油量
		/// </summary>
		public decimal? OID_QUAN
		{
			set{ _oid_quan=value;}
			get{return _oid_quan;}
		}
		/// <summary>
		/// 温度1
		/// </summary>
		public decimal? TEMP_S1
		{
			set{ _temp_s1=value;}
			get{return _temp_s1;}
		}
		/// <summary>
		/// 温度2
		/// </summary>
		public decimal? TEMP_S2
		{
			set{ _temp_s2=value;}
			get{return _temp_s2;}
		}
		/// <summary>
		/// 温度3
		/// </summary>
		public decimal? TEMP_S3
		{
			set{ _temp_s3=value;}
			get{return _temp_s3;}
		}
		/// <summary>
		/// 温度4
		/// </summary>
		public decimal? TEMP_S4
		{
			set{ _temp_s4=value;}
			get{return _temp_s4;}
		}
		#endregion Model

	}
}

