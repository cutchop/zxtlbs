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
        var dlat = 30.556, dlng = 114.327;
        function initialize() {
            var latlng = new google.maps.LatLng(dlat, dlng);
            var myOptions = {
                zoom: 15,
                center: latlng,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            }
            var map = new google.maps.Map(document.getElementById("map_canvas"),myOptions);

//            var image = 'images/beachflag.png';
//            var beachMarker = new google.maps.Marker({
//                position: latlng,
//                map: map,
//                icon: image
//            });

            new google.maps.Marker({
                position: latlng,
                map: map
            });
        }
    </script>
</head>
<body onload="initialize()">
    <div id="map_canvas"></div>
</body>
</html>
