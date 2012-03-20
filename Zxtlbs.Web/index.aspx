<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Zxtlbs.Web.index" %>

<!DOCTYPE html>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>中信通位置服务系统</title>
<link href="common/common.css" rel="stylesheet" type="text/css" />
<link href="frame/frame.css" rel="stylesheet" type="text/css" />
<link href="frame/jquery-ui-1.8.18.custom.css" rel="stylesheet" type="text/css" />
<link href="frame/jquery.dataTables_themeroller.css" rel="stylesheet" type="text/css" />
<link href="frame/dialog/zebra_dialog.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="frame/jquery-1.6.2.min.js"></script>
<script type="text/javascript" src="frame/jquery-ui-1.8.18.custom.min.js"></script>
<script type="text/javascript" src="frame/jquery.dataTables.min.js"></script>
<script type="text/javascript" src="frame/dialog/zebra_dialog.js"></script>
<script type="text/javascript" src="common/base.js"></script>
<script type="text/javascript" src="common/common.js"></script>
<script type="text/javascript" src="frame/frame.js"></script>
<script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false"></script>
</head>
<body>
<div id="wrapper">
    <div id="header">
        <div id="headerTop" class="lock">
            <div id="headerMain">
                <h1 class="logo"><a href="#">LBS</a></h1>
                <ul class="nav">
                    <li id="nav_map"><div class="wrapIcon" onclick="ajaxloading('map','map/map.html','实时监控')"><em class="navIcon_map">&nbsp;</em><span>实时监控</span></div></li>
                    <li id="nav_history"><div class="wrapIcon" onclick="ajaxloading('history','map/history.html','历史轨迹')"><em class="navIcon_history">&nbsp;</em><span>历史轨迹</span></div></li>
                    <li id="nav_report"><div class="wrapIcon" onclick="ajaxloading('report','report/index.html','报表管理')"><em class="navIcon_report">&nbsp;</em><span>报表管理</span></div></li>
					<li id="nav_device"><div class="wrapIcon" onclick="ajaxloading('device','device/device.html','设备管理')"><em class="navIcon_device">&nbsp;</em><span>设备管理</span></div></li>
                    <li id="nav_setting"><div class="wrapIcon" onclick="ajaxloading('setting','setting/setting.html','系统设置')"><em class="navIcon_setting">&nbsp;</em><span>系统设置</span></div></li>
                    <li id="nav_other"><div class="wrapIcon"><em class="navIcon_other">&nbsp;</em><span>其他系统</span></div></li>
                </ul>
                
                <div class="area">
                    <div class="loginBox">
                        <div class="loginPic stopPropagation" onclick="toggle('#addMore3');"><img src="frame/images/img.jpg" /></div>
                        <div class="loginText">伍凯</div>
                    </div>
                    <ul class="areaTools stopPropagation">
                        <li title="系统消息" onclick="popupBody('#xtbg_wxts');">
                            <a class="sysinfoIcon" href="#">&nbsp;</a>
                            <span class="c_num">
                                <span><i>555</i></span>
                            </span>
                        </li>
                        <li title="email" onclick="popupBody('#lbzm-email');">
                            <a class="emailIcon" href="#">&nbsp;</a>
                            <span class="c_num">
                                <span><i>3</i></span>
                            </span>
                        </li>
                        <li title="IM" onclick="toggle('#imDiv');toggleClass(this,'topOptionClick')"><a class="imIcon" href="#">&nbsp;</a></li>
                    </ul>
                    <ul class="areaTools">
                        <li class="topChange"><a class="cgIcon stopPropagation" onclick="toggle('#topChangeMenu')" href="#">&nbsp;</a></li>
                        <li>
                            <a class="helpIcon" title="帮助" onclick="winOpen('help.html',960,600)" href="#">&nbsp;</a>
                            <a id="top-tree-xtbg_01" title="帮助" style="display:none;" class="helpIcon" onclick="winOpen('help.html?id=tree-xtbg_01',960,600)" href="#">&nbsp;</a>
                            <a id="top-tree-jk_01" title="帮助" style="display:none;" class="helpIcon" onclick="winOpen('help.html?id=tree-jk_01',960,600)" href="#">&nbsp;</a>
                        </li>
                        <li><a title="退出" class="exitIcon" href="login.html">&nbsp;</a></li>
                    </ul>
                </div>
                <ul id="topChangeMenu" class="sq-popDiv" style="display:none">
                    <li class="active" onclick="topChange.Max()">最大</li>
                    <li onclick="topChange.Min()">最小</li>
                    <li onclick="topChange.Hide()">隐藏</li>
                </ul>
            </div>
        </div>
        <div id="headerBottom"><span>&nbsp;</span></div>
    </div>
    <div id="addMore3" class="popTip sq-popDiv"> <span class="popTip-tips-up">&nbsp;</span>
        <div class="popTip-tl"><div class="popTip-tr"><div class="popTip-tc">&nbsp;</div></div></div>
        <div class="popTip-ml">
            <div class="popTip-mr">
                <div class="popTip-mc">
                    <div class="userbox">
                        <div class="userbox-info-wrap">
                        <div class="userbox-img"><img alt="" src="frame/images/img.gif" /></div>
                        <h3 class="userbox-name">伍凯</h3>
                        <p class="userbox-info">中企动力 > 数字管理部</p>
                        </div>
<table class="tableStyle tableStyleNoBorder cb" width="100%" border="0" cellspacing="0" cellpadding="0">
    <tr>
        <td class="tr" width="60"><strong>登录帐号</strong></td>
        <td>zhoujianguo</td>
    </tr>
    <tr>
        <td class="tr"><strong>公司电话</strong></td>
        <td>010-83921321-990</td>
    </tr>
    <tr>
        <td class="tr"><strong>手机</strong></td>
        <td>13627382212</td>
    </tr>
    <tr>
        <td class="tr"><strong>公司邮箱</strong></td>
        <td>zhoujianguo@300.cn</td>
    </tr>
</table>
<div class="userbox-icon">
    <span class="userbox-icon_01" onclick="popupBody('#userpop_grxx');hiddenDiv('#addMore3')" title="个人设置" alt="个人设置">&nbsp;</span>
    <span class="userbox-icon_02" onclick="popupBody('#userpop_xgmm');hiddenDiv('#addMore3')" title="修改密码" alt="修改密码">&nbsp;</span>
    <span class="userbox-icon_03" onclick="winOpen('html/community/my_index.html',800,600);hiddenDiv('#addMore3')" title="我的空间" alt="我的空间">&nbsp;</span>
</div>
                    </div>
                </div>
            </div>
        </div>
        <div class="popTip-bl">
            <div class="popTip-br">
                <div class="popTip-bc"></div>
            </div>
        </div>
    </div>
    <div id="imDiv" class="sq-popDiv"><img alt="" onclick="popupBody('#imBOX');" src="frame/images/imIMG.png" /></div>
    <div id="fullBG"><table><tr><td><img alt="" src="frame/images/bg.jpg" /></td></tr></table></div>
</div>
<div id="lbzm-email" class="z-window x-window-fixed" style="display:none;"> 
    <div class="z-window-tl"><div class="z-window-tr"><div class="z-window-tc"> 
        <div class="z-window-tools"><a href="#" onclick="closePopup(this)" class="z-close"></a></div> 
        <h2>邮件</h2> 
    </div></div></div> 
    <div class="z-window-ml"><div class="z-window-mr"><div class="z-window-mc">
        <!--弹出内容开始--> 
        <img src="frame/images/yj.jpg" alt="" />
        <!--弹出内容结束-->  
    </div></div></div>
    <div class="z-window-bl"><div class="z-window-br"><div class="z-window-bc"></div></div></div> 
</div>
<div id="userpop_grxx_xg" class="z-window x-window-fixed" style="display:none;"> 
    <div class="z-window-tl"><div class="z-window-tr"><div class="z-window-tc"> 
        <div class="z-window-tools"><a href="#" onclick="closePopup(this)" class="z-close"></a></div> 
        <h2>上传头像</h2> 
    </div></div></div> 
    <div class="z-window-ml"><div class="z-window-mr"><div class="z-window-mc">
        <!--弹出内容开始--> 
        <div class="z-window-content">                           
<div style="padding:0 10px; width:300px; height:200px; overflow:hidden;"> 
  <div style="margin:-100px 0 0 -200px;" class="pr">
  <img src="common/images/up.jpg" />
  <input type="file" class="alpha0" style="height: 42px; left: 96px; position: absolute; top: 144px; width: 150px;" />
  </div>
</div>
        </div>
                
        <div class="z-window-bbar"> 
            <div class="z-btn"><a href="#" onclick="closePopup(this)" class="z-btn-blue"><span>确定</span></a></div> 
            <div class="z-btn"><a href="#" onclick="closePopup(this)" class="z-btn-gray"><span>取消</span></a></div> 
        </div>         
        <!--弹出内容结束-->  
    </div></div></div>
    <div class="z-window-bl"><div class="z-window-br"><div class="z-window-bc"></div></div></div> 
</div>
<div id="userpop_grxx" class="z-window x-window-fixed" style="display:none;"> 
    <div class="z-window-tl"><div class="z-window-tr"><div class="z-window-tc"> 
        <div class="z-window-tools"><a href="#" onclick="closePopup(this)" class="z-close"></a></div> 
        <h2>个人信息</h2> 
    </div></div></div> 
    <div class="z-window-ml"><div class="z-window-mr"><div class="z-window-mc">
        <!--弹出内容开始--> 
        <div class="z-window-content">
        <div class="clearfl">
        <div class="fl">
            <img alt="" src="frame/images/img.gif" /><br />
            <a href="#" onclick="popupBody('#userpop_grxx_xg');">修改显示图片</a>
        </div>
        <div class="fl">
        <table class="z-window-form"> 
            <tr> 
              <td width="60" class="label">登录帐号</td> 
              <td class="space"><span class="z-font-gray">zhoujianguo</span></td> 
            </tr> 
            <tr> 
              <td class="label">姓名</td> 
              <td class="space"><span class="z-font-gray">周建国</span></td> 
            </tr> 
            <tr> 
              <td class="label">性别</td> 
              <td class="space"><span class="z-font-gray">男</span></td> 
            </tr> 
            <tr> 
              <td class="label">公司电话</td> 
              <td class="space"><span class="z-basic-input"> 
                <input type="text" class="z-basic-text" /> 
                </span></td> 
            </tr> 
            <tr> 
              <td class="label">手机</td> 
              <td class="space"><span class="z-basic-input"> 
                <input type="text" value="13526372822" class="z-basic-text" /> 
                </span></td> 
            </tr> 
            <tr> 
              <td class="label">公司邮箱</td> 
              <td class="space"><span class="z-font-gray">zhoujianguo@300.cn</span></td> 
            </tr> 
            <tr> 
              <td class="label">部门</td> 
              <td class="space"><span class="z-font-gray">数字管理部</span></td> 
            </tr> 
            <tr> 
              <td class="label">职务</td> 
              <td class="space"><span class="z-font-gray">可用性工程师</span></td> 
            </tr> 
        </table> 
        </div>
        </div>
        </div>
        <div class="z-window-bbar"> 
            <div class="z-btn"><a href="#" onclick="closePopup(this)" class="z-btn-blue"><span>确定</span></a></div> 
            <div class="z-btn"><a href="#" onclick="closePopup(this)" class="z-btn-gray"><span>取消</span></a></div> 
        </div> 
        <!--弹出内容结束-->  
    </div></div></div>
    <div class="z-window-bl"><div class="z-window-br"><div class="z-window-bc"></div></div></div> 
</div>
<div id="userpop_xgmm" class="z-window x-window-fixed" style="display:none;"> 
    <div class="z-window-tl"><div class="z-window-tr"><div class="z-window-tc"> 
        <div class="z-window-tools"><a href="#" onclick="closePopup(this)" class="z-close"></a></div> 
        <h2>修改密码</h2> 
    </div></div></div> 
    <div class="z-window-ml"><div class="z-window-mr"><div class="z-window-mc">
        <!--弹出内容开始--> 
        <div class="z-window-content">
        <table class="z-window-form"> 
            <tr> 
              <td class="label">旧密码</td> 
              <td class="space"><span class="z-basic-input"> 
                <input type="password" class="z-basic-text" /> 
                </span></td>
            </tr>
            <tr> 
              <td class="label">新密码</td> 
              <td><span class="z-basic-input"> 
                <input type="password" class="z-basic-text" /> 
                </span></td> 
            </tr> 
            <tr> 
              <td class="label">再次输入新密码</td> 
              <td><span class="z-basic-input"> 
                <input type="password" class="z-basic-text" /> 
                </span></td> 
            </tr> 
        </table> 
        </div>
        <div class="z-window-bbar"> 
            <div class="z-btn"><a href="#" onclick="closePopup(this)" class="z-btn-blue"><span>确定</span></a></div> 
            <div class="z-btn"><a href="#" onclick="closePopup(this)" class="z-btn-gray"><span>取消</span></a></div> 
        </div> 
        <!--弹出内容结束-->  
    </div></div></div>
    <div class="z-window-bl"><div class="z-window-br"><div class="z-window-bc"></div></div></div> 
</div>

<script type="text/javascript">
    $(document).ready(function() {
        ajaxloading('map', 'map/map.html', '实时监控');
    })
</script>
</body>
</html>