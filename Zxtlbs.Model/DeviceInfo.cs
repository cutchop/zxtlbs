using System;
namespace Zxtlbs.Model
{
	/// <summary>
	/// 设备基本信息表
	/// </summary>
    public class DeviceInfo : BaseModel
	{
        public DeviceInfo()
		{}
		#region Model
		private string _rw_id;
		private string _device_id;
		private string _device_name;
		private string _factory_code;
		private string _device_sim;
		private string _device_type;
		private decimal? _ico_num;
		private string _belong_groupid;
		private string _com_mode;
		private DateTime? _install_date;
		private decimal? _initial_course;
		private string _engine_number;
		private string _frame_number;
		private string _linkphone;
		private string _plate_color;
		private string _vehicle_color;
		private decimal? _is_oil_sensor;
		private decimal? _is_camera;
		private decimal? _is_temp_sensor;
		private decimal? _is_is_relay;
		private DateTime? _createtime;
        private string _device_remark;
        private decimal? _lon;
        private decimal? _lat;
        private string _cur_status;
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
		/// 设备名称
		/// </summary>
		public string DEVICE_NAME
		{
			set{ _device_name=value;}
			get{return _device_name;}
		}
		/// <summary>
		/// 出厂编号
		/// </summary>
		public string FACTORY_CODE
		{
			set{ _factory_code=value;}
			get{return _factory_code;}
		}
		/// <summary>
		/// SIM卡号
		/// </summary>
		public string DEVICE_SIM
		{
			set{ _device_sim=value;}
			get{return _device_sim;}
		}
		/// <summary>
		/// 设备类型
		/// </summary>
		public string DEVICE_TYPE
		{
			set{ _device_type=value;}
			get{return _device_type;}
		}
		/// <summary>
		/// 图标编号
		/// </summary>
		public decimal? ICO_NUM
		{
			set{ _ico_num=value;}
			get{return _ico_num;}
		}
		/// <summary>
		/// 上级ID(所属组ID)
		/// </summary>
		public string BELONG_GROUPID
		{
			set{ _belong_groupid=value;}
			get{return _belong_groupid;}
		}
		/// <summary>
		/// 通讯模式(GPRS、CDMA)
		/// </summary>
		public string COM_MODE
		{
			set{ _com_mode=value;}
			get{return _com_mode;}
		}
		/// <summary>
		/// 安装日期
		/// </summary>
		public DateTime? INSTALL_DATE
		{
			set{ _install_date=value;}
			get{return _install_date;}
		}
		/// <summary>
		/// 初始化里程
		/// </summary>
		public decimal? INITIAL_COURSE
		{
			set{ _initial_course=value;}
			get{return _initial_course;}
		}
		/// <summary>
		/// 发动机号
		/// </summary>
		public string ENGINE_NUMBER
		{
			set{ _engine_number=value;}
			get{return _engine_number;}
		}
		/// <summary>
		/// 车架号
		/// </summary>
		public string FRAME_NUMBER
		{
			set{ _frame_number=value;}
			get{return _frame_number;}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string LINKPHONE
		{
			set{ _linkphone=value;}
			get{return _linkphone;}
		}
		/// <summary>
		/// 牌照颜色
		/// </summary>
		public string PLATE_COLOR
		{
			set{ _plate_color=value;}
			get{return _plate_color;}
		}
		/// <summary>
		/// 汽车颜色
		/// </summary>
		public string VEHICLE_COLOR
		{
			set{ _vehicle_color=value;}
			get{return _vehicle_color;}
		}
		/// <summary>
		/// 是否支持油量传感器
		/// </summary>
		public decimal? IS_OIL_SENSOR
		{
			set{ _is_oil_sensor=value;}
			get{return _is_oil_sensor;}
		}
		/// <summary>
		/// 是否支持摄像头
		/// </summary>
		public decimal? IS_CAMERA
		{
			set{ _is_camera=value;}
			get{return _is_camera;}
		}
		/// <summary>
		/// 是否支持温度
		/// </summary>
		public decimal? IS_TEMP_SENSOR
		{
			set{ _is_temp_sensor=value;}
			get{return _is_temp_sensor;}
		}
		/// <summary>
		/// 是否支持断油电
		/// </summary>
		public decimal? IS_IS_RELAY
		{
			set{ _is_is_relay=value;}
			get{return _is_is_relay;}
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
		public string DEVICE_REMARK
		{
			set{ _device_remark=value;}
			get{return _device_remark;}
        }
        /// <summary>
        /// 经度
        /// </summary>
        public decimal? LON
        {
            set { _lon = value; }
            get { return _lon; }
        }
        /// <summary>
        /// 纬度
        /// </summary>
        public decimal? LAT
        {
            set { _lat = value; }
            get { return _lat; }
        }
        /// <summary>
        /// 当前状态(离线...)
        /// </summary>
        public string CUR_STATUS
        {
            set { _cur_status = value; }
            get { return _cur_status; }
        }
		#endregion Model

	}
}

