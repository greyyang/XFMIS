using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using CodeGeneratorLib;
using CodeGeneratorWin.CustomProperty;

namespace CodeGeneratorWin
{
    public partial class frmIBatisGeneratorMain : Form
    {
        private readonly string iniPath = ConfigurationManager.AppSettings["ini"];
        private IList<Guid> list;

        public frmIBatisGeneratorMain()
        {
            InitializeComponent();
            BindPropertyGrid();

            DelegateInit();

            list = new List<Guid>();
            for (int i = 0; i < 4; i++)
            {
                list.Add(Guid.NewGuid());
            }
        }

        private void DelegateInit()
        {
            sbg = setBtnGenerator;
            slp = setLblProccess;
        }

        private void setBtnGenerator(bool enabled)
        {
            btnGenerator.Enabled = enabled;
        }

        private void setLblProccess(string label)
        {
            lblProccess.Text = label;
        }

        private void BindPropertyGrid()
        {
            PropertyEntity entity = new PropertyEntity();
            Type type = entity.GetType();
            if (!File.Exists(iniPath))
            {
                propertyGrid1.SelectedObject = entity;
                return;
            }
            using (StreamReader sr = new StreamReader(iniPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        string[] keyvalues = line.Split('=');
                        string key = keyvalues[0];
                        object val = keyvalues[1];
                        if (val.ToString() == "True" || val.ToString() == "False")
                        {
                            val = Convert.ToBoolean(val);
                        }
                        type.GetProperty(key).SetValue(entity, val, null);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }
            propertyGrid1.SelectedObject = entity;
        }

        private void btnSaveIni_Click(object sender, EventArgs e)
        {
            PropertyEntity entity = (PropertyEntity)propertyGrid1.SelectedObject;

            Type type = entity.GetType();
            using (StreamWriter sw = new StreamWriter(iniPath, false, Encoding.UTF8))
            {
                foreach (PropertyInfo info in type.GetProperties())
                {
                    object obj = info.GetValue(entity, null);
                    string val = obj == null ? "" : obj.ToString();
                    sw.WriteLine(info.Name + "=" + val);
                }
            }
            MessageBox.Show("保存成功");
        }

        private void btnGenerator_Click(object sender, EventArgs e)
        {
            btnGenerator.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Invoke(slp, "正在生成Entity层");
            GeneratorEntity();

            Invoke(slp, "正在生成Component层");
            GeneratorComponent();

            Invoke(slp, "正在生成Logic层");
            GeneratorLogic();

            Invoke(slp, "正在生成Web层");
            GeneratorWeb();

            Invoke(slp, "全部生成已成功");
            Invoke(sbg, true);

            if (MessageBox.Show("全部生成已成功,是否打开输出目录", "生成成功", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                btnOpenFolder_Click(this, new EventArgs());
            }
        }

        private void GeneratorEntity()
        {
            PropertyEntity entity = (PropertyEntity)propertyGrid1.SelectedObject;
            string assembly = entity.EntityAssembly ?? "";
            string nameSpace = entity.EntityNameSpace ?? "";
            string dbName = entity.DatabaseName ?? "";
            string folderName = entity.OutputFolder ?? "";
            bool nullable = entity.UseNullable;
            bool equals = entity.CreateEquals;
            EntityGenerator eg = new EntityGenerator(assembly, nameSpace,
                                                    dbName, folderName,
                                                    nullable, equals, list);
            eg.Generator();
        }

        private void GeneratorComponent()
        {
            PropertyEntity entity = (PropertyEntity)propertyGrid1.SelectedObject;
            string assembly = entity.ComponentAssembly ?? "";
            string nameSpace = entity.ComponentNameSpace ?? "";
            string dbName = entity.DatabaseName ?? "";
            string folderName = entity.OutputFolder ?? "";
            bool nullable = entity.UseNullable;
            bool equals = entity.CreateEquals;
            ComponentGenerator cg = new ComponentGenerator(assembly, nameSpace,
                                                            dbName, folderName,
                                                            nullable, equals, list);
            cg.Generator();
        }

        private void GeneratorLogic()
        {
            PropertyEntity entity = (PropertyEntity)propertyGrid1.SelectedObject;
            string assembly = entity.LogicNameSpace ?? "";
            string nameSpace = entity.LogicAssembly ?? "";
            string entityNameSpace = entity.EntityNameSpace ?? "";
            string entityAssembly = entity.EntityAssembly ?? "";
            string dbName = entity.DatabaseName ?? "";
            string folderName = entity.OutputFolder ?? "";
            bool nullable = entity.UseNullable;
            bool equals = entity.CreateEquals;
            LogicGenerator lg = new LogicGenerator(assembly, nameSpace,
                                                dbName, folderName,
                                                nullable, equals, list,
                                                entityAssembly, entityNameSpace);
            lg.Generator();
        }

        private void GeneratorWeb()
        {
            PropertyEntity entity = (PropertyEntity)propertyGrid1.SelectedObject;
            string assembly = entity.WebSiteName ?? "";
            string nameSpace = entity.WebSiteName ?? "";
            string entityNameSpace = entity.EntityNameSpace ?? "";
            string entityAssembly = entity.EntityAssembly ?? "";
            string logicNameSpace = entity.LogicNameSpace ?? "";
            string logicAssembly = entity.LogicAssembly ?? "";
            string dbName = entity.DatabaseName ?? "";
            string folderName = entity.OutputFolder ?? "";
            bool nullable = entity.UseNullable;
            bool equals = entity.CreateEquals;
            WebGenerator wg = new WebGenerator(assembly, nameSpace,
                                                dbName, folderName,
                                                nullable, equals, list,
                                                entityAssembly, entityNameSpace,
                                                logicAssembly, logicNameSpace);
            wg.Generator();
        }

        #region Delegate Method
        private delegate void SetBtnGenerator(bool enabled);
        private delegate void SetLblProccess(string label);

        private SetBtnGenerator sbg;
        private SetLblProccess slp;
        #endregion

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            PropertyEntity entity = (PropertyEntity)propertyGrid1.SelectedObject;
            Process.Start("explorer.exe", entity.OutputFolder);
        }

        private void frmIBatisGeneratorMain_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            int height = control.Size.Height;
            int width = control.Size.Width;

            // btnGenerator
            // Height = 23
            btnGenerator.Top = height - 23 - 39;
            btnGenerator.Left = width - 75 - 4;

            // btnSaveIni
            btnSaveIni.Top = btnGenerator.Top;
            btnSaveIni.Left = width - (btnGenerator.Width + 4 + 75) - 4;

            // btnOpenFolder
            btnOpenFolder.Top = btnGenerator.Top;
            btnOpenFolder.Left = width - (btnSaveIni.Width + 4 + 15) - (btnGenerator.Width + 4 + 75) - 4;

            // lblProccess
            lblProccess.Top = height - (43 + 23 + 39);
            lblProccess.Left = 0;

            // propertyGrid1
            propertyGrid1.Top = 0;
            propertyGrid1.Left = 0;
            propertyGrid1.Width = width-4;
            propertyGrid1.Height = height - (43 + 23 + 39);
        }
    }
}