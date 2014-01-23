namespace MISClient.UI.ProjectManagement
{
    partial class UI_MaterialFlowManagement
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
            this.btnShowChooseMaterialFlow = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ShowAllMaterialFlow = new DevExpress.XtraEditors.SimpleButton();
            this.gc_MaterialCountList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_MaterialCountList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_Add);
            this.groupControl1.Controls.Add(this.btnShowChooseMaterialFlow);
            this.groupControl1.Controls.Add(this.btn_ShowAllMaterialFlow);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(784, 74);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "材料库存管理";
            // 
            // btnShowChooseMaterialFlow
            // 
            this.btnShowChooseMaterialFlow.Location = new System.Drawing.Point(131, 32);
            this.btnShowChooseMaterialFlow.Name = "btnShowChooseMaterialFlow";
            this.btnShowChooseMaterialFlow.Size = new System.Drawing.Size(123, 23);
            this.btnShowChooseMaterialFlow.TabIndex = 4;
            this.btnShowChooseMaterialFlow.Text = "显示选定材料流水";
            this.btnShowChooseMaterialFlow.Click += new System.EventHandler(this.btnShowChooseMaterialFlow_Click);
            // 
            // btn_ShowAllMaterialFlow
            // 
            this.btn_ShowAllMaterialFlow.Location = new System.Drawing.Point(12, 32);
            this.btn_ShowAllMaterialFlow.Name = "btn_ShowAllMaterialFlow";
            this.btn_ShowAllMaterialFlow.Size = new System.Drawing.Size(113, 23);
            this.btn_ShowAllMaterialFlow.TabIndex = 3;
            this.btn_ShowAllMaterialFlow.Text = "显示所有材料流水";
            this.btn_ShowAllMaterialFlow.Click += new System.EventHandler(this.btn_ShowAllMaterialFlow_Click);
            // 
            // gc_MaterialCountList
            // 
            this.gc_MaterialCountList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_MaterialCountList.Location = new System.Drawing.Point(0, 74);
            this.gc_MaterialCountList.MainView = this.gridView1;
            this.gc_MaterialCountList.Name = "gc_MaterialCountList";
            this.gc_MaterialCountList.Size = new System.Drawing.Size(784, 487);
            this.gc_MaterialCountList.TabIndex = 4;
            this.gc_MaterialCountList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc_MaterialCountList;
            this.gridView1.Name = "gridView1";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(260, 32);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(112, 23);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "添加材料流水记录";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // UI_MaterialFlowManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gc_MaterialCountList);
            this.Controls.Add(this.groupControl1);
            this.Name = "UI_MaterialFlowManagement";
            this.Text = "材料库存管理";
            this.Load += new System.EventHandler(this.UI_MaterialFlowManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_MaterialCountList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gc_MaterialCountList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_ShowAllMaterialFlow;
        private DevExpress.XtraEditors.SimpleButton btnShowChooseMaterialFlow;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
    }
}