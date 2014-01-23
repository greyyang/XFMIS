namespace MISClient.UI.ProjectManagement
{
    partial class UI_ShowMaterialFlow
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Modify = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.ce_MaterialIn = new DevExpress.XtraEditors.CheckEdit();
            this.ce_MaterialOut = new DevExpress.XtraEditors.CheckEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ce_MaterialIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_MaterialOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_Modify);
            this.groupControl1.Controls.Add(this.btn_Delete);
            this.groupControl1.Controls.Add(this.ce_MaterialIn);
            this.groupControl1.Controls.Add(this.ce_MaterialOut);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(896, 94);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "材料流水";
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(149, 41);
            this.btn_Modify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(130, 30);
            this.btn_Modify.TabIndex = 7;
            this.btn_Modify.Text = "修改材料流水记录";
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(14, 41);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(128, 30);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "删除材料流水记录";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // ce_MaterialIn
            // 
            this.ce_MaterialIn.EditValue = true;
            this.ce_MaterialIn.Location = new System.Drawing.Point(791, 46);
            this.ce_MaterialIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ce_MaterialIn.Name = "ce_MaterialIn";
            this.ce_MaterialIn.Properties.Caption = "物料入";
            this.ce_MaterialIn.Size = new System.Drawing.Size(86, 23);
            this.ce_MaterialIn.TabIndex = 4;
            this.ce_MaterialIn.CheckedChanged += new System.EventHandler(this.ce_MaterialIn_CheckedChanged);
            // 
            // ce_MaterialOut
            // 
            this.ce_MaterialOut.EditValue = true;
            this.ce_MaterialOut.Location = new System.Drawing.Point(698, 46);
            this.ce_MaterialOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ce_MaterialOut.Name = "ce_MaterialOut";
            this.ce_MaterialOut.Properties.Caption = "物料出";
            this.ce_MaterialOut.Size = new System.Drawing.Size(86, 23);
            this.ce_MaterialOut.TabIndex = 3;
            this.ce_MaterialOut.CheckedChanged += new System.EventHandler(this.ce_MaterialOut_CheckedChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 94);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(896, 627);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // UI_ShowMaterialFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 721);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UI_ShowMaterialFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "材料流水";
            this.Load += new System.EventHandler(this.UI_ShowMaterialFlow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ce_MaterialIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_MaterialOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Modify;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.CheckEdit ce_MaterialIn;
        private DevExpress.XtraEditors.CheckEdit ce_MaterialOut;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}