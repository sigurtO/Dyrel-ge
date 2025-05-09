namespace WinFormsApp1
{
    partial class InvoiceForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            comboBoxOwnerId = new ComboBox();
            comboBoxPetId = new ComboBox();
            numericUpDownTotalAmount = new NumericUpDown();
            comboBoxConsultationId = new ComboBox();
            comboBoxTreatmentId = new ComboBox();
            comboBoxItemId = new ComboBox();
            comboBoxCageId = new ComboBox();
            dataGridViewInvoice = new DataGridView();
            label9 = new Label();
            numericUpDownNetAmount = new NumericUpDown();
            numericUpDownDiscount = new NumericUpDown();
            buttonAddInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNetAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 22);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Owner Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 85);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Pet ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 361);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 2;
            label3.Text = "Total Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 143);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 3;
            label4.Text = "Consultation Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 202);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 4;
            label5.Text = "Treatment Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 292);
            label6.Name = "label6";
            label6.Size = new Size(146, 20);
            label6.TabIndex = 5;
            label6.Text = "Item (not added yet)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(244, 202);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 6;
            label7.Text = "Cage Id (yes no)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(222, 361);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 7;
            label8.Text = "Discount (%)";
            // 
            // comboBoxOwnerId
            // 
            comboBoxOwnerId.FormattingEnabled = true;
            comboBoxOwnerId.Location = new Point(43, 54);
            comboBoxOwnerId.Name = "comboBoxOwnerId";
            comboBoxOwnerId.Size = new Size(151, 28);
            comboBoxOwnerId.TabIndex = 8;
            // 
            // comboBoxPetId
            // 
            comboBoxPetId.FormattingEnabled = true;
            comboBoxPetId.Location = new Point(48, 112);
            comboBoxPetId.Name = "comboBoxPetId";
            comboBoxPetId.Size = new Size(151, 28);
            comboBoxPetId.TabIndex = 9;
            // 
            // numericUpDownTotalAmount
            // 
            numericUpDownTotalAmount.Location = new Point(48, 384);
            numericUpDownTotalAmount.Name = "numericUpDownTotalAmount";
            numericUpDownTotalAmount.Size = new Size(150, 27);
            numericUpDownTotalAmount.TabIndex = 10;
            // 
            // comboBoxConsultationId
            // 
            comboBoxConsultationId.FormattingEnabled = true;
            comboBoxConsultationId.Location = new Point(48, 171);
            comboBoxConsultationId.Name = "comboBoxConsultationId";
            comboBoxConsultationId.Size = new Size(151, 28);
            comboBoxConsultationId.TabIndex = 11;
            // 
            // comboBoxTreatmentId
            // 
            comboBoxTreatmentId.FormattingEnabled = true;
            comboBoxTreatmentId.Location = new Point(48, 234);
            comboBoxTreatmentId.Name = "comboBoxTreatmentId";
            comboBoxTreatmentId.Size = new Size(151, 28);
            comboBoxTreatmentId.TabIndex = 12;
            // 
            // comboBoxItemId
            // 
            comboBoxItemId.FormattingEnabled = true;
            comboBoxItemId.Location = new Point(43, 318);
            comboBoxItemId.Name = "comboBoxItemId";
            comboBoxItemId.Size = new Size(151, 28);
            comboBoxItemId.TabIndex = 13;
            // 
            // comboBoxCageId
            // 
            comboBoxCageId.FormattingEnabled = true;
            comboBoxCageId.Location = new Point(232, 234);
            comboBoxCageId.Name = "comboBoxCageId";
            comboBoxCageId.Size = new Size(151, 28);
            comboBoxCageId.TabIndex = 14;
            // 
            // dataGridViewInvoice
            // 
            dataGridViewInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoice.Location = new Point(580, 54);
            dataGridViewInvoice.Name = "dataGridViewInvoice";
            dataGridViewInvoice.RowHeadersWidth = 51;
            dataGridViewInvoice.Size = new Size(300, 188);
            dataGridViewInvoice.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 430);
            label9.Name = "label9";
            label9.Size = new Size(284, 20);
            label9.TabIndex = 17;
            label9.Text = "NetAmount (auto fill on discount change)";
            // 
            // numericUpDownNetAmount
            // 
            numericUpDownNetAmount.Location = new Point(48, 453);
            numericUpDownNetAmount.Name = "numericUpDownNetAmount";
            numericUpDownNetAmount.Size = new Size(150, 27);
            numericUpDownNetAmount.TabIndex = 18;
            // 
            // numericUpDownDiscount
            // 
            numericUpDownDiscount.Location = new Point(222, 384);
            numericUpDownDiscount.Name = "numericUpDownDiscount";
            numericUpDownDiscount.Size = new Size(150, 27);
            numericUpDownDiscount.TabIndex = 19;
            // 
            // buttonAddInvoice
            // 
            buttonAddInvoice.Location = new Point(466, 451);
            buttonAddInvoice.Name = "buttonAddInvoice";
            buttonAddInvoice.Size = new Size(94, 29);
            buttonAddInvoice.TabIndex = 20;
            buttonAddInvoice.Text = "buttonAddInvoice";
            buttonAddInvoice.UseVisualStyleBackColor = true;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 487);
            Controls.Add(buttonAddInvoice);
            Controls.Add(numericUpDownDiscount);
            Controls.Add(numericUpDownNetAmount);
            Controls.Add(label9);
            Controls.Add(dataGridViewInvoice);
            Controls.Add(comboBoxCageId);
            Controls.Add(comboBoxItemId);
            Controls.Add(comboBoxTreatmentId);
            Controls.Add(comboBoxConsultationId);
            Controls.Add(numericUpDownTotalAmount);
            Controls.Add(comboBoxPetId);
            Controls.Add(comboBoxOwnerId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InvoiceForm";
            Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNetAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxOwnerId;
        private ComboBox comboBoxPetId;
        private NumericUpDown numericUpDownTotalAmount;
        private ComboBox comboBoxConsultationId;
        private ComboBox comboBoxTreatmentId;
        private ComboBox comboBoxItemId;
        private ComboBox comboBoxCageId;
        private DataGridView dataGridViewInvoice;
        private Label label9;
        private NumericUpDown numericUpDownNetAmount;
        private NumericUpDown numericUpDownDiscount;
        private Button buttonAddInvoice;
    }
}