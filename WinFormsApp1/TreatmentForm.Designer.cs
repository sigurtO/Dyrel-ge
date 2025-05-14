namespace WinFormsApp1
{
    partial class TreatmentForm
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
            dataGridViewTreatment = new DataGridView();
            comboBoxTreatmentOwner = new ComboBox();
            comboBoxTreatmentVet = new ComboBox();
            comboBoxTreatmentConsultation = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxPriceTreatment = new TextBox();
            textBoxNotesTreatment = new TextBox();
            label4 = new Label();
            comboBoxTreatmentPet = new ComboBox();
            label6 = new Label();
            textBoxDateTreatment = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTreatment).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTreatment
            // 
            dataGridViewTreatment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTreatment.Location = new Point(609, 67);
            dataGridViewTreatment.Name = "dataGridViewTreatment";
            dataGridViewTreatment.RowHeadersWidth = 62;
            dataGridViewTreatment.Size = new Size(587, 379);
            dataGridViewTreatment.TabIndex = 1;
            // 
            // comboBoxTreatmentOwner
            // 
            comboBoxTreatmentOwner.FormattingEnabled = true;
            comboBoxTreatmentOwner.Location = new Point(70, 67);
            comboBoxTreatmentOwner.Name = "comboBoxTreatmentOwner";
            comboBoxTreatmentOwner.Size = new Size(182, 33);
            comboBoxTreatmentOwner.TabIndex = 2;
            // 
            // comboBoxTreatmentVet
            // 
            comboBoxTreatmentVet.FormattingEnabled = true;
            comboBoxTreatmentVet.Location = new Point(70, 145);
            comboBoxTreatmentVet.Name = "comboBoxTreatmentVet";
            comboBoxTreatmentVet.Size = new Size(182, 33);
            comboBoxTreatmentVet.TabIndex = 3;
            // 
            // comboBoxTreatmentConsultation
            // 
            comboBoxTreatmentConsultation.FormattingEnabled = true;
            comboBoxTreatmentConsultation.Location = new Point(70, 225);
            comboBoxTreatmentConsultation.Name = "comboBoxTreatmentConsultation";
            comboBoxTreatmentConsultation.Size = new Size(182, 33);
            comboBoxTreatmentConsultation.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 39);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 5;
            label1.Text = "Owner";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 117);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 6;
            label2.Text = "Veterinarian";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 197);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 7;
            label3.Text = "ConsultationID";
            // 
            // textBoxPriceTreatment
            // 
            textBoxPriceTreatment.Location = new Point(70, 302);
            textBoxPriceTreatment.Name = "textBoxPriceTreatment";
            textBoxPriceTreatment.Size = new Size(182, 31);
            textBoxPriceTreatment.TabIndex = 8;
            // 
            // textBoxNotesTreatment
            // 
            textBoxNotesTreatment.Location = new Point(70, 453);
            textBoxNotesTreatment.Multiline = true;
            textBoxNotesTreatment.Name = "textBoxNotesTreatment";
            textBoxNotesTreatment.Size = new Size(243, 119);
            textBoxNotesTreatment.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 274);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 10;
            label4.Text = "Price";
            // 
            // comboBoxTreatmentPet
            // 
            comboBoxTreatmentPet.FormattingEnabled = true;
            comboBoxTreatmentPet.Location = new Point(294, 67);
            comboBoxTreatmentPet.Name = "comboBoxTreatmentPet";
            comboBoxTreatmentPet.Size = new Size(182, 33);
            comboBoxTreatmentPet.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(294, 39);
            label6.Name = "label6";
            label6.Size = new Size(36, 25);
            label6.TabIndex = 12;
            label6.Text = "Pet";
            // 
            // textBoxDateTreatment
            // 
            textBoxDateTreatment.Location = new Point(70, 375);
            textBoxDateTreatment.Name = "textBoxDateTreatment";
            textBoxDateTreatment.Size = new Size(300, 31);
            textBoxDateTreatment.TabIndex = 13;
            // 
            // TreatmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 630);
            Controls.Add(textBoxDateTreatment);
            Controls.Add(label6);
            Controls.Add(comboBoxTreatmentPet);
            Controls.Add(label4);
            Controls.Add(textBoxNotesTreatment);
            Controls.Add(textBoxPriceTreatment);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxTreatmentConsultation);
            Controls.Add(comboBoxTreatmentVet);
            Controls.Add(comboBoxTreatmentOwner);
            Controls.Add(dataGridViewTreatment);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TreatmentForm";
            Text = "TreatmentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTreatment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewTreatment;
        private ComboBox comboBoxTreatmentOwner;
        private ComboBox comboBoxTreatmentVet;
        private ComboBox comboBoxTreatmentConsultation;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxPriceTreatment;
        private TextBox textBoxNotesTreatment;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxTreatmentPet;
        private Label label6;
        private DateTimePicker textBoxDateTreatment;
    }
}