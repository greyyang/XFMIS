/**
 * @author YuBing
 */
/*
*  ���ݲ�ͬ�����������ȡAjax����
*/
function getAjaxObject() {
	var xmlHttpRequest;
	//  �ж��Ƿ��XMLHttpRequestʵ��Ϊһ������javascript����
	if(window.XMLHttpRequest){
	xmlHttpRequest = new XMLHttpRequest();
	}else if(window.ActiveXObject){  //  �ж��Ƿ�֧��ActiveX�ؼ�
	try{
	  //  ͨ��ʵ����ActiveXObject��һ����ʵ��������XMLHttpRequest����
	    xmlHttpRequest = new ActiveXObject("Microsoft.XMLHTTP");  //  msxml3���ϰ汾
	}catch(e){
	    try{
	      //  ͨ��ʵ����ActiveXObject��һ����ʵ��������XMLHttpRequest����
	      xmlHttpRequest = new ActiveXObject("Msxml2.XMLHTTP");  //  msxml3���°汾
	      }catch(e){}
		}
	}
	if ( !xmlHttpRequest ) {
	  alert("����Ajax����ʧ�ܣ������޷����������ҳ");
	}
	return xmlHttpRequest;
} 