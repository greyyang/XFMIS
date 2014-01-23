﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


using MISEntity.Entity;
using MISLogic.Interface;
using MISLogic.BaseClass;
namespace MISLogic.Implement
{
    public class TabMaterialFlowLogic : CommonLogic<TabMaterialFlow, int>,ITabMaterialFlowLogic
    {

        /// <sammury>
        /// 创建对象
        /// </sammury>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Create(TabMaterialFlow entity)
        {
            return CreateObject(entity);
        }

        /// <sammury>
        /// 更新对象
        /// </sammury>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Update(TabMaterialFlow entity)
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
        public TabMaterialFlow FindByID(int entityId)
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
        public IList<TabMaterialFlow> FindAll()
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
        public IList<TabMaterialFlow> FindAll(Hashtable table)
        {
            return FindAllObject(table);
        }
    }
}