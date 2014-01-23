namespace MISClient.UI.SystemManagement
{
    partial class UI_PasswordManagement
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
            this.txt_OldPassword = new DevExpress.XtraEditors.TextEdit();
            this.txt_NewPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_OK = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_OldPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ConfirmPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "旧密码";
            // 
            // txt_OldPassword
            // 
            this.txt_OldPassword.Location = new System.Drawing.Point(84, 27);
            this.txt_OldPassword.Name = "txt_OldPassword";
            this.txt_OldPassword.Properties.PasswordChar = '*';
            this.txt_OldPassword.Size = new System.Drawing.Size(100, 20);
            this.txt_OldPassword.TabIndex = 1;
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.Location = new System.Drawing.Point(84, 53);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Properties.PasswordChar = '*';
            this.txt_NewPassword.Size = new System.Drawing.Size(100, 20);
            this.txt_NewPassword.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "新密码";
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(84, 79);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Properties.PasswordChar = '*';
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.txt_ConfirmPassword.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "确认密码";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(55, 116);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(48, 27);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "确认";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(109, 116);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(48, 27);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // UI_PasswordManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 179);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_NewPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_OldPassword);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UI_PasswordManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码管理";
            this.Load += new System.EventHandler(this.UI_PasswordManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_OldPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ConfirmPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_OldPassword;
        private DevExpress.XtraEditors.TextEdit txt_NewPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_ConfirmPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_OK;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;


    }
}