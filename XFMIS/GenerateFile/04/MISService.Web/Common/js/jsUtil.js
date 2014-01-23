//+---------------------------------------------
//| js������
//| Create By:2009-4-20
//| Author:YuBing
//+---------------------------------------------

//+---------------------------------------------
//| ��Date/String����,����ΪString����. 
//| ����String����,���Ƚ���ΪDate���� 
//| ����ȷ��Date,���� '' 
//| ���ʱ�䲿��Ϊ0,�����,ֻ�������ڲ���. 
//+---------------------------------------------
function formatDate(v){  
    if(typeof v == 'string') v = parseDate(v);  
    if(v instanceof Date){  
     var y = v.getFullYear();  
     var m = v.getMonth() + 1;  
     var d = v.getDate();  
     var h = v.getHours();  
     var i = v.getMinutes();  
     var s = v.getSeconds();  
     var ms = v.getMilliseconds();     
     if(ms>0) return y + '-' + m + '-' + d + ' ' + h + ':' + i + ':' + s + '.' + ms;  
     if(h>0 || i>0 || s>0) return y + '-' + m + '-' + d + ' ' + h + ':' + i + ':' + s;  
     return y + '-' + m + '-' + d;  
    }  
    return '';  
}  



//+---------------------------------------------------  
//| �ַ���ת����������   
//| ��ʽ MM/dd/YYYY MM-dd-YYYY YYYY/MM/dd YYYY-MM-dd  
//+---------------------------------------------------  
function stringToDate(DateStr) {   
     if (DateStr == '' || DateStr == 'undefined') {
        return null;
     }
     var converted = Date.parse(DateStr);  
     var myDate = new Date(converted);  
     if (isNaN(myDate))  
     {   
         //var delimCahar = DateStr.indexOf('/')!=-1?'/':'-';  
         var arys= DateStr.split('-');  
         myDate = new Date(arys[0],--arys[1],arys[2]);  
     }  
     return myDate;  
}

//+------------------------------------------------------------
//| ��ȡһ�������
//+------------------------------------------------------------
function getRandomNumber() {
    var Timer = new Date();
    var seconds = Timer.getSeconds();
    var randomnumber = Math.floor(Math.random()*10000)+seconds;
    return randomnumber;
}

//+---------------------------------------------------  
//| �Ƚ�����ʱ��Ĵ�С   
//| time1 < time2 return -1;
//| time1 == time2 return 0;
//| time1 > time2 return 1;
//+--------------------------------------------------- 
function compareDate(time1, time2) {
    var i = time1 - time2;
    if (i < 0)
        return -1;
    if (i > 0)
        return 1;
    return 0;
}

//+---------------------------------------------------  
//| request����
//+--------------------------------------------------- 
function request(strName) {
    var strHref = window.document.location.href;
    var intPos = strHref.indexOf("?");
    var strRight = strHref.substr(intPos + 1);

    var arrTmp = strRight.split("&");
    for(var i = 0; i < arrTmp.length; i++)
    {
        var arrTemp = arrTmp[i].split("=");

        if(arrTemp[0].toUpperCase() == strName.toUpperCase()) return arrTemp[1];
    }
    return "";
}

//+---------------------------------------------------  
//| string.Trim()
//+--------------------------------------------------- 
String.prototype.trim = function() {
    return this.replace(/(^\s*)|(\s*$)/g, "");
}

String.prototype.lTrim = function() {
    return this.replace(/(^\s*)/g, "");
}

String.prototype.rTrim = function() {
    return this.replace(/(\s*$)/g, "");
}
//+---------------------------------------------------  
//| End
//+--------------------------------------------------- 


//+---------------------------------------------------  
//| �ı���ֻ��������Ч���֣��磺123;   123.456;  etc....
//| ʾ����<input type="text" onkeypress="keypressNumeric(this)" onkeyup="keyupNumeric(this)" onblur="blurNumreic(this)">
//+--------------------------------------------------- 

function keypressNumeric(obj) {
	if(!obj.value.match(/^[\+\-]?\d*?\.?\d*?$/))
		obj.value=obj.t_value;
	else 
		obj.t_value=obj.value;
	if(obj.value.match(/^(?:[\+\-]?\d+(?:\.\d+)?)?$/))
		obj.o_value=obj.value
}

function keyupNumeric(obj) {
	if(!obj.value.match(/^[\+\-]?\d*?\.?\d*?$/))
		obj.value=obj.t_value;
	else obj.t_value=obj.value;
	if(obj.value.match(/^(?:[\+\-]?\d+(?:\.\d+)?)?$/))
		obj.o_value=obj.value
}

function blurNumreic(obj) {
	 if(!obj.value.match(/^(?:[\+\-]?\d+(?:\.\d+)?|\.\d*?)?$/))
	 	obj.value=obj.o_value;
	else {
		if(obj.value.match(/^\.\d+$/))
			obj.value=0+obj.value;
		if(obj.value.match(/^\.$/))
			obj.value=0;
		obj.o_value=obj.value
	}
}

//+---------------------------------------------------  
//| End
//+--------------------------------------------------- 

//+---------------------------------------------------  
//| Validate.RegExp
//+--------------------------------------------------- 
/* ƥ������ */
var regChinese = /[\u4e00-\u9fa5]/
/* ƥ��հ��� */
var regSpace = /\n\s*\r/
/* ƥ����β�հ��ַ� */
var regFirstLastSpace = /^\s*|\s*$/
/* ƥ��Email��ַ */
var regEmail = /\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*/
/* ƥ����ַURL */
var regURL = /[a-zA-z]+:\/\/[^\s]*/
/* ƥ���ʺ��Ƿ�Ϸ�(��ĸ��ͷ������5-16�ֽڣ�������ĸ�����»���) */
var regAccount = /^[a-zA-Z][a-zA-Z0-9_]{4,15}$/
/* ƥ����ڵ绰���� */
var regPhoneNumber = /\d{3}-\d{8}|\d{4}-\d{7}/
/* ƥ���й��������� */
var regPostCode = /[1-9]\d{5}(?!\d)/
/* ƥ�����֤ */
var regIDCard = /^[\d]{15}$|^[\d]{17}[\dx]{1}$/
/* ƥ��ipv4��ַ */
var regIPV4Address = /^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$/
/* ƥ��ipv6��ַ */
var regIPV6Address = /^((([0-9A-Fa-f]{1,4}:){7}[0-9A-Fa-f]{1,4})|(([0-9A-Fa-f]{1,4}:){6}:[0-9A-Fa-f]{1,4})|(([0-9A-Fa-f]{1,4}:){5}:([0-9A-Fa-f]{1,4}:)?[0-9A-Fa-f]{1,4})|(([0-9A-Fa-f]{1,4}:){4}:([0-9A-Fa-f]{1,4}:){0,2}[0-9A-Fa-f]{1,4})|(([0-9A-Fa-f]{1,4}:){3}:([0-9A-Fa-f]{1,4}:){0,3}[0-9A-Fa-f]{1,4})|(([0-9A-Fa-f]{1,4}:){2}:([0-9A-Fa-f]{1,4}:){0,4}[0-9A-Fa-f]{1,4})|(([0-9A-Fa-f]{1,4}:){6}((\b((25[0-5])|(1\d{2})|(2[0-4]\d)|(\d{1,2}))\b)\.){3}(\b((25[0-5])|(1\d{2})|(2[0-4]\d)|(\d{1,2}))\b))|(([0-9A-Fa-f]{1,4}:){0,5}:((\b((25[0-5])|(1\d{2})|(2[0-4]\d)|(\d{1,2}))\b)\.){3}(\b((25[0-5])|(1\d{2})|(2[0-4]\d)|(\d{1,2}))\b))|(::([0-9A-Fa-f]{1,4}:){0,5}((\b((25[0-5])|(1\d{2})|(2[0-4]\d)|(\d{1,2}))\b)\.){3}(\b((25[0-5])|(1\d{2})|(2[0-4]\d)|(\d{1,2}))\b))|([0-9A-Fa-f]{1,4}::([0-9A-Fa-f]{1,4}:){0,5}[0-9A-Fa-f]{1,4})|(::([0-9A-Fa-f]{1,4}:){0,6}[0-9A-Fa-f]{1,4})|(([0-9A-Fa-f]{1,4}:){1,7}:))$/

//+---------------------------------------------------  
//| End
//+--------------------------------------------------- 

//+---------------------------------------------------  
//| $
//+--------------------------------------------------- 
function $( elementId ) {
  return document.getElementById(elementId);
} 
//+---------------------------------------------------  
//| End
//+--------------------------------------------------- 