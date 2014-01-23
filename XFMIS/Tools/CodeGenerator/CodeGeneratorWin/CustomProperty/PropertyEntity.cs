using System.ComponentModel;
using System.Drawing.Design;

namespace CodeGeneratorWin.CustomProperty
{
    [DefaultProperty("OutputFolder")]
    public class PropertyEntity
    {
        private string _outputFolder;
        private string _componentNameSpace;
        private string _componentAssembly;
        private string _entityNameSpace;
        private string _entityAssembly;
        private string _logicNameSpace;
        private string _logicAssembly;
        private string _webSiteName;
        private bool _useNullable;
        private bool _createEquals;
        private string _databaseName;

        [CategoryAttribute("SolutionOptions"), 
         DescriptionAttribute("项目输出路径"), 
         EditorAttribute(typeof(PropertyGridFolderItem), 
             typeof(UITypeEditor))]
        public string OutputFolder
        {
            get { return _outputFolder; }
            set { _outputFolder = value; }
        }

        [CategoryAttribute("Component"), DescriptionAttribute("Component层命名空间")]
        public string ComponentNameSpace
        {
            get { return _componentNameSpace; }
            set { _componentNameSpace = value; }
        }

        [CategoryAttribute("Component"), DescriptionAttribute("Component层程序集")]
        public string ComponentAssembly
        {
            get { return _componentAssembly; }
            set { _componentAssembly = value; }
        }

        [CategoryAttribute("Entity"), DescriptionAttribute("Entity层命名空间")]
        public string EntityNameSpace
        {
            get { return _entityNameSpace; }
            set { _entityNameSpace = value; }
        }

        [CategoryAttribute("Entity"), DescriptionAttribute("Entity层程序集")]
        public string EntityAssembly
        {
            get { return _entityAssembly; }
            set { _entityAssembly = value; }
        }

        [CategoryAttribute("Logic"), DescriptionAttribute("Logic层命名空间")]
        public string LogicNameSpace
        {
            get { return _logicNameSpace; }
            set { _logicNameSpace = value; }
        }

        [CategoryAttribute("Logic"), DescriptionAttribute("Logic层程序集")]
        public string LogicAssembly
        {
            get { return _logicAssembly; }
            set { _logicAssembly = value; }
        }

        [CategoryAttribute("Web"), DescriptionAttribute("Web层文件夹")]
        public string WebSiteName
        {
            get { return _webSiteName; }
            set { _webSiteName = value; }
        }

        [CategoryAttribute("Settings"), DescriptionAttribute("是否使用Nullable")]
        public bool UseNullable
        {
            get { return _useNullable; }
            set { _useNullable = value; }
        }

        [CategoryAttribute("Settings"), DescriptionAttribute("是否创建Equals和GetHashCode")]
        public bool CreateEquals
        {
            get { return _createEquals; }
            set { _createEquals = value; }
        }

        [CategoryAttribute("Database"), 
         DescriptionAttribute("选择数据库"),
         TypeConverter(typeof(PropertyGridSelectDatabaseItem))]
        public string DatabaseName
        {
            get { return _databaseName; }
            set { _databaseName = value; }
        }
    }
}