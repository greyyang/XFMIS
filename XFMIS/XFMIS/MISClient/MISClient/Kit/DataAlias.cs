using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Grid;

namespace MISClient.Kit
{
    /// <summary>
    /// 初始化表头别名的方法,必须在Grid的DataSource属性被赋值的情况下使用
    /// </summary>
    public class DataAlias
    {

        public DataAlias()
        {
        }

        private static Hashtable getAliasSet_TabProjectInfo()
        {
            Hashtable ht_ProjectInfo = new Hashtable();
            string[] value = { "工程ID", "工程编号", "工程名称", "建设单位", "施工单位", "工程状态", "客户维度", "工程类别", "经营方式", "立项时间", "合同金额", "审计金额", "成本计划", "分包计划", "成本占收比", "技术交底", "开工日期", "完工日期", "设计变更", "资源录入", "竣工资料", "项目经理", "联系方式", "合同编号" };
            string[] key = { "PID", "PNO", "PName", "PConstruction", "PBuilder", "PState", "PCustomer", "PCategory", "PBusinessPlan", "PDateTime", "PContractAmount", "PAuditors", "PPlan", "PAllocation", "PRatio", "PDisclosure", "PStartDate", "PEndDate", "PDesignChange", "PDataIn", "PCompletion", "PManager", "PTel", "PTeleComNO" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_ProjectInfo.Add(key[i], value[i]);
            }
            return ht_ProjectInfo;
        }

        private static Hashtable getAliasSet_TabSubProjectInfo()
        {
            Hashtable ht_SubProjectInfo = new Hashtable();
            string[] value = { "子工程ID", "所属项目ID", "子项目编号", "子项目名称", "子项目状态", "子项目添加日期", "子项目协议金额", "子项目审计金额", "子项目成本占收比", "子项目分包计划", "子项目经理", "经理联系方式" };
            string[] key = { "SPID", "SPProjectID", "SPNO", "SPName", "SPState", "SPDate", "SPContractAmount", "SPAuditors", "SPRatio", "SPAllocation", "SPManager", "SPTel" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_SubProjectInfo.Add(key[i], value[i]);
            }
            return ht_SubProjectInfo;
        }

        private static Hashtable getAliasSet_TabStateRecord()
        {
            Hashtable ht_StateRecord = new Hashtable();
            string[] value = { "项目编号", "项目名称", "修改人", "日期", "备注", "项目状态" };
            string[] key = { "FV_PNO", "FV_PName", "FV_People", "FV_Date", "FV_Memo", "FV_State" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_StateRecord.Add(key[i], value[i]);
            }
            return ht_StateRecord;
        }

        private static Hashtable getAliasSet_ProjectFinanceView()
        {
            Hashtable ht_ProjectFinanceView = new Hashtable();
            string[] value = { "主工程ID", "工程编号", "工程名称", "工程状态", "客户维度", "工程种类", "经营方式", "添加时间", "开票金额", "回款金额", "成本金额", "报账金额", "管理费", "分包金额", "结算金额", "借款金额", "还款金额", "成本计划" };
            string[] key = { "FVP_Id", "FVP_NO", "FVP_Name", "FVP_State", "FVP_Customer", "FVP_Category", "FVP_BusinessPlan", "FVP_DateTime", "FVP_Billing", "FVP_Payment", "FVP_Amount", "FVP_BackAmount", "FVP_ManagerialFee", "FVP_Deal", "FVP_Balance", "FVP_Loan", "FVP_Repay", "FVP_Plan" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_ProjectFinanceView.Add(key[i], value[i]);
            }
            return ht_ProjectFinanceView;
        }

        private static Hashtable getAliasSet_SubProjectFinanceView()
        {
            Hashtable ht_SubProjectFinanceView = new Hashtable();
            string[] value = { "子工程ID", "子工程编号", "子工程名称", "子工程状态", "添加时间", "关联主工程ID", "开票金额", "回款金额", "成本金额", "报账金额", "管理费", "分包金额", "结算金额", "借款金额", "还款金额" };
            string[] key = { "FVSP_Id", "FVSP_NO", "FVSP_Name", "FVSP_State", "FVSP_DateTime", "FVSP_ProjectID", "FVSP_Billing", "FVSP_Payment", "FVSP_Amount", "FVSP_BackAmount", "FVSP_ManagerialFee", "FVSP_Deal", "FVSP_Balance", "FVSP_Loan", "FVSP_Repay" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_SubProjectFinanceView.Add(key[i], value[i]);
            }
            return ht_SubProjectFinanceView;
        }

        private static Hashtable getAliasSet_TabPayment()
        {
            Hashtable ht_Payment = new Hashtable();
            string[] value = { "开票回款ID", "关联子项目ID", "工单号", "开票金额", "回款金额", "结算单位", "添加时间", "备注", "标识" };
            string[] key = { "PYID", "PYSubProjectID", "PYWorkOrder", "PYBilling", "PYPayment", "PYPayCompany", "PYDateTIme", "PYMemo", "PYFlag" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_Payment.Add(key[i], value[i]);
            }
            return ht_Payment;
        }

        private static Hashtable getAliasSet_TabCostAndReimburse()
        {
            Hashtable ht_TabCandR = new Hashtable();
            string[] value = { "成本报账ID", "关联子项目ID", "工单号", "成本金额", "回款金额", "管理费", "申请人", "添加时间", "备注", "经手人", "标识" };
            string[] key = { "CRID", "CRSubProjectID", "CRWorkOrder", "CRAmount", "CRBackAmount", "CRManagerialFee", "CRPerson", "CRDateTime", "CRMemo", "CRHandler", "CRFlag" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_TabCandR.Add(key[i], value[i]);
            }
            return ht_TabCandR;
        }

        private static Hashtable getAliasSet_TabLoanRepay()
        {
            Hashtable ht_TabLR = new Hashtable();
            string[] value = { "借还款ID", "关联子项目ID", "工单号", "借款金额", "还款金额", "经手人", "借还款人", "银行账号", "添加时间", "备注", "标识" };
            string[] key = { "LRID", "LRSubProjectID", "LRWorkOrder", "LRLoan", "LRRepay", "LRHandler", "LRPerson", "LRBankNO", "LRDateTime", "LRMemo", "LRFlag" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_TabLR.Add(key[i], value[i]);
            }
            return ht_TabLR;
        }


        private static Hashtable getAliasSet_TabBP()
        {
            Hashtable ht_BP = new Hashtable();
            string[] value = { "经营方式" };
            string[] key = { "BPValue" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_BP.Add(key[i], value[i]);
            }
            return ht_BP;
        }

        private static Hashtable getAliasSet_TabCU()
        {
            Hashtable ht_CU = new Hashtable();
            string[] value = { "客户维度" };
            string[] key = { "CUValue" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_CU.Add(key[i], value[i]);
            }
            return ht_CU;
        }

        private static Hashtable getAliasSet_TabPC()
        {
            Hashtable ht_PC = new Hashtable();
            string[] value = { "工程类别" };
            string[] key = { "PCName" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_PC.Add(key[i], value[i]);
            }
            return ht_PC;
        }

        private static Hashtable getAliasSet_TabPS()
        {
            Hashtable ht_PS = new Hashtable();
            string[] value = { "工程状态" };
            string[] key = { "PSValue" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_PS.Add(key[i], value[i]);
            }
            return ht_PS;
        }

        private static Hashtable getAliasSet_TabMaterial()
        {
            Hashtable ht_M = new Hashtable();
            string[] value = { "材料名称", "材料型号", "材料单位", "材料代号", "材料备注", "材料类别", "材料库存" };
            string[] key = { "MName", "MType", "MUnit", "MCode", "MMemo", "MClass", "MCount" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_M.Add(key[i], value[i]);
            }
            return ht_M;
        }

        private static Hashtable getAliasSet_TabMF()
        {
            Hashtable ht_MF = new Hashtable();
            string[] value = { "子项目ID", "主项目ID", "进出数量", "进出判断", "材料ID", "添加时间", "注释" };
            string[] key = { "MFSubProjectID", "MFProject", "MFAmount", "MFFlag", "MFMaterialID", "MFDatetime", "MFMemo" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_MF.Add(key[i], value[i]);
            }
            return ht_MF;
        }

        private static Hashtable getAliasSet_TabSC()
        {
            Hashtable ht_SC = new Hashtable();
            string[] value = { "分包单位名称", "分包单位银行帐号", "分包单位开户行", "分包单位联系人", "分包单位联系方式" };
            string[] key = { "SCName", "SCBankAccount", "SCBank", "SCContactor", "SCTel" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_SC.Add(key[i], value[i]);
            }
            return ht_SC;
        }

        private static Hashtable getAliasSet_TabMP()
        {
            Hashtable ht_MP = new Hashtable();
            string[] value = { "资金", "经手人", "日期", "备注" };
            string[] key = { "MPMoney", "MPHandler", "MPDate", "MPMemo" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_MP.Add(key[i], value[i]);
            }
            return ht_MP;
        }

        private static Hashtable getAliasSet_TabU()
        {
            Hashtable ht_U = new Hashtable();
            string[] value = { "用户帐号", "用户密码", "用户姓名", "用户部门", "用户权限" };
            string[] key = { "UAccount", "UPassword", "UName", "UDepart", "UPrivilege" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_U.Add(key[i], value[i]);
            }
            return ht_U;
        }

        private static Hashtable getAliasSet_TabDL()
        {
            Hashtable ht_DL = new Hashtable();
            string[] value = { "关联子项目ID", "项目经理", "分包单位", "分包费用", "计划开工时间", "计划完工时间", "协议状态", "协议添加时间" };
            string[] key = { "DLSubProjectID", "DLManager", "DLCompany", "DLMoeny", "DLStart", "DLEnd", "DLState", "DLDate" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_DL.Add(key[i], value[i]);
            }
            return ht_DL;
        }

        private static Hashtable getAliasSet_TabBL()
        {
            Hashtable ht_BL = new Hashtable();
            string[] value = { "关联子工程ID", "日期", "工单号", "付款金额", "付款单位", "经手人", "银行帐号", "备注" };
            string[] key = { "BLSubProjectID", "BLDateTime", "BLWorkOrder", "BLPay", "BLPayCompany", "BLHandler", "BLBankNO", "BLMemo" };
            for (int i = 0; i < value.Length; i++)
            {
                ht_BL.Add(key[i], value[i]);
            }
            return ht_BL;
        }

        public static Hashtable getAliasSet(string dataType)
        {
            switch (dataType)
            {
                case "TabProjectInfo": return getAliasSet_TabProjectInfo();
                case "TabSubProjectInfo": return getAliasSet_TabSubProjectInfo();
                case "TabStateRecord": return getAliasSet_TabStateRecord();
                case "ProjectFinanceView": return getAliasSet_ProjectFinanceView();
                case "SubProjectFinanceView": return getAliasSet_SubProjectFinanceView();
                case "TabPayment": return getAliasSet_TabPayment();
                case "TabCostAndReimburse": return getAliasSet_TabCostAndReimburse();
                case "TabLoanRepay": return getAliasSet_TabLoanRepay();
                case "TabBP": return getAliasSet_TabBP();
                case "TabCU": return getAliasSet_TabCU();
                case "TabPC": return getAliasSet_TabPC();
                case "TabPS": return getAliasSet_TabPS();
                case "TabM": return getAliasSet_TabMaterial();
                case "TabMF": return getAliasSet_TabMF();
                case "TabSC": return getAliasSet_TabSC();
                case "TabU": return getAliasSet_TabU();
                case "TabMP": return getAliasSet_TabMP();
                case "TabDL": return getAliasSet_TabDL();
                case "TabBL": return getAliasSet_TabBL();
                default: break;
            }
            return null;
        }

        public static void setTableCaption(string dataType, GridView gridView)
        {
            if (gridView.GridControl.DataSource != null)
            {
                Hashtable ht = DataAlias.getAliasSet(dataType);
                //初始化表头名称
                for (int i = 0; i < gridView.Columns.Count; i++)
                {
                    if (ht.Contains(gridView.Columns[i].FieldName.Trim()))
                    {
                        if (!String.IsNullOrEmpty(ht[gridView.Columns[i].FieldName.Trim()].ToString()))
                        {
                            gridView.Columns[i].Caption = ht[gridView.Columns[i].FieldName.Trim()].ToString();
                        }
                    }
                }
            }
        }
    }
}
