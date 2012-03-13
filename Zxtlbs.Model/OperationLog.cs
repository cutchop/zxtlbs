using System;
namespace Zxtlbs.Model
{
	/// <summary>
	/// 报警类型表
	/// </summary>
    public class OperationLog : BaseModel
	{
		public OperationLog()
		{}
		#region Model
		private string _rw_id;
		private string _user_id;
		private DateTime? _oper_time;
		private string _oper_title;
		private string _oper_content;
		private string _groupid;
		/// <summary>
		/// 记录ID
		/// </summary>
		public string RW_ID
		{
			set{ _rw_id=value;}
			get{return _rw_id;}
		}
		/// <summary>
		/// 用户帐号
		/// </summary>
		public string USER_ID
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 操作日期
		/// </summary>
		public DateTime? OPER_TIME
		{
			set{ _oper_time=value;}
			get{return _oper_time;}
		}
		/// <summary>
		/// 操作标题
		/// </summary>
		public string OPER_TITLE
		{
			set{ _oper_title=value;}
			get{return _oper_title;}
		}
		/// <summary>
		/// 操作内容
		/// </summary>
		public string OPER_CONTENT
		{
			set{ _oper_content=value;}
			get{return _oper_content;}
		}
		/// <summary>
		/// 所属公司
		/// </summary>
		public string GROUPID
		{
			set{ _groupid=value;}
			get{return _groupid;}
		}
		#endregion Model

	}
}

