﻿namespace WinFormsApp1
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
            comboBoxConsultationId = new ComboBox();
            comboBoxTreatmentId = new ComboBox();
            comboBoxItemId = new ComboBox();
            comboBoxCageId = new ComboBox();
            dataGridViewInvoice = new DataGridView();
            label9 = new Label();
            numericUpDownDiscount = new NumericUpDown();
            buttonAddInvoice = new Button();
            textBoxTotalAmount = new TextBox();
            textBoxNetAmount = new TextBox();
            BackButtonInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 21);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Owner Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 85);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Pet ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 308);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 2;
            label3.Text = "Total Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 147);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 3;
            label4.Text = "Consultation Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 212);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 4;
            label5.Text = "Treatment Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(232, 85);
            label6.Name = "label6";
            label6.Size = new Size(146, 20);
            label6.TabIndex = 5;
            label6.Text = "Item (not added yet)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(232, 21);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 6;
            label7.Text = "Cage Id (yes no)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(224, 308);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 7;
            label8.Text = "Discount (%)";
            // 
            // comboBoxOwnerId
            // 
            comboBoxOwnerId.FormattingEnabled = true;
            comboBoxOwnerId.Location = new Point(43, 44);
            comboBoxOwnerId.Name = "comboBoxOwnerId";
            comboBoxOwnerId.Size = new Size(151, 28);
            comboBoxOwnerId.TabIndex = 8;
            comboBoxOwnerId.SelectedIndexChanged += comboBoxOwnerId_SelectedIndexChanged;
            // 
            // comboBoxPetId
            // 
            comboBoxPetId.FormattingEnabled = true;
            comboBoxPetId.Location = new Point(43, 108);
            comboBoxPetId.Name = "comboBoxPetId";
            comboBoxPetId.Size = new Size(151, 28);
            comboBoxPetId.TabIndex = 9;
            comboBoxPetId.SelectedIndexChanged += comboBoxPetId_SelectedIndexChanged;
            // 
            // comboBoxConsultationId
            // 
            comboBoxConsultationId.FormattingEnabled = true;
            comboBoxConsultationId.Location = new Point(43, 169);
            comboBoxConsultationId.Name = "comboBoxConsultationId";
            comboBoxConsultationId.Size = new Size(151, 28);
            comboBoxConsultationId.TabIndex = 11;
            comboBoxConsultationId.SelectedIndexChanged += comboBoxConsultationId_SelectedIndexChanged;
            // 
            // comboBoxTreatmentId
            // 
            comboBoxTreatmentId.FormattingEnabled = true;
            comboBoxTreatmentId.Location = new Point(43, 235);
            comboBoxTreatmentId.Name = "comboBoxTreatmentId";
            comboBoxTreatmentId.Size = new Size(151, 28);
            comboBoxTreatmentId.TabIndex = 12;
            comboBoxTreatmentId.SelectedIndexChanged += comboBoxTreatmentId_SelectedIndexChanged;
            // 
            // comboBoxItemId
            // 
            comboBoxItemId.FormattingEnabled = true;
            comboBoxItemId.Location = new Point(232, 108);
            comboBoxItemId.Name = "comboBoxItemId";
            comboBoxItemId.Size = new Size(151, 28);
            comboBoxItemId.TabIndex = 13;
            // 
            // comboBoxCageId
            // 
            comboBoxCageId.FormattingEnabled = true;
            comboBoxCageId.Location = new Point(232, 44);
            comboBoxCageId.Name = "comboBoxCageId";
            comboBoxCageId.Size = new Size(151, 28);
            comboBoxCageId.TabIndex = 14;
            // 
            // dataGridViewInvoice
            // 
            dataGridViewInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoice.Location = new Point(489, 53);
            dataGridViewInvoice.Name = "dataGridViewInvoice";
            dataGridViewInvoice.RowHeadersWidth = 51;
            dataGridViewInvoice.Size = new Size(391, 295);
            dataGridViewInvoice.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 387);
            label9.Name = "label9";
            label9.Size = new Size(284, 20);
            label9.TabIndex = 17;
            label9.Text = "NetAmount (auto fill on discount change)";
            // 
            // numericUpDownDiscount
            // 
            numericUpDownDiscount.Location = new Point(212, 333);
            numericUpDownDiscount.Name = "numericUpDownDiscount";
            numericUpDownDiscount.Size = new Size(150, 27);
            numericUpDownDiscount.TabIndex = 19;
            numericUpDownDiscount.ValueChanged += numericUpDownDiscount_ValueChanged_1;
            // 
            // buttonAddInvoice
            // 
            buttonAddInvoice.BackColor = Color.LimeGreen;
            buttonAddInvoice.Location = new Point(489, 378);
            buttonAddInvoice.Name = "buttonAddInvoice";
            buttonAddInvoice.Size = new Size(120, 29);
            buttonAddInvoice.TabIndex = 20;
            buttonAddInvoice.Text = "CreateInvoice";
            buttonAddInvoice.UseVisualStyleBackColor = false;
            buttonAddInvoice.Click += ButtonAddInvoice_Click;
            // 
            // textBoxTotalAmount
            // 
            textBoxTotalAmount.Location = new Point(48, 332);
            textBoxTotalAmount.Margin = new Padding(3, 4, 3, 4);
            textBoxTotalAmount.Name = "textBoxTotalAmount";
            textBoxTotalAmount.Size = new Size(114, 27);
            textBoxTotalAmount.TabIndex = 21;
            // 
            // textBoxNetAmount
            // 
            textBoxNetAmount.Location = new Point(48, 411);
            textBoxNetAmount.Margin = new Padding(3, 4, 3, 4);
            textBoxNetAmount.Name = "textBoxNetAmount";
            textBoxNetAmount.Size = new Size(114, 27);
            textBoxNetAmount.TabIndex = 22;
            // 
            // BackButtonInvoice
            // 
            BackButtonInvoice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BackButtonInvoice.BackColor = SystemColors.MenuHighlight;
            BackButtonInvoice.Location = new Point(48, 557);
            BackButtonInvoice.Margin = new Padding(3, 4, 3, 4);
            BackButtonInvoice.Name = "BackButtonInvoice";
            BackButtonInvoice.Size = new Size(100, 31);
            BackButtonInvoice.TabIndex = 23;
            BackButtonInvoice.Text = "Back";
            BackButtonInvoice.UseVisualStyleBackColor = false;
            BackButtonInvoice.Click += BackButtonInvoice_Click;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 604);
            Controls.Add(BackButtonInvoice);
            Controls.Add(textBoxNetAmount);
            Controls.Add(textBoxTotalAmount);
            Controls.Add(buttonAddInvoice);
            Controls.Add(numericUpDownDiscount);
            Controls.Add(label9);
            Controls.Add(dataGridViewInvoice);
            Controls.Add(comboBoxCageId);
            Controls.Add(comboBoxItemId);
            Controls.Add(comboBoxTreatmentId);
            Controls.Add(comboBoxConsultationId);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).EndInit();
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
        private Label label9;
        public ComboBox comboBoxOwnerId;
        public ComboBox comboBoxPetId;
        public ComboBox comboBoxConsultationId;
        public ComboBox comboBoxTreatmentId;
        public ComboBox comboBoxItemId;
        public ComboBox comboBoxCageId;
        public DataGridView dataGridViewInvoice;
        public NumericUpDown numericUpDownDiscount;
        public Button buttonAddInvoice;
        public TextBox textBoxTotalAmount;
        public TextBox textBoxNetAmount;
        private Button BackButtonInvoice;
    }
}