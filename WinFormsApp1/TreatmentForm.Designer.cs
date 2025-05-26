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
            label7 = new Label();
            buttonBackTreatment = new Button();
            buttonAddTreatment = new Button();
            buttonDeleteTreatment = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTreatment).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTreatment
            // 
            dataGridViewTreatment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTreatment.Location = new Point(487, 54);
            dataGridViewTreatment.Margin = new Padding(2);
            dataGridViewTreatment.Name = "dataGridViewTreatment";
            dataGridViewTreatment.RowHeadersWidth = 62;
            dataGridViewTreatment.Size = new Size(470, 303);
            dataGridViewTreatment.TabIndex = 1;
            // 
            // comboBoxTreatmentOwner
            // 
            comboBoxTreatmentOwner.FormattingEnabled = true;
            comboBoxTreatmentOwner.Location = new Point(56, 54);
            comboBoxTreatmentOwner.Margin = new Padding(2);
            comboBoxTreatmentOwner.Name = "comboBoxTreatmentOwner";
            comboBoxTreatmentOwner.Size = new Size(146, 28);
            comboBoxTreatmentOwner.TabIndex = 2;
            comboBoxTreatmentOwner.SelectedIndexChanged += comboBoxTreatmentOwner_SelectedIndexChanged;
            // 
            // comboBoxTreatmentVet
            // 
            comboBoxTreatmentVet.FormattingEnabled = true;
            comboBoxTreatmentVet.Location = new Point(56, 116);
            comboBoxTreatmentVet.Margin = new Padding(2);
            comboBoxTreatmentVet.Name = "comboBoxTreatmentVet";
            comboBoxTreatmentVet.Size = new Size(146, 28);
            comboBoxTreatmentVet.TabIndex = 3;
            // 
            // comboBoxTreatmentConsultation
            // 
            comboBoxTreatmentConsultation.FormattingEnabled = true;
            comboBoxTreatmentConsultation.Location = new Point(56, 180);
            comboBoxTreatmentConsultation.Margin = new Padding(2);
            comboBoxTreatmentConsultation.Name = "comboBoxTreatmentConsultation";
            comboBoxTreatmentConsultation.Size = new Size(146, 28);
            comboBoxTreatmentConsultation.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 5;
            label1.Text = "Owner";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 94);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 6;
            label2.Text = "Veterinarian";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 158);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 7;
            label3.Text = "ConsultationID";
            // 
            // textBoxPriceTreatment
            // 
            textBoxPriceTreatment.Location = new Point(56, 242);
            textBoxPriceTreatment.Margin = new Padding(2);
            textBoxPriceTreatment.Name = "textBoxPriceTreatment";
            textBoxPriceTreatment.Size = new Size(146, 27);
            textBoxPriceTreatment.TabIndex = 8;
            // 
            // textBoxNotesTreatment
            // 
            textBoxNotesTreatment.Location = new Point(56, 362);
            textBoxNotesTreatment.Margin = new Padding(2);
            textBoxNotesTreatment.Multiline = true;
            textBoxNotesTreatment.Name = "textBoxNotesTreatment";
            textBoxNotesTreatment.Size = new Size(224, 96);
            textBoxNotesTreatment.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 219);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 10;
            label4.Text = "Price";
            // 
            // comboBoxTreatmentPet
            // 
            comboBoxTreatmentPet.FormattingEnabled = true;
            comboBoxTreatmentPet.Location = new Point(235, 54);
            comboBoxTreatmentPet.Margin = new Padding(2);
            comboBoxTreatmentPet.Name = "comboBoxTreatmentPet";
            comboBoxTreatmentPet.Size = new Size(146, 28);
            comboBoxTreatmentPet.TabIndex = 11;
            comboBoxTreatmentPet.SelectedIndexChanged += comboBoxTreatmentPet_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(235, 31);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(29, 20);
            label6.TabIndex = 12;
            label6.Text = "Pet";
            // 
            // textBoxDateTreatment
            // 
            textBoxDateTreatment.Location = new Point(56, 300);
            textBoxDateTreatment.Margin = new Padding(2);
            textBoxDateTreatment.Name = "textBoxDateTreatment";
            textBoxDateTreatment.Size = new Size(241, 27);
            textBoxDateTreatment.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 340);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 14;
            label7.Text = "Notes";
            // 
            // buttonBackTreatment
            // 
            buttonBackTreatment.BackColor = SystemColors.MenuHighlight;
            buttonBackTreatment.Location = new Point(56, 467);
            buttonBackTreatment.Margin = new Padding(2);
            buttonBackTreatment.Name = "buttonBackTreatment";
            buttonBackTreatment.Size = new Size(100, 31);
            buttonBackTreatment.TabIndex = 15;
            buttonBackTreatment.Text = "Back";
            buttonBackTreatment.UseVisualStyleBackColor = false;
            buttonBackTreatment.Click += buttonBackTreatment_Click_1;
            // 
            // buttonAddTreatment
            // 
            buttonAddTreatment.BackColor = Color.LimeGreen;
            buttonAddTreatment.Location = new Point(174, 467);
            buttonAddTreatment.Margin = new Padding(2);
            buttonAddTreatment.Name = "buttonAddTreatment";
            buttonAddTreatment.Size = new Size(100, 31);
            buttonAddTreatment.TabIndex = 16;
            buttonAddTreatment.Text = "Create";
            buttonAddTreatment.UseVisualStyleBackColor = false;
            buttonAddTreatment.Click += buttonAddTreatment_Click_1;
            // 
            // buttonDeleteTreatment
            // 
            buttonDeleteTreatment.BackColor = Color.Red;
            buttonDeleteTreatment.Location = new Point(857, 382);
            buttonDeleteTreatment.Margin = new Padding(2);
            buttonDeleteTreatment.Name = "buttonDeleteTreatment";
            buttonDeleteTreatment.Size = new Size(100, 31);
            buttonDeleteTreatment.TabIndex = 17;
            buttonDeleteTreatment.Text = "Delete";
            buttonDeleteTreatment.UseVisualStyleBackColor = false;
            // 
            // TreatmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 504);
            Controls.Add(buttonDeleteTreatment);
            Controls.Add(buttonAddTreatment);
            Controls.Add(buttonBackTreatment);
            Controls.Add(label7);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label7;
        private Button buttonBackTreatment;
        private Button buttonAddTreatment;
        private Button buttonDeleteTreatment;
    }
}