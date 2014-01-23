/**
 * @author YuBing
 */
/*
*  根据不同的浏览器，获取Ajax对象
*/
function getAjaxObject() {
	var xmlHttpRequest;
	//  判断是否把XMLHttpRequest实现为一个本地javascript对象
	if(window.XMLHttpRequest){
	xmlHttpRequest = new XMLHttpRequest();
	}else if(window.ActiveXObject){  //  判断是否支持ActiveX控件
	try{
	  //  通过实例化ActiveXObject的一个新实例来创建XMLHttpRequest对象
	    xmlHttpRequest = new ActiveXObject("Microsoft.XMLHTTP");  //  msxml3以上版本
	}catch(e){
	    try{
	      //  通过实例化ActiveXObject的一个新实例来创建XMLHttpRequest对象
	      xmlHttpRequest = new ActiveXObject("Msxml2.XMLHTTP");  //  msxml3以下版本
	      }catch(e){}
		}
	}
	if ( !xmlHttpRequest ) {
	  alert("创建Ajax对象失败，您将无法正常浏览网页");
	}
	return xmlHttpRequest;
} 