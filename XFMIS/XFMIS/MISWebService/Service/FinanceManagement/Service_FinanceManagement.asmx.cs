using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MISEntity.Entity;
using MISLogic.Implement;
using MISLogic.Interface;
using System.Collections;

namespace MISWebService.Service.FinanceManagement
{
    /// <summary>
    /// FinanceManagement 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class Service_FinanceManagement : System.Web.Services.WebService
    {

        #region 定义实现类
        private static readonly ITabPaymentLogic _paymentLogic = Container<ITabPaymentLogic>.Instance;
        private static readonly ITabCostAndReimburseLogic _costAndReimburseLogic = Container<ITabCostAndReimburseLogic>.Instance;
        private static readonly ITabBalanceLogic _balanceLogic = Container<ITabBalanceLogic>.Instance;
        private static readonly ITabLoanRepayLogic _loanRepayLogic = Container<ITabLoanRepayLogic>.Instance;
        private static readonly ITabSubProjectInfoLogic _subProjectInfoLogic = Container<ITabSubProjectInfoLogic>.Instance;
        private static readonly ITabDealLogic _dealLogic = Container<ITabDealLogic>.Instance;
        private static readonly ITabMoneyPoolLogic _moneyPoolLogic = Container<ITabMoneyPoolLogic>.Instance;
        #endregion

        #region 对开票回款信息的数据操作
        [WebMethod]
        public int create_TabPayment(TabPayment payment)
        {
            return _paymentLogic.Create(payment);
        }

        [WebMethod]
        public int delete_TabPayment(int id)
        {
            return _paymentLogic.Delete(id);
        }

        [WebMethod]
        public List<TabPayment> select_TabPayment_ByPID(int Id)
        {
            Hashtable ht = new Hashtable();
            ht.Add("PYPID", Id);
            return (List<TabPayment>)_paymentLogic.FindAll(ht);
        }

        [WebMethod]
        public int update_TabPayment(TabPayment payment)
        {
            return _paymentLogic.Update(payment);
        }

        [WebMethod]
        public List<TabPayment> select_TabPayment()
        {
            return (List<TabPayment>)_paymentLogic.FindAll();
        }

        [WebMethod]
        public int count_TabPayment(int subID)
        {
            Hashtable ht = new Hashtable();
            ht.Add("PYSubProjectID", subID);
            return _paymentLogic.FindCount(ht);
        }


        #endregion

        #region 对成本报账信息的数据操作
        [WebMethod]
        public int create_CostAndReimburse(TabCostAndReimburse costAndReimburse)
        {
            return _costAndReimburseLogic.Create(costAndReimburse);
        }

        [WebMethod]
        public int delete_TabCostAndReimburse(int id)
        {
            return _costAndReimburseLogic.Delete(id);
        }

        [WebMethod]
        public List<TabCostAndReimburse> select_TabCostAndReimburse_ByPID(int Id)
        {
            Hashtable ht = new Hashtable();
            ht.Add("CRPID", Id);
            return (List<TabCostAndReimburse>)_costAndReimburseLogic.FindAll(ht);
        }

        [WebMethod]
        public int update_TabCostAndReimburse(TabCostAndReimburse costAndReimburse)
        {
            return _costAndReimburseLogic.Update(costAndReimburse);
        }

        [WebMethod]
        public List<TabCostAndReimburse> select_TabCostAndReimburse()
        {
            return (List<TabCostAndReimburse>)_costAndReimburseLogic.FindAll();
        }

        [WebMethod]
        public int count_TabCostAndReimburse(int subID)
        {
            Hashtable ht = new Hashtable();
            ht.Add("CRSubProjectID", subID);
            return _costAndReimburseLogic.FindCount(ht);
        }
        #endregion

        #region 对结算信息的数据操作
        [WebMethod]
        public int create_TabBalance(TabBalance balance)
        {
            return _balanceLogic.Create(balance);
        }

        [WebMethod]
        public int delete_TabBalance(int id)
        {
            return _balanceLogic.Delete(id);
        }

        [WebMethod]
        public List<TabBalance> select_TabBalance_BySubID(int subId)
        {
            Hashtable ht = new Hashtable();
            ht.Add("BLSubProjectID", subId);
            return (List<TabBalance>)_balanceLogic.FindAll(ht);
        }

        [WebMethod]
        public int update_TabBalance(TabBalance balance)
        {
            return _balanceLogic.Update(balance);
        }

        [WebMethod]
        public List<TabBalance> select_TabBalance()
        {
            return (List<TabBalance>)_balanceLogic.FindAll();
        }

        [WebMethod]
        public int count_TabBalance(int subID)
        {
            Hashtable ht = new Hashtable();
            ht.Add("BLSubProjectID", subID);
            return _balanceLogic.FindCount(ht);
        }
        #endregion

        #region 对借还款的数据操作
        [WebMethod]
        public int create_TabLoanRepay(TabLoanRepay loanRepay)
        {
            return _loanRepayLogic.Create(loanRepay);
        }

        [WebMethod]
        public int delete_TabLoanRepay(int id)
        {
            return _loanRepayLogic.Delete(id);
        }

        [WebMethod]
        public List<TabLoanRepay> select_TabLoanRepay_BySubID(int subId)
        {
            Hashtable ht = new Hashtable();
            ht.Add("LRSubProjectID", subId);
            return (List<TabLoanRepay>)_loanRepayLogic.FindAll(ht);
        }

        [WebMethod]
        public int update_TabLoanRepay(TabLoanRepay loanRepay)
        {
            return _loanRepayLogic.Update(loanRepay);
        }

        [WebMethod]
        public List<TabLoanRepay> select_TabLoanRepay()
        {
            return (List<TabLoanRepay>)_loanRepayLogic.FindAll();
        }

        [WebMethod]
        public int count_TabLoanRepay(int subID)
        {
            Hashtable ht = new Hashtable();
            ht.Add("LRSubProjectID", subID);
            return _loanRepayLogic.FindCount(ht);
        }
        #endregion

        #region 对资金池的数据操作
        [WebMethod]
        public int create_MoneyPool(TabMoneyPool pool)
        {
            return _moneyPoolLogic.Create(pool);
        }

        [WebMethod]
        public int delete_MoneyPool(int id)
        {
            return _moneyPoolLogic.Delete(id);
        }

        [WebMethod]
        public List<TabMoneyPool> select_MoneyPool()
        {
            return (List<TabMoneyPool>)_moneyPoolLogic.FindAll();
        }

        [WebMethod]
        public int update_MoneyPool(TabMoneyPool storage)
        {
            return _moneyPoolLogic.Update(storage);
        }
        #endregion

        #region 其他
        [WebMethod]
        public List<TabSubProjectInfo> select_SubID_BySubNO(string subNO)
        {
            Hashtable ht = new Hashtable();
            ht.Add("SPNO", subNO);
            return (List<TabSubProjectInfo>)_subProjectInfoLogic.FindAll(ht);
        }

        /// <summary>
        /// 根据输入的公司名称与项目id, 查询deal表中所有相关的记录, 并返回结果集中DLMoeny字段的和
        /// </summary>
        /// <param name="companyID"></param>
        /// <param name="projectID"></param>
        /// <param name="mainOrSubProject"></param>
        /// <returns></returns>
        [WebMethod]
        public decimal get_Deal_Money_ByProjectIDAndCompanyID(int companyID, int projectID, bool mainOrSubProject)
        {
            decimal result = 0;
            List<TabSubProjectInfo> allRelateSubProjectInfo = new List<TabSubProjectInfo>();
            if (mainOrSubProject)//显示主项目数据
            {
                Hashtable ht = new Hashtable();
                ht.Add("SPProjectID", projectID);
                allRelateSubProjectInfo.AddRange((List<TabSubProjectInfo>)_subProjectInfoLogic.FindAll(ht));//查询出与此主项目有关的所有子项目
            }
            else//显示子项目数据
            {
                allRelateSubProjectInfo.Add(_subProjectInfoLogic.FindByID(projectID));
            }

            foreach (TabSubProjectInfo subProjectInfo in allRelateSubProjectInfo)
            {
                Hashtable ht = new Hashtable();
                ht.Add("DLSubProjectID", companyID);
                ht.Add("DLCompany", subProjectInfo.SPID);
                List<TabDeal> deals = (List<TabDeal>)_dealLogic.FindAll(ht);//查询出和指定公司与子项目id相关的deal记录
                foreach (TabDeal deal in deals)
                {
                    result += deal.DLMoeny.GetValueOrDefault();
                }
            }
            return result;
        }
        #endregion
    }
}
