using System;
using System.Data;
using System.Configuration;
using System.IO;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Castle.Core.Resource;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;
using log4net.Config;

/// <summary>
/// GlobalApplication 的摘要说明
/// </summary>

public class GlobalApplication : HttpApplication, IContainerAccessor
{

    private static IWindsorContainer windsorContainer;
    /// <summary>
    /// 
    /// </summary>
    public IWindsorContainer Container
    {
        get { return windsorContainer; }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void Application_Start(object sender, EventArgs e)
    {
        windsorContainer = new WindsorContainer(new XmlInterpreter());
        string mapPath = Server.MapPath("Config") + "\\log4net.config";
        FileInfo file = new FileInfo(mapPath);
        XmlConfigurator.Configure();
    }
    /// <summary>
    /// 转换权限(涂首豪 2009-04-14）
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Application_AuthorizeRequest(object sender, System.EventArgs e)
    {
        HttpApplication App = (HttpApplication)sender;
        HttpContext Ctx = App.Context; //获取本次Http请求相关的HttpContext对象
        if (Ctx.Request.IsAuthenticated == true) //验证过的用户才进行role的处理
        {
            FormsIdentity Id = (FormsIdentity)Ctx.User.Identity;
            FormsAuthenticationTicket Ticket = Id.Ticket; //取得身份验证票
            string[] Roles = Ticket.UserData.Split(','); //将身份验证票中的role数据转成字符串数组
            /// Ctx.Response.Write(Ticket.UserData);
            Ctx.User = new System.Security.Principal.GenericPrincipal(Id, Roles); //将原有的Identity加上角色信息新建一个GenericPrincipal表示当前用户,这样当前用户就拥有了role信息
        }
    }





    public void Application_End(object sender, EventArgs e)
    {
        windsorContainer.Dispose();
    }

    public void Application_Error(object sender, EventArgs e) { }

    public void Session_Start(object sender, EventArgs e) { }

    public void Session_End(object sender, EventArgs e)
    {
    }



}



