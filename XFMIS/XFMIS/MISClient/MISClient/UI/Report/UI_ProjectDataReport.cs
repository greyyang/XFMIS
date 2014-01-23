using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace MISClient.UI.Report
{
    public partial class UI_ProjectDataReport : DevExpress.XtraReports.UI.XtraReport
    {
        private int projectID = 0;
        private bool mainOrSubProject = false;
        Service_ProjectManagement.Service_ProjectManagement pm = new Service_ProjectManagement.Service_ProjectManagement();

        public UI_ProjectDataReport(int projectID, bool mainOrSubProject)
        {
            this.projectID = projectID;
            this.mainOrSubProject = mainOrSubProject;//标记传入的projectID代表主项目(true)或者子项目(false)
            InitializeComponent();
            init();
        }

        private void init()
        {
            bindingHead();
            bindingDetail_1();
            bindingDetail_2();
            bindingDetail_3();
            bindingDetail_4();
            xrLabel70.Text = DateTime.Now.ToShortDateString();
        }

        private void bindingHead()
        {
            if (mainOrSubProject)//如果是主工程
            {
                Service_ProjectManagement.TabProjectInfo projectInfo = pm.Select_ProjectInfoByID(projectID);
                xrLabel3.Text = projectInfo.PName;//工程名称
                xrLabel5.Text = projectInfo.PNO;//项目编号
                xrTableCell2.Text = projectInfo.PConstruction;//建设单位
                xrTableCell4.Text = projectInfo.PManager;//项目主管
                xrTableCell5.Text = projectInfo.PTel;//联系方式
                xrTableCell8.Text = projectInfo.PCustomer;//客户维度
                xrTableCell10.Text = projectInfo.PCategory;//工程类别
                xrTableCell12.Text = projectInfo.PBusinessPlan;//经营方式
                xrTableCell14.Text = projectInfo.PState;//工程状态
                xrTableCell24.Text = projectInfo.PDisclosure.GetValueOrDefault().ToShortDateString();//技术交底
                xrTableCell26.Text = projectInfo.PStartDate.GetValueOrDefault().ToShortDateString();//开工日期
                xrTableCell28.Text = projectInfo.PEndDate.GetValueOrDefault().ToShortDateString();//完工日期
                xrTableCell30.Text = projectInfo.PDesignChange;//设计变更
                xrTableCell16.Text = projectInfo.PDataIn;//资源录入
                xrTableCell18.Text = projectInfo.PCompletion;//竣工资料
                xrTableCell20.Text = projectInfo.PManager;//项目经理
                xrTableCell22.Text = projectInfo.PTel;//联系方式
            }
            else//如果是子工程
            {
                Service_ProjectManagement.TabSubProjectInfo subProjectInfo = pm.Query_SubProjectInfo_ByID(projectID);
                Service_ProjectManagement.TabProjectInfo projectInfo = pm.Select_ProjectInfoByID(subProjectInfo.SPProjectID);

                //标记有@@符号的,说明是子项目数据表中有的字段,那就用这个表中的数据咯
                xrLabel3.Text = subProjectInfo.SPName;//工程名称@@
                xrLabel5.Text = subProjectInfo.SPNO;//项目编号@@
                xrTableCell2.Text = projectInfo.PConstruction;//建设单位
                xrTableCell4.Text = subProjectInfo.SPManager;//项目主管@@
                xrTableCell5.Text = subProjectInfo.SPTel;//联系方式@@
                xrTableCell8.Text = projectInfo.PCustomer;//客户维度
                xrTableCell10.Text = projectInfo.PCategory;//工程类别
                xrTableCell12.Text = projectInfo.PBusinessPlan;//经营方式
                xrTableCell14.Text = subProjectInfo.SPState;//工程状态@@
                xrTableCell24.Text = projectInfo.PDisclosure.GetValueOrDefault().ToShortDateString();//技术交底
                xrTableCell26.Text = projectInfo.PStartDate.GetValueOrDefault().ToShortDateString();//开工日期
                xrTableCell28.Text = projectInfo.PEndDate.GetValueOrDefault().ToShortDateString();//完工日期
                xrTableCell30.Text = projectInfo.PDesignChange;//设计变更
                xrTableCell16.Text = projectInfo.PDataIn;//资源录入
                xrTableCell18.Text = projectInfo.PCompletion;//竣工资料
                xrTableCell20.Text = subProjectInfo.SPManager;//项目经理@@
                xrTableCell22.Text = subProjectInfo.SPTel;//联系方式@@
            }
        }

        /// <summary>
        /// 施工单位绑定
        /// </summary>
        private void bindingDetail_1()
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

            for (int i = 0; i < buildCompany.Length; i++)//将编号变为自增的序号
            {
                buildCompany[i].BCID = i + 1;
            }

            DetailReport.DataSource = buildCompany;
            xrTableCell37.DataBindings.Add("Text", DetailReport.DataSource, "BCID");//序号
            xrTableCell38.DataBindings.Add("Text", DetailReport.DataSource, "BCName");//施工单位
            xrTableCell39.DataBindings.Add("Text", DetailReport.DataSource, "BCWork");//主要工作量
            xrTableCell40.DataBindings.Add("Text", DetailReport.DataSource, "BCContactor");//联系人
            xrTableCell41.DataBindings.Add("Text", DetailReport.DataSource, "BCTel");//电话号码
            xrTableCell42.DataBindings.Add("Text", DetailReport.DataSource, "BCMemo");//备注
        }

        /// <summary>
        /// 入库
        /// </summary>
        private void bindingDetail_2()
        {
            //读取和项目相关的入库物料流记录
            Service_ProjectManagement.TabMaterialFlow[] materialFlowIn = null;
            if (mainOrSubProject)//显示主项目数据
            {
                List<Service_ProjectManagement.TabMaterialFlow> materialFlowIns = new List<Service_ProjectManagement.TabMaterialFlow>();
                Service_ProjectManagement.TabSubProjectInfo[] subprojectInfos = pm.Select_SubProjectInfo_ByProjectID(projectID);
                foreach (Service_ProjectManagement.TabSubProjectInfo subprojectInfo in subprojectInfos)
                {
                    materialFlowIns.AddRange(pm.Select_MaterialFlowIn(subprojectInfo.SPID));
                }
                materialFlowIn = materialFlowIns.ToArray();
            }
            else//显示子项目数据
            {
                materialFlowIn = pm.Select_MaterialFlowIn(projectID);
            }

            //将入库记录转换为临时对象数组
            List<MaterialDetailObject> materialDetails = new List<MaterialDetailObject>();
            foreach (Service_ProjectManagement.TabMaterialFlow materialFlow in materialFlowIn)
            {
                MaterialDetailObject materialDetail = new MaterialDetailObject();
                materialDetail.ID = materialFlow.MFID;//物流编号,之后会被修改为一个从1开始自增的序号
                materialDetail.Date = materialFlow.MFDatetime.GetValueOrDefault();
                materialDetail.DocumentsNo = materialDetail.ID.ToString();//单据号为物流编号,存疑
                Service_ProjectManagement.TabMaterial material = pm.Select_MaterialClassByID(materialFlow.MFMaterialID.GetValueOrDefault());
                if (null != material)
                {
                    materialDetail.Code = material.MCode;
                    materialDetail.Name = material.MName;
                    materialDetail.Type = material.MType;
                    materialDetail.Unit = material.MUnit;
                }
                materialDetail.Amount = materialFlow.MFAmount.ToString();
                materialDetail.Memo = materialFlow.MFMemo;
                materialDetails.Add(materialDetail);
            }

            for (int i = 0; i < materialDetails.Count; i++)//将编号变为自增的序号
            {
                materialDetails[i].ID = i + 1;
            }

            //数据绑定
            DetailReport1.DataSource = materialDetails;
            xrTableCell52.DataBindings.Add("Text", DetailReport1.DataSource, "ID");//序号
            xrTableCell53.DataBindings.Add("Text", DetailReport1.DataSource, "Date");//日期
            xrTableCell54.DataBindings.Add("Text", DetailReport1.DataSource, "DocumentsNo");//单据号
            xrTableCell55.DataBindings.Add("Text", DetailReport1.DataSource, "Code");//代号
            xrTableCell56.DataBindings.Add("Text", DetailReport1.DataSource, "Name");//材料名称
            xrTableCell57.DataBindings.Add("Text", DetailReport1.DataSource, "Type");//型号
            xrTableCell58.DataBindings.Add("Text", DetailReport1.DataSource, "Unit");//单位
            xrTableCell59.DataBindings.Add("Text", DetailReport1.DataSource, "Amount");//数量
            xrTableCell60.DataBindings.Add("Text", DetailReport1.DataSource, "Memo");//备注

        }

        /// <summary>
        /// 出库
        /// </summary>
        private void bindingDetail_3()
        {
            //读取和项目相关的出库物料流记录
            Service_ProjectManagement.TabMaterialFlow[] materialFlowOut = null;
            if (mainOrSubProject)//显示主项目数据
            {
                List<Service_ProjectManagement.TabMaterialFlow> materialFlowOuts = new List<Service_ProjectManagement.TabMaterialFlow>();
                Service_ProjectManagement.TabSubProjectInfo[] subprojectInfos = pm.Select_SubProjectInfo_ByProjectID(projectID);
                foreach (Service_ProjectManagement.TabSubProjectInfo subprojectInfo in subprojectInfos)
                {
                    materialFlowOuts.AddRange(pm.Select_MaterialFlowOut(subprojectInfo.SPID));
                }
                materialFlowOut = materialFlowOuts.ToArray();
            }
            else//显示子项目数据
            {
                materialFlowOut = pm.Select_MaterialFlowIn(projectID);
            }

            //将出库记录转换为临时对象数组
            List<MaterialDetailObject> materialDetails = new List<MaterialDetailObject>();
            foreach (Service_ProjectManagement.TabMaterialFlow materialFlow in materialFlowOut)
            {
                MaterialDetailObject materialDetail = new MaterialDetailObject();
                materialDetail.ID = materialFlow.MFID;//物流编号,之后会被修改为一个从1开始自增的序号
                materialDetail.Date = materialFlow.MFDatetime.GetValueOrDefault();
                materialDetail.DocumentsNo = materialDetail.ID.ToString();//单据号为物流编号,存疑
                Service_ProjectManagement.TabMaterial material = pm.Select_MaterialClassByID(materialFlow.MFMaterialID.GetValueOrDefault());
                if (null != material)
                {
                    materialDetail.Code = material.MCode;
                    materialDetail.Name = material.MName;
                    materialDetail.Type = material.MType;
                    materialDetail.Unit = material.MUnit;
                }
                materialDetail.Amount = materialFlow.MFAmount.ToString();
                materialDetail.Memo = materialFlow.MFMemo;
                materialDetails.Add(materialDetail);
            }

            for (int i = 0; i < materialDetails.Count; i++)//将编号变为自增的序号
            {
                materialDetails[i].ID = i + 1;
            }

            //数据绑定
            DetailReport2.DataSource = materialDetails;
            xrTableCell70.DataBindings.Add("Text", DetailReport2.DataSource, "ID");//序号
            xrTableCell71.DataBindings.Add("Text", DetailReport2.DataSource, "Date");//日期
            xrTableCell72.DataBindings.Add("Text", DetailReport2.DataSource, "DocumentsNo");//单据号
            xrTableCell73.DataBindings.Add("Text", DetailReport2.DataSource, "Code");//代号
            xrTableCell74.DataBindings.Add("Text", DetailReport2.DataSource, "Name");//材料名称
            xrTableCell75.DataBindings.Add("Text", DetailReport2.DataSource, "Type");//型号
            xrTableCell76.DataBindings.Add("Text", DetailReport2.DataSource, "Unit");//单位
            xrTableCell77.DataBindings.Add("Text", DetailReport2.DataSource, "Amount");//数量
            xrTableCell78.DataBindings.Add("Text", DetailReport2.DataSource, "Memo");//领料单位


        }

        /// <summary>
        /// 库存
        /// </summary>
        private void bindingDetail_4()
        {
            DetailReport3.Visible = false;
        }
    }

    /// <summary>
    /// 临时类
    /// </summary>
    public class MaterialDetailObject
    {
        public MaterialDetailObject()
        {
            ID = 0;
            Date = DateTime.MinValue;
            DocumentsNo = string.Empty;
            Code = string.Empty;
            Name = string.Empty;
            Type = string.Empty;
            Unit = string.Empty;
            Amount = string.Empty;
            Memo = string.Empty;
        }
        public int ID { get; set; }//序号
        public DateTime Date { get; set; }//日期
        public string DocumentsNo { get; set; }//单据号
        public string Code { get; set; }//代号
        public string Name { get; set; }//材料名称
        public string Type { get; set; }//型号
        public string Unit { get; set; }//单位
        public string Amount { get; set; }//数量
        public string Memo { get; set; }//备注,在出库时为领料单位
    }
}