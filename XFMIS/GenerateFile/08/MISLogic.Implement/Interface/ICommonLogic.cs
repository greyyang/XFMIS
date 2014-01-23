using System;
using System.Collections;
using System.Collections.Generic;

namespace MISLogic.Interface
{
    public interface ICommonLogic<T, IdT>
    {
        /// <sammury>
        /// 创建对象
        /// </sammury>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Create(T entity);

        /// <sammury>
        /// 更新对象
        /// </sammury>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Update(T entity);

        /// <summary>
        /// 删除对象
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        int Delete(IdT entityId);

        /// <summary>
        /// 删除所有对象
        /// </summary>
        /// <returns></returns>
        int DeleteAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        T FindById(IdT entityId);

        /// <summary>
        /// 检索对象数量
        /// </summary>
        /// <returns></returns>
        int FindCount();

        /// <sammury>
        /// 检索对象
        /// </sammury>
        IList<T> FindAll();

        /// <summary>
        /// 检索对象数量
        /// </summary>
        /// <returns></returns>
        int FindCount(Hashtable table);

        /// <sammury>
        /// 检索对象
        /// </sammury>
        IList<T> FindAll(Hashtable table);
    }
}