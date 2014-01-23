namespace MISClient.UI.FinanceManagement
{
    partial class UI_AddPayment
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
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.label_order = new DevExpress.XtraEditors.LabelControl();
            this.text_kpje = new DevExpress.XtraEditors.TextEdit();
            this.text_company = new DevExpress.XtraEditors.TextEdit();
            this.text_Pay = new DevExpress.XtraEditors.TextEdit();
            this.memo_memo = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.label_kpje = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.label_pay = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.date_time = new DevExpress.XtraEditors.DateEdit();
            this.text_NO = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_kpje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_company.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Pay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_memo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_time.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_time.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_NO.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.radioGroup1);
            this.groupControl1.Controls.Add(this.label_order);
            this.groupControl1.Controls.Add(this.text_kpje);
            this.groupControl1.Controls.Add(this.text_company);
            this.groupControl1.Controls.Add(this.text_Pay);
            this.groupControl1.Controls.Add(this.memo_memo);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.label_kpje);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.label_pay);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.date_time);
            this.groupControl1.Controls.Add(this.text_NO);
            this.groupControl1.Location = new System.Drawing.Point(12, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(431, 214);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "开票回款";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(247, 26);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "回款"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "开票")});
            this.radioGroup1.Size = new System.Drawing.Size(166, 37);
            this.radioGroup1.TabIndex = 19;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // label_order
            // 
            this.label_order.Location = new System.Drawing.Point(83, 26);
            this.label_order.Name = "label_order";
            this.label_order.Size = new System.Drawing.Size(44, 14);
            this.label_order.TabIndex = 13;
            this.label_order.Text = "-----------";
            // 
            // text_kpje
            // 
            this.text_kpje.Location = new System.Drawing.Point(313, 72);
            this.text_kpje.Name = "text_kpje";
            this.text_kpje.Size = new System.Drawing.Size(100, 20);
            this.text_kpje.TabIndex = 11;
            // 
            // text_company
            // 
            this.text_company.Location = new System.Drawing.Point(83, 98);
            this.text_company.Name = "text_company";
            this.text_company.Size = new System.Drawing.Size(100, 20);
            this.text_company.TabIndex = 10;
            // 
            // text_Pay
            // 
            this.text_Pay.Location = new System.Drawing.Point(83, 72);
            this.text_Pay.Name = "text_Pay";
            this.text_Pay.Size = new System.Drawing.Size(100, 20);
            this.text_Pay.TabIndex = 9;
            // 
            // memo_memo
            // 
            this.memo_memo.Location = new System.Drawing.Point(83, 124);
            this.memo_memo.Name = "memo_memo";
            this.memo_memo.Size = new System.Drawing.Size(330, 80);
            this.memo_memo.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(247, 101);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 14);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "添加时间：";
            // 
            // label_kpje
            // 
            this.label_kpje.Location = new System.Drawing.Point(247, 75);
            this.label_kpje.Name = "label_kpje";
            this.label_kpje.Size = new System.Drawing.Size(60, 14);
            this.label_kpje.TabIndex = 5;
            this.label_kpje.Text = "开票金额：";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(17, 126);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 14);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "备      注：";
            // 
            // label_pay
            // 
            this.label_pay.Location = new System.Drawing.Point(17, 75);
            this.label_pay.Name = "label_pay";
            this.label_pay.Size = new System.Drawing.Size(60, 14);
            this.label_pay.TabIndex = 3;
            this.label_pay.Text = "回款金额：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "付款单位：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "工单号：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "项目编号：";
            // 
            // date_time
            // 
            this.date_time.EditValue = null;
            this.date_time.Location = new System.Drawing.Point(313, 98);
            this.date_time.Name = "date_time";
            this.date_time.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_time.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_time.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.date_time.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.date_time.Properties.Mask.EditMask = "";
            this.date_time.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.date_time.Size = new System.Drawing.Size(100, 20);
            this.date_time.TabIndex = 12;
            // 
            // text_NO
            // 
            this.text_NO.Location = new System.Drawing.Point(83, 46);
            this.text_NO.Name = "text_NO";
            this.text_NO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text_NO.Properties.NullText = "";
            this.text_NO.Size = new System.Drawing.Size(100, 20);
            this.text_NO.TabIndex = 8;
            // 
            // UI_AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 255);
            this.Controls.Add(this.groupControl1);
            this.Name = "UI_AddPayment";
            this.Text = "开票回款表单";
            this.Controls.SetChildIndex(this.btn_save, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_kpje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_company.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Pay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_memo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_time.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_time.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_NO.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit memo_memo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl label_kpje;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl label_pay;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit text_kpje;
        private DevExpress.XtraEditors.TextEdit text_company;
        private DevExpress.XtraEditors.TextEdit text_Pay;
        private DevExpress.XtraEditors.LabelControl label_order;
        private DevExpress.XtraEditors.DateEdit date_time;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.LookUpEdit text_NO;
    }
}