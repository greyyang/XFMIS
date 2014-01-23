using System.Windows.Forms;

namespace CodeGeneratorWin
{
    partial class frmIBatisGeneratorMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaveIni = new System.Windows.Forms.Button();
            this.btnGenerator = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblProccess = new System.Windows.Forms.Label();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveIni
            // 
            this.btnSaveIni.Location = new System.Drawing.Point(374, 534);
            this.btnSaveIni.Name = "btnSaveIni";
            this.btnSaveIni.Size = new System.Drawing.Size(75, 23);
            this.btnSaveIni.TabIndex = 0;
            this.btnSaveIni.Text = "保存设置";
            this.btnSaveIni.UseVisualStyleBackColor = true;
            this.btnSaveIni.Click += new System.EventHandler(this.btnSaveIni_Click);
            // 
            // btnGenerator
            // 
            this.btnGenerator.Location = new System.Drawing.Point(455, 534);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(75, 23);
            this.btnGenerator.TabIndex = 1;
            this.btnGenerator.Text = "生成";
            this.btnGenerator.UseVisualStyleBackColor = true;
            this.btnGenerator.Click += new System.EventHandler(this.btnGenerator_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(530, 484);
            this.propertyGrid1.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lblProccess
            // 
            this.lblProccess.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProccess.Location = new System.Drawing.Point(-2, 488);
            this.lblProccess.Name = "lblProccess";
            this.lblProccess.Size = new System.Drawing.Size(532, 43);
            this.lblProccess.TabIndex = 2;
            this.lblProccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(275, 534);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(93, 23);
            this.btnOpenFolder.TabIndex = 3;
            this.btnOpenFolder.Text = "打开输出目录";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // frmIBatisGeneratorMain
            // 
            this.ClientSize = new System.Drawing.Size(532, 562);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.lblProccess);
            this.Controls.Add(this.btnGenerator);
            this.Controls.Add(this.btnSaveIni);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "frmIBatisGeneratorMain";
            this.Text = "IBatisNet生成工具";
            this.Resize += new System.EventHandler(this.frmIBatisGeneratorMain_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSaveIni;
        private Button btnGenerator;
        private PropertyGrid propertyGrid1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblProccess;
        private Button btnOpenFolder;

    }
}

