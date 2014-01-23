using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBatisNet.Common;
using IBatisNet.Common.Pagination;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Commands;
using IBatisNet.DataMapper.Configuration.Statements;
using IBatisNet.DataMapper.Exceptions;
using IBatisNet.DataMapper.MappedStatements;
using IBatisNet.DataMapper.Scope;
namespace MISLogic.BaseClass
{
    public class BaseSqlMapDao
    {
        //静态只读成员变量，保存了类中要用到的框架中进行数据操作的对象
        private static readonly ISqlMapper sqlMap = (ContainerAccessorUtil.GetContainer())["sqlServerSqlMap"] as ISqlMapper;

        /// <summary>
        /// 执行插入一条操作
        /// </summary>
        /// <param name="statementName"></param>
        /// <param name="parameterObject"></param>
        /// <returns>返回执行插入操作后自增长的主键ID</returns>
        protected virtual object ExecuteInsert(string statementName, object parameterObject)
        {
            try
            {
                object obj = sqlMap.Insert(statementName, parameterObject);
                return obj;
            }
            catch (Exception e)
            {
                throw new DataMapperException("Error executing query '" + statementName + "' for insert.  Cause: " + e.Message, e);
            }
        }

        /// <summary>
        /// 执行更新操作
        /// </summary>
        /// <param name="statementName"></param>
        /// <param name="parameterObject"></param>
        /// <returns>返回受影响的行数</returns>
        protected virtual int ExecuteUpdate(string statementName, object parameterObject)
        {
            try
            {
                return sqlMap.Update(statementName, parameterObject);
            }
            catch (Exception e)
            {
                throw new DataMapperException("Error executing query '" + statementName + "' for update.  Cause: " + e.Message, e);
            }
        }

        /// <summary>
        /// 执行删除操作
        /// </summary>
        /// <param name="statementName"></param>
        /// <param name="parameterObject"></param>
        /// <returns>返回受影响的行数</returns>
        protected virtual int ExecuteDelete(string statementName, object parameterObject)
        {
            try
            {
                return sqlMap.Delete(statementName, parameterObject);
            }
            catch (Exception e)
            {
                throw new DataMapperException("Error executing query '" + statementName + "' for delete.  Cause: " + e.Message, e);
            }
        }

        /// <summary>
        /// 执行查询一条数据操作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="statementName"></param>
        /// <param name="parameterObject"></param>
        /// <returns>返回一个对象</returns>
        protected virtual T ExecuteQueryForObject<T>(string statementName, object parameterObject)
        {
            try
            {
                return sqlMap.QueryForObject<T>(statementName, parameterObject);
            }
            catch (Exception e)
            {
                throw new DataMapperException("Error executing query '" + statementName + "' for object.  Cause: " + e.Message, e);
            }
        }

        /// <summary>
        /// 获取xml文件配置块的sql语句
        /// </summary>
        /// <param name="statementName"></param>
        /// <param name="parameterObject"></param>
        /// <returns></returns>
        protected virtual string GetSql(string statementName, object parameterObject)
        {
            IMappedStatement statement = sqlMap.GetMappedStatement(statementName);
            if (!sqlMap.IsSessionStarted)
            {
                sqlMap.OpenConnection();
            }
            RequestScope scope = statement.Statement.Sql.GetRequestScope(statement, parameterObject, sqlMap.LocalSession);

            return scope.PreparedStatement.PreparedSql;
        }


        //public string GetSql(string tag, object paramObject) 
        //{
        //    IStatement statement = sqlMap.GetMappedStatement(tag).Statement; 
        //    RequestScope request = statement.Sql.GetRequestScope(sqlMap.GetMappedStatement(tag),paramObject, new SqlMapSession(sqlMap.DataSource)); 
        //    return request.PreparedStatement.PreparedSql; 
        //}

        /// <summary>
        /// 执行一个返回多条数据的查询操作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="statementName"></param>
        /// <param name="parameterObject"></param>
        /// <returns>返回一个IList的数据集</returns>
        public virtual IList<T> ExecuteQueryForList<T>(string statementName, object parameterObject)
        {
            try
            {
                return sqlMap.QueryForList<T>(statementName, parameterObject);
            }
            catch (Exception e)
            {
                throw new DataMapperException("Error executing query '" + statementName + "' for list.  Cause: " + e.Message, e);
            }
        }
    }
}
