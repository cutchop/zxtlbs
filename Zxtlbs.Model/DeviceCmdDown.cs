using System;
namespace Zxtlbs.Model
{
	/// <summary>
	/// 设备命令下载表，未执行
	/// </summary>
    public class DeviceCmdDown : BaseModel
	{
		public DeviceCmdDown()
		{}
		#region Model
		private string _rw_id;
		private DateTime? _sub_datetime;
		private string _device_id;
		private string _com_type;
		private string _cmd_type;
		private string _cmd_remark;
		private decimal? _cur_status=0;
		private decimal? _out_datetime=30;
		private decimal? _retry_times=1;
		private string _download_content;
		private DateTime? _download_datetime;
		private string _return_result;
		/// <summary>
		/// 记录ID
		/// </summary>
		public string RW_ID
		{
			set{ _rw_id=value;}
			get{return _rw_id;}
		}
		/// <summary>
		/// 提交时间
		/// </summary>
		public DateTime? SUB_DATETIME
		{
			set{ _sub_datetime=value;}
			get{return _sub_datetime;}
		}
		/// <summary>
		/// 设备号
		/// </summary>
		public string DEVICE_ID
		{
			set{ _device_id=value;}
			get{return _device_id;}
		}
		/// <summary>
		/// 通讯模式 TCP,UDP
		/// </summary>
		public string COM_TYPE
		{
			set{ _com_type=value;}
			get{return _com_type;}
		}
		/// <summary>
		/// 命令类型
		/// </summary>
		public string CMD_TYPE
		{
			set{ _cmd_type=value;}
			get{return _cmd_type;}
		}
		/// <summary>
		/// 命令说明
		/// </summary>
		public string CMD_REMARK
		{
			set{ _cmd_remark=value;}
			get{return _cmd_remark;}
		}
		/// <summary>
		/// 设备状态 0 提交，1-n 已下发次数，888888 下发成功
		/// </summary>
		public decimal? CUR_STATUS
		{
			set{ _cur_status=value;}
			get{return _cur_status;}
		}
		/// <summary>
		/// 超时时长(s)
		/// </summary>
		public decimal? OUT_DATETIME
		{
			set{ _out_datetime=value;}
			get{return _out_datetime;}
		}
		/// <summary>
		/// 重试限次 0 表示无限次
		/// </summary>
		public decimal? RETRY_TIMES
		{
			set{ _retry_times=value;}
			get{return _retry_times;}
		}
		/// <summary>
		/// 下发内容
		/// </summary>
		public string DOWNLOAD_CONTENT
		{
			set{ _download_content=value;}
			get{return _download_content;}
		}
		/// <summary>
		/// 下发时间
		/// </summary>
		public DateTime? DOWNLOAD_DATETIME
		{
			set{ _download_datetime=value;}
			get{return _download_datetime;}
		}
		/// <summary>
		/// 反馈结果(没有反馈结果，一般就是超时没有反馈)
		/// </summary>
		public string RETURN_RESULT
		{
			set{ _return_result=value;}
			get{return _return_result;}
		}
		#endregion Model

	}
}

