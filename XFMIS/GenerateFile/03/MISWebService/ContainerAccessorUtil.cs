using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using Castle.Windsor;

namespace MISWebService
{
    public class ContainerAccessorUtil
    {
        private ContainerAccessorUtil()
        {
        }

        /// <summary>
        /// Obtain the Cuyahoga container.
        /// </summary>
        /// <returns></returns>
        public static IWindsorContainer GetContainer()
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
    } 
}