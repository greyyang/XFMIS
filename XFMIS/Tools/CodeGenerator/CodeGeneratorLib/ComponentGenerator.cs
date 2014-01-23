using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CodeGeneratorLib.Resx;

namespace CodeGeneratorLib
{
    public class ComponentGenerator : AbastractGenerator
    {
        private string guidString;
        public ComponentGenerator(string _assmebly, string _nameSpace, string _dbName,
            string _folderName, bool _useNullable, bool _createEquals, IList<Guid> _guidList)
            : 
            base(_assmebly, _nameSpace, _dbName, _folderName, _useNullable, _createEquals, _guidList)
        {
            guidString = _guidList[1].ToString().ToUpper();
        }

        public override void Generator()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            GeneratorContainer();
            GeneratorComponentPropertiesFile();
            GeneratorComponentVsProject();
        }
        
        protected void GeneratorContainer()
        {
            string container = resource.ContainerAccessorUtil;
            container = container.Replace("${NameSpace}", NameSpace);

            string fileName = path + "ContainerAccessorUtil.cs";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                sw.Write(container);
                sw.Close();
            }
        }

        protected void GeneratorComponentPropertiesFile()
        {
            string properties = resource.Properties;
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

        protected void GeneratorComponentVsProject()
        {
            string project = resource.ComponentProject;
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
