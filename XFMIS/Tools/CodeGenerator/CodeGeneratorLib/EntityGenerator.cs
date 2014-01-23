using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using CodeGeneratorLib.Resx;
using Microsoft.SqlServer.Management.Smo;

namespace CodeGeneratorLib
{
    public class EntityGenerator : AbastractGenerator
    {
        private string guidString;

        public EntityGenerator(string _assmebly, string _nameSpace, string _dbName,
            string _folderName, bool _useNullable, bool _createEquals, IList<Guid> _guidList)
            :
            base(_assmebly, _nameSpace, _dbName, _folderName, _useNullable, _createEquals, _guidList)
        {
            guidString = _guidList[0].ToString().ToUpper();
        }

        public override void Generator()
        {
            IList<string> tables = GetTables();
            foreach (string tableName in tables)
            {
                Table table = SelectedDatabase.Tables[tableName];
                if (table != null)
                {
                    GeneratorEntityClassForTable(table);
                }
            }
            GeneratorEntityPropertiesFile();
            GeneratorEntityVsProject();
        }

        protected void GeneratorEntityClassForTable(Table table)
        {
            string classFile = resource.EntityClass;
            string className = ConvertTableNameToClassName(table.Name);
            StringBuilder constructor = new StringBuilder();
            classFile = classFile.Replace("${NameSpace}", NameSpace);
            classFile = classFile.Replace("${ClassName}", className);

            //--------------------------------------构造函数-----------------------------------------------
            int i = 0;
            foreach (Column column in table.Columns)
            {
                if (!column.Nullable)
                {
                    string head = i == 0 ? "" : "\t\t\t";
                    string csharpType = ConvertToCSharpType(column.DataType.Name);
                    string privateVariant = ConvertToPrivateVariant(column.Name);
                    constructor.AppendLine(head + privateVariant + " = " + ConvertToValue(csharpType) + ";");
                    i++;
                }
            }
            classFile = classFile.Replace("${Constructor}", constructor.ToString());
            //---------------------------------------------------------------------------------------------


            //--------------------------------------公共属性-----------------------------------------------

            StringBuilder filed = new StringBuilder();
            i = 0;
            foreach (Column column in table.Columns)
            {
                string csharpType = ConvertToCSharpType(column.DataType.Name);
                string privateVariant = ConvertToPrivateVariant(column.Name);
                string publicField = ConvertToPublicVariants(privateVariant);
                string nullableChar = ConvertToNullableChar(column, UseNullable);
                string head = i == 0 ? "" : "\t\t";

                filed.AppendLine(head + "#region " + publicField);
                filed.AppendLine("\t\t");
                filed.AppendLine("\t\tprivate " + csharpType + nullableChar + " " + privateVariant + ";");
                filed.AppendLine("\t\t");
                filed.AppendLine("\t\tpublic " + csharpType + nullableChar + " " + publicField);
                filed.AppendLine("\t\t{");
                filed.AppendLine("\t\t\tget { return " + privateVariant + "; }");
                filed.AppendLine("\t\t\tset { " + privateVariant + " = value; }");
                filed.AppendLine("\t\t}");
                filed.AppendLine("\t\t");
                filed.AppendLine("\t\t#endregion");
                filed.AppendLine("\t\t");
                i++;
            }
            classFile = classFile.Replace("${Fields}", filed.ToString());
            //---------------------------------------------------------------------------------------------

            //--------------------------------------GetHashCode--------------------------------------------
            if (CreateEquals)
            {
                StringBuilder equals = new StringBuilder();
                Random random = new Random((int)DateTime.Now.Ticks);
                int randomNum = random.Next(100);

                equals.AppendLine("#region Rewrite Equals and HashCode");
                equals.AppendLine("\t\t");
                equals.AppendLine("\t\t/// <summary>");
                equals.AppendLine("\t\t/// ");
                equals.AppendLine("\t\t/// </summary>");
                equals.AppendLine("\t\tpublic override bool Equals(object obj)");
                equals.AppendLine("\t\t{");
                equals.AppendLine("\t\t\tif( this == obj ) return true;");
                equals.AppendLine("\t\t\tif( ( obj == null ) || ( obj.GetType() != GetType() ) ) return false;");
                equals.AppendLine("\t\t\t" + className + " castObj = (" + className + ") obj;");
                equals.AppendLine("\t\t\treturn ( castObj != null )");
                foreach (Column column in table.Columns)
                {
                    string privateVariant = ConvertToPrivateVariant(column.Name);
                    string publicField = ConvertToPublicVariants(privateVariant);
                    if (column.InPrimaryKey)
                    {
                        equals.Append(" && " + privateVariant + " == castObj." + publicField + "");
                    }
                }
                equals.Insert(equals.Length, ";");
                equals.AppendLine("\t\t}");
                equals.AppendLine("\t\t");
                equals.AppendLine("\t\t/// <summary>");
                equals.AppendLine("\t\t/// 用唯一值实现GetHashCode");
                equals.AppendLine("\t\t/// </summary>");
                equals.AppendLine("\t\tpublic override int GetHashCode()");
                equals.AppendLine("\t\t{");
                equals.AppendLine("\t\t\tint hash = " + randomNum + ";");
                equals.AppendLine("\t\t\thash = hash * " + randomNum);
                foreach (Column column in table.Columns)
                {
                    string privateVariant = ConvertToPrivateVariant(column.Name);
                    if (column.InPrimaryKey)
                    {
                        equals.Append(" * " + privateVariant + ".GetHashCode()");
                    }
                }
                equals.Insert(equals.Length, ";");
                equals.AppendLine("\t\t\treturn hash;");
                equals.AppendLine("\t\t}");
                equals.AppendLine("\t\t");
                equals.AppendLine("\t\t#endregion");
                equals.AppendLine("\t\t");


                classFile = classFile.Replace("${EqualsHashCode}", equals.ToString());
            }
            //---------------------------------------------------------------------------------------------


            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (File.Exists(path + className + ".cs"))
            {
                File.Delete(path + className + ".cs");
            }
            using (StreamWriter sw = new StreamWriter(path + className + ".cs", false, Encoding.UTF8))
            {
                sw.Write(classFile);
                sw.Close();
            }
        }

        protected void GeneratorEntityPropertiesFile()
        {
            string properties = resource.Properties;
            properties = properties.Replace("${Assembly}", Assembly);
            properties = properties.Replace("${Guid}", guidString);
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

        protected void GeneratorEntityVsProject()
        {
            StringBuilder sb = new StringBuilder();
            string project = resource.EntityProject;
            int i = 0;
            foreach (Table table in SelectedDatabase.Tables)
            {
                if (table.ID < 0) continue;
                string head = i == 0 ? "" : "    ";
                string className = ConvertTableNameToClassName(table.Name);
                sb.AppendLine(head + "<Compile Include=\"" + className + ".cs\" />");
                i++;
            }
            project = project.Replace("${CompileString}", sb.ToString());
            project = project.Replace("${Guid}", guidString);
            project = project.Replace("${NameSpace}", NameSpace);
            project = project.Replace("${Assembly}", Assembly);

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
