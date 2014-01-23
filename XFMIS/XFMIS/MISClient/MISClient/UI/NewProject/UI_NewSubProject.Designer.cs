namespace MISClient.UI.NewProject
{
    partial class UI_NewSubProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_ProjectId = new DevExpress.XtraEditors.LookUpEdit();
            this.cmb_ProjectName = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.text_Tel = new DevExpress.XtraEditors.TextEdit();
            this.text_Manager = new DevExpress.XtraEditors.TextEdit();
            this.text_Ratio = new DevExpress.XtraEditors.TextEdit();
            this.text_ContractAmount = new DevExpress.XtraEditors.TextEdit();
            this.text_Auditors = new DevExpress.XtraEditors.TextEdit();
            this.text_SubProjectName = new DevExpress.XtraEditors.TextEdit();
            this.text_SubProjectNO = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.tabProjectInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uINewPlaningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ProjectId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ProjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_Tel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Manager.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Ratio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_ContractAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Auditors.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_SubProjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_SubProjectNO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabProjectInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uINewPlaningBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cmb_ProjectId);
            this.groupControl1.Controls.Add(this.cmb_ProjectName);
            this.groupControl1.Location = new System.Drawing.Point(10, 61);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(570, 70);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "所属主项目";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(295, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "主项目名称:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "主项目编号:";
            // 
            // cmb_ProjectId
            // 
            this.cmb_ProjectId.Location = new System.Drawing.Point(78, 35);
            this.cmb_ProjectId.Name = "cmb_ProjectId";
            this.cmb_ProjectId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ProjectId.Properties.NullText = "";
            this.cmb_ProjectId.Properties.PopupSizeable = false;
            this.cmb_ProjectId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmb_ProjectId.Size = new System.Drawing.Size(198, 20);
            this.cmb_ProjectId.TabIndex = 3;
            this.cmb_ProjectId.EditValueChanged += new System.EventHandler(this.cmb_ProjectId_EditValueChanged);
            // 
            // cmb_ProjectName
            // 
            this.cmb_ProjectName.Location = new System.Drawing.Point(365, 35);
            this.cmb_ProjectName.Name = "cmb_ProjectName";
            this.cmb_ProjectName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ProjectName.Properties.NullText = "";
            this.cmb_ProjectName.Properties.PopupSizeable = false;
            this.cmb_ProjectName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmb_ProjectName.Size = new System.Drawing.Size(200, 20);
            this.cmb_ProjectName.TabIndex = 4;
            this.cmb_ProjectName.EditValueChanged += new System.EventHandler(this.cmb_ProjectName_EditValueChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.text_Tel);
            this.groupControl2.Controls.Add(this.text_Manager);
            this.groupControl2.Controls.Add(this.text_Ratio);
            this.groupControl2.Controls.Add(this.text_ContractAmount);
            this.groupControl2.Controls.Add(this.text_Auditors);
            this.groupControl2.Controls.Add(this.text_SubProjectName);
            this.groupControl2.Controls.Add(this.text_SubProjectNO);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.dateEdit);
            this.groupControl2.Location = new System.Drawing.Point(10, 138);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(570, 133);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "子项目信息";
            // 
            // text_Tel
            // 
            this.text_Tel.Location = new System.Drawing.Point(365, 103);
            this.text_Tel.Name = "text_Tel";
            this.text_Tel.Size = new System.Drawing.Size(200, 20);
            this.text_Tel.TabIndex = 21;
            // 
            // text_Manager
            // 
            this.text_Manager.Location = new System.Drawing.Point(78, 103);
            this.text_Manager.Name = "text_Manager";
            this.text_Manager.Size = new System.Drawing.Size(198, 20);
            this.text_Manager.TabIndex = 20;
            // 
            // text_Ratio
            // 
            this.text_Ratio.Location = new System.Drawing.Point(78, 77);
            this.text_Ratio.Name = "text_Ratio";
            this.text_Ratio.Size = new System.Drawing.Size(198, 20);
            this.text_Ratio.TabIndex = 18;
            // 
            // text_ContractAmount
            // 
            this.text_ContractAmount.Location = new System.Drawing.Point(78, 51);
            this.text_ContractAmount.Name = "text_ContractAmount";
            this.text_ContractAmount.Size = new System.Drawing.Size(198, 20);
            this.text_ContractAmount.TabIndex = 17;
            // 
            // text_Auditors
            // 
            this.text_Auditors.Location = new System.Drawing.Point(365, 51);
            this.text_Auditors.Name = "text_Auditors";
            this.text_Auditors.Size = new System.Drawing.Size(200, 20);
            this.text_Auditors.TabIndex = 16;
            // 
            // text_SubProjectName
            // 
            this.text_SubProjectName.Location = new System.Drawing.Point(365, 25);
            this.text_SubProjectName.Name = "text_SubProjectName";
            this.text_SubProjectName.Size = new System.Drawing.Size(200, 20);
            this.text_SubProjectName.TabIndex = 15;
            // 
            // text_SubProjectNO
            // 
            this.text_SubProjectNO.Location = new System.Drawing.Point(78, 25);
            this.text_SubProjectNO.Name = "text_SubProjectNO";
            this.text_SubProjectNO.Size = new System.Drawing.Size(198, 20);
            this.text_SubProjectNO.TabIndex = 14;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(8, 106);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(64, 14);
            this.labelControl11.TabIndex = 13;
            this.labelControl11.Text = "项 目 经 理:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(295, 54);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(64, 14);
            this.labelControl10.TabIndex = 12;
            this.labelControl10.Text = "审 计 金 额:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(8, 54);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(64, 14);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "协 议 金 额:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(295, 28);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 14);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "项 目 名 称:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(295, 106);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 14);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "联 系 方 式:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(8, 80);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 14);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "成本占收比:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(295, 80);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 14);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "添 加 日 期:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(8, 28);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 14);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "项 目 编 号:";
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(365, 77);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEdit.Properties.Mask.EditMask = "";
            this.dateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dateEdit.Size = new System.Drawing.Size(200, 20);
            this.dateEdit.TabIndex = 19;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(592, 330);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.Highlight;
            this.lineShape2.BorderWidth = 5;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 10;
            this.lineShape2.X2 = 578;
            this.lineShape2.Y1 = 282;
            this.lineShape2.Y2 = 282;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.Highlight;
            this.lineShape1.BorderWidth = 5;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 10;
            this.lineShape1.X2 = 578;
            this.lineShape1.Y1 = 50;
            this.lineShape1.Y2 = 50;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl2.Location = new System.Drawing.Point(18, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 28);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "新建子项目";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(183, 295);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "确  定";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(330, 295);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "取  消";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // tabProjectInfoBindingSource
            // 
            this.tabProjectInfoBindingSource.DataSource = typeof(MISClient.Service_NewProject.TabProjectInfo);
            // 
            // uINewPlaningBindingSource
            // 
            this.uINewPlaningBindingSource.DataSource = typeof(MISClient.UI.NewProject.UI_NewPlaning);
            // 
            // UI_NewSubProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 330);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "UI_NewSubProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新建子项目";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ProjectId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ProjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_Tel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Manager.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Ratio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_ContractAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Auditors.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_SubProjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_SubProjectNO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabProjectInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uINewPlaningBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit text_Tel;
        private DevExpress.XtraEditors.TextEdit text_Manager;
        private DevExpress.XtraEditors.TextEdit text_Ratio;
        private DevExpress.XtraEditors.TextEdit text_ContractAmount;
        private DevExpress.XtraEditors.TextEdit text_Auditors;
        private DevExpress.XtraEditors.TextEdit text_SubProjectName;
        private DevExpress.XtraEditors.TextEdit text_SubProjectNO;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private DevExpress.XtraEditors.LookUpEdit cmb_ProjectId;
        private System.Windows.Forms.BindingSource uINewPlaningBindingSource;
        private System.Windows.Forms.BindingSource tabProjectInfoBindingSource;
        private DevExpress.XtraEditors.LookUpEdit cmb_ProjectName;
    }
}