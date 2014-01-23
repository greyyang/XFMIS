using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MISEntity.Entity;
using MISLogic.Interface;
using System.Collections;

namespace MISWebService.Service.SystemManagement
{
    /// <summary>
    /// Service_SystemManagement 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class Service_SystemManagement : System.Web.Services.WebService
    {
        #region 定义实现类
        private static readonly ITabUsersLogic _usersLogic = Container<ITabUsersLogic>.Instance;
        #endregion

        #region 对用户的操作

        [WebMethod]
        public int Create_User(TabUsers user)
        {
            return _usersLogic.Create(user);
        }

        [WebMethod]
        public int Find_UserAccount(string account)
        {
            Hashtable ht = new Hashtable();
            ht.Add("UAccount", account);
            return _usersLogic.FindCount(ht);
        }

        [WebMethod]
        public List<TabUsers> Select_UserAll()
        {
            return (List<TabUsers>)_usersLogic.FindAll();
        }

        [WebMethod]
        public TabUsers Select_User(int userID)
        {
            return (TabUsers)_usersLogic.FindByID(userID);
        }

        [WebMethod]
        public int Delete_User(TabUsers user)
        {
            return _usersLogic.Delete(user.UID);
        }

        [WebMethod]
        public int Update_User(TabUsers user)
        {
            return _usersLogic.Update(user);
        }

        [WebMethod]
        public int checkPassword(string username, string password)
        {
            Hashtable ht = new Hashtable();
            ht.Add("UAccount", username);
            ht.Add("UPassword", password);
            return _usersLogic.FindCount(ht);
        }

        [WebMethod]
        public List<TabUsers> Select_User_ByAcount(string account)
        {
            Hashtable ht = new Hashtable();
            ht.Add("UAccount", account);
            return (List<TabUsers>)_usersLogic.FindAll(ht);
        }

        #endregion
    }
}
