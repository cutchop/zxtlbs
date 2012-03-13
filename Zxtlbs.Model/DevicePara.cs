using System;
namespace Zxtlbs.Model
{
	/// <summary>
	/// 设备参数信息表
	/// </summary>
    public class DevicePara : BaseModel
	{
        public DevicePara()
		{}
		#region Model
		private string _rw_id;
		private string _device_id;
		private decimal? _fee_mode;
		private decimal? _balance;
		private decimal? _use_money;
		private decimal? _add_money;
		private decimal? _area_flag;
		private decimal? _overspeed_flag;
		private decimal? _sms_flag;
		private string _sms_phone;
		/// <summary>
		/// 记录ID
		/// </summary>
		public string RW_ID
		{
			set{ _rw_id=value;}
			get{return _rw_id;}
		}
		/// <summary>
		/// 设备号码#
		/// </summary>
		public string DEVICE_ID
		{
			set{ _device_id=value;}
			get{return _device_id;}
		}
		/// <summary>
		/// 设备计费模式
		/// </summary>
		public decimal? FEE_MODE
		{
			set{ _fee_mode=value;}
			get{return _fee_mode;}
		}
		/// <summary>
		/// 设备可用金额
		/// </summary>
		public decimal? BALANCE
		{
			set{ _balance=value;}
			get{return _balance;}
		}
		/// <summary>
		/// 设备已用金额
		/// </summary>
		public decimal? USE_MONEY
		{
			set{ _use_money=value;}
			get{return _use_money;}
		}
		/// <summary>
		/// 设备累计充值
		/// </summary>
		public decimal? ADD_MONEY
		{
			set{ _add_money=value;}
			get{return _add_money;}
		}
		/// <summary>
		/// 区域报警开关
		/// </summary>
		public decimal? AREA_FLAG
		{
			set{ _area_flag=value;}
			get{return _area_flag;}
		}
		/// <summary>
		/// 超速报警开关
		/// </summary>
		public decimal? OVERSPEED_FLAG
		{
			set{ _overspeed_flag=value;}
			get{return _overspeed_flag;}
		}
		/// <summary>
		/// 短信报警开关
		/// </summary>
		public decimal? SMS_FLAG
		{
			set{ _sms_flag=value;}
			get{return _sms_flag;}
		}
		/// <summary>
		/// 短信报警号码
		/// </summary>
		public string SMS_PHONE
		{
			set{ _sms_phone=value;}
			get{return _sms_phone;}
		}
		#endregion Model

	}
}

