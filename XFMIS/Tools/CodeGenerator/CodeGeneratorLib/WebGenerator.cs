using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CodeGeneratorLib.Resx;
using Microsoft.SqlServer.Management.Smo;

namespace CodeGeneratorLib
{
    public class WebGenerator : AbastractGenerator
    {
        private readonly string _entityNameSpace;
        private readonly string _entityAssembly;
        private readonly string _logicAssembly;
        private readonly string _logicNameSpace;

        public WebGenerator(string assmebly, string nameSpace, string dbName,
            string folderName, bool useNullable, bool createEquals,
            IList<Guid> guidList,
            string entityAssembly, string entityNameSpace,
            string logicAssembly, string logicNameSpace)
            :
            base(assmebly, nameSpace, dbName, folderName, useNullable, createEquals, guidList)
        {
            _entityNameSpace = entityNameSpace;
            _entityAssembly = entityAssembly;
            _logicAssembly = logicAssembly;
            _logicNameSpace = logicNameSpace;
        }

        public override void Generator()
        {
            CopySharedLib();
            CopyWeb();
            GeneratorMaps();
            GeneratorSqlMapConfig();
            GeneratorLogicXml();
        }

        protected void GeneratorMaps()
        {
            IList<string> list = GetTables();
            foreach (string tableName in list)
            {
                Table table = SelectedDatabase.Tables[tableName];
                GeneratorMapFile(table);
            }
        }

        protected void GeneratorMapFile(Table table)
        {
            string mapFile = resource.IBatisMapFile;

            string tableName = table.Name;
            string className = ConvertTableNameToClassName(tableName);
            string primaryKeyName = "";
            foreach (Column column in table.Columns)
            {
                if (column.InPrimaryKey)
                {
                    primaryKeyName = column.Name;
                    break;
                }
            }
            string primaryClassName = ConvertToPublicVariants(ConvertToPrivateVariant(primaryKeyName));

            mapFile = mapFile.Replace("${ClassName}", className);
            mapFile = mapFile.Replace("${EntityNameSpace}", _entityNameSpace);
            mapFile = mapFile.Replace("${EntityAssembly}", _entityAssembly);
            mapFile = mapFile.Replace("${TableName}", tableName);
            mapFile = mapFile.Replace("${primaryKeyID}", primaryKeyName);
            mapFile = mapFile.Replace("${primaryClassID}", primaryClassName);

            // result
            StringBuilder reslut = new StringBuilder();
            foreach (Column column in table.Columns)
            {
                string privateVariant = ConvertToPrivateVariant(column.Name);
                string publicVariant = ConvertToPublicVariants(privateVariant);
                string valueType = column.DataType.Name;

                string xml = string.Format("\t\t\t<result property=\"{0}\" column=\"{1}\" dbType=\"{2}\"/>", publicVariant, column.Name, valueType);
                reslut.AppendLine(xml);
            }
            reslut.Remove(0, 3);
            mapFile = mapFile.Replace("${reslut}", reslut.ToString());

            // INSERT
            StringBuilder INSERT = new StringBuilder();
            INSERT.AppendFormat("INSERT INTO {0}(", tableName);
            foreach (Column column in table.Columns)
            {
                if (column.Identity) continue;
                
                INSERT.Append("[" + column.Name + "],");
            }
            INSERT.Remove(INSERT.Length - 1, 1);
            INSERT.Append(") VALUES (");
            foreach (Column column in table.Columns)
            {
                if (column.Identity) continue;
                
                string privateVariant = ConvertToPrivateVariant(column.Name);
                string publicVariant = ConvertToPublicVariants(privateVariant);
                INSERT.Append("#" + publicVariant + "#,");
            }
            INSERT.Remove(INSERT.Length - 1, 1);
            INSERT.Append(")");
            mapFile = mapFile.Replace("${INSERT}", INSERT.ToString());

            // UPDATE
            StringBuilder UPDATE = new StringBuilder();
            UPDATE.AppendFormat("UPDATE {0} SET", tableName);
            foreach (Column column in table.Columns)
            {
                if (column.InPrimaryKey) continue;

                string privateVariant = ConvertToPrivateVariant(column.Name);
                string publicVariant = ConvertToPublicVariants(privateVariant);
                UPDATE.Append(" " + column.Name + " = #" + publicVariant + "#,");
            }
            UPDATE.Remove(UPDATE.Length - 1, 1);
            UPDATE.Append(" WHERE 1=1");
            foreach (Column column in table.Columns)
            {
                if (!column.InPrimaryKey) continue;

                string privateVariant = ConvertToPrivateVariant(column.Name);
                string publicVariant = ConvertToPublicVariants(privateVariant);
                UPDATE.AppendLine("\t\t\t AND " + column.Name + " = #" + publicVariant + "# ");
            }
            mapFile = mapFile.Replace("${UPDATE}", UPDATE.ToString());

            // ParameterList
            StringBuilder ParameterList = new StringBuilder();
            foreach (Column column in table.Columns)
            {
                string privateVariant = ConvertToPrivateVariant(column.Name);
                string publicVariant = ConvertToPublicVariants(privateVariant);
                ParameterList.AppendLine("\t\t\t\t<isNotNull prepend=\"and\" property=\"" + publicVariant + "\">");
                ParameterList.AppendLine("\t\t\t\t\t" + column.Name + " = #" + publicVariant + "#");
                ParameterList.AppendLine("\t\t\t\t</isNotNull>");
            }
            mapFile = mapFile.Replace("${ParameterList}", ParameterList.ToString());

            string fileName = path + "Maps\\" + className + ".xml";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                sw.Write(mapFile);
                sw.Close();
            }
        }

        protected void GeneratorSqlMapConfig()
        {
            string sqlMapConfig = resource.SqlMapConfig;
            sqlMapConfig = sqlMapConfig.Replace("${ConnectionString}", SelectedDatabase.Parent.ConnectionContext.ConnectionString);

            StringBuilder sb = new StringBuilder();
            IList<string> list = GetTables();
            foreach (string tableName in list)
            {
                string className = ConvertTableNameToClassName(tableName);
                sb.AppendLine("\t\t<sqlMap embedded=\"" + _entityAssembly + ".Maps." + className + ".xml," + _entityAssembly + "\" />");
            }
            sb.Remove(0, 2);
            sqlMapConfig = sqlMapConfig.Replace("${SqlMap}", sb.ToString());

            string fileName = path + "Config\\SqlMap.config";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                sw.Write(sqlMapConfig);
                sw.Close();
            }
        }

        protected void GeneratorLogicXml()
        {
            StringBuilder sb = new StringBuilder();
            IList<string> list = GetTables();
            string logicComponent = resource.CommonLogicsConfig;
            foreach (string tableName in list)
            {
                string className = ConvertTableNameToClassName(tableName);
                string str = string.Format("\t\t<component id=\"{0}Logic\" service=\"{2}.Interface.I{0}Logic, {2}\" type=\"{1}.{0}Logic, {2}\" />",
                                           className, _logicNameSpace, _logicAssembly);
                sb.AppendLine(str);
            }
            sb.Remove(0, 2);

            logicComponent = logicComponent.Replace("${LogicComponent}", sb.ToString());
            string fileName = path + "Config\\common-services.config";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                sw.Write(logicComponent);
                sw.Close();
            }
        }


        protected void CopySharedLib()
        {
            byte[] by = resource.SharedLib;
            FileStream fs = new FileStream(folderName + "SharedLib.zip", FileMode.Create);
            fs.Write(by, 0, by.Length);
            fs.Close();
            fs.Dispose();

            if (!Directory.Exists(folderName + "SharedLib"))
            {
                Directory.CreateDirectory(folderName + "SharedLib");
            }
            string err;
            if (ZipOperator.UnZipFile(folderName + "SharedLib.zip", folderName + "SharedLib", out err))
            {
                File.Delete(folderName + "SharedLib.zip");
            }
        }

        protected void CopyWeb()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            byte[] by = resource.Web;
            FileStream fs = new FileStream(path + "\\Web.zip", FileMode.Create);
            fs.Write(by, 0, by.Length);
            fs.Close();
            fs.Dispose();
            string err;
            if (ZipOperator.UnZipFile(path + "\\Web.zip", path, out err))
            {
                File.Delete(path + "\\Web.zip");
            }
        }
    }
}
