using System;
using System.Collections.Generic;
using System.Collections;
using log4net;

namespace MISLogic.BaseClass
{
    public abstract class CommonLogic<T, IdT> : BaseSqlMapDao
    {
        private readonly ILog _log = LogManager.GetLogger("DatabaseOp");

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns>受影响的行数</returns>
        public virtual IdT CreateObject(T entity)
        {
            string statementName = typeof(T).Name + ".Insert";
            try
            {
                return (IdT)ExecuteInsert(statementName, entity);
            }
            catch (Exception ex)
            {
                _log.Error("创建对象出错：" + ex.Message + "/r/n创建对象语句如下" + GetSql(statementName, entity), ex);
                throw;
            }
        }

        /// <summary>
        /// 更新一个对象
        /// </summary>
        /// <param name="entity">要更新的实体对象</param>
        /// <returns>受影响的行数</returns>
        public virtual int UpdateObject(T entity)
        {
            string statementName = typeof(T).Name + ".Update";
            try
            {
                return ExecuteUpdate(statementName, entity);
            }
            catch (Exception ex)
            {
                _log.Error("更新对象语句如下" + GetSql(statementName, entity) + "\r\n更新对象出错：" + ex.Message, ex);
                throw;
            }
        }

        /// <summary>
        /// 根据主键ID删除一个对象
        /// </summary>
        /// <param name="entityid">对象的ID</param>
        /// <returns>受影响的行数</returns>
        public virtual int DeleteObject(IdT entityid)
        {
            string statementName = typeof(T).Name + ".Delete";
            try
            {
                return ExecuteDelete(statementName, entityid);
            }
            catch (Exception ex)
            {
                _log.Error("删除对象语句如下" + GetSql(statementName, entityid) + "\r\n删除对象出错：" + ex.Message, ex);
                throw;
            }
        }

        /// <summary>
        /// 根据ID查询一个对象
        /// </summary>
        /// <param name="entityid">对象ID</param>
        /// <returns>实体对象</returns>
        public virtual T FindObjectByID(IdT entityid)
        {
            string statementName = typeof(T).Name + ".FindById";
            try
            {
                return ExecuteQueryForObject<T>(statementName, entityid);
            }
            catch (Exception ex)
            {
                _log.Error("根据ID查询对象语句如下" + GetSql(statementName, entityid) + "\r\n根据ID查询对象出错：" + ex.Message, ex);
                throw;
            }
        }

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns>包含多个对象的IList数据集</returns>
        public virtual IList<T> FindAllObject()
        {
            string statementName = typeof(T).Name + ".Find";
            try
            {
                return ExecuteQueryForList<T>(statementName, null);
            }
            catch (Exception ex)
            {
                _log.Error("查询所有对象语句如下" + GetSql(statementName, null) + "\r\n查询所有对象出错：" + ex.Message, ex);
                throw;
            }

        }

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns>包含多个对象的IList数据集</returns>
        public virtual IList<T> FindAllObject(Hashtable ht)
        {
            string statementName = typeof(T).Name + ".Find";
            try
            {
                _log.Error(GetSql(statementName, ht));
                return ExecuteQueryForList<T>(statementName, ht);

            }
            catch (Exception ex)
            {
                _log.Error("查询所有对象语句如下" + GetSql(statementName, ht) + "\r\n查询所有对象出错：" + ex.Message, ex);
                throw;
            }

        }

        /// <summary>
        /// 自定义查询对象列表
        /// </summary>
        /// <param name="statementName"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public virtual IList<TCustomer> FindCustomer<TCustomer>(string statementName, object obj)
        {
            try
            {
                _log.Error(GetSql(statementName, obj));
                return ExecuteQueryForList<TCustomer>(statementName, obj);
            }
            catch (Exception ex)
            {

               _log.Error("自定义查询对象语句如下" + GetSql(statementName, obj) + "\r\n自定义查询对象出错：" + ex.Message, ex);
                throw;
            }
        }

        /// <summary>
        /// 查询对象数量
        /// </summary>
        /// <returns></returns>
        public virtual int FindObjectByCount()
        {
            string statementName = typeof(T).Name + ".FindCount";
            try
            {
                return ExecuteQueryForObject<int>(statementName, null);
            }
            catch (Exception ex)
            {
                _log.Error("自定义查询对象语句如下" + GetSql(statementName, null) + "\r\n查询对象数量出错：" + ex.Message, ex);
                throw;
            }
        }

        /// <summary>
        /// 查询对象数量
        /// </summary>
        /// <param name="ht"></param>
        /// <returns></returns>
        public virtual int FindObjectByCount(Hashtable ht)
        {
            string statementName = typeof(T).Name + ".FindCount";
            try
            {
                return ExecuteQueryForObject<int>(statementName, ht);
            }
            catch (Exception ex)
            {
                _log.Error("查询对象数量语句如下" + GetSql(statementName, ht) + "\r\n查询对象数量出错：" + ex.Message, ex);
                throw;
            }
        }
    }
}
