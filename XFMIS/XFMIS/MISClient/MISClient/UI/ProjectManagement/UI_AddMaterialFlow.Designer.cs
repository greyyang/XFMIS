namespace MISClient.UI.ProjectManagement
{
    partial class UI_AddMaterialFlow
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_ProjectNo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_SubProjectNo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ce_Out = new DevExpress.XtraEditors.CheckEdit();
            this.ce_In = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Amount = new DevExpress.XtraEditors.TextEdit();
            this.label_Flag = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Memo = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_MaterialName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btn_OK = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.label_SubProjectName = new DevExpress.XtraEditors.LabelControl();
            this.label_ProjectName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ProjectNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SubProjectNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_Out.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_In.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Amount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Memo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MaterialName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "项目编号";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 55);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "子项目编号";
            // 
            // cmb_ProjectNo
            // 
            this.cmb_ProjectNo.Location = new System.Drawing.Point(97, 12);
            this.cmb_ProjectNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_ProjectNo.Name = "cmb_ProjectNo";
            this.cmb_ProjectNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ProjectNo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_ProjectNo.Size = new System.Drawing.Size(173, 24);
            this.cmb_ProjectNo.TabIndex = 2;
            this.cmb_ProjectNo.SelectedIndexChanged += new System.EventHandler(this.cmb_ProjectNo_SelectedIndexChanged);
            // 
            // cmb_SubProjectNo
            // 
            this.cmb_SubProjectNo.Location = new System.Drawing.Point(97, 51);
            this.cmb_SubProjectNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_SubProjectNo.Name = "cmb_SubProjectNo";
            this.cmb_SubProjectNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_SubProjectNo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_SubProjectNo.Size = new System.Drawing.Size(173, 24);
            this.cmb_SubProjectNo.TabIndex = 3;
            this.cmb_SubProjectNo.SelectedIndexChanged += new System.EventHandler(this.cmb_SubProjectNo_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 143);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "类别";
            // 
            // ce_Out
            // 
            this.ce_Out.EditValue = true;
            this.ce_Out.Location = new System.Drawing.Point(110, 140);
            this.ce_Out.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ce_Out.Name = "ce_Out";
            this.ce_Out.Properties.Caption = "出库";
            this.ce_Out.Size = new System.Drawing.Size(56, 23);
            this.ce_Out.TabIndex = 5;
            this.ce_Out.CheckedChanged += new System.EventHandler(this.ce_Out_CheckedChanged);
            // 
            // ce_In
            // 
            this.ce_In.Location = new System.Drawing.Point(190, 140);
            this.ce_In.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ce_In.Name = "ce_In";
            this.ce_In.Properties.Caption = "入库";
            this.ce_In.Size = new System.Drawing.Size(56, 23);
            this.ce_In.TabIndex = 6;
            this.ce_In.CheckedChanged += new System.EventHandler(this.ce_In_CheckedChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 180);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "数量";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(94, 176);
            this.txt_Amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(173, 24);
            this.txt_Amount.TabIndex = 8;
            // 
            // label_Flag
            // 
            this.label_Flag.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label_Flag.Appearance.ForeColor = System.Drawing.Color.Red;
            this.label_Flag.Location = new System.Drawing.Point(82, 171);
            this.label_Flag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_Flag.Name = "label_Flag";
            this.label_Flag.Size = new System.Drawing.Size(9, 30);
            this.label_Flag.TabIndex = 9;
            this.label_Flag.Text = "-";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 279);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 18);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "备注";
            // 
            // txt_Memo
            // 
            this.txt_Memo.Location = new System.Drawing.Point(94, 225);
            this.txt_Memo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Memo.Name = "txt_Memo";
            this.txt_Memo.Size = new System.Drawing.Size(173, 120);
            this.txt_Memo.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(14, 98);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 18);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "材料名称";
            // 
            // cmb_MaterialName
            // 
            this.cmb_MaterialName.Location = new System.Drawing.Point(97, 94);
            this.cmb_MaterialName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_MaterialName.Name = "cmb_MaterialName";
            this.cmb_MaterialName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_MaterialName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_MaterialName.Size = new System.Drawing.Size(173, 24);
            this.cmb_MaterialName.TabIndex = 13;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(40, 370);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(86, 30);
            this.btn_OK.TabIndex = 14;
            this.btn_OK.Text = "确认";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(160, 370);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(86, 30);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label_SubProjectName
            // 
            this.label_SubProjectName.Location = new System.Drawing.Point(295, 55);
            this.label_SubProjectName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_SubProjectName.Name = "label_SubProjectName";
            this.label_SubProjectName.Size = new System.Drawing.Size(0, 18);
            this.label_SubProjectName.TabIndex = 17;
            // 
            // label_ProjectName
            // 
            this.label_ProjectName.Location = new System.Drawing.Point(295, 15);
            this.label_ProjectName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_ProjectName.Name = "label_ProjectName";
            this.label_ProjectName.Size = new System.Drawing.Size(0, 18);
            this.label_ProjectName.TabIndex = 18;
            // 
            // UI_AddMaterialFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 428);
            this.Controls.Add(this.label_ProjectName);
            this.Controls.Add(this.label_SubProjectName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.cmb_MaterialName);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.label_Flag);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ce_In);
            this.Controls.Add(this.ce_Out);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmb_SubProjectNo);
            this.Controls.Add(this.cmb_ProjectNo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_Memo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UI_AddMaterialFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加材料流水记录";
            this.Load += new System.EventHandler(this.UI_AddMaterialFlow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ProjectNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SubProjectNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_Out.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_In.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Amount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Memo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MaterialName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_ProjectNo;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_SubProjectNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit ce_Out;
        private DevExpress.XtraEditors.CheckEdit ce_In;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Amount;
        private DevExpress.XtraEditors.LabelControl label_Flag;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txt_Memo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_MaterialName;
        private DevExpress.XtraEditors.SimpleButton btn_OK;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.LabelControl label_SubProjectName;
        private DevExpress.XtraEditors.LabelControl label_ProjectName;
    }
}