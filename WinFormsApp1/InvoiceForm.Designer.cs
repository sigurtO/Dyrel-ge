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
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 16);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Owner Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 64);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Pet ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 271);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Total Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 107);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 3;
            label4.Text = "Consultation Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 152);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 4;
            label5.Text = "Treatment Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 219);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 5;
            label6.Text = "Item (not added yet)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(214, 152);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 6;
            label7.Text = "Cage Id (yes no)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(194, 271);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 7;
            label8.Text = "Discount (%)";
            // 
            // comboBoxOwnerId
            // 
            comboBoxOwnerId.FormattingEnabled = true;
            comboBoxOwnerId.Location = new Point(38, 40);
            comboBoxOwnerId.Margin = new Padding(3, 2, 3, 2);
            comboBoxOwnerId.Name = "comboBoxOwnerId";
            comboBoxOwnerId.Size = new Size(133, 23);
            comboBoxOwnerId.TabIndex = 8;
            comboBoxOwnerId.SelectedIndexChanged += comboBoxOwnerId_SelectedIndexChanged;
            // 
            // comboBoxPetId
            // 
            comboBoxPetId.FormattingEnabled = true;
            comboBoxPetId.Location = new Point(42, 84);
            comboBoxPetId.Margin = new Padding(3, 2, 3, 2);
            comboBoxPetId.Name = "comboBoxPetId";
            comboBoxPetId.Size = new Size(133, 23);
            comboBoxPetId.TabIndex = 9;
            // 
            // comboBoxConsultationId
            // 
            comboBoxConsultationId.FormattingEnabled = true;
            comboBoxConsultationId.Location = new Point(42, 128);
            comboBoxConsultationId.Margin = new Padding(3, 2, 3, 2);
            comboBoxConsultationId.Name = "comboBoxConsultationId";
            comboBoxConsultationId.Size = new Size(133, 23);
            comboBoxConsultationId.TabIndex = 11;
            comboBoxConsultationId.SelectedIndexChanged += comboBoxConsultationId_SelectedIndexChanged;
            // 
            // comboBoxTreatmentId
            // 
            comboBoxTreatmentId.FormattingEnabled = true;
            comboBoxTreatmentId.Location = new Point(42, 176);
            comboBoxTreatmentId.Margin = new Padding(3, 2, 3, 2);
            comboBoxTreatmentId.Name = "comboBoxTreatmentId";
            comboBoxTreatmentId.Size = new Size(133, 23);
            comboBoxTreatmentId.TabIndex = 12;
            comboBoxTreatmentId.SelectedIndexChanged += comboBoxTreatmentId_SelectedIndexChanged;
            // 
            // comboBoxItemId
            // 
            comboBoxItemId.FormattingEnabled = true;
            comboBoxItemId.Location = new Point(38, 238);
            comboBoxItemId.Margin = new Padding(3, 2, 3, 2);
            comboBoxItemId.Name = "comboBoxItemId";
            comboBoxItemId.Size = new Size(133, 23);
            comboBoxItemId.TabIndex = 13;
            // 
            // comboBoxCageId
            // 
            comboBoxCageId.FormattingEnabled = true;
            comboBoxCageId.Location = new Point(203, 176);
            comboBoxCageId.Margin = new Padding(3, 2, 3, 2);
            comboBoxCageId.Name = "comboBoxCageId";
            comboBoxCageId.Size = new Size(133, 23);
            comboBoxCageId.TabIndex = 14;
            // 
            // dataGridViewInvoice
            // 
            dataGridViewInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoice.Location = new Point(508, 40);
            dataGridViewInvoice.Margin = new Padding(3, 2, 3, 2);
            dataGridViewInvoice.Name = "dataGridViewInvoice";
            dataGridViewInvoice.RowHeadersWidth = 51;
            dataGridViewInvoice.Size = new Size(262, 141);
            dataGridViewInvoice.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 322);
            label9.Name = "label9";
            label9.Size = new Size(229, 15);
            label9.TabIndex = 17;
            label9.Text = "NetAmount (auto fill on discount change)";
            // 
            // numericUpDownDiscount
            // 
            numericUpDownDiscount.Location = new Point(194, 288);
            numericUpDownDiscount.Margin = new Padding(3, 2, 3, 2);
            numericUpDownDiscount.Name = "numericUpDownDiscount";
            numericUpDownDiscount.Size = new Size(131, 23);
            numericUpDownDiscount.TabIndex = 19;
            // 
            // buttonAddInvoice
            // 
            buttonAddInvoice.Location = new Point(408, 338);
            buttonAddInvoice.Margin = new Padding(3, 2, 3, 2);
            buttonAddInvoice.Name = "buttonAddInvoice";
            buttonAddInvoice.Size = new Size(82, 22);
            buttonAddInvoice.TabIndex = 20;
            buttonAddInvoice.Text = "buttonAddInvoice";
            buttonAddInvoice.UseVisualStyleBackColor = true;
            // 
            // textBoxTotalAmount
            // 
            textBoxTotalAmount.Location = new Point(39, 296);
            textBoxTotalAmount.Name = "textBoxTotalAmount";
            textBoxTotalAmount.Size = new Size(100, 23);
            textBoxTotalAmount.TabIndex = 21;
            // 
            // textBoxNetAmount
            // 
            textBoxNetAmount.Location = new Point(42, 340);
            textBoxNetAmount.Name = "textBoxNetAmount";
            textBoxNetAmount.Size = new Size(100, 23);
            textBoxNetAmount.TabIndex = 22;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 365);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private ComboBox comboBoxOwnerId;
        private ComboBox comboBoxPetId;
        private ComboBox comboBoxConsultationId;
        private ComboBox comboBoxTreatmentId;
        private ComboBox comboBoxItemId;
        private ComboBox comboBoxCageId;
        private DataGridView dataGridViewInvoice;
        private Label label9;
        private NumericUpDown numericUpDownDiscount;
        private Button buttonAddInvoice;
        private TextBox textBoxTotalAmount;
        private TextBox textBoxNetAmount;
    }
}