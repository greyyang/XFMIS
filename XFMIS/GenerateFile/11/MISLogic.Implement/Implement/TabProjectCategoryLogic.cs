using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


using MISEntity.Entity;
using MISLogic.Interface;

namespace MISLogic.Implement
{
    public class TabProjectCategoryLogic : CommonLogic<TabProjectCategory, int>,ITabProjectCategoryLogic
    {

        /// <sammury>
        /// 创建对象
        /// </sammury>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Create(TabProjectCategory entity)
        {
            return CreateObject(entity);
        }

        /// <sammury>
        /// 更新对象
        /// </sammury>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Update(TabProjectCategory entity)
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
        public TabProjectCategory FindByID(int entityId)
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
        public IList<TabProjectCategory> FindAll()
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
        public IList<TabProjectCategory> FindAll(Hashtable table)
        {
            return FindAllObject(table);
        }
    }
}