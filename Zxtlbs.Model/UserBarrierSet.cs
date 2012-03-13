using System;
namespace Zxtlbs.Model
{
	/// <summary>
	/// 电子围栏设定表
	/// </summary>
    public class UserBarrierSet : BaseModel
	{
		public UserBarrierSet()
		{}
		#region Model
		private string _rw_id;
		private decimal? _id;
		private string _phonenum;
		private decimal? _is_open;
		private decimal? _isopentime;
		private string _opentime;
		private decimal? _speedlimit;
		private decimal? _reginscope;
		private decimal? _alarmtype;
		private decimal? _hittime;
		private DateTime? _createtime;
		/// <summary>
		/// 记录ID
		/// </summary>
		public string RW_ID
		{
			set{ _rw_id=value;}
			get{return _rw_id;}
		}
		/// <summary>
		/// 电子围栏编号
		/// </summary>
		public decimal? ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 设备号
		/// </summary>
		public string PHONENUM
		{
			set{ _phonenum=value;}
			get{return _phonenum;}
		}
		/// <summary>
		/// 是否开启电子栅栏 1、开启 2、关闭
		/// </summary>
		public decimal? IS_OPEN
		{
			set{ _is_open=value;}
			get{return _is_open;}
		}
		/// <summary>
		/// 是否设置电子栅栏启用时间段
		/// </summary>
		public decimal? ISOPENTIME
		{
			set{ _isopentime=value;}
			get{return _isopentime;}
		}
		/// <summary>
		/// 开始时间
		/// </summary>
		public string OPENTIME
		{
			set{ _opentime=value;}
			get{return _opentime;}
		}
		/// <summary>
		/// 限速
		/// </summary>
		public decimal? SPEEDLIMIT
		{
			set{ _speedlimit=value;}
			get{return _speedlimit;}
		}
		/// <summary>
		/// 阀值
		/// </summary>
		public decimal? REGINSCOPE
		{
			set{ _reginscope=value;}
			get{return _reginscope;}
		}
		/// <summary>
		/// 报警类型 进区域告警1，出区域告警2，停车区域限时告警3，区域超速告警4，进出区域告警5，线路偏移告警6
		/// </summary>
		public decimal? ALARMTYPE
		{
			set{ _alarmtype=value;}
			get{return _alarmtype;}
		}
		/// <summary>
		/// 报警提示次数
		/// </summary>
		public decimal? HITTIME
		{
			set{ _hittime=value;}
			get{return _hittime;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATETIME
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

