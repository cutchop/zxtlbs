using System;
namespace Zxtlbs.Model
{
    /// <summary>
    /// 用户信息表
    /// </summary>
    public class AUser : BaseModel
    {
        public AUser()
        { }
        #region Model
        private string _userid;
        private string _username;
        private string _adminid;
        private string _orgid;
        private string _password;
        private string _stamppassword;
        private decimal _userlevel;
        private decimal? _isleader;
        private DateTime? _expireddate;
        private decimal? _expired;
        private DateTime? _logintime;
        private string _loginip;
        private DateTime? _lasttime;
        private string _lastip;
        private string _skin;
        private string _ipconfig;
        private string _langcode;
        private string _usertype;
        private decimal? _postid;
        private decimal? _sex;
        private DateTime? _birthday;
        private string _idcard;
        private string _school;
        private decimal? _graduation;
        private decimal? _degree;
        private string _major;
        private string _country;
        private string _province;
        private string _city;
        private string _address;
        private string _postcode;
        private string _phone;
        private string _fax;
        private string _mobile;
        private string _email;
        private string _remark;
        private string _creator;
        private DateTime? _createtime;
        private string _modifier;
        private DateTime? _modifytime;
        /// <summary>
        /// 用户编号
        /// </summary>
        public string USERID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string USERNAME
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 管理员编号
        /// </summary>
        public string ADMINID
        {
            set { _adminid = value; }
            get { return _adminid; }
        }
        /// <summary>
        /// 机构编号
        /// </summary>
        public string ORGID
        {
            set { _orgid = value; }
            get { return _orgid; }
        }
        /// <summary>
        /// 密码MD5-32位加密
        /// </summary>
        public string PASSWORD
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// 图章
        /// </summary>
        public string STAMPPASSWORD
        {
            set { _stamppassword = value; }
            get { return _stamppassword; }
        }
        /// <summary>
        /// 用户级别普通用户、管理用户、超级用户
        /// </summary>
        public decimal USERLEVEL
        {
            set { _userlevel = value; }
            get { return _userlevel; }
        }
        /// <summary>
        /// 机构主管
        /// </summary>
        public decimal? ISLEADER
        {
            set { _isleader = value; }
            get { return _isleader; }
        }
        /// <summary>
        /// 过期日期
        /// </summary>
        public DateTime? EXPIREDDATE
        {
            set { _expireddate = value; }
            get { return _expireddate; }
        }
        /// <summary>
        /// 过期状态0 未过期 1 过期
        /// </summary>
        public decimal? EXPIRED
        {
            set { _expired = value; }
            get { return _expired; }
        }
        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime? LOGINTIME
        {
            set { _logintime = value; }
            get { return _logintime; }
        }
        /// <summary>
        /// 最后登录ip
        /// </summary>
        public string LOGINIP
        {
            set { _loginip = value; }
            get { return _loginip; }
        }
        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime? LASTTIME
        {
            set { _lasttime = value; }
            get { return _lasttime; }
        }
        /// <summary>
        /// 上次登录ip
        /// </summary>
        public string LASTIP
        {
            set { _lastip = value; }
            get { return _lastip; }
        }
        /// <summary>
        /// 皮肤
        /// </summary>
        public string SKIN
        {
            set { _skin = value; }
            get { return _skin; }
        }
        /// <summary>
        /// 设置用于登录验证
        /// </summary>
        public string IPCONFIG
        {
            set { _ipconfig = value; }
            get { return _ipconfig; }
        }
        /// <summary>
        /// 语言
        /// </summary>
        public string LANGCODE
        {
            set { _langcode = value; }
            get { return _langcode; }
        }
        /// <summary>
        /// 用户类别
        /// </summary>
        public string USERTYPE
        {
            set { _usertype = value; }
            get { return _usertype; }
        }
        /// <summary>
        /// 职位
        /// </summary>
        public decimal? POSTID
        {
            set { _postid = value; }
            get { return _postid; }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public decimal? SEX
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? BIRTHDAY
        {
            set { _birthday = value; }
            get { return _birthday; }
        }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string IDCARD
        {
            set { _idcard = value; }
            get { return _idcard; }
        }
        /// <summary>
        /// 毕业学校
        /// </summary>
        public string SCHOOL
        {
            set { _school = value; }
            get { return _school; }
        }
        /// <summary>
        /// 毕业时间
        /// </summary>
        public decimal? GRADUATION
        {
            set { _graduation = value; }
            get { return _graduation; }
        }
        /// <summary>
        /// 学历
        /// </summary>
        public decimal? DEGREE
        {
            set { _degree = value; }
            get { return _degree; }
        }
        /// <summary>
        /// 专业
        /// </summary>
        public string MAJOR
        {
            set { _major = value; }
            get { return _major; }
        }
        /// <summary>
        /// 国家
        /// </summary>
        public string COUNTRY
        {
            set { _country = value; }
            get { return _country; }
        }
        /// <summary>
        /// 省份
        /// </summary>
        public string PROVINCE
        {
            set { _province = value; }
            get { return _province; }
        }
        /// <summary>
        /// 城市
        /// </summary>
        public string CITY
        {
            set { _city = value; }
            get { return _city; }
        }
        /// <summary>
        /// 地址
        /// </summary>
        public string ADDRESS
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 邮编
        /// </summary>
        public string POSTCODE
        {
            set { _postcode = value; }
            get { return _postcode; }
        }
        /// <summary>
        /// 电话
        /// </summary>
        public string PHONE
        {
            set { _phone = value; }
            get { return _phone; }
        }
        /// <summary>
        /// 传真
        /// </summary>
        public string FAX
        {
            set { _fax = value; }
            get { return _fax; }
        }
        /// <summary>
        /// 手机
        /// </summary>
        public string MOBILE
        {
            set { _mobile = value; }
            get { return _mobile; }
        }
        /// <summary>
        /// 邮件
        /// </summary>
        public string EMAIL
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string REMARK
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CREATOR
        {
            set { _creator = value; }
            get { return _creator; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CREATETIME
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 修改人
        /// </summary>
        public string MODIFIER
        {
            set { _modifier = value; }
            get { return _modifier; }
        }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? MODIFYTIME
        {
            set { _modifytime = value; }
            get { return _modifytime; }
        }
        #endregion Model

    }
}

