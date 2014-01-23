using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Web;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;

namespace MISLogic.BaseClass
{
    class ContainerAccessorUtil
    {
        private ContainerAccessorUtil()
        {

        }

        public static IWindsorContainer GetContainer()
        {
            string isWeb = System.Configuration.ConfigurationManager.AppSettings["IsWeb"];
            return isWeb == "Yes" ? GetHttpContainer() : GetClassContainer();
        }

        #region Web方式

        private static IWindsorContainer GetHttpContainer()
        {
            IContainerAccessor containerAccessor = HttpContext.Current.ApplicationInstance as IContainerAccessor;

            if (containerAccessor == null)
            {
                throw new Exception("You must extend the HttpApplication in your web project " +
                    "and implement the IContainerAccessor to properly expose your container instance");
            }

            IWindsorContainer container = containerAccessor.Container as IWindsorContainer;

            if (container == null)
            {
                throw new Exception("The container seems to be unavailable in " +
                    "your HttpApplication subclass");
            }

            return container;
        }

        #endregion

        #region 类库方式

        private static readonly IWindsorContainer _container = new WindsorContainer(new XmlInterpreter());

        private static IWindsorContainer GetClassContainer()
        {
            return _container;
        }

        #endregion
    }
}
