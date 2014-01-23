using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CodeGeneratorLib.Resx;
using Microsoft.SqlServer.Management.Smo;

namespace CodeGeneratorLib
{
    public class LogicGenerator : AbastractGenerator
    {
        private readonly string entityGuidString;
        private readonly string daoGuidString;
        private readonly string logicGuidString;
        private readonly string _entityNameSpace;
        private readonly string _entityAssembly;


        public LogicGenerator(string assmebly, string nameSpace, string dbName,
            string folderName, bool useNullable, bool createEquals,
            IList<Guid> guidList,
            string entityAssembly, string entityNameSpace)
            :
            base(assmebly, nameSpace, dbName, folderName, useNullable, createEquals, guidList)
        {
            entityGuidString = guidList[0].ToString().ToUpper();
            daoGuidString = guidList[2].ToString().ToUpper();
            logicGuidString = guidList[3].ToString().ToUpper();
            this._entityNameSpace = entityNameSpace;
            this._entityAssembly = entityAssembly;
        }

        public override void Generator()
        {
            //GeneratorInterface();
            GeneratorImplement();
            GeneratorProperties();
            GeneratorLogicVsProject();
            GeneratorInterface();
        }

        protected void GeneratorInterface()
        {
            //---------------------------------ICommonLogic----------------------------------
            string commonLogic = resource.ICommonLogic;
            commonLogic = commonLogic.Replace("${LogicNameSpace}", NameSpace);
            if (!Directory.Exists(path + "Interface"))
            {
                Directory.CreateDirectory(path + "Interface");
            }
            string fileName = path + "Interface\\ICommonLogic.cs";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                sw.Write(commonLogic);
                sw.Close();
            }
            //-------------------------------------------------------------------------------

            //---------------------------------IxxxxxxLogic----------------------------------
            IList<string> list = GetTables();
            foreach (string tableName in list)
            {
                Table table = SelectedDatabase.Tables[tableName];
                GeneratorLogicInterface(table);
            }
            //-------------------------------------------------------------------------------
        }

        protected void GeneratorLogicInterface(Table table)
        {
            if (table == null) return;
            string className = ConvertTableNameToClassName(table.Name);
            string primaryKeyType = "";
            foreach (Column column in table.Columns)
            {
                if (column.InPrimaryKey)
                {
                    primaryKeyType = ConvertToCSharpType(column.DataType.Name);
                    break;
                }
            }
            string ixxLogic = resource.IXXLogic;
            ixxLogic = ixxLogic.Replace("${EntityNameSpace}", "using " + _entityNameSpace + ";");
            ixxLogic = ixxLogic.Replace("${LogicNameSpace}", NameSpace);
            ixxLogic = ixxLogic.Replace("${ClassName}", className);
            ixxLogic = ixxLogic.Replace("${KeyType}", primaryKeyType);

            string fileName = path + "Interface\\I" + className + "Logic.cs";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                sw.Write(ixxLogic);
                sw.Close();
            }
        }

        protected void GeneratorImplement()
        {
            IList<string> list = GetTables();
            if (!Directory.Exists(path + "Implement"))
            {
                Directory.CreateDirectory(path + "Implement");
            }
            foreach (string tableName in list)
            {
                Table table = SelectedDatabase.Tables[tableName];
                GeneratorLogicImplement(table);
            }
        }

        protected void GeneratorLogicImplement(Table table)
        {
            if (table == null) return;
            string className = ConvertTableNameToClassName(table.Name);
            string primaryKeyType = "";
            foreach (Column column in table.Columns)
            {
                if (column.InPrimaryKey)
                {
                    primaryKeyType = ConvertToCSharpType(column.DataType.Name);
                    break;
                }
            }
            primaryKeyType = primaryKeyType == "" ? "int" : primaryKeyType;
            string xxLogic = resource.XXLogic;
            xxLogic = xxLogic.Replace("${EntityNameSpace}", "using " + _entityNameSpace + ";");
            xxLogic = xxLogic.Replace("${DaoNameSpace}", "");
            xxLogic = xxLogic.Replace("${LogicNameSpace}", NameSpace);
            xxLogic = xxLogic.Replace("${ClassName}", className);
            xxLogic = xxLogic.Replace("${KeyType}", primaryKeyType);

            string fileName = path + "Implement\\" + className + "Logic.cs";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                sw.Write(xxLogic);
                sw.Close();
            }
        }

        protected void GeneratorProperties()
        {
            string properties = resource.Properties;
            properties = properties.Replace("${Assembly}", Assembly);
            properties = properties.Replace("${Guid}", logicGuidString);

            if (!Directory.Exists(path + "Properties"))
            {
                Directory.CreateDirectory(path + "Properties");
            }
            string fileName = path + "Properties\\AssemblyInfo.cs";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                sw.Write(properties);
                sw.Close();
            }
        }

        protected void GeneratorLogicVsProject()
        {
            StringBuilder sb = new StringBuilder();
            string project = resource.LogicProject;

            int i = 0;
            foreach (Table table in SelectedDatabase.Tables)
            {
                if (table.ID < 0) continue;

                string head = i == 0 ? "" : "    ";
                string className = ConvertTableNameToClassName(table.Name);
                sb.AppendLine(head + "<Compile Include=\"" + className + "Logic.cs\" />");
                i++;
            }

            sb.AppendLine("    <Compile Include=\"Interface\\ICommonLogic.cs\" />");

            project = project.Replace("${Compile}", sb.ToString());
            project = project.Replace("${Guid}", logicGuidString);
            project = project.Replace("${NameSpace}", NameSpace);
            project = project.Replace("${Assembly}", Assembly);
            project = project.Replace("${EntityAssembly}", _entityAssembly);
            project = project.Replace("${EntityGuid}", entityGuidString);

            string fileName = path + Assembly + ".csproj";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                sw.Write(project);
                sw.Close();
            }
        }
    }
}
