using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Castle.Windsor;

/// <summary>
/// Container 的摘要说明
/// </summary>
public class Container<T>
{

    private static IWindsorContainer container;
     static Container()
    {
        IContainerAccessor containerAccessor =HttpContext.Current.ApplicationInstance as IContainerAccessor;
            if (containerAccessor == null)
            {
                throw new ApplicationException("你必须在HttpApplication中实现接口 IContainerAccessor 暴露容器的属性");
            }
             container = containerAccessor.Container;
            if (container == null)
            {
                throw new ApplicationException("HttpApplication 得不到容器的实例");
            }
    }
    public static T Instance
    {
        get {
            string[] strArr = typeof(T).ToString().Split('.');
            string rt = strArr[strArr.Length - 1].Substring(1);
            return (T)container[rt];
        }
       
    }


}
	
