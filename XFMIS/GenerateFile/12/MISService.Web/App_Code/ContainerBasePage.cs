using System;
using System.Reflection;
using System.Web;
using System.Web.UI;
using Castle.Windsor;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using GWEE.Logic.Interface;

/// <summary>
/// BasePage 的摘要说明
/// </summary>
public class ContainerBasePage : Page
{
    protected BindingFlags BINDING_FLAGS_SET
                = BindingFlags.Public
                | BindingFlags.SetProperty
                | BindingFlags.Instance
                | BindingFlags.SetField
                ;
    protected override void OnInit(EventArgs e)
    {
        IWindsorContainer container = ObtainContainer();

        Type type = this.GetType();

        PropertyInfo[] properties = type.GetProperties(BINDING_FLAGS_SET);

        foreach (PropertyInfo propertie in properties)
        {
            string pname = propertie.Name;

            if (container.Kernel.HasComponent(pname))
            {
                propertie.SetValue(this, container[pname], null);
            }
        }

        base.OnInit(e);
    }


    public IWindsorContainer ObtainContainer()
    {
        IContainerAccessor containerAccessor =

        HttpContext.Current.ApplicationInstance as IContainerAccessor;
        if (containerAccessor == null)
        {
            throw new ApplicationException("你必须在HttpApplication中实现接口 IContainerAccessor 暴露容器的属性");
        }

        IWindsorContainer container = containerAccessor.Container;
        if (container == null)
        {
            throw new ApplicationException("HttpApplication 得不到容器的实例");
        }
        return container;
    }
}
