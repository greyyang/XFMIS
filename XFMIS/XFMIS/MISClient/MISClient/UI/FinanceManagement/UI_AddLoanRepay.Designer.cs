namespace MISClient.UI.FinanceManagement
{
    partial class UI_AddLoanRepay
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
            this.text_doer = new DevExpress.XtraEditors.TextEdit();
            this.text_BankNO = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.label_order = new DevExpress.XtraEditors.LabelControl();
            this.text_Repay = new DevExpress.XtraEditors.TextEdit();
            this.text_inputer = new DevExpress.XtraEditors.TextEdit();
            this.text_Loan = new DevExpress.XtraEditors.TextEdit();
            this.memo_memo = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.label_Repay = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.label_Loan = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.date_time = new DevExpress.XtraEditors.DateEdit();
            this.text_NO = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_doer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_BankNO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Repay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_inputer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Loan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_memo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_time.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_time.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_NO.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.radioGroup1);
            this.groupControl1.Controls.Add(this.text_doer);
            this.groupControl1.Controls.Add(this.text_BankNO);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.label_order);
            this.groupControl1.Controls.Add(this.text_Repay);
            this.groupControl1.Controls.Add(this.text_inputer);
            this.groupControl1.Controls.Add(this.text_Loan);
            this.groupControl1.Controls.Add(this.memo_memo);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.label_Repay);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.label_Loan);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.date_time);
            this.groupControl1.Controls.Add(this.text_NO);
            this.groupControl1.Location = new System.Drawing.Point(12, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(431, 214);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "借还款";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(247, 26);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "借款"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "还款")});
            this.radioGroup1.Size = new System.Drawing.Size(166, 37);
            this.radioGroup1.TabIndex = 18;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // text_doer
            // 
            this.text_doer.Location = new System.Drawing.Point(313, 125);
            this.text_doer.Name = "text_doer";
            this.text_doer.Size = new System.Drawing.Size(100, 20);
            this.text_doer.TabIndex = 17;
            // 
            // text_BankNO
            // 
            this.text_BankNO.Location = new System.Drawing.Point(83, 125);
            this.text_BankNO.Name = "text_BankNO";
            this.text_BankNO.Size = new System.Drawing.Size(158, 20);
            this.text_BankNO.TabIndex = 16;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(247, 128);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(60, 14);
            this.labelControl10.TabIndex = 15;
            this.labelControl10.Text = "借还款人：";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(17, 128);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(52, 14);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "银行账号:";
            // 
            // label_order
            // 
            this.label_order.Location = new System.Drawing.Point(83, 26);
            this.label_order.Name = "label_order";
            this.label_order.Size = new System.Drawing.Size(44, 14);
            this.label_order.TabIndex = 13;
            this.label_order.Text = "-----------";
            // 
            // text_Repay
            // 
            this.text_Repay.Location = new System.Drawing.Point(313, 72);
            this.text_Repay.Name = "text_Repay";
            this.text_Repay.Size = new System.Drawing.Size(100, 20);
            this.text_Repay.TabIndex = 11;
            // 
            // text_inputer
            // 
            this.text_inputer.Location = new System.Drawing.Point(83, 98);
            this.text_inputer.Name = "text_inputer";
            this.text_inputer.Size = new System.Drawing.Size(100, 20);
            this.text_inputer.TabIndex = 10;
            // 
            // text_Loan
            // 
            this.text_Loan.Location = new System.Drawing.Point(83, 72);
            this.text_Loan.Name = "text_Loan";
            this.text_Loan.Size = new System.Drawing.Size(100, 20);
            this.text_Loan.TabIndex = 9;
            // 
            // memo_memo
            // 
            this.memo_memo.Location = new System.Drawing.Point(83, 151);
            this.memo_memo.Name = "memo_memo";
            this.memo_memo.Size = new System.Drawing.Size(330, 53);
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
            // label_Repay
            // 
            this.label_Repay.Location = new System.Drawing.Point(247, 75);
            this.label_Repay.Name = "label_Repay";
            this.label_Repay.Size = new System.Drawing.Size(60, 14);
            this.label_Repay.TabIndex = 5;
            this.label_Repay.Text = "还款金额：";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(17, 154);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 14);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "备      注：";
            // 
            // label_Loan
            // 
            this.label_Loan.Location = new System.Drawing.Point(17, 75);
            this.label_Loan.Name = "label_Loan";
            this.label_Loan.Size = new System.Drawing.Size(60, 14);
            this.label_Loan.TabIndex = 3;
            this.label_Loan.Text = "借款金额：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "经手人:";
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
            this.labelControl1.Location = new System.Drawing.Point(5, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "子项目编号：";
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
            // UI_AddLoanRepay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 258);
            this.Controls.Add(this.groupControl1);
            this.Name = "UI_AddLoanRepay";
            this.Text = "借还款表单";
            this.Controls.SetChildIndex(this.btn_save, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_doer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_BankNO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Repay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_inputer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Loan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_memo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_time.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_time.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_NO.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit text_Repay;
        private DevExpress.XtraEditors.TextEdit text_inputer;
        private DevExpress.XtraEditors.TextEdit text_Loan;
        private DevExpress.XtraEditors.MemoEdit memo_memo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl label_Repay;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl label_Loan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl label_order;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit text_doer;
        private DevExpress.XtraEditors.TextEdit text_BankNO;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.DateEdit date_time;
        private DevExpress.XtraEditors.LookUpEdit text_NO;

    }
}