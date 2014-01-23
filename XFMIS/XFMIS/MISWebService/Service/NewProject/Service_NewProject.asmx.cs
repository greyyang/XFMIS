using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MISEntity.Entity;
using MISLogic.Interface;
using MISLogic.Implement;

namespace MISWebService
{
    /// <summary>
    /// Service_NewProject 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class Service_NewProject : System.Web.Services.WebService
    {
        private static readonly ITabProjectInfoLogic _projectInfoLogic = Container<ITabProjectInfoLogic>.Instance;
        private static readonly ITabSubProjectInfoLogic _subProjectInfoLogic = Container<ITabSubProjectInfoLogic>.Instance;
        private static readonly ITabImageLogic _imageLogic = Container<ITabImageLogic>.Instance;

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int add_ProjectInfo(TabProjectInfo projectInfo)
        {
            return _projectInfoLogic.Create(projectInfo);
        }

        [WebMethod]
        public int add_SubProjectInfo(TabSubProjectInfo subProjectInfo)
        {
            return _subProjectInfoLogic.Create(subProjectInfo);
        }

        [WebMethod]
        public List<TabProjectInfo> select_ProjectInfo()
        {
            return (List<TabProjectInfo>)_projectInfoLogic.FindAll();
        }

        [WebMethod]
        public List<TabSubProjectInfo> select_SubProjectInfo()
        {
            return (List<TabSubProjectInfo>)_subProjectInfoLogic.FindAll();
        }

        [WebMethod]
        public int delete_ProjectInfo(int id)
        {
            return _projectInfoLogic.Delete(id);
        }

        [WebMethod]
        public int delete_subProjectInfo(int id)
        {
            return _subProjectInfoLogic.Delete(id);
        }

        [WebMethod]
        public int update_ProjectInfo(TabProjectInfo projectInfo)
        {
            return _projectInfoLogic.Update(projectInfo);
        }

        [WebMethod]
        public int update_SubProjectInfo(TabSubProjectInfo subProjectInfo)
        {
            return _subProjectInfoLogic.Update(subProjectInfo);
        }

        [WebMethod]
        public int update_ExInfo(TabProjectInfo projectInfo)
        {
            return _projectInfoLogic.updateExInfo(projectInfo);
        }

        [WebMethod]
        public int update_Plan(TabProjectInfo projectInfo)
        {
            return _projectInfoLogic.updatePlan(projectInfo);
        }

        [WebMethod]
        public int add_Image(TabImage image)
        {
            return _imageLogic.Create(image);
        }
    }
}
