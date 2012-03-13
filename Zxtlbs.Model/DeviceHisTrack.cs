using System;
namespace Zxtlbs.Model
{
	/// <summary>
	/// 历史信息表结构示例
	/// </summary>
    public class DeviceHisTrack : BaseModel
	{
		public DeviceHisTrack()
		{}
		#region Model
		private string _rw_id;
		private string _device_id;
		private decimal? _lon;
		private decimal? _lat;
		private decimal? _v_lon;
		private decimal? _v_lat;
		private decimal? _speed;
		private DateTime? _logintime;
		private decimal? _direction;
		private decimal? _acc;
		private decimal? _licheng;
		private string _status;
		private string _device_status;
		private string _cur_dev_ip;
		private string _cur_server_ip;
		private decimal? _cur_server_port;
		private decimal? _oid_quan;
		private decimal? _temp_s1;
		private decimal? _temp_s2;
		private decimal? _temp_s3;
		private decimal? _temp_s4;
		private string _ora_data;
		private decimal? _alerttype;
		private string _alertid;
        private DateTime? _createtime;
        private string _device_name;
		/// <summary>
		/// 记录ID
		/// </summary>
		public string RW_ID
		{
			set{ _rw_id=value;}
			get{return _rw_id;}
		}
		/// <summary>
		/// 终端号
		/// </summary>
		public string DEVICE_ID
		{
			set{ _device_id=value;}
			get{return _device_id;}
		}
		/// <summary>
		/// 经度值
		/// </summary>
		public decimal? LON
		{
			set{ _lon=value;}
			get{return _lon;}
		}
		/// <summary>
		/// 纬度值
		/// </summary>
		public decimal? LAT
		{
			set{ _lat=value;}
			get{return _lat;}
		}
		/// <summary>
		/// 纠偏经度值
		/// </summary>
		public decimal? V_LON
		{
			set{ _v_lon=value;}
			get{return _v_lon;}
		}
		/// <summary>
		/// 纠偏纬度值
		/// </summary>
		public decimal? V_LAT
		{
			set{ _v_lat=value;}
			get{return _v_lat;}
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
		/// 数据上传时间
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
		/// 点火标记
		/// </summary>
		public decimal? ACC
		{
			set{ _acc=value;}
			get{return _acc;}
		}
		/// <summary>
		/// 里程数
		/// </summary>
		public decimal? LICHENG
		{
			set{ _licheng=value;}
			get{return _licheng;}
		}
		/// <summary>
		/// 状态(离线、停车)
		/// </summary>
		public string STATUS
		{
			set{ _status=value;}
			get{return _status;}
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
		/// <summary>
		/// 原始数据包
		/// </summary>
		public string ORA_DATA
		{
			set{ _ora_data=value;}
			get{return _ora_data;}
		}
		/// <summary>
		/// 报警类型
		/// </summary>
		public decimal? ALERTTYPE
		{
			set{ _alerttype=value;}
			get{return _alerttype;}
		}
		/// <summary>
		/// 报警关联ID
		/// </summary>
		public string ALERTID
		{
			set{ _alertid=value;}
			get{return _alertid;}
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
        /// 设备名称
        /// </summary>
        public string DEVICE_NAME
        {
            set { _device_name = value; }
            get { return _device_name; }
        }
		#endregion Model

	}
}

