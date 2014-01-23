using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;

namespace MISWebService
{
    public class Global : HttpApplication, IContainerAccessor
    {

        private static IWindsorContainer _windsorContainer;
        private static bool _reged = false;
        public static bool Reged
        {
            get { return _reged; }
            set { _reged = value; }
        }

        public IWindsorContainer Container
        {
            get { return _windsorContainer; }
        }

        public Global()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        public void Application_Start(object sender, EventArgs e)
        {
            try
            {

                // 在应用程序启动时运行的代码
                XmlInterpreter xml = new XmlInterpreter();
                _windsorContainer = new WindsorContainer(xml);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public void Application_End(object sender, EventArgs e)
        {
            //  在应用程序关闭时运行的代码
            _windsorContainer.Dispose();
        }

        public void Application_Error(object sender, EventArgs e)
        {
            // 在出现未处理的错误时运行的代码

        }

        public void Session_Start(object sender, EventArgs e)
        {
            // 在新会话启动时运行的代码

        }

        void Session_End(object sender, EventArgs e)
        {
            // 在会话结束时运行的代码。 
            // 注意: 只有在 Web.config 文件中的 sessionstate 模式设置为
            // InProc 时，才会引发 Session_End 事件。如果会话模式设置为 StateServer 
            // 或 SQLServer，则不会引发该事件。

        }
    }
}