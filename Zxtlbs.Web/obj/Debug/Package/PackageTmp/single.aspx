<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="single.aspx.cs" Inherits="Zxtlbs.Web.single" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>单独监控</title>
    <style type="text/css">
        html, body {
          height: 100%;
          margin: 0;
          padding: 0;
        }

        #map_canvas {
          height: 100%;
        }
    </style>
    <script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false"></script>
    <script type="text/javascript">
        <%=VarInit %>
        var marker,map,infowindow;
        function initialize() {
            var latlng = new google.maps.LatLng(lat, lng);
            var myOptions = {
                zoom: 15,
                center: latlng,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            }
            map = new google.maps.Map(document.getElementById("map_canvas"),myOptions);
            marker = new google.maps.Marker({
                position: latlng,
                map: map,
                id: id,
                title: name,
                icon: 'frame/images/icons/'+icon
            }); 
	        google.maps.event.addListener(marker, 'click', function (event) {
	            infowindow.setContent(getContent());
	            infowindow.open(map, marker);
	        });
            infowindow = new google.maps.InfoWindow();
	        infowindow.setContent(getContent());
	        infowindow.open(map, marker);
        }
        function getContent(){
            return '<div style="font-size:14px;line-height:22px;"><div style="font-weight:bold;">'
                    + name
                    + '</div><div>设备号码:'
                    + id
                    + '</div><div>SIM卡号:'
                    + sim
                    + '</div><div>设备状态:'
                    + status
                    + '</div><div>速度:'
                    + speed
                    + ' km/h</div><div>方向:'
                    + direction
                    + '</div><div>总里程:'
                    + licheng
                    + ' km</div><div>经纬度:'
                    + lng + '°E,' + lat + '°N'
                    + '</div><div>定位时间:'
                    + logintime
                    + '</div></div>';
        }
    </script>
</head>
<body onload="initialize()">
    <div id="map_canvas"></div>
</body>
</html>
