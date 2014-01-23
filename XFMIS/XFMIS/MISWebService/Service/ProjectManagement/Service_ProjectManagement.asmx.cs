using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MISEntity.Entity;
using MISLogic.Interface;
using System.Collections;

namespace MISWebService.Service.ProjectManagement
{
    /// <summary>
    /// Service_ProjectManagement 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class Service_ProjectManagement : System.Web.Services.WebService
    {
        #region 定义实现类
        private static readonly ITabSubContractorLogic _subContractorLogic = Container<ITabSubContractorLogic>.Instance;
        private static readonly ITabBusinessModeLogic _businessModeLogic = Container<ITabBusinessModeLogic>.Instance;
        private static readonly ITabCustomerLogic _customerLogic = Container<ITabCustomerLogic>.Instance;
        private static readonly ITabProjectCategoryLogic _projectCategoryLogic = Container<ITabProjectCategoryLogic>.Instance;
        private static readonly ITabProjectStateLogic _projectStateLogic = Container<ITabProjectStateLogic>.Instance;
        private static readonly ITabProjectInfoLogic _projectInfoLogic = Container<ITabProjectInfoLogic>.Instance;
        private static readonly ITabSubProjectInfoLogic _subProjectInfoLogic = Container<ITabSubProjectInfoLogic>.Instance;
        private static readonly ITabDealLogic _dealLogic = Container<ITabDealLogic>.Instance;
        private static readonly ITabStateRecordLogic _stateRecordLogic = Container<ITabStateRecordLogic>.Instance;
        private static readonly ITabMaterialLogic _materialLogic = Container<ITabMaterialLogic>.Instance;
        private static readonly ITabMaterialFlowLogic _materialFlowLogic = Container<ITabMaterialFlowLogic>.Instance;
        private static readonly ITabImageLogic _imageLogic = Container<ITabImageLogic>.Instance;
        private static readonly ITabBuildCompanyLogic _buildCompanyLogic = Container<ITabBuildCompanyLogic>.Instance;
        #endregion

        #region 对分包单位表的数据操作
        [WebMethod]
        public int add_SubContractor(TabSubContractor subContractor)
        {
            return _subContractorLogic.Create(subContractor);
        }

        [WebMethod]
        public List<TabSubContractor> Select_SubContractor()
        {
            return (List<TabSubContractor>)_subContractorLogic.FindAll();
        }

        [WebMethod]
        public int Delete_SubContractor(int id)
        {
            return _subContractorLogic.Delete(id);
        }

        [WebMethod]
        public int Update_SubContractor(TabSubContractor subContractor)
        {
            return _subContractorLogic.Update(subContractor);
        }
        #endregion

        #region 对经营模式的数据操作
        [WebMethod]
        public List<TabBusinessMode> Select_BusinessMode()
        {
            return (List<TabBusinessMode>)_businessModeLogic.FindAll();
        }

        [WebMethod]
        public int Delete_BusinessMode(int id)
        {
            return _businessModeLogic.Delete(id);
        }

        [WebMethod]
        public int Create_BusinessMode(TabBusinessMode businessMode)
        {
            return _businessModeLogic.Create(businessMode);
        }
        #endregion

        #region 对客户维度的数据操作
        [WebMethod]
        public List<TabCustomer> Select_Customer()
        {
            return (List<TabCustomer>)_customerLogic.FindAll();
        }

        [WebMethod]
        public int Delete_Customer(int id)
        {
            return _customerLogic.Delete(id);
        }

        [WebMethod]
        public int Create_Customer(TabCustomer customer)
        {
            return _customerLogic.Create(customer);
        }
        #endregion

        #region 对工程类别的数据操作
        [WebMethod]
        public List<TabProjectCategory> Select_ProjectCategory()
        {
            return (List<TabProjectCategory>)_projectCategoryLogic.FindAll();
        }
        [WebMethod]
        public int Delete_ProjectCategory(int id)
        {
            return _projectCategoryLogic.Delete(id);
        }
        [WebMethod]
        public int Create_ProjectCategory(TabProjectCategory projectCategory)
        {
            return _projectCategoryLogic.Create(projectCategory);
        }
        #endregion

        #region 对工程状态的数据操作
        [WebMethod]
        public List<TabProjectState> Select_ProjectState()
        {
            return (List<TabProjectState>)_projectStateLogic.FindAll();
        }
        [WebMethod]
        public int Delete_ProjectState(int id)
        {
            return _projectStateLogic.Delete(id);
        }
        [WebMethod]
        public int Create_ProjectState(TabProjectState projectState)
        {
            return _projectStateLogic.Create(projectState);
        }
        #endregion

        #region 对工程管理的数据操作
        /// <summary>
        /// 查询主工程信息
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<TabProjectInfo> Select_ProjectInfo()
        {
            return (List<TabProjectInfo>)_projectInfoLogic.FindAll();
        }

        /// <summary>
        /// 根据主工程ID查询主工程信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [WebMethod]
        public TabProjectInfo Select_ProjectInfoByID(int ID)
        {
            return _projectInfoLogic.FindByID(ID);
        }

        /// <summary>
        /// 根据主工程ID查询子工程
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public List<TabSubProjectInfo> Select_SubProjectInfo_ByProjectID(int id)
        {
            Hashtable ht = new Hashtable();
            ht.Add("SPProjectID", id);
            return (List<TabSubProjectInfo>)_subProjectInfoLogic.FindAll(ht);
        }

        /// <summary>
        /// 根据主工程ID删除主工程
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public int Delete_ProjectInfo_ByProjectID(int id)
        {
            return _projectInfoLogic.Delete(id);

        }

        /// <summary>
        /// 更新主工程信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        [WebMethod]
        public int Update_ProjectInfo(TabProjectInfo info)
        {
            return _projectInfoLogic.Update(info);
        }

        /// <summary>
        /// 根据子工程ID删除子工程
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public int Delete_SubProjectInfo_ByProjectID(int id)
        {
            return _subProjectInfoLogic.Delete(id);
        }

        /// <summary>
        /// 更新子工程信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        [WebMethod]
        public int Update_SubProjectInfo(TabSubProjectInfo info)
        {
            return _subProjectInfoLogic.Update(info);
        }

        /// <summary>
        /// 根据子工程ID查询子工程
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public TabSubProjectInfo Query_SubProjectInfo_ByID(int id)
        {
            return _subProjectInfoLogic.FindByID(id);
        }

        [WebMethod]
        public List<TabSubProjectInfo> Select_SubProjectInfo()
        {
            return (List<TabSubProjectInfo>)_subProjectInfoLogic.FindAll();
        }

        #endregion

        #region 对内部协议的数据操作
        [WebMethod]
        public List<TabDeal> Select_Deal()
        {
            return (List<TabDeal>)_dealLogic.FindAll();
        }
        [WebMethod]
        public int Delete_Deal(int id)
        {
            return _dealLogic.Delete(id);
        }
        [WebMethod]
        public int Create_Deal(TabDeal deal)
        {
            return _dealLogic.Create(deal);
        }
        [WebMethod]
        public int Update_Deal(TabDeal deal)
        {
            return _dealLogic.Update(deal);
        }
        [WebMethod]
        public List<TabDeal> select_Deal_BySubID(int subID)
        {
            Hashtable ht = new Hashtable();
            ht.Add("DLSubProjectID", subID);
            return (List<TabDeal>)_dealLogic.FindAll(ht);
        }
        #endregion

        #region 对工程状态记录的数据操作
        [WebMethod]
        public int Create_StateRecord(TabStateRecord stateRecord)
        {
            return _stateRecordLogic.Create(stateRecord);
        }
        [WebMethod]
        public int Delete_StateRecord(int id)
        {
            return _stateRecordLogic.Delete(id);
        }
        [WebMethod]
        public List<TabStateRecord> Select_StateRecord()
        {
            return (List<TabStateRecord>)_stateRecordLogic.FindAll();
        }
        #endregion

        #region 对材料类别的数据操作
        [WebMethod]
        public int Create_MaterialClass(TabMaterial material)
        {
            return _materialLogic.Create(material);
        }

        [WebMethod]
        public List<TabMaterial> Select_MaterialClass()
        {
            return (List<TabMaterial>)_materialLogic.FindAll();
        }

        [WebMethod]
        public TabMaterial Select_MaterialClassByID(int ID)
        {
            return (TabMaterial)_materialLogic.FindByID(ID);
        }

        [WebMethod]
        public int Delete_MaterialClass(TabMaterial material)
        {
            return _materialLogic.Delete(material.MID);
        }

        [WebMethod]
        public int Update_MaterialClass(TabMaterial material)
        {
            return _materialLogic.Update(material);
        }
        #endregion

        #region 对材料流水的数据操作
        [WebMethod]
        public int Create_MaterialFlow(TabMaterialFlow materialFlow)
        {
            int result = _materialFlowLogic.Create(materialFlow);
            RecalculateMaterialCount(materialFlow.MFMaterialID.Value);
            return result;

        }

        [WebMethod]
        public List<TabMaterialFlow> Select_MaterialFlowAll()
        {
            return (List<TabMaterialFlow>)_materialFlowLogic.FindAll();
        }

        /// <summary>
        /// 查询某项子工程相关的材料入库情况
        /// </summary>
        /// <param name="subProjectID"></param>
        /// <returns></returns>
        [WebMethod]
        public List<TabMaterialFlow> Select_MaterialFlowIn(int subProjectID)
        {
            Hashtable ht = new Hashtable();
            ht.Add("MFFlag", 1);//1为入库，0为出库
            ht.Add("MFSubProjectID", subProjectID);
            return (List<TabMaterialFlow>)_materialFlowLogic.FindAll(ht);
        }

        /// <summary>
        /// 查询某项子工程相关的材料出库情况
        /// </summary>
        /// <param name="subProjectID"></param>
        /// <returns></returns>
        [WebMethod]
        public List<TabMaterialFlow> Select_MaterialFlowOut(int subProjectID)
        {
            Hashtable ht = new Hashtable();
            ht.Add("MFFlag", 0);//1为入库，0为出库
            ht.Add("MFSubProjectID", subProjectID);
            return (List<TabMaterialFlow>)_materialFlowLogic.FindAll(ht);
        }

        [WebMethod]
        public TabMaterialFlow Select_MaterialFlowByID(int ID)
        {
            return (TabMaterialFlow)_materialFlowLogic.FindByID(ID);
        }

        [WebMethod]
        public List<TabMaterialFlow> Select_MaterialFlowByMaterialID(int MaterialID)
        {
            Hashtable ht = new Hashtable();
            ht.Add("MFMaterialID", MaterialID);
            return (List<TabMaterialFlow>)_materialFlowLogic.FindAll(ht);
        }

        [WebMethod]
        public int Delete_MaterialFlow(TabMaterialFlow materialFlow)
        {
            int materialID = _materialFlowLogic.FindByID(materialFlow.MFID).MFMaterialID.Value;
            int result = _materialFlowLogic.Delete(materialFlow.MFID);
            RecalculateMaterialCount(materialID);
            return result;
        }

        [WebMethod]
        public int Update_MaterialFlow(TabMaterialFlow materialFlow)
        {
            int result = _materialFlowLogic.Update(materialFlow);
            RecalculateMaterialCount(materialFlow.MFMaterialID.Value);
            return result;
        }

        /// <summary>
        /// 重新计算物料当前库存,并且更新到数据库
        /// </summary>
        /// <param name="materialID"></param>
        private void RecalculateMaterialCount(int materialID)
        {
            Hashtable ht = new Hashtable();
            ht.Add("MFMaterialID", materialID);
            List<TabMaterialFlow> materialFlowList = (List<TabMaterialFlow>)_materialFlowLogic.FindAll(ht);
            decimal count = 0;
            foreach (TabMaterialFlow materialFlow in materialFlowList)
            {
                count += materialFlow.MFAmount.Value;
            }
            TabMaterial material = _materialLogic.FindByID(materialID);
            material.MCount = count;
            _materialLogic.Update(material);
        }

        #endregion

        #region 对施工单位的操作
        /// <summary>
        /// 根据ID查找施工单位
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [WebMethod]
        public TabBuildCompany Select_BuildCompanyByID(int ID)
        {
            return (TabBuildCompany)_buildCompanyLogic.FindByID(ID);
        }

        /// <summary>
        /// 根据关联的子项目ID查找施工单位
        /// </summary>
        /// <param name="subProjectID"></param>
        /// <returns></returns>
        [WebMethod]
        public List<TabBuildCompany> Select_BuildCompanyBySubProjectID(int subProjectID)
        {
            Hashtable ht = new Hashtable();
            ht.Add("BCSubProjectID", subProjectID);
            return (List<TabBuildCompany>)_buildCompanyLogic.FindAll(ht);
        }
        #endregion

        #region 对合同图片的数据操作
        [WebMethod]
        public List<TabImage> Select_Image()
        {
            return (List<TabImage>)_imageLogic.FindAll();
        }

        [WebMethod]
        public List<TabImage> Select_Image_ByPID(int PID)
        {
            Hashtable ht = new Hashtable();
            ht.Add("TIProjectID",PID);
            return (List<TabImage>)_imageLogic.FindAll(ht);
        }
        #endregion
    }
}
