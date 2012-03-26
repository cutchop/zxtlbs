if($.browser.msie && $.browser.version=='6.0'){
	 var str='暂时不支持IE6，请使用火狐或者IE6.0以上版本的高级浏览器浏览！';
	 alert(str);
}	


function maxIndex(cls){
	var namecls = (arguments.length<1) ? 'ajaxWindow' : cls;
	
	var num = 1;
	var _this=$('.'+namecls);
	for(var i=0;i<_this.length;i++){
		if(_this.eq(i).css('z-index') > num ){
			num=parseInt(_this.eq(i).css('z-index'));
		}
	}
	num+=1;
	return num;
}

function ajaxloading(id,htmlURL,text){
	$('.popupBg').remove();
	
	var _popUplength = $('body > .popUp').length;
	for(var i=0;i<_popUplength;i++){
	    var _this = $('body > .popUp').eq(i);
		if(!_this.hasClass('x-window-fixed')){
		    _this.remove();
		}
	}
	
	$('#nav_'+id).addClass('yy_active').siblings().removeClass('yy_active');

	var content='<img class="loading" src="common/images/loading.gif">';
	
	if($('.ajaxWindow').length<1){
	    var bodyht=$(window).height()-70-5-20,
	        n=$('.ajaxWindow').length,
	        _str = '<div id="'+id+'" style="width:100%;top:68px;left:0;z-index:'+maxIndex()+'" class="window ajaxWindow"><div class="window-body"><div class="window-tl"><div class="window-tr"><div class="window-t">'+
	    '</div></div></div><div class="window-l"><div class="window-r"><div class="window-c" style="height:'+bodyht+'px">'+content+
	    '</div></div></div><div class="window-bl"><div class="window-br"><div class="window-b">&nbsp;</div></div></div></div></div>';
	
	    $(document.body).append(_str);
	}else{
	    $('.ajaxWindow').attr('id',id);
		$('.window-c').html(content);
	}


	if(arguments[3] && arguments[3] instanceof Array){
	    var _arr = arguments[3];
	}
	
	setTimeout(function(){
        $('#'+id).find('.window-c').load(htmlURL,function(){
		    init();
			
			if(_arr){
				var i =0;
				 for(i;i<_arr.length;i++){
					eval(_arr[i]);
				 }   
		    }
		})
	},250)
}

function showNavTree(name){
	$('.z-pm-sub').show().siblings().hide();
	if($(name).parents('.navsub-div').length){
	  $(name).parents('.navwrap').css('margin-left','-173px');
	 }else{
	  $(name).parents('.navwrap').css('margin-left','0');	 
     }
	 
	/*$('.navwrap').css('margin-left','-173px');*/
	$('.nav-tree li a').removeClass('nav-a-active');
	$('.navsub-div').hide();
	
	$(name).parents('.navsub-div').show();
	$(name).parents('.navmain').show().siblings().hide();
	$(name).addClass('nav-a-active').parents('.navsub-div').show().prev().addClass('nav-a-active');
	$(name).parents('.nav-tree-li').each(function(){
	    $(this).addClass('nav-tree-parent')
		$(this).children('h3').addClass('nav-h3-active');
		$(this).children('.nav-tree-ul').addClass('nav-tree-ul-show');
	})
}

function sysinfo(){
	setTimeout(function(){
		$('#xtxx2').css('display','block');
		
		var _sysinfo=$('.sysinfoIcon');
	
		setTimeout(function(){
			_sysinfo.animate({top:15},200).animate({top:0},200).animate({top:12},300).animate({top:0},300).animate({top:7},400).animate({top:0},400)
		},500)
		
		var xtxxTime=setTimeout(function(){
			$('#xtxx2').css('display','none');
		},5000)
		$('#xtxx2').mouseover(function(){
			clearTimeout(xtxxTime);
		})
	},2000)
}

$(document).ready(function(){
    //sysinfo();
	topChange.init();
})


var topChange = {
    init: function () {
        $('#topChangeMenu li').click(function () {
            $(this).addClass('active').siblings().removeClass('active');
        })

        $('.topChange .cgIcon').click(function () {
            $(this).parent().toggleClass('topChange-active');
        })

        $(document).click(function () {
            $('.topChange').removeClass('topChange-active');
            $('#topChangeMenu').hide();
        })
    },
    bind: function () {
        $('#headerBottom').bind('mouseover', function () {
            if ($("#headerTop").css('display') == 'none') {
                $("#headerTop").slideDown("slow");
            }
        });
        $('.ajaxWindow').bind('mouseover', function () {
            if ($("#headerTop").css('display') !== 'none') {
                $("#headerTop").slideUp("slow");
            }
        })
    },
    unbind: function () {
        $('#headerBottom').unbind();
        $('.ajaxWindow').unbind();
    },
    Max: function () {
        $('#topChangeMenu').hide();
        $('.topChange').removeClass('topChange-active');
        topChange.unbind();
        $('.userlogin2').attr('src', 'frame/images/userlogin2.png');
        $('#header').attr('class', 'headerMax');
        $('.window').css({ 'top': '68px' });
        $('.window-c').css({ 'height': $(window).height() - 70 - 5 - 20 });
        $('#headerTop').show();
        if (heightchange) {
            heightchange($(window).height() - 70 - 5 - 20);
        }
    },
    Min: function () {
        $('#topChangeMenu').hide();
        $('.topChange').removeClass('topChange-active');
        topChange.unbind();
        $('.userlogin2').attr('src', 'frame/images/userlogin2_min.png');
        $('#header').attr('class', 'headerMin');
        $('.window').css({ 'top': '36px' });
        $('.window-c').css({ 'height': $(window).height() - 70 - 5 - 20 + 34 });
        $('#headerTop').show();
        if (heightchange) {
            heightchange($(window).height() - 70 - 5 - 20 + 34);
        }
    },
    Hide: function () {
        $('#topChangeMenu').hide();
        $('.topChange').removeClass('topChange-active');
        $('.userlogin2').attr('src', 'frame/images/userlogin2_min.png');
        $('#header').attr('class', 'headerMin headerHide');
        $('.window').css({ 'top': '5px' });
        $('.window-c').css({ 'height': $(window).height() - 5 - 20 - 5 });
        $('#headerTop').hide();
        topChange.bind();
        if (heightchange) {
            heightchange($(window).height() - 5 - 20 - 5);
        }
    }
}












