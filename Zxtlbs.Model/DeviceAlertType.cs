using System;
namespace Zxtlbs.Model
{
	/// <summary>
	/// 报警类型表
	/// </summary>
    public class DeviceAlertType : BaseModel
	{
        public DeviceAlertType()
		{}
		#region Model
		private string _rw_id;
		private decimal? _alerttype;
		private string _alertmemo;
		/// <summary>
		/// 记录ID
		/// </summary>
		public string RW_ID
		{
			set{ _rw_id=value;}
			get{return _rw_id;}
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
		/// 报警类型名称
		/// </summary>
		public string ALERTMEMO
		{
			set{ _alertmemo=value;}
			get{return _alertmemo;}
		}
		#endregion Model

	}
}

