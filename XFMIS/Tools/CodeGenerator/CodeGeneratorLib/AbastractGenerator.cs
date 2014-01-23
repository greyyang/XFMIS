using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace CodeGeneratorLib
{
    public abstract class AbastractGenerator
    {
        protected string path;
        protected string folderName;
        protected AbastractGenerator(string _assmebly, string _nameSpace,
                                string _dbName, string _folderName,
                                bool _useNullable, bool _createEquals, IList<Guid> list)
        {
            Assembly = _assmebly;
            NameSpace = _nameSpace;
            DatabaseName = _dbName;
            SolutionFolder = _folderName;
            UseNullable = _useNullable;
            CreateEquals = _createEquals;
            GuidList = list;

            _folderName =
                _folderName.Substring(_folderName.Length - 1, 1) != "\\" ?
                        _folderName + "\\" :
                        _folderName;
            folderName = _folderName;

            path = _folderName + _assmebly + "\\";
        }

        protected readonly string _connectionString = ConfigurationManager.AppSettings["connectionStrings"];

        private string _assembly;
        private string _nameSpace;
        private string _solutionFolder;
        private string _databaseName;
        private bool _useNullable;
        private bool _createEquals;
        private IList<Guid> _guidList;

        protected string Assembly
        {
            get { return _assembly; }
            set { _assembly = value; }
        }

        protected string NameSpace
        {
            get { return _nameSpace; }
            set { _nameSpace = value; }
        }

        protected string SolutionFolder
        {
            get { return _solutionFolder; }
            set { _solutionFolder = value; }
        }

        protected string DatabaseName
        {
            get { return _databaseName; }
            set { _databaseName = value; }
        }

        protected bool UseNullable
        {
            get { return _useNullable; }
            set { _useNullable = value; }
        }

        protected bool CreateEquals
        {
            get { return _createEquals; }
            set { _createEquals = value; }
        }

        protected IList<Guid> GuidList
        {
            get { return _guidList; }
            set { _guidList = value; }
        }

        protected Database SelectedDatabase
        {
            get
            {
                SqlConnection conn = new SqlConnection(_connectionString);
                Server server = new Server(new ServerConnection(conn));
                Database database = server.Databases[DatabaseName];
                return database;
            }
        }

        public abstract void Generator();

        protected virtual IList<string> GetTables()
        {
            IList<string> list = new List<string>();
            foreach (Table table in SelectedDatabase.Tables)
            {
                if (table.ID < 0) continue;
                
                list.Add(table.Name);
            }
            return list;
        }


        #region 数据库-类 转换方法

        /// <summary>
        /// 转换为私有变量
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        protected virtual string ConvertToPrivateVariant(string column)
        {
            return "m_" + ColumnNameToPropertyName(column);
        }

        /// <summary>
        /// 转换为公有属性
        /// </summary>
        /// <param name="privateVariant"></param>
        /// <returns></returns>
        protected virtual string ConvertToPublicVariants(string privateVariant)
        {
            return privateVariant.Substring(2);
        }

        /// <summary>
        /// 表名转类名
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        protected virtual string ConvertTableNameToClassName(string tableName)
        {
            string[] splitNames = tableName.Split(new char[] { '_' });
            string result = "";
            foreach (string s in splitNames)
            {
                string a = s.Substring(0, 1).ToUpper() + s.Substring(1);
                result += a;
            }
            if (result == "")
            {
                return tableName.Substring(0, 1).ToUpper() + tableName.Substring(1);
            }
            return result;
        }

        /// <summary>
        /// 字段名转属性名
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        protected virtual string ColumnNameToPropertyName(string tableName)
        {
            string[] splitNames = tableName.Split(new char[] { '_' });
            string result = "";
            foreach (string s in splitNames)
            {
                if (s.Length < 2)
                {
                    result += s;
                    continue;
                }
                string a = s.Substring(0, 1).ToUpper() + s.Substring(1);
                result += a;
            }
            if (result == "")
                return tableName;
            return result;
        }

        /// <summary>
        /// 转换为C#类型
        /// </summary>
        /// <param name="dataTypeName"></param>
        /// <returns></returns>
        protected virtual string ConvertToCSharpType(string dataTypeName)
        {
            string retVal = "";

            switch (dataTypeName)
            {
                case "nchar":
                case "char":
                case "ntext":
                case "nvarchar":
                case "text":
                case "varchar":
                    retVal = "string";
                    break;
                case "binary":
                case "image":
                case "varbinary":
                    retVal = "byte[]";
                    break;
                case "decimal":
                case "money":
                case "numeric":
                case "smallmoney":
                    retVal = "decimal";
                    break;
                case "float":
                case "real":
                    retVal = "double";
                    break;
                case "datetime":
                case "smalldatetime":
                    retVal = "DateTime";
                    break;
                case "bit":
                    retVal = "bool";
                    break;
                case "bigint":
                    retVal = "long";
                    break;
                case "int":
                    retVal = "int";
                    break;
                case "smallint":
                    retVal = "short";
                    break;
                case "tinyint":
                    retVal = "byte";
                    break;
                case "uniqueidentifier":
                    retVal = "Guid";
                    break;
            }

            return retVal;
        }

        /// <summary>
        /// 转换成IBatisNet类型
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        protected virtual string ConvertToIBatisNetType(string column)
        {
            string retVal = "";

            switch (column)
            {
                case "string":
                    retVal = "String";
                    break;
                case "decimal":
                    retVal = "Decimal";
                    break;
                case "double":
                    retVal = "Double";
                    break;
                case "DateTime":
                    retVal = "DateTime";
                    break;
                case "bool":
                    retVal = "Boolean";
                    break;
                case "long":
                    retVal = "Int64";
                    break;
                case "int":
                    retVal = "Int32";
                    break;
                case "short":
                    retVal = "Int16";
                    break;
                case "byte":
                    retVal = "Byte";
                    break;
                case "Guid":
                    retVal = "Guid";
                    break;
                case "byte[]":
                    retVal = "BinaryBlob";
                    break;
            }

            return retVal;
        }

        protected virtual string ConvertToValue(string column)
        {
            string retVal = "";

            switch (column)
            {
                case "string":
                    retVal = "null";
                    break;
                case "decimal":
                    retVal = "0";
                    break;
                case "double":
                    retVal = "0";
                    break;
                case "DateTime":
                    retVal = "DateTime.Now";
                    break;
                case "bool":
                    retVal = "false";
                    break;
                case "long":
                    retVal = "0";
                    break;
                case "int":
                    retVal = "0";
                    break;
                case "short":
                    retVal = "0";
                    break;
                case "byte":
                    retVal = "null";
                    break;
                case "Guid":
                    retVal = "Guid.Empty";
                    break;
                case "byte[]":
                    retVal = "null";
                    break;
            }
            return retVal;
        }

        protected virtual string ConvertToNullableChar(Column column, bool nullable)
        {
            string character = "";
            string csharpType = ConvertToCSharpType(column.DataType.Name);
            switch (csharpType)
            {
                case "decimal":
                case "double":
                case "DateTime":
                case "bool":
                case "long":
                case "int":
                case "short":
                case "byte":
                    if (column.Nullable)
                        character = "?";
                    break;
                default:
                    character = "";
                    break;
            }

            return character;
        }

        #endregion
    }
}
