namespace MISClient.UI.ProjectManagement
{
    partial class UI_MaterialClassManagement
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
            this.btn_AddMaterialClass = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ModifyMaterialClass = new DevExpress.XtraEditors.SimpleButton();
            this.btn_DeleteMaterialClass = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gc_MaterialClassList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_MaterialClassList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddMaterialClass
            // 
            this.btn_AddMaterialClass.Location = new System.Drawing.Point(5, 25);
            this.btn_AddMaterialClass.Name = "btn_AddMaterialClass";
            this.btn_AddMaterialClass.Size = new System.Drawing.Size(91, 23);
            this.btn_AddMaterialClass.TabIndex = 0;
            this.btn_AddMaterialClass.Text = "添加材料类别";
            this.btn_AddMaterialClass.Click += new System.EventHandler(this.btn_AddMaterialClass_Click);
            // 
            // btn_ModifyMaterialClass
            // 
            this.btn_ModifyMaterialClass.Location = new System.Drawing.Point(102, 25);
            this.btn_ModifyMaterialClass.Name = "btn_ModifyMaterialClass";
            this.btn_ModifyMaterialClass.Size = new System.Drawing.Size(91, 23);
            this.btn_ModifyMaterialClass.TabIndex = 2;
            this.btn_ModifyMaterialClass.Text = "修改材料类别";
            this.btn_ModifyMaterialClass.Click += new System.EventHandler(this.btn_ModifyMaterialClass_Click);
            // 
            // btn_DeleteMaterialClass
            // 
            this.btn_DeleteMaterialClass.Location = new System.Drawing.Point(199, 25);
            this.btn_DeleteMaterialClass.Name = "btn_DeleteMaterialClass";
            this.btn_DeleteMaterialClass.Size = new System.Drawing.Size(91, 23);
            this.btn_DeleteMaterialClass.TabIndex = 3;
            this.btn_DeleteMaterialClass.Text = "删除材料类别";
            this.btn_DeleteMaterialClass.Click += new System.EventHandler(this.btn_DeleteMaterialClass_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_AddMaterialClass);
            this.groupControl1.Controls.Add(this.btn_DeleteMaterialClass);
            this.groupControl1.Controls.Add(this.btn_ModifyMaterialClass);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(784, 80);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "材料类别管理";
            // 
            // gc_MaterialClassList
            // 
            this.gc_MaterialClassList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_MaterialClassList.Location = new System.Drawing.Point(0, 80);
            this.gc_MaterialClassList.MainView = this.gridView1;
            this.gc_MaterialClassList.Name = "gc_MaterialClassList";
            this.gc_MaterialClassList.Size = new System.Drawing.Size(784, 481);
            this.gc_MaterialClassList.TabIndex = 5;
            this.gc_MaterialClassList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc_MaterialClassList;
            this.gridView1.Name = "gridView1";
            // 
            // UI_MaterialClassManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gc_MaterialClassList);
            this.Controls.Add(this.groupControl1);
            this.Name = "UI_MaterialClassManagement";
            this.Text = "材料类别管理";
            this.Load += new System.EventHandler(this.UI_MaterialClassManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_MaterialClassList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_AddMaterialClass;
        private DevExpress.XtraEditors.SimpleButton btn_ModifyMaterialClass;
        private DevExpress.XtraEditors.SimpleButton btn_DeleteMaterialClass;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gc_MaterialClassList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}