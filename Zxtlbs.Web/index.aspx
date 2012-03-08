<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Zxtlbs.Web.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>LBS</title>
<link href="common/common.css" rel="stylesheet" type="text/css" />
<link href="frame/frame.css" rel="stylesheet" type="text/css" />
<link href="frame/jquery-ui-1.8.18.custom.css" rel="stylesheet" type="text/css" />
<link href="frame/jquery.dataTables_themeroller.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="frame/jquery-1.6.2.min.js"></script>
<script type="text/javascript" src="frame/jquery-ui-1.8.18.custom.min.js"></script>
<script type="text/javascript" src="frame/jquery.dataTables.min.js"></script>
<script type="text/javascript" src="common/base.js"></script>
<script type="text/javascript" src="common/common.js"></script>
<script type="text/javascript" src="frame/frame.js"></script>
<script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false"></script>
</head>
<body>
<form id="form1" runat="server">
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
                        <div class="loginText">张微</div>
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
<div id="xtbg_wxts" style="display:none; width:800px;" class="z-window x-window-fixed">
    <div class="z-window-tl">
        <div class="z-window-tr">
            <div class="z-window-tc">
                <div class="z-window-tools"><a href="#" onclick="closePopup(this)" class="z-close"></a></div>
                <h2>系统消息</h2>
            </div>
        </div>
    </div>
    <div class="z-window-ml">
        <div class="z-window-mr">
            <div class="z-window-mc"> 
                <!--弹出内容开始-->
                <div class="z-window-main">
<div class="z-tab z-tab-gray">                         
    <ul class="z-tab-menu"> 
        <li class="z-tab-menu-first"><a class="z-active" href="#"><span>未读<em>(<i>5</i>)</em></span></a></li> 
        <li class="z-tab-menu-last"><a href="#"><span>已读</span></a></li> 
    </ul> 
    <div class="z-tab-box"> 
        <div class="z-tab-box-content" style="height:400px;display:block"> 
            <div class="z-window-content">
                
                <div class="z-list z-window-list"> 
            <table class="z-list-table">
                <thead>
                      <tr>
                        <th width="80">服务单元名称</th>
                        <th>系统消息</th>
                        <th width="10%">时间</th>
                        <th width="48px"></th>
                      </tr>
                    </thead>
            <tbody>
              <tr>
                <td>出差</td>
                <td>韩立跟的出差申</td>
                <td>2011-04-16</td>
                <td><div class="hide"><a onclick="initTime('loading')" href="#">我知道了</a></div></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>为第第二会议室规范的讨论议室规范的讨会的会议室变更为第二会议室...</td>
                  <td>2011-04-06</td>
                  <td><div class="hide"><a onclick="initTime('loading')" href="#">我知道了</a></div></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td><div class="hide"><a onclick="initTime('loading')" href="#">我知道了</a></div></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td><div class="hide"><a onclick="initTime('loading')" href="#">我知道了</a></div></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td><div class="hide"><a onclick="initTime('loading')" href="#">我知道了</a></div></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td><div class="hide"><a onclick="initTime('loading')" href="#">我知道了</a></div></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td><div class="hide"><a onclick="initTime('loading')" href="#">我知道了</a></div></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td><div class="hide"><a onclick="initTime('loading')" href="#">我知道了</a></div></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td><div class="hide"><a onclick="initTime('loading')" href="#">我知道了</a></div></td>
              </tr>
            </tbody>
        </table> 
    </div>
            </div>
        </div> 
        <div class="z-tab-box-content"> 
            <div class="z-search"> 
        <div class="z-search-condition"> 
            <div class="z-search-term-three"> 
                <table class="z-search-box"> 
                    <thead> 
                        <tr> 
                            <td class="z-search-name">系统消息</td> 
                            <td><span class="z-basic-input"> 
                                <input type="text" class="z-basic-text" /> 
                                </span></td> 
                            <td class="z-search-name">时间</td> 
                            <td><div class="z-basic-time-part-wrap"> 
                                    <div class="z-select-box-wrap1 z-basic-time-wrap"><span class="z-basic-trigger z-basic-time"> 
                                        <input type="text" class="z-basic-text z-basic-text-disable" disabled="disabled" /> 
                                        <a class="z-btn-trigger" href="javascript:void(0)"></a></span> 
                                        <div class="z-select-box1 z-select-box-time1" style="display:none;"> <img onclick="hiddenDiv('.z-select-box-time1')" src="common/images/basic/z-calendar2.gif" /> </div> 
                                    </div> 
                                    <div class="z-basic-to">至</div> 
                                    <div class="z-select-box-wrap1 z-basic-time-wrap"><span class="z-basic-trigger z-basic-time"> 
                                        <input type="text" class="z-basic-text z-basic-text-disable" disabled="disabled" /> 
                                        <a href="javascript:void(0)" class="z-btn-trigger"></a></span> 
                                        <div class="z-select-box1 z-select-box-time1" style="display:none;"> <img onclick="hiddenDiv('.z-select-box-time1')" src="common/images/basic/z-calendar2.gif" /> </div> 
                                    </div> 
                                </div></td> 
                        </tr> 
                    </thead> 
                </table> 
            </div> 
            <div class="z-search-btn"><a href="#" onclick="showOnly('#xtbg_wxts_02')" class="z-search-inq"><span>查询</span></a> <a href="#" class="z-search-reset">重置</a> </div> 
        </div> 
    </div>
        <div>
            <div class="z-window-content z-js-height" style="height:310px;">
                <div class="z-list z-window-list z-list-scroll" rel="40"> 
        <div class="z-list-table-t"> 
            <table class="z-list-table">
                <thead>
                      <tr>
                        <th width="80">服务单元名称</th>
                        <th>系统消息</th>
                        <th width="10%">时间</th>
                        <th width="20%"></th>
                      </tr>
                    </thead>
            </table>
        </div>
        <div class="z-list-table-b"> 
        <table class="z-list-table">
            <tbody>
              <tr>
                <td width="80">出差</td>
                <td><a href="#">韩立跟的出差申</a></td>
                <td width="10%">2011-4-16</td>
                <td width="20%"></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
            </tbody>
        </table> 
        </div>
    </div>
                <div class="z-page"> 
        <div class="z-page-width"> 
            <div class="z-page-left"> <span class="z-page-every">每页</span> 
                <div class="z-select-box-wrap1"><span class="z-basic-trigger z-basic-select"> 
                    <input name="" type="text" class="z-basic-text z-basic-text-disable" value="20"/> 
                    <a class="z-btn-trigger" href="javascript:void(0)"></a> </span> 
                    <div class="z-select-box1 z-box1" style="display:none;"> 
                        <div class="z-box-t"><span> </span></div> 
                        <div class="z-box-c"> 
                            <div class="z-box-m"> 
                                <ul class="z-list1"> 
                                    <li><a title="10" href="#">10</a></li> 
                                    <li><a title="20" href="#">20</a></li> 
                                    <li><a title="50" href="#">50</a></li> 
                                </ul> 
                            </div> 
                        </div> 
                        <div class="z-box-b"><span> </span></div> 
                    </div> 
                </div> 
                <span class="z-page-item">条</span> </div> 
            <div class="z-page-center"> <a href="#" class="z-page-pre"></a> <a href="#">1</a> <span class="z-page-ellipsis">···</span> <a href="#">5</a> <a href="#">6</a> <span class="z-page-current">7</span> <a href="#">8</a> <a href="#">9</a> <a href="#">10</a> <span class="z-page-ellipsis">···</span> <a href="#">16</a> <a href="#" class="z-page-next"></a> </div> 
            <div class="z-page-right">共150条</div> 
        </div> 
    </div>
            </div>
            <div id="xtbg_wxts_02" class="z-window-content z-js-height" style="height:310px;display:none;">
                <div class="z-list-result">找到相关结果<span>45</span>个</div>
                <div class="z-list z-window-list z-list-scroll" rel="65"> 
        <div class="z-list-table-t"> 
            <table class="z-list-table">
                <thead>
                      <tr>
                        <th width="80">服务单元名称</th>
                        <th>消息内容</th>
                        <th width="10%">时间</th>
                        <th width="20%"></th>
                      </tr>
                    </thead>
            </table>
        </div>
        <div class="z-list-table-b"> 
        <table class="z-list-table">
            <tbody>
              <tr>
                <td width="80">出差</td>
                <td><a href="#">韩立跟的出差申</a></td>
                <td width="10%">2011-4-16</td>
                <td width="20%"></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
              <tr>
                  <td>会议</td>
                  <td>UE规范的讨论会的会议室变更为第二会议室</td>
                  <td>2011-04-06</td>
                  <td></td>
              </tr>
            </tbody>
        </table> 
        </div>
    </div>
                <div class="z-page"> 
        <div class="z-page-width"> 
            <div class="z-page-left"> <span class="z-page-every">每页</span> 
                <div class="z-select-box-wrap1"><span class="z-basic-trigger z-basic-select"> 
                    <input name="" type="text" class="z-basic-text z-basic-text-disable" value="20"/> 
                    <a class="z-btn-trigger" href="javascript:void(0)"></a> </span> 
                    <div class="z-select-box1 z-box1" style="display:none;"> 
                        <div class="z-box-t"><span> </span></div> 
                        <div class="z-box-c"> 
                            <div class="z-box-m"> 
                                <ul class="z-list1"> 
                                    <li><a title="10" href="#">10</a></li> 
                                    <li><a title="20" href="#">20</a></li> 
                                    <li><a title="50" href="#">50</a></li> 
                                </ul> 
                            </div> 
                        </div> 
                        <div class="z-box-b"><span> </span></div> 
                    </div> 
                </div> 
                <span class="z-page-item">条</span> </div> 
            <div class="z-page-center"> <a href="#" class="z-page-pre"></a> <a href="#">1</a> <span class="z-page-ellipsis">···</span> <a href="#">5</a> <a href="#">6</a> <span class="z-page-current">7</span> <a href="#">8</a> <a href="#">9</a> <a href="#">10</a> <span class="z-page-ellipsis">···</span> <a href="#">16</a> <a href="#" class="z-page-next"></a> </div> 
            <div class="z-page-right">共150条</div> 
        </div> 
    </div>
            </div>
        </div>
        </div> 
    </div> 
</div>
                </div>
                <!--弹出内容结束--> 
            </div>
        </div>
    </div>
    <div class="z-window-bl">
        <div class="z-window-br">
            <div class="z-window-bc"> </div>
        </div>
    </div>
</div>
<div id="xtxx2" style="display:none;width:266px;">
    <div class="xx-tl"><div class="xx-tr"><div class="xx-tc">&nbsp;</div></div></div>
    <div class="xx-ml"><div class="xx-mr"><div class="xx-mc">
        <h2 class="xx-alarm">关于办公邮箱切换的通知</h2><span onclick="hiddenDiv('#xtxx2')" class="xx-close">&nbsp;</span>
        <p>为了提高统一通讯平台的稳定性，准备在2010年7月31日凌晨0：00-2：00对所有员工的办公邮箱切换到统一通讯平台的邮件3.0上。</p>
    </div></div></div>
    <div class="xx-bl"><div class="xx-br"><div class="xx-bc">&nbsp;</div></div></div>
</div>


<div id="xzbg-jkgl-ytjsp-sp" style="display:none;">
    <div class="z-form">
    <div class="z-form-btnarea">
      <div class="z-form-btnarea-tl">
        <div class="z-form-btnarea-tr">
          <div class="z-form-btnarea-tc">&nbsp;</div>
        </div>
      </div>
      <div class="z-form-btnarea-ml">
        <div class="z-form-btnarea-mr">
          <div class="z-form-btnarea-mc">
            <ul>
              <li><a href="#" class="z-icon-submit" onclick="popupBody('#z-jk-sqjk-next2');closePopup(this);">提交</a></li>
              <li><a href="#" class="z-icon-save" onclick="initTime('暂存成功！');closePopup(this)">暂存</a></li>
            </ul>
            <ul class="z-form-line">
              <li><a href="#" class="z-icon-view" onclick="popupBody('#z-jk-cklct1');closePopup(this)">查看流程</a></li>
              <li><a href="#" class="z-icon-print" onclick="closePopup(this)">打印</a></li>
              <li><a href="#" class="z-icon-close" onclick="closePopup(this)">关闭</a></li>
            </ul>
          </div>
        </div>
      </div>
      <div class="z-form-btnarea-bl">
        <div class="z-form-btnarea-br">
          <div class="z-form-btnarea-bc">&nbsp;</div>
        </div>
      </div>
    </div>
    <div class="z-form-main">
      <div class="z-form-tl">
        <div class="z-form-tr">
          <div class="z-form-tc">&nbsp;</div>
        </div>
      </div>
      <div class="z-form-ml">
        <div class="z-form-mr">
          <div class="z-form-mc">
            <h2 class="z-form-head-title z-form-head-f_j">朱振超的借款单<span class="f_j">&nbsp;</span></h2>
            <div class="z-form-scroll">
              <div class="z-form-head-info">
                <table class="z-form-item-table">
                  <tbody>
                    <tr>
                      <td class="label width1">编号</td>
                      <td class="width2"><span class="z-form-read">SZGLB2001021501</span></td>
                      <td class="label width1">日期</td>
                      <td><span class="z-form-read">2010-01-12</span></td>
                    </tr>
                    <tr>
                      <td class="label">经办人</td>
                      <td><span class="z-form-read">朱振超</span></td>
                      <td class="label">部门</td>
                      <td><span class="z-form-read">数字管理部</span></td>
                    </tr>
                  </tbody>
                </table>
              </div>
              <div class="z-form-item-wrap">
                <div class="z-form-item">
                  <h3 class="z-form-item-title">基本信息</h3>
                  <div class="z-form-item-div">
                    <table class="z-form-item-table">
                      <tbody>
                        <tr>
                          <td class="label width1">借款人<span class="z-font-red">*</span></td>
                          <td class="width2"><div class="z-select-box-wrap z-form-person-wrap"> <span class="z-form-trigger z-form-person">
                              <input type="text" value="朱振超" class="z-form-text" />
                              <a class="z-btn-trigger" href="javascript:void(0)">&nbsp;</a> </span> </div></td>
                          <td class="label width1">所属部门</td>
                          <td><span class="z-form-read">数字管理部</span></td>
                        </tr>
                        <tr>
                          <td class="label">信用额度(元)</td>
                          <td><span class="z-form-read">5000</span></td>
                          <td class="label">结欠金额(元)</td>
                          <td><span class="z-form-read">500</span><a href="#" class="fr mr15" onclick="popupBody('#z-jk-ckjqmx')">查看结欠明细</a></td>
                        </tr>
                        <tr>
                          <td class="label">借款金额(元)<span class="z-font-red">*</span></td>
                          <td><input type="text" class="z-form-text" /></td>
                          <td class="label">付款方式</td>
                          <td><div class="z-select-box-wrap"> <span class="z-form-trigger z-form-select">
                              <input type="text" value="" disabled="disabled" class="z-form-text" />
                              <a class="z-btn-trigger" href="javascript:void(0)">&nbsp;</a> </span>
                              <div style="display: none;" class="z-select-box z-box">
                                <div class="z-box-t"><span>&nbsp;</span></div>
                                <div class="z-box-c">
                                  <div class="z-box-m">
                                    <ul class="z-list">
                                      <li class="current"><a title="请选择" href="#">请选择</a></li>
                                      <li><a title="现金" href="#">现金</a></li>
                                      <li><a title="支票" href="#">支票</a></li>
                                      <li><a title="电汇" href="#">电汇</a></li>
                                    </ul>
                                  </div>
                                </div>
                                <div class="z-box-b"><span>&nbsp;</span></div>
                              </div>
                            </div></td>
                        </tr>
                        <tr>
                          <td class="label">使用日期</td>
                          <td><div class="z-select-box-wrap"> <span class="z-form-trigger z-form-time">
                              <input type="text" value="" class="z-form-text">
                              <a class="z-btn-trigger" href="javascript:void(0)">&nbsp;</a> </span></div></td>
                          <td class="label">预计还款日期<span class="z-font-red">*</span></td>
                          <td><div class="z-select-box-wrap"> <span class="z-form-trigger z-form-time">
                              <input type="text" value="" class="z-form-text" />
                              <a class="z-btn-trigger" href="javascript:void(0)">&nbsp;</a> </span></div></td>
                        </tr>
                        <tr>
                          <td class="label">借款类型</td>
                          <td><div class="z-select-box-wrap"> <span class="z-form-trigger z-form-select">
                              <input type="text" value="" disabled="disabled" class="z-form-text" />
                              <a class="z-btn-trigger" href="javascript:void(0)">&nbsp;</a> </span>
                              <div style="display: none;" class="z-select-box z-box">
                                <div class="z-box-t"><span>&nbsp;</span></div>
                                <div class="z-box-c">
                                  <div class="z-box-m">
                                    <ul class="z-list">
                                      <li class="current"><a title="请选择" href="#">请选择</a></li>
                                      <li><a title="个人" href="#">个人</a></li>
                                      <li><a title="部门" href="#">部门</a></li>
                                      <li><a title="项目" href="#">项目</a></li>
                                    </ul>
                                  </div>
                                </div>
                                <div class="z-box-b"><span>&nbsp;</span></div>
                              </div>
                            </div></td>
                          <td class="label">关联项目</td>
                          <td><div class="z-select-box-wrap"> <span class="z-form-trigger z-form-select">
                              <input type="text" value="" disabled="disabled" class="z-form-text" />
                              <a class="z-btn-trigger" href="javascript:void(0)">&nbsp;</a> </span>
                              <div style="display: none;" class="z-select-box z-box">
                                <div class="z-box-t"><span>&nbsp;</span></div>
                                <div class="z-box-c">
                                  <div class="z-box-m">
                                    <ul class="z-list">
                                      <li class="current"><a title="请选择" href="#">请选择</a></li>
                                    </ul>
                                  </div>
                                </div>
                                <div class="z-box-b"><span>&nbsp;</span></div>
                              </div>
                            </div></td>
                        </tr>
                        <tr>
                          <td class="label">借款用途</td>
                          <td><div class="z-select-box-wrap"> <span class="z-form-trigger z-form-select">
                              <input type="text" value="" disabled="disabled" class="z-form-text" />
                              <a class="z-btn-trigger" href="javascript:void(0)">&nbsp;</a> </span>
                              <div style="display: none;" class="z-select-box z-box">
                                <div class="z-box-t"><span>&nbsp;</span></div>
                                <div class="z-box-c">
                                  <div class="z-box-m">
                                    <ul class="z-list">
                                      <li><a title="出差" href="#" onclick="popupBody('#z-jk-glcc')">出差</a></li>
                                      <li><a title="广告费" href="#" onclick="hideDiv('.z-jk-glcc')">广告费</a></li>
                                      <li><a title="推广费" href="#" onclick="hideDiv('.z-jk-glcc')">推广费</a></li>
                                      <li><a title="招待费" href="#" onclick="hideDiv('.z-jk-glcc')">招待费</a></li>
                                    </ul>
                                  </div>
                                </div>
                                <div class="z-box-b"><span>&nbsp;</span></div>
                              </div>
                            </div></td>
                        </tr>
                        <tr class="z-jk-glcc" style="display:none;">
                          <td class="label"></td>
                          <td colspan="3"><div class="z-glcc">
                              <ul class="z-glcc-list">
                                <li><a href="#" class="name">OA项目上海出差申请</a><a href="#" class="del"></a></li>
                                <li><a href="#" class="name">HR项目上海出差申请</a><a href="#" class="del"></a></li>
                              </ul>
                              <p class="z-glcc-oper mr15"><a href="#" class="name" onclick="popupBody('#z-jk-glcc')">关联出差</a></p>
                            </div></td>
                        </tr>
                        <tr>
                          <td class="label">申请事由</td>
                          <td colspan="3"><textarea class="z-form-textarea"></textarea></td>
                        </tr>
                        <tr>
                          <td class="label">附件</td>
                          <td colspan="3"><div class="z-affix z-affix-icon-show"> <a onclick="showDiv('#z-affix-upload')" href="javascript:void(0)" class="z-affix-icon">添加附件</a></div></td>
                        </tr>
                      </tbody>
                    </table>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="z-form-bl">
        <div class="z-form-br">
          <div class="z-form-bc">&nbsp;</div>
        </div>
      </div>
    </div>
  </div>
</div>

<div id="imBOX" class="z-window x-window-fixed" style="display:none;"> 
    <img alt="" src="frame/images/imBOX.png" border="0" usemap="#MapimBOX" />
    <map name="MapimBOX" id="MapimBOX">
        <area onclick="closePopup(this)" shape="rect" coords="393,3,422,30" href="#" />
    </map>
</div>

<script type="text/javascript">
    $(document).ready(function() {
        ajaxloading('map', 'map/map.html', '实时监控');
    })
</script>
</form>
</body>
</html>