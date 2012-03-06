function zTab(){
    $(".z-tab li").click(function(){
		$(this).children('a').addClass('z-active');
		$(this).siblings().children('a').removeClass('z-active')
		var _index = $(this).index();
		$(this).parent().parent().children().children('.z-tab-box-content').eq(_index).show().siblings().hide();
	})
	$(".z-filter a").click(function(){
		$(this).addClass('z-active').siblings().removeClass('z-active');
	})
}


	  $('.z-list-table').each(function(){
	    var _this = $(this);
		var _th = _this.find('th');
		var _num = _th.length;
		var _str1 = '<div class="z-list-table-th-title"><span>';
		var _str2 = '</span><a href="#" class="z-list-sort-down"></a></div>';
		for(var i = 0; i<_num;i++){
		    if(_th.eq(i).text() != '' && !_th.eq(i).hasClass('z-list-table-th-none')){
			    _th.eq(i).html(_str1+_th.eq(i).text()+_str2);
			}
		}
	})

//function zShrink(){
//	$('.z-sub-payout-bg').each(function(){
//		var _this=$(this);
//		var _pShrink= _this.find('.z-sub-main-bg');
//		var str = '<div class="z-shrink"><a href="#"></a></div>';
//		$(str).appendTo(_pShrink);
//		})
//		$(".z-shrink").children('a').hide();
//		$(".z-shrink").hover(function(){
//			$(this).children('a').show();
//		  },function(){
//			$(this).children('a').hide();
//	 		});
//		$('.z-shrink').mousemove(function(e) {
//			var yy = e.originalEvent.y || e.originalEvent.layerY || 0;
//			$(this).children('a').css('top',yy + "px")
//		});
//
// }
 
 function zShrink(){
	$('.z-sub-payout-bg').each(function(){
		var _this=$(this);
		var _pShrink= _this.find('.z-sub-main-bg');
		var str = '<div class="z-shrink"></div>';
		$(str).appendTo(_pShrink);
		})
 }

function zScroll(){
    $('.z-js-scroll').each(function(){
		var _this = $(this),
		_h = _this.parents('.z-js-height').height() || _this.parents('.z-sub-main').height() || _this.parents('.window-c').height();
	    if(_this.attr('rel')){
		    _h = _h - _this.attr('rel');
		}else{
		    var i = 0, _siblings = _this.siblings();
		    for(i;i<_siblings.length;i++){
		        _h -= _siblings.get(i).offsetHeight;
		    }
		}
		_this.height(_h);
	})
}

function zListScroll(){
    $('.z-list-scroll').each(function(){
	    var _this = $(this),
		_t = _this.find('.z-list-table-t'),
		_b = _this.find('.z-list-table-b'),
		//_w = _this.parents('.z-js-width').width() || _this.parents('.z-sub-main').width(),
		
		_h = _this.parents('.z-js-height').height() || _this.parents('.z-sub-main').height() || _this.parents('.window-c').height();
		
		if(_this.attr('rel')){
		    _h = _h - _this.attr('rel') - 20;
		}else{
		    var i = 0, _siblings = _this.siblings();
		    _h -= 20;
		    for(i;i<_siblings.length;i++){
		        _h -= _siblings.get(i).offsetHeight;
		    }
		}
		
		_b.height(_h);
	})
}

function zList(){
	zListScroll();
	
	 //第一个和最后一个加class	
	  $(".z-list-table thead tr th:first-child,.z-list-table tbody tr td:first-child").each(function(){
			if($(this).children().hasClass("z-checkboxStyle"))	
			$(this).addClass('z-first');
		})
	  $(".z-list-table thead tr th:last-child,.z-list-table tbody tr td:last-child").addClass('z-last');
	  $(".z-chart-table tbody tr td:last-child").addClass('z-chart-last');
	  $(".z-form-list-table thead tr th:last-child").addClass('z-last');
	  $(".z-list1 .z-list-table tbody tr:last-child").each(function(){
		$(this).addClass('z-bottom');														
		})
	 $(".z-basic-radio-wrap label:last-child,.z-basic-check-wrap label:last-child").addClass('last');
	 $(".employee-info-table tr td:last-child").addClass('last');
	  
	//th hover
	$(".z-list-table thead th").hover(function(){
		$(this).addClass("z-hover"); 
		$(this).children().children(".z-list-sort-down").show();
		$(this).children().children(".z-list-table-locking").show();
	  },function(){
		$(this).removeClass("z-hover");    
		$(this).children().children(".z-list-sort-down").hide();
		$(this).children().children(".z-list-table-locking").hide();
  });
	
	//添加排序	  
	  $('.z-list-table').each(function(){
	    var _this = $(this);
		var _th = _this.find('th');
		var _num = _th.length;
		var _str1 = '<div class="z-list-table-th-title"><span>';
		var _str2 = '</span><a href="#" class="z-list-sort-down"></a></div>';
		for(var i = 0; i<_num;i++){
		    if(_th.eq(i).text() != '' && !_th.eq(i).hasClass('z-list-table-th-none')){
			    _th.eq(i).html(_str1+_th.eq(i).text()+_str2);
			}
		}
	})
	$(".z-list-sort-down").toggle(function(){
   		$(this).addClass("z-list-sort-up");},
	function(){$(this).removeClass("z-list-sort-up");}); 
	
    //step步骤
    $(".z-step1-ul li:not('.z-step1-active')").hover(function(){
		$(this).addClass('z-step1-hover');
	},function(){
		$(this).removeClass('z-step1-hover');
		}).click(function(){$(this).addClass('z-step1-active').siblings().removeClass('z-step1-active');});
	
	 //tbody选择行
    $(".z-list-table tbody tr:not('.z-list-tips')").hover(function(){
		$(this).addClass('z-hover');
	},function(){
		$(this).removeClass('z-hover');
		}).click(function(){$(this).addClass('z-click').siblings().removeClass('z-click');});
	
	//SCM左侧 行选中
    $(".z-level-second li").hover(function(){
		$(this).addClass('z-hover');
	},function(){
		$(this).removeClass('z-hover');
		}).click(function(){$(this).addClass('z-click').siblings().removeClass('z-click');});
	
		
   //鼠标划过单元格显示操作
   $(".z-window-form tr").hover(function(){
	$(this).children().children(".z-row-oper").show();   
   },function(){
	$(this).children().children(".z-row-oper").hide();       
   })
		
	}

function zProcess(){
	$(".z-process-main-icon ul li").click(function(){
		$(this).addClass('z-click').siblings().removeClass('z-click');	
		var _index = $(this).index();
		$(this).parents('.z-process-main').find('.z-process-content-img').eq(_index).show();
	
	})
}

function zOper(){
    $(".z-oper").hover(function(){
        $(this).addClass("z-oper-hover");    
    },function(){
        $(this).removeClass("z-oper-hover");    
    }).mousedown(function(){
        $(this).addClass("z-oper-click");   
    }).mouseout(function(){
        $(this).removeClass("z-oper-click");   
    })
}


function zSearch(){
	 $(".z-search-btn-down").click(function(){
		$(this).toggleClass('z-search-btn-up');
	var _tbody = $(this).parent().parent(".z-search-condition").children().children(".z-search-box").find('tbody');
	if($(this).hasClass('z-search-btn-up')){
	 _tbody.show();
	}else{
	 _tbody.hide();
	}											
		})
	 }

/*********** 第二套非中间件表单组件 **************/
	 
function zBasic(){
    $('.z-basic-trigger .z-basic-text-disable').click(function(){
		$('.z-select-box').css('display','none');
	    var _obj = $(this).parents('.z-select-box-wrap').find('.z-select-box');
		_obj.css('display','block');
	})

    $(document).click(function(){
	    $('.z-select-box1').css('display','none');
	})
	
	$('.z-select-box-wrap1').click(function(event){
	    event.stopPropagation();
	})  
	
	$('.z-basic-trigger').click(function(){
		$('.z-select-box1').css('display','none');
	    var _obj = $(this).parents('.z-select-box-wrap1').eq(0).find('.z-select-box1');
		_obj.css('display','block');
	})
	
	/** 文本框 **/	
	$('.z-basic-input .z-basic-text').hover(function(){
		$(this).parent().addClass('z-basic-input-hover')
	 }, function(){
		 $(this).parent().removeClass('z-basic-input-hover')
	}).focus(function(){
	     $(this).parent().addClass('z-basic-input-focus')
	}).focusout(function(){
	    $(this).parent().removeClass('z-basic-input-focus')
	})
	
	$('.z-basic-trigger .z-basic-text').hover(function(){
		$(this).parent().addClass('z-basic-trigger-hover')
	}, function(){
		 $(this).parent().removeClass('z-basic-trigger-hover')
	}).focus(function(){
		$(this).parent().addClass('z-basic-trigger-focus')
	}).focusout(function(){
	    $(this).parent().removeClass('z-basic-trigger-focus')
	})
	
	$('.z-basic-trigger .z-btn-trigger').hover(function(){
	    $(this).parent().addClass('z-basic-trigger-hover')
	}, function(){
	    $(this).parent().removeClass('z-basic-trigger-hover')
	})
	
	/** 多行文本域 **/	
	 $('.z-basic-textarea').hover(function(){
		$(this).parents().addClass('z-basic-textarea-wrap-hover')
	 }, function(){
		 $(this).parents().removeClass('z-basic-textarea-wrap-hover')
	 }).focus(function(){
	    $(this).parents().addClass('z-basic-textarea-wrap-focus')
	 }).focusout(function(){
	    $(this).parents().removeClass('z-basic-textarea-wrap-focus')
	 })
	
	
	/**单选 下拉列表 **/	
	$('.z-select-box-wrap1 .z-list1 li a').click(function(){
	    if(!$(this).parents('.z-select-box-wrap1').hasClass('z-select-box-noval')){
			var _val = $(this).text();
			$(this).parents('.z-select-box-wrap1').eq(0).find('.z-basic-text').val(_val);
		}
		$(this).parents('.z-select-box1').hide();
		return false;
	})
	
    $('.z-select-box-wrap1 .z-list1 li a').click(function(){
		if(!$(this).parents('.z-select-box-wrap1').hasClass('z-select-box-noval')){												  
	    	var _val = $(this).text();
			$(this).parents('.z-select-box-wrap1').eq(0).find('.z-basic-text-disable').val(_val);
			$(this).parent("li").addClass("current").siblings("li").removeClass("current");
		}
		$(this).parents('.z-select-box1').hide();
		return false;
	})
    
	/* 部门单选、人员单选 */
    $('.z-basic-organ-wrap .z-tree-leaf a').click(function(){
		var _text = $(this).text();
		var _obj = $(this).parents('.z-basic-organ-wrap').find('.z-basic-organ .z-basic-text');
		if(_text == '请选择'){
		    _obj.addClass('z-basic-text-gray');
		}else{
	        _obj.removeClass('z-basic-text-gray');
		}
		_obj.val(_text);
		$(this).parents('.z-select-box1').hide();
	})
	
	$('.z-basic-person-wrap .z-tree-leaf a').click(function(){
		var _text = $(this).text();
		var _obj = $(this).parents('.z-basic-person-wrap').find('.z-basic-person .z-basic-text');
		if(_text == '请选择'){
		    _obj.addClass('z-basic-text-gray');
		}else{
	        _obj.removeClass('z-basic-text-gray');
		}
		_obj.val(_text);
		
		$(this).parents('.z-select-box1').hide();
	})
	
	/* 部门多选、人员多选 */
	$('.z-select-more-box1 .z-result-list li .z-row-oper').hide();
	$('.z-select-more-box1 .z-result-list li').hover(function(){
	  $(this).addClass("hover");
	  $(this).children(".z-row-oper").show();
	},function(){
	  $(this).removeClass("hover");	
	  $(this).children(".z-row-oper").hide();
	})
	
		/* 上传附件 */
	$('.z-affix-list li .z-row-oper').hide();
	$('.z-affix-list li').hover(function(){
	  $(this).addClass("hover");
	  $(this).children(".z-row-oper").show();
	},function(){
	  $(this).removeClass("hover");	
	  $(this).children(".z-row-oper").hide();
	})

}

/*********** 第一套中间件表单组件 **************/

function zForm(){
	zformSingleSelect();
	zbase();
    zidea();
	zTree();
	selectbox();
	selectboxMore();
	
	$(document.body).click(function(){
	    $('.z-select-box').css('display','none');
	})
	$('.z-select-box-wrap').click(function(event){
	    event.stopPropagation();
	})
}

/* 基础组件 */
function zbase(){
    $('.z-form-text').hover(function(){
									 
		if($(this).parent().hasClass('z-form-trigger')){
		    $(this).parent().addClass('z-form-trigger-hover')
		}else{
		    $(this).addClass('z-form-text-hover');
		}
	}, function(){
		if($(this).parent().hasClass('z-form-trigger')){
		    $(this).parent().removeClass('z-form-trigger-hover')
		}else{
		    $(this).removeClass('z-form-text-hover');
		}
	}).focus(function(){
		if($(this).parent().hasClass('z-form-trigger')){
			$(this).blur();
		}else{
		    $(this).addClass('z-form-text-focus');
		}
		}).focusout(function(){
		if($(this).parent().hasClass('z-form-trigger')){
		    $(this).parent().removeClass('z-form-trigger-focus')
		}else{
		    $(this).removeClass('z-form-text-focus');
		}
	})
	
	$('.z-form-trigger .z-btn-trigger').hover(function(){
		if($(this).parent().hasClass('z-form-trigger')){
		    $(this).parent().addClass('z-form-trigger-hover')
		}
	}, function(){
		if($(this).parent().hasClass('z-form-trigger')){
		    $(this).parent().removeClass('z-form-trigger-hover')
		}
	}).click(function(){
		$('.z-select-box').css('display','none');
	    var _obj = $(this).parents('.z-select-box-wrap').find('.z-select-box');
		_obj.css('display','block');
	})
	
	$('.z-form-trigger .z-form-text').click(function(){
		$('.z-select-box').css('display','none');
	    var _obj = $(this).parents('.z-select-box-wrap').find('.z-select-box');
		_obj.css('display','block');
	})
	
	
	$('.z-form-textarea').hover(function(){
	    $(this).addClass('z-form-textarea-hover');
	}, function(){
	    $(this).removeClass('z-form-textarea-hover');
	}).focus(function(){
	    $(this).addClass('z-form-textarea-focus');
	}).focusout(function(){
	    $(this).removeClass('z-form-textarea-focus');
	})
	
	$('.z-affix-list li').hover(function(){
	    $(this).addClass('hover');
	}, function(){
	    $(this).removeClass('hover');
	})
	
	$('.z-affix-list .z-file-del').click(function(){
	    $(this).parent().remove();
	})
	
	$('.z-image-upload').hover(function(){
	    $(this).addClass('z-image-upload-hover');
	},function(){
	    $(this).removeClass('z-image-upload-hover');
	})
	
	$('.z-select-box-time img').click(function(){
	    $(this).parents('.z-select-box-wrap').find('.z-form-text').val('2011-06-08');
	})
	
	$('.z-form-tips-del').click(function(){
	    $(this).parents('.z-form-tips').remove();
	})
	
	$('.z-form-disable').attr("disabled","disabled");
}
/* 部门单选、人员单选 */
function selectbox(){
    $('.z-form-organ-wrap .z-tree-leaf a').click(function(){
		var _text = $(this).text();
		var _obj = $(this).parents('.z-form-organ-wrap').find('.z-form-organ .z-form-text');
		if(_text == '请选择'){
		    _obj.addClass('z-form-text-gray');
		}else{
	        _obj.removeClass('z-form-text-gray');
		}
		_obj.val(_text);
		$(this).parents('.z-select-box').hide();
	})
	
	$('.z-form-person-wrap .z-tree-leaf a').click(function(){
		var _text = $(this).text();
		var _obj = $(this).parents('.z-form-person-wrap').find('.z-form-person .z-form-text');
		if(_text == '请选择'){
		    _obj.addClass('z-form-text-gray');
		}else{
	        _obj.removeClass('z-form-text-gray');
		}
		_obj.val(_text);
		
		$(this).parents('.z-select-box').hide();
	})
	
}

/* 部门多选、人员多选 */
function selectboxMore(){
	$('.z-select-more-box .z-result-list li .z-row-oper').hide();
	$('.z-select-more-box .z-result-list li').hover(function(){
	  $(this).addClass("hover");
	  $(this).children(".z-row-oper").show();
	},function(){
	  $(this).removeClass("hover");	
	  $(this).children(".z-row-oper").hide();
	})
}

/* 意见型 */
function zidea(){
    $('.z-btn-idea').click(function(){
	    $(this).next('.z-box-idea').toggle();
	})
	
	$('.z-form-textarea-idea').click(function(){
		if($(this).val() == ''){$(this).next('.z-idea-list-wrap').css('display','block')}else{$(this).next('.z-idea-list-wrap').css('display','none')}
	}).keyup(function(){
		if($(this).val() == ''){$(this).next('.z-idea-list-wrap').css('display','block')}else{$(this).next('.z-idea-list-wrap').css('display','none')}
	})
	
	$('.z-idea-list a').click(function(){
	    var _text = $(this).text();
		var _parents = $(this).parents('.z-idea-list-wrap');
		_parents.css('display','none');
		
		_parents.prev().focus().val(_text+'。');
	})
	
	$('.z-form-idea,.z-form').click(function(){
	    $(this).find('.z-idea-list-wrap')
	})
	
	$('.z-form-idea .z-box-idea .z-btn-blue').click(function(){
		var _formidea = $(this).parents('.z-form-idea');
	    var _textarea = _formidea.find('.z-form-textarea-idea');
		var _ideabox = _formidea.find('.z-form-idea-box-ul');
		var _idea = $(this).parents('.z-box-idea');
		if(_textarea.val() != ''){
			if(_formidea.hasClass('z-form-idea-add')){
				//var _first = $(this).parents('.z-box-idea').find('z-form-idea-addli');
				//_first.remove();    
			}
			var _str = '<li class="z-form-idea-addli">'+
				'<p class="z-textarea-val z-font-hwxk f16">'+_textarea.val()+'</p>'+
				'<p class="z-form-remarks">部门经理：<span class="z-font-hwxk f16 mr20">张则</span>2011-06-04 13:40:21</p>'+
			'</li>'
			    _ideabox.prepend(_str);
			    _formidea.addClass('z-form-idea-add');
		}
		_idea.hide();
	})
	
	$('.z-form-idea .z-box-idea .z-btn-gray').click(function(){
		var _idea = $(this).parents('.z-box-idea');
		_idea.hide();
	})
	
	$('.z-idea-edit').click(function(){
	     popupBody('#z-idea-editbox');
	})
}

/* 单选下拉列表 */
function zformSingleSelect(){
    $('select.z-form-single-select').each(function(){
		var _this = $(this);
	    var _option = _this.find('option');
		var _class = $(this)[0].className;
		var _str = '';
		_str += '<div class="z-select-box-wrap '+_class+'">'+
    '<span class="z-form-trigger z-form-select">'+
	    '<input type="text" class="z-form-text" value="" /><a href="javascript:void(0)" class="z-btn-trigger">&nbsp;</a>'+
    '</span>'+
	'<div class="z-select-box z-box" style="display:none">'+
		'<div class="z-box-t"><span>&nbsp;</span></div>'+
		'<div class="z-box-c"><div class="z-box-m"><ul class="z-list">';
		
		_str += '<li><a href="#">请选择</a></li>';
		for(var i=0;i<_option.length;i++){
		    _str += '<li><a href="#">'+_option.eq(i).text()+'</a></li>';
		}
		
		_str += '</ul></div></div><div class="z-box-b"><span>&nbsp;</span></div></div></div>';
		
		_this.after(_str);
		_this.remove();
	})

	$('.z-form-single-select .z-list li a').click(function(){
	    var _val = $(this).text();
		var _this = $(this).parents('.z-form-single-select').find('.z-form-text');
		if(_val == '请选择'){
		    _this.addClass('z-form-text-gray')
		}else{
		    _this.removeClass('z-form-text-gray')
		}
		
		_this.val(_val);
		$(this).parents('.z-select-box').hide();
		return false;
	})
	
	$('.z-select-box-wrap .z-list li a').click(function(){
	    var _val = $(this).text();
		var _this = $(this).parents('.z-select-box-wrap').find('.z-form-text');
		if(_val == '请选择'){
		    _this.addClass('z-form-text-gray')
		}else{
		    _this.removeClass('z-form-text-gray')
		}
		
		$(this).parent("li").addClass("current").siblings("li").removeClass("current");
		_this.val(_val);
		$(this).parents('.z-select-box').hide();
		return false;
	})
	
}
/* 结构树 */
function zTree(){
	/*$('.z-tree-active').css({'background-color':'red','background-position':'0'});*/
    $('.z-tree-li a').click(function(event){
		var _this = $(this);
		var _bg = _this.parents('.z-tree').find('.z-tree-bg');
		var _top = $(this).parent().position().top;
		_bg.css('top',_top);
		
		
	    if(!_this.parent().hasClass('z-tree-leaf')&&!_this.parent().hasClass('z-tree-none')){
			_this.toggleClass('z-tree-active');
		    _this.parent().next().toggle();
		}
		event.preventDefault();
	})
}


function navTree(){
    $('.nav-tree-li > h3 > a').click(function(){
	    var _this = $(this),
		_h3 = _this.parent(),
		_next = _this.parent().next(),
		_parent = _this.parent().parent();
		
		_parent.addClass('nav-tree-parent');

		_h3.addClass('nav-h3-active');
		_next.addClass('nav-tree-ul-show')
		
		_parent.siblings().each(function(){
			$(this).removeClass('nav-tree-parent');
			$(this).find('.nav-a-active').removeClass('nav-a-active');
			$(this).find('.nav-h3-active').removeClass('nav-h3-active');
			$(this).find('.nav-tree-ul-show').removeClass('nav-tree-ul-show');
		})
		
	})
	$('.nav-tree-leaf > a').click(function(){
		var _this = $(this);
		var _parent = _this.parent();
		
		_this.addClass('nav-a-active');
		
		_parent.siblings().each(function(){
			$(this).removeClass('nav-tree-parent');
			$(this).find('.nav-a-active').removeClass('nav-a-active');
			$(this).find('.nav-tree-ul-show').removeClass('nav-tree-ul-show');
		})
		
		if($(this).next().hasClass('navsub-div')){
			$('.navsub-div').hide();
			$(this).next().show();
		    $('.navwrap').animate({'margin-left':'-173px'},500)
		}
	})
	
	$('.navsub-return').click(function(){
	    $(this).parents('.navwrap').animate({'margin-left':0},500)
	})
}



function yyregionsecond(name){
	showOnly(name);
	$('#'+name).parents('.yy-region-tips').show();
}

function yyregion(){
    $('.yy-region-img').click(function(){
		var _offsetLeft = $(this).offset().left,
		    _offsetTop = $(this).offset().top,
		    _pWidth = $('.z-pm-yy').width(),
			_pHeight = $('.window-c').height(),
			_obj = $(this).next('.yy-region-tips'),
			_next = $(this).next().next();
			
			//alert(_offsetTop);
			
	    if(_obj && _next.hasClass('yy-region-tips-second')){
		    var _oWidth = _obj.width(),
			    _oHeight = _obj.height(),
			    _nextWidth = _next.width();

			if(_offsetLeft + 42 + _oWidth + _nextWidth > _pWidth){
				_obj.addClass('yy-region-tips-east').css({ "margin-left": -_oWidth, "width": _oWidth}).attr();
				_next.addClass('yy-region-tips-east').css({ "margin-left": - (_oWidth+_nextWidth), "width": _nextWidth});
			}
			
			var _nextHeight;
			var _child = $('.yy-region-tips-mc').children();
			for(var i=0,len=_child.length;i<len;i++){
				if(_nextHeight<_child.eq(i).height()){
				    _nextHeight = _child.eq(i).height();
				}
			}
			
			if(_offsetTop + _oHeight > _pHeight || _offsetTop + _nextHeight > _pHeight){
			    _obj.addClass('yy-region-tips-north');
				_next.addClass('yy-region-tips-north');
			}
		}else{
			var _oWidth = _obj.width(),
			    _oHeight = _obj.height();
			if(_offsetLeft + 42 + _oWidth > _pWidth){
				_obj.addClass('yy-region-tips-east').css({ "margin-left": -_oWidth, "width": _oWidth});
			}
			
			if(_offsetTop + _oHeight > _pHeight){
			    _obj.addClass('yy-region-tips-north');
			}
		}
		
		$('.yy-region-tips').not(_obj).css('display','none');
		
	    _obj.toggle();
	})
	
	$('.yy-region-tips').click(function(event){
		event.stopPropagation();
	})
	
	$('.yy-region li').click(function(event){
		if(!$(this).hasClass('yy-region-stopPropagation')){
		    $('#nav-tree_1').css('display','block').siblings().css('display','none');
		}
		event.stopPropagation();
	})
	
	$(document.body).click(function(){
	    $('.yy-region-tips').css('display','none').removeClass('yy-region-tips-east').removeClass('yy-region-tips-north');
	})		
	
	$('.yy-nav').hover(function(){
	    $(this).addClass('yy-nav-hover');
	}, function(){
	    $(this).removeClass('yy-nav-hover');
	})
	
}


/** 信息提示 **/
function zmesstip(){
	$(".z-mess-tips1 .z-mess-tips-up").hover(function(){
	  $(this).next(".z-mess-tips-div").show();
    },function(){
	  $(this).next(".z-mess-tips-div").hide();	
	})
}

/** 工作流 **/
function zWorkflow(){
	
	/** 选择人员 **/	
  $(".z-workflow-process .z-workflow-click-left").hover(function(){
	$(this).addClass("z-workflow-click-left-hover");  
  },function(){
	$(this).removeClass("z-workflow-click-left-hover");    
  })
  $(".z-workflow-process .z-workflow-click-right").hover(function(){
	$(this).addClass("z-workflow-click-right-hover");  
  },function(){
	$(this).removeClass("z-workflow-click-right-hover");    
  })
  
  $(".z-workflow-choose").hide();
  $(".z-workflow-tab li").hover(function(){
	$(this).addClass("hover"); 
  },function(){
	$(this).removeClass("hover"); 
   }).click(function(){
		$(this).addClass('already').addClass("click").siblings().removeClass("click"); 
	})
   $(".z-workflow-tab li.tab1").click(function(){
	$(this).parents(".z-workflow-process").siblings(".z-workflow-list1").show();
	$(this).parents(".z-workflow-process").siblings(".z-workflow-list3").hide();
  })
   $(".z-workflow-tab li.tab3").click(function(){
	$(this).parents(".z-workflow-process").siblings(".z-workflow-list3").show();
	$(this).parents(".z-workflow-process").siblings(".z-workflow-list1").hide();
  })
  
 $(".z-workflow-choose2 .con").hover(function(){
	$(this).addClass("con-hover");   
	$(this).children(".z-row-oper").show();
},function(){
	$(this).removeClass("con-hover"); 
	$(this).children(".z-row-oper").hide(); 
	})
  
  /** 选择人员列表 **/	
   $(".z-workflow-chooselist .chooselist2 .info").hover(function(){
	 $(this).children(".z-row-oper").show();
  },function(){
	  $(this).children(".z-row-oper").hide(); 
  })
  $(".z-workflow-chooselist .info").hover(function(){
	$(this).addClass("hover");   
  },function(){
	$(this).removeClass("hover");    
  })
  $(".z-workflow-chooselist .info").click(function(){
	$(this).addClass("click").siblings(".click").removeClass("click");   
  })
  
   /** 视图切换 **/
  $(".z-view-type1 span .chart").click(function(){
	$(this).parent("span").removeClass(); 
	$(this).parent("span").addClass("view1");   
  })
  $(".z-view-type1 span .card").click(function(){
	$(this).parent("span").removeClass(); 
	$(this).parent("span").addClass("view2");   
  })
  $(".z-view-type1 span .list").click(function(){
	$(this).parent("span").removeClass(); 
	$(this).parent("span").addClass("view3");   
  })

}



$.fn.wordLimit = function(num){	
	this.each(function(){	
		if(!num){
			var copyThis = $(this.cloneNode(true)).hide().css({
				'position': 'absolute',
				'width': 'auto',
				'overflow': 'visible'
			});	
			$(this).after(copyThis);
			if(copyThis.width()>$(this).width()){
				$(this).text($(this).text().substring(0,$(this).text().length-4));
				$(this).html($(this).html()+'...');
				copyThis.remove();
				$(this).wordLimit();
			}else{
				copyThis.remove(); //清除复制
				return;
			}	
		}else{
			var maxwidth=num;
			
			for(var i=0,_text=$(this).text(),len=_text.length;i<num;i++){
			    maxwidth+=(_text.substring(i).charCodeAt(0)<255)?0.5:0;
			}
			
			if($(this).text().length>maxwidth){
				$(this).text($(this).text().substring(0,maxwidth-1));
				$(this).html($(this).html()+'...');
			}
		}					 
	});
}




