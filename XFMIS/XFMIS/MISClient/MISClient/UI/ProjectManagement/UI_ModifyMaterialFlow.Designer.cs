namespace MISClient.UI.ProjectManagement
{
    partial class UI_ModifyMaterialFlow
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
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_OK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.label_Flag = new DevExpress.XtraEditors.LabelControl();
            this.txt_Amount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ce_In = new DevExpress.XtraEditors.CheckEdit();
            this.ce_Out = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Memo = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Amount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_In.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_Out.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Memo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(148, 192);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 25;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(43, 192);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 24;
            this.btn_OK.Text = "确认";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(20, 121);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "备注";
            // 
            // label_Flag
            // 
            this.label_Flag.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label_Flag.Appearance.ForeColor = System.Drawing.Color.Red;
            this.label_Flag.Location = new System.Drawing.Point(80, 37);
            this.label_Flag.Name = "label_Flag";
            this.label_Flag.Size = new System.Drawing.Size(7, 24);
            this.label_Flag.TabIndex = 21;
            this.label_Flag.Text = "-";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(90, 41);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(151, 20);
            this.txt_Amount.TabIndex = 20;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "数量";
            // 
            // ce_In
            // 
            this.ce_In.Location = new System.Drawing.Point(174, 13);
            this.ce_In.Name = "ce_In";
            this.ce_In.Properties.Caption = "入库";
            this.ce_In.Size = new System.Drawing.Size(49, 19);
            this.ce_In.TabIndex = 18;
            this.ce_In.CheckedChanged += new System.EventHandler(this.ce_In_CheckedChanged);
            // 
            // ce_Out
            // 
            this.ce_Out.EditValue = true;
            this.ce_Out.Location = new System.Drawing.Point(104, 13);
            this.ce_Out.Name = "ce_Out";
            this.ce_Out.Properties.Caption = "出库";
            this.ce_Out.Size = new System.Drawing.Size(49, 19);
            this.ce_Out.TabIndex = 17;
            this.ce_Out.CheckedChanged += new System.EventHandler(this.ce_Out_CheckedChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "类别";
            // 
            // txt_Memo
            // 
            this.txt_Memo.Location = new System.Drawing.Point(90, 79);
            this.txt_Memo.Name = "txt_Memo";
            this.txt_Memo.Size = new System.Drawing.Size(151, 93);
            this.txt_Memo.TabIndex = 23;
            // 
            // UI_ModifyMaterialFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 249);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.label_Flag);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ce_In);
            this.Controls.Add(this.ce_Out);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_Memo);
            this.Name = "UI_ModifyMaterialFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料流水修改";
            this.Load += new System.EventHandler(this.UI_ModifyMaterialFlow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Amount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_In.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_Out.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Memo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_OK;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl label_Flag;
        private DevExpress.XtraEditors.TextEdit txt_Amount;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit ce_In;
        private DevExpress.XtraEditors.CheckEdit ce_Out;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txt_Memo;
    }
}