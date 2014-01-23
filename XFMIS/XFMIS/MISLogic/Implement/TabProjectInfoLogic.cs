using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


using MISEntity.Entity;
using MISLogic.Interface;
using MISLogic.BaseClass;
using log4net;
namespace MISLogic.Implement
{
    public class TabProjectInfoLogic : CommonLogic<TabProjectInfo, int>,ITabProjectInfoLogic
    {
        private readonly ILog _log = LogManager.GetLogger("DatabaseOp");
        /// <sammury>
        /// 创建对象
        /// </sammury>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Create(TabProjectInfo entity)
        {
            return CreateObject(entity);
        }

        /// <sammury>
        /// 更新对象
        /// </sammury>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Update(TabProjectInfo entity)
        {
            return UpdateObject(entity);
        }

        /// <summary>
        /// 删除对象
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public int Delete(int entityId)
        {
            return DeleteObject(entityId);
        }
        

        /// <summary>
        /// 根据主键ID查询对象
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public TabProjectInfo FindByID(int entityId)
        {
            return FindObjectByID(entityId);
        }

        /// <summary>
        /// 检索对象数量
        /// </summary>
        /// <returns></returns>
        public int FindCount()
        {
            return FindObjectByCount();
        }

        /// <sammury>
        /// 检索对象
        /// </sammury>
        public IList<TabProjectInfo> FindAll()
        {
            return FindAllObject();
        }

        /// <summary>
        /// 检索对象数量
        /// </summary>
        /// <returns></returns>
        public int FindCount(Hashtable table)
        {
            return FindObjectByCount(table);
        }

        /// <sammury>
        /// 检索对象
        /// </sammury>
        public IList<TabProjectInfo> FindAll(Hashtable table)
        {
            return FindAllObject(table);
        }

        //----------------------以下是-自定义方法实现-------------------------------

        public int updateExInfo(TabProjectInfo projectInfo)
        {
            string statementName = typeof(TabProjectInfo).Name + ".UpdateExInfo";
            try
            {
                return ExecuteUpdate(statementName, projectInfo);
            }
            catch (Exception ex)
            {
                _log.Error("更新对象语句如下" + GetSql(statementName, projectInfo) + "\r\n更新对象出错：" + ex.Message, ex);
                throw;
            }
        }

        public int updatePlan(TabProjectInfo projectInfo)
        {
            string statementName = typeof(TabProjectInfo).Name + ".UpdatePlan";
            try
            {
                return ExecuteUpdate(statementName, projectInfo);
            }
            catch (Exception ex)
            {
                _log.Error("更新对象语句如下" + GetSql(statementName, projectInfo) + "\r\n更新对象出错：" + ex.Message, ex);
                throw;
            }
        }
    }
}