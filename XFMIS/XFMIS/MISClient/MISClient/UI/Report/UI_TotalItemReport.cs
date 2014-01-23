using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace MISClient.UI.Report
{
    public partial class UI_TotalItemReport : DevExpress.XtraReports.UI.XtraReport
    {
        Service_FinanceManagement.Service_FinanceManagement fm = new Service_FinanceManagement.Service_FinanceManagement();
        Service_ProjectManagement.Service_ProjectManagement pm = new Service_ProjectManagement.Service_ProjectManagement();

        private int projectID = 0;
        private bool mainOrSubProject = false;

        public UI_TotalItemReport(int projectID, bool mainOrSubProject)
        {
            this.projectID = projectID;
            this.mainOrSubProject = mainOrSubProject;//标记传入的projectID代表主项目(true)或者子项目(false)
            InitializeComponent();
            init();
        }

        private void init()
        {
            bindingHead();
            bindingDetail();
            xrLabel70.Text = DateTime.Now.ToShortDateString();
        }

        /// <summary>
        /// 施工单位绑定
        /// </summary>
        private void bindingDetail()
        {
            Service_ProjectManagement.TabBuildCompany[] buildCompany = null;
            if (mainOrSubProject)//显示主项目数据
            {
                List<Service_ProjectManagement.TabBuildCompany> buildCompanys = new List<Service_ProjectManagement.TabBuildCompany>();
                Service_ProjectManagement.TabSubProjectInfo[] subprojectInfos = pm.Select_SubProjectInfo_ByProjectID(projectID);
                foreach (Service_ProjectManagement.TabSubProjectInfo subprojectInfo in subprojectInfos)
                {
                    buildCompanys.AddRange(pm.Select_BuildCompanyBySubProjectID(subprojectInfo.SPID));
                }
                buildCompany = buildCompanys.ToArray();
            }
            else//显示子项目数据
            {
                buildCompany = pm.Select_BuildCompanyBySubProjectID(projectID);
            }

            for (int i = 0; i < buildCompany.Length; i++)
            {

                //向主要工作量字段中写入承包金额
                //其具体算法为:根据SubProjectID与Company, 在Deal数据表中查询关联结果, 并将结果中的DL_Moeny字段自加并返回
                buildCompany[i].BCWork = fm.get_Deal_Money_ByProjectIDAndCompanyID(buildCompany[i].BCID, projectID, mainOrSubProject).ToString();
                buildCompany[i].BCID = i + 1;//将编号变为自增的序号,这一行必须放在后面!!!
            }

            DetailReport.DataSource = buildCompany;
            xrTableCell59.DataBindings.Add("Text", DetailReport.DataSource, "BCID");//序号
            xrTableCell60.DataBindings.Add("Text", DetailReport.DataSource, "BCName");//施工单位
            xrTableCell61.DataBindings.Add("Text", DetailReport.DataSource, "BCContactor");//联系人
            xrTableCell62.DataBindings.Add("Text", DetailReport.DataSource, "BCTel");//联系方式
            xrTableCell63.DataBindings.Add("Text", DetailReport.DataSource, "BCWork");//承包金额
            xrTableCell64.DataBindings.Add("Text", DetailReport.DataSource, "BCMemo");//备注


            decimal allMoney = 0;
            foreach (Service_ProjectManagement.TabBuildCompany company in buildCompany)
            {
                decimal money = 0;
                decimal.TryParse(company.BCWork, out money);
                allMoney += money;
            }
            xrTableCell69.Text = allMoney.ToString();
        }

        /// <summary>
        /// 表头数据绑定
        /// </summary>
        private void bindingHead()
        {
            if (mainOrSubProject)//如果是主工程
            {
                Service_ProjectManagement.TabProjectInfo projectInfo = pm.Select_ProjectInfoByID(projectID);

                xrLabel3.Text = projectInfo.PName;//项目名称
                xrLabel5.Text = projectInfo.PNO;//立项编号
                xrTableCell2.Text = projectInfo.PBuilder;//建设单位
                xrTableCell4.Text = projectInfo.PState;//工程状态
                xrTableCell6.Text = projectInfo.PCustomer;//客户维度
                xrTableCell8.Text = projectInfo.PCategory;//工程类别
                xrTableCell10.Text = projectInfo.PBusinessPlan;//经营方式
                xrTableCell12.Text = projectInfo.PStartDate.GetValueOrDefault().ToShortDateString();//开工日期
                xrTableCell14.Text = projectInfo.PEndDate.GetValueOrDefault().ToShortDateString();//完工日期
                xrTableCell16.Text = projectInfo.PDesignChange;//设计更改
                xrTableCell18.Text = projectInfo.PAllocation.GetValueOrDefault().ToString();//分包费用
                xrTableCell20.Text = getManagerialFee().ToString();//管理费用
                xrTableCell22.Text = projectInfo.PCompletion; //竣工资料
                xrTableCell24.Text = projectInfo.PManager;//项目经理
                xrTableCell26.Text = projectInfo.PTel;//联系方式
                xrTableCell30.Text = projectInfo.PContractAmount.GetValueOrDefault().ToString();//合同金额
                xrTableCell32.Text = projectInfo.PAuditors.GetValueOrDefault().ToString();//审计金额
                xrTableCell34.Text = projectInfo.PRatio.GetValueOrDefault().ToString();//直接费占收比
                getBillAndPay();//开票金额,回款金额,回款率
                xrTableCell42.Text = projectInfo.PPlan.GetValueOrDefault().ToString();//直接费成本计划
                getPlanFee();//直接费报账,直接费报账率
                getBalance();//分包付款金额,付款占比
            }
            else//如果是子工程
            {
                Service_ProjectManagement.TabSubProjectInfo subProjectInfo = pm.Query_SubProjectInfo_ByID(projectID);
                Service_ProjectManagement.TabProjectInfo projectInfo = pm.Select_ProjectInfoByID(subProjectInfo.SPProjectID);

                xrLabel3.Text = subProjectInfo.SPName;//项目名称!!
                xrLabel5.Text = subProjectInfo.SPNO;//立项编号!!
                xrTableCell2.Text = projectInfo.PBuilder;//建设单位
                xrTableCell4.Text = subProjectInfo.SPState;//工程状态!
                xrTableCell6.Text = projectInfo.PCustomer;//客户维度
                xrTableCell8.Text = projectInfo.PCategory;//工程类别
                xrTableCell10.Text = projectInfo.PBusinessPlan;//经营方式
                xrTableCell12.Text = projectInfo.PStartDate.GetValueOrDefault().ToShortDateString();//开工日期
                xrTableCell14.Text = projectInfo.PEndDate.GetValueOrDefault().ToShortDateString();//完工日期
                xrTableCell16.Text = projectInfo.PDesignChange;//设计更改
                //ERRORMARK:xrTableCell18.Text = subProjectInfo.SPAllocation.GetValueOrDefault().ToString();//分包费用!!
                xrTableCell20.Text = getManagerialFee().ToString();//管理费用
                xrTableCell22.Text = projectInfo.PCompletion; //竣工资料
                xrTableCell24.Text = subProjectInfo.SPManager;//项目经理!!
                xrTableCell26.Text = subProjectInfo.SPTel;//联系方式!!
                xrTableCell30.Text = subProjectInfo.SPContractAmount.GetValueOrDefault().ToString();//合同金额!!
                xrTableCell32.Text = subProjectInfo.SPAuditors.GetValueOrDefault().ToString();//审计金额!!
                xrTableCell34.Text = subProjectInfo.SPRatio.GetValueOrDefault().ToString();//直接费占收比!!
                getBillAndPay();//开票金额,回款金额,回款率
                xrTableCell42.Text = projectInfo.PPlan.GetValueOrDefault().ToString();//直接费成本计划
                getPlanFee();//直接费报账,直接费报账率
                getBalance();//分包付款金额,付款占比
            }
        }

        /// <summary>
        /// 向表格中直接写入开票/回款金额与回款率
        /// </summary>
        private void getBillAndPay()
        {
            Service_FinanceManagement.TabPayment[] payment = null;
            if (mainOrSubProject)//显示主项目数据
            {
                List<Service_FinanceManagement.TabPayment> payments = new List<Service_FinanceManagement.TabPayment>();
                Service_ProjectManagement.TabSubProjectInfo[] subprojectInfos = pm.Select_SubProjectInfo_ByProjectID(projectID);
                payment = fm.select_TabPayment_ByPID(projectID);
                payment = payments.ToArray();
            }
            else//显示子项目数据
            {
                
            }

            decimal allBilling = 0;
            decimal allPayment = 0;
            foreach (Service_FinanceManagement.TabPayment pay in payment)
            {
                if (pay.PYBilling.HasValue)
                    allBilling += pay.PYBilling.Value;
                if (pay.PYPayment.HasValue)
                    allPayment += pay.PYPayment.Value;
            }
            xrTableCell36.Text = allBilling.ToString();//开票金额
            xrTableCell38.Text = allPayment.ToString();//回款金额
            if (allBilling <= 0)
            {
                xrTableCell40.Text = string.Empty;
            }
            else
            {
                xrTableCell40.Text = (allPayment / allBilling * 100).ToString(".000") + "%";//回款率!!
            }
        }

        /// <summary>
        /// 读取管理费用
        /// </summary>
        /// <returns></returns>
        private decimal getManagerialFee()
        {
            Service_FinanceManagement.TabCostAndReimburse[] costAndReimburse = null;
            if (mainOrSubProject)//显示主项目数据
            {
                List<Service_FinanceManagement.TabCostAndReimburse> costAndReimburses = new List<Service_FinanceManagement.TabCostAndReimburse>();
                Service_ProjectManagement.TabSubProjectInfo[] subprojectInfos = pm.Select_SubProjectInfo_ByProjectID(projectID);
                costAndReimburse = fm.select_TabCostAndReimburse_ByPID(projectID);
                costAndReimburse = costAndReimburses.ToArray();
            }
            else//显示子项目数据
            {
            }

            decimal allManagerialFee = 0;
            foreach (Service_FinanceManagement.TabCostAndReimburse car in costAndReimburse)
            {
                if (car.CRManagerialFee.HasValue)
                    allManagerialFee += car.CRManagerialFee.Value;
            }
            return allManagerialFee;
        }

        /// <summary>
        /// 写入成本计划/报账/报账率
        /// </summary>
        private void getPlanFee()
        {

            Service_FinanceManagement.TabCostAndReimburse[] costAndReimburse = null;
            if (mainOrSubProject)//显示主项目数据
            {
                List<Service_FinanceManagement.TabCostAndReimburse> costAndReimburses = new List<Service_FinanceManagement.TabCostAndReimburse>();
                Service_ProjectManagement.TabSubProjectInfo[] subprojectInfos = pm.Select_SubProjectInfo_ByProjectID(projectID);
                costAndReimburse = fm.select_TabCostAndReimburse_ByPID(projectID);
                costAndReimburse = costAndReimburses.ToArray();
            }
            else//显示子项目数据
            {
            }

            decimal allAmount = 0;
            decimal allManagerialFee = 0;
            decimal allBackAmount = 0;
            foreach (Service_FinanceManagement.TabCostAndReimburse car in costAndReimburse)
            {
                if (car.CRAmount.HasValue)
                    allAmount += car.CRAmount.Value;
                if (car.CRManagerialFee.HasValue)
                    allManagerialFee += car.CRManagerialFee.Value;
                if (car.CRBackAmount.HasValue)
                    allBackAmount += car.CRBackAmount.Value;
            }
            decimal plan = 0;
            decimal.TryParse(xrTableCell42.Text, out plan);//直接费计划
            decimal allFee = allAmount + allManagerialFee;
            xrTableCell44.Text = allFee.ToString();//直接费报账=单项工程表中的成本报账栏目中的开票金额+管理费
            if (plan <= 0)
                xrTableCell46.Text = string.Empty;
            else
                xrTableCell46.Text = (allFee / plan * 100).ToString(".000") + "%";//直接费报账率
        }

        /// <summary>
        /// 分包付款金额=结算之和
        /// 付款占比 = 分包付款金额/分包计划
        /// </summary>
        private void getBalance()
        {
            Service_FinanceManagement.TabBalance[] balance = null;
            if (mainOrSubProject)//显示主项目数据
            {
                List<Service_FinanceManagement.TabBalance> balances = new List<Service_FinanceManagement.TabBalance>();
                Service_ProjectManagement.TabSubProjectInfo[] subprojectInfos = pm.Select_SubProjectInfo_ByProjectID(projectID);
                foreach (Service_ProjectManagement.TabSubProjectInfo subprojectInfo in subprojectInfos)
                {
                    balances.AddRange(fm.select_TabBalance_BySubID(subprojectInfo.SPID));
                }
                balance = balances.ToArray();
            }
            else//显示子项目数据
            {
                balance = fm.select_TabBalance_BySubID(projectID);
            }

            decimal allPay = 0;

            foreach (Service_FinanceManagement.TabBalance ba in balance)
            {
                if (ba.BLPay.HasValue)
                    allPay += ba.BLPay.Value;
            }
            xrTableCell50.Text = allPay.ToString();//分包付款金额!!

            decimal allocation = 0;//分包计划
            decimal.TryParse(xrTableCell18.Text, out allocation);
            if (allocation <= 0)
                xrTableCell52.Text = string.Empty;
            else
                xrTableCell52.Text = (allPay / allocation * 100).ToString(".000") + "%";//付款占比!!
        }
    }
}