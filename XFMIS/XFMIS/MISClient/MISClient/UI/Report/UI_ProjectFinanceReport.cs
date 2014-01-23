using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Collections.Generic;

namespace MISClient.UI.Report
{
    public partial class UI_ProjectFinanceReport : DevExpress.XtraReports.UI.XtraReport
    {

        Service_FinanceManagement.Service_FinanceManagement fm = new Service_FinanceManagement.Service_FinanceManagement();
        Service_ProjectManagement.Service_ProjectManagement pm = new Service_ProjectManagement.Service_ProjectManagement();
        private int projectID = 0;
        private bool mainOrSubProject = false;

        public UI_ProjectFinanceReport(int projectID, bool mainOrSubProject)
        {
            this.projectID = projectID;
            this.mainOrSubProject = mainOrSubProject;//标记传入的projectID代表主项目(true)或者子项目(false)
            InitializeComponent();
            init();
        }

        private void init()
        {
            bindingDetail_1();
            bindingDetail_2();
            bindingDetail_3();
            bindingDetail_4();
            bindingHead();
            xrLabel70.Text = DateTime.Now.ToShortDateString();
        }

        /// <summary>
        /// 表头绑定
        /// </summary>
        private void bindingHead()
        {
            if (mainOrSubProject)//如果是主工程
            {
                Service_ProjectManagement.TabProjectInfo projectInfo = pm.Select_ProjectInfoByID(projectID);
                xrLabel3.Text = projectInfo.PName;//工程名称
                xrLabel5.Text = projectInfo.PNO;//项目编号
                xrLabel7.Text = projectInfo.PConstruction;//建设单位
                xrLabel9.Text = projectInfo.PBuilder;//施工单位
                xrLabel12.Text = projectInfo.PCustomer;//客户维度
                xrLabel14.Text = projectInfo.PCategory;//工程类别
                xrLabel16.Text = projectInfo.PBusinessPlan;//经营方式
                xrLabel18.Text = projectInfo.PState;//工程状态
                xrLabel20.Text = projectInfo.PContractAmount.ToString();//合同金额
                xrLabel22.Text = projectInfo.PAuditors.ToString();//审计金额
                xrLabel24.Text = projectInfo.PRatio.ToString();//成本占收比
                xrLabel26.Text = xrLabel63.Text;//开票金额
                xrLabel28.Text = xrLabel64.Text;//回款金额
                xrLabel30.Text = (decimal.Parse(xrLabel63.Text) - decimal.Parse(xrLabel64.Text)).ToString();//未回金额
                if (string.IsNullOrEmpty(xrLabel63.Text))
                {
                    xrLabel32.Text = (decimal.Parse(xrLabel64.Text) / decimal.Parse(xrLabel63.Text) * 100).ToString("0.00") + "%";//回款率
                }
                xrLabel34.Text = projectInfo.PPlan.ToString();//成本计划
                xrLabel36.Text = (decimal.Parse(xrTableCell24.Text) + decimal.Parse(xrTableCell25.Text)).ToString();//成本开票
                xrLabel38.Text = xrTableCell26.Text;//成本回款
                xrLabel40.Text = (decimal.Parse(xrLabel36.Text) - decimal.Parse(xrLabel38.Text)).ToString();//未回成本
                xrLabel42.Text = projectInfo.PAllocation.ToString();//分包计划
                xrLabel44.Text = xrTableCell45.Text;//结算金额
                xrLabel46.Text = xrTableCell25.Text;//管理费
                xrLabel48.Text = (decimal.Parse(xrTableCell66.Text) - decimal.Parse(xrTableCell67.Text)).ToString();//借款 xrLabel50.Text = (decimal.Parse(xrLabel44.Text) + decimal.Parse(xrLabel46.Text) + decimal.Parse(xrLabel48.Text)).ToString();//工程总开支
                xrLabel50.Text = (decimal.Parse(xrLabel44.Text) + decimal.Parse(xrLabel46.Text) + decimal.Parse(xrLabel48.Text)).ToString();//工程总开支
                xrLabel54.Text = (decimal.Parse(xrLabel34.Text) - decimal.Parse(xrLabel50.Text)).ToString();//工程结余

            }
            else//如果是子工程
            {
                Service_ProjectManagement.TabSubProjectInfo subProjectInfo = pm.Query_SubProjectInfo_ByID(projectID);
                Service_ProjectManagement.TabProjectInfo projectInfo = pm.Select_ProjectInfoByID(subProjectInfo.SPProjectID);

                //标记有@@符号的,说明是子项目数据表中有的字段,那就用这个表中的数据咯
                xrLabel3.Text = subProjectInfo.SPName;//工程名称@@
                xrLabel5.Text = subProjectInfo.SPNO;//项目编号@@
                xrLabel7.Text = projectInfo.PConstruction;//建设单位
                xrLabel9.Text = projectInfo.PBuilder;//施工单位
                xrLabel12.Text = projectInfo.PCustomer;//客户维度
                xrLabel14.Text = projectInfo.PCategory;//工程类别
                xrLabel16.Text = projectInfo.PBusinessPlan;//经营方式
                xrLabel18.Text = subProjectInfo.SPState;//工程状态@@
                xrLabel20.Text = subProjectInfo.SPContractAmount.ToString();//合同金额@@
                xrLabel22.Text = subProjectInfo.SPAuditors.ToString();//审计金额@@
                xrLabel24.Text = subProjectInfo.SPRatio.ToString();//成本占收比@@
                xrLabel26.Text = xrLabel63.Text;//开票金额
                xrLabel28.Text = xrLabel64.Text;//回款金额
                xrLabel30.Text = (decimal.Parse(xrLabel63.Text) - decimal.Parse(xrLabel64.Text)).ToString();//未回金额
                xrLabel32.Text = (decimal.Parse(xrLabel64.Text) / decimal.Parse(xrLabel63.Text) * 100).ToString("0.00") + "%";//回款率
                xrLabel34.Text = projectInfo.PPlan.ToString();//成本计划
                xrLabel36.Text = (decimal.Parse(xrTableCell24.Text) + decimal.Parse(xrTableCell25.Text)).ToString();//成本开票
                xrLabel38.Text = xrTableCell26.Text;//成本回款
                xrLabel40.Text = (decimal.Parse(xrLabel36.Text) - decimal.Parse(xrLabel38.Text)).ToString();//未回成本
                //ERRORMARK:xrLabel42.Text = subProjectInfo.SPAllocation.ToString();//分包计划@@
                xrLabel44.Text = xrTableCell45.Text;//结算金额
                xrLabel46.Text = xrTableCell25.Text;//管理费
                xrLabel48.Text = (decimal.Parse(xrTableCell66.Text) - decimal.Parse(xrTableCell67.Text)).ToString();//借款
                xrLabel50.Text = (decimal.Parse(xrLabel44.Text) + decimal.Parse(xrLabel46.Text) + decimal.Parse(xrLabel48.Text)).ToString();//工程总开支
                xrLabel54.Text = (decimal.Parse(xrLabel34.Text) - decimal.Parse(xrLabel50.Text)).ToString();//工程结余

            }


        }

        /// <summary>
        /// 开票/回款数据绑定
        /// </summary>
        private void bindingDetail_1()
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

            for (int i = 0; i < payment.Length; i++)//将编号变为自增的序号
            {
                payment[i].PYID = i + 1;
            }

            DetailReport.DataSource = payment;
            xrTableCell1.DataBindings.Add("Text", DetailReport.DataSource, "PYID");//序号
            xrTableCell2.DataBindings.Add("Text", DetailReport.DataSource, "PYDateTIme", "{0:yyyy年MM月dd日}");//日期
            xrTableCell3.DataBindings.Add("Text", DetailReport.DataSource, "PYWorkOrder");//单据号
            xrTableCell4.DataBindings.Add("Text", DetailReport.DataSource, "PYBilling");//开票金额
            xrTableCell5.DataBindings.Add("Text", DetailReport.DataSource, "PYPayment");//回款金额
            xrTableCell6.DataBindings.Add("Text", DetailReport.DataSource, "PYMemo");//备注

            decimal allBilling = 0;
            decimal allPayment = 0;
            foreach (Service_FinanceManagement.TabPayment pay in payment)
            {
                if (pay.PYBilling.HasValue)
                    allBilling += pay.PYBilling.Value;
                if (pay.PYPayment.HasValue)
                    allPayment += pay.PYPayment.Value;
            }
            xrLabel63.Text = allBilling.ToString();//开票小计
            xrLabel64.Text = allPayment.ToString();//回款小计
        }

        /// <summary>
        /// 成本报账
        /// </summary>
        private void bindingDetail_2()
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

            for (int i = 0; i < costAndReimburse.Length; i++)//将编号变为自增的序号
            {
                costAndReimburse[i].CRID = i + 1;
            }

            DetailReport2.DataSource = costAndReimburse;


            xrTableCell15.DataBindings.Add("Text", DetailReport2.DataSource, "CRID");//序号
            xrTableCell16.DataBindings.Add("Text", DetailReport2.DataSource, "CRDateTime", "{0:yyyy年MM月dd日}");//日期
            xrTableCell17.DataBindings.Add("Text", DetailReport2.DataSource, "CRWorkOrder");//单据号
            xrTableCell18.DataBindings.Add("Text", DetailReport2.DataSource, "CRAmount");//开票金额
            xrTableCell19.DataBindings.Add("Text", DetailReport2.DataSource, "CRManagerialFee");//管理费
            xrTableCell20.DataBindings.Add("Text", DetailReport2.DataSource, "CRBackAmount");//成本回款
            xrTableCell21.DataBindings.Add("Text", DetailReport2.DataSource, "CRBillingUnit");//开票单位
            xrTableCell22.DataBindings.Add("Text", DetailReport2.DataSource, "CRMemo");//备注

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

            xrTableCell24.Text = allAmount.ToString();//开票金额小计
            xrTableCell25.Text = allManagerialFee.ToString();//管理费小计
            xrTableCell26.Text = allBackAmount.ToString();//成本回款小计
        }

        /// <summary>
        /// 结算
        /// </summary>
        private void bindingDetail_3()
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

            for (int i = 0; i < balance.Length; i++)//将编号变为自增的序号
            {
                balance[i].BLID = i + 1;
            }

            DetailReport1.DataSource = balance;

            xrTableCell36.DataBindings.Add("Text", DetailReport1.DataSource, "BLID");//序号
            xrTableCell37.DataBindings.Add("Text", DetailReport1.DataSource, "BLDateTime", "{0:yyyy年MM月dd日}");//日期
            xrTableCell38.DataBindings.Add("Text", DetailReport1.DataSource, "BLWorkOrder");//单据号
            xrTableCell39.DataBindings.Add("Text", DetailReport1.DataSource, "BLPay");//付款金额
            xrTableCell40.DataBindings.Add("Text", DetailReport1.DataSource, "BLPayCompany");//收款单位
            xrTableCell41.DataBindings.Add("Text", DetailReport1.DataSource, "BLHandler");//经手人
            xrTableCell42.DataBindings.Add("Text", DetailReport1.DataSource, "BLBankNO");//账号
            xrTableCell43.DataBindings.Add("Text", DetailReport1.DataSource, "BLMemo");//备注

            decimal allPay = 0;

            foreach (Service_FinanceManagement.TabBalance ba in balance)
            {
                if (ba.BLPay.HasValue)
                    allPay += ba.BLPay.Value;
            }
            xrTableCell45.Text = allPay.ToString();//付款金额小计
        }

        /// <summary>
        /// 借/还款
        /// </summary>
        private void bindingDetail_4()
        {
            Service_FinanceManagement.TabLoanRepay[] loanRepay = null;

            if (mainOrSubProject)//显示主项目数据
            {
                List<Service_FinanceManagement.TabLoanRepay> loanRepays = new List<Service_FinanceManagement.TabLoanRepay>();
                Service_ProjectManagement.TabSubProjectInfo[] subprojectInfos = pm.Select_SubProjectInfo_ByProjectID(projectID);
                foreach (Service_ProjectManagement.TabSubProjectInfo subprojectInfo in subprojectInfos)
                {
                    loanRepays.AddRange(fm.select_TabLoanRepay_BySubID(subprojectInfo.SPID));
                }
                loanRepay = loanRepays.ToArray();
            }
            else//显示子项目数据
            {
                loanRepay = fm.select_TabLoanRepay_BySubID(projectID);
            }
            for (int i = 0; i < loanRepay.Length; i++)//将编号变为自增的序号
            {
                loanRepay[i].LRID = i + 1;
            }

            DetailReport3.DataSource = loanRepay;

            xrTableCell57.DataBindings.Add("Text", DetailReport3.DataSource, "LRID");//序号
            xrTableCell58.DataBindings.Add("Text", DetailReport3.DataSource, "LRDateTime", "{0:yyyy年MM月dd日}");//日期
            xrTableCell59.DataBindings.Add("Text", DetailReport3.DataSource, "LRWorkOrder");//单据号
            xrTableCell60.DataBindings.Add("Text", DetailReport3.DataSource, "LRLoan");//借款金额
            xrTableCell61.DataBindings.Add("Text", DetailReport3.DataSource, "LRRepay");//还款金额
            xrTableCell62.DataBindings.Add("Text", DetailReport3.DataSource, "LRHandler");//经手人
            xrTableCell63.DataBindings.Add("Text", DetailReport3.DataSource, "LRBankNO");//账号
            xrTableCell64.DataBindings.Add("Text", DetailReport3.DataSource, "LRMemo");//备注

            decimal allLoan = 0;
            decimal allRepay = 0;

            foreach (Service_FinanceManagement.TabLoanRepay lr in loanRepay)
            {
                if (lr.LRLoan.HasValue)
                    allLoan += lr.LRLoan.Value;
                if (lr.LRRepay.HasValue)
                    allRepay += lr.LRRepay.Value;
            }

            xrTableCell66.Text = allLoan.ToString();//借款金额小计
            xrTableCell67.Text = allRepay.ToString();//还款金额小计
        }
    }
}