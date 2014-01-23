namespace MISClient.UI.ProjectManagement
{
    partial class UI_ModifyMaterialClass
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_M_Name = new DevExpress.XtraEditors.TextEdit();
            this.txt_M_Type = new DevExpress.XtraEditors.TextEdit();
            this.txt_M_Unit = new DevExpress.XtraEditors.TextEdit();
            this.txt_M_Code = new DevExpress.XtraEditors.TextEdit();
            this.txt_M_Memo = new DevExpress.XtraEditors.TextEdit();
            this.txt_M_Class = new DevExpress.XtraEditors.TextEdit();
            this.btn_OK = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_M_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_M_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_M_Unit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_M_Code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_M_Memo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_M_Class.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "材料名称";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "材料型号";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(32, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "材料单位";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(32, 90);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "材料代号";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(32, 116);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "材料备注";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(32, 142);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "材料类别";
            // 
            // txt_M_Name
            // 
            this.txt_M_Name.Location = new System.Drawing.Point(86, 9);
            this.txt_M_Name.Name = "txt_M_Name";
            this.txt_M_Name.Size = new System.Drawing.Size(163, 20);
            this.txt_M_Name.TabIndex = 6;
            // 
            // txt_M_Type
            // 
            this.txt_M_Type.Location = new System.Drawing.Point(86, 36);
            this.txt_M_Type.Name = "txt_M_Type";
            this.txt_M_Type.Size = new System.Drawing.Size(163, 20);
            this.txt_M_Type.TabIndex = 7;
            // 
            // txt_M_Unit
            // 
            this.txt_M_Unit.Location = new System.Drawing.Point(86, 61);
            this.txt_M_Unit.Name = "txt_M_Unit";
            this.txt_M_Unit.Size = new System.Drawing.Size(163, 20);
            this.txt_M_Unit.TabIndex = 8;
            // 
            // txt_M_Code
            // 
            this.txt_M_Code.Location = new System.Drawing.Point(86, 87);
            this.txt_M_Code.Name = "txt_M_Code";
            this.txt_M_Code.Size = new System.Drawing.Size(163, 20);
            this.txt_M_Code.TabIndex = 9;
            // 
            // txt_M_Memo
            // 
            this.txt_M_Memo.Location = new System.Drawing.Point(86, 113);
            this.txt_M_Memo.Name = "txt_M_Memo";
            this.txt_M_Memo.Size = new System.Drawing.Size(163, 20);
            this.txt_M_Memo.TabIndex = 10;
            // 
            // txt_M_Class
            // 
            this.txt_M_Class.Location = new System.Drawing.Point(86, 139);
            this.txt_M_Class.Name = "txt_M_Class";
            this.txt_M_Class.Size = new System.Drawing.Size(163, 20);
            this.txt_M_Class.TabIndex = 11;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(56, 175);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 12;
            this.btn_OK.Text = "确认";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(137, 175);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // UI_ModifyMaterialClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 219);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_M_Class);
            this.Controls.Add(this.txt_M_Memo);
            this.Controls.Add(this.txt_M_Code);
            this.Controls.Add(this.txt_M_Unit);
            this.Controls.Add(this.txt_M_Type);
            this.Controls.Add(this.txt_M_Name);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "UI_ModifyMaterialClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改材料类别";
            this.Load += new System.EventHandler(this.ModifyMaterialClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_M_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_M_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_M_Unit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_M_Code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_M_Memo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_M_Class.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_M_Name;
        private DevExpress.XtraEditors.TextEdit txt_M_Type;
        private DevExpress.XtraEditors.TextEdit txt_M_Unit;
        private DevExpress.XtraEditors.TextEdit txt_M_Code;
        private DevExpress.XtraEditors.TextEdit txt_M_Memo;
        private DevExpress.XtraEditors.TextEdit txt_M_Class;
        private DevExpress.XtraEditors.SimpleButton btn_OK;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
    }
}