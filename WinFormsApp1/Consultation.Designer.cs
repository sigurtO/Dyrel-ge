namespace WinFormsApp1
{
    partial class Consultation
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
            textBoxDate = new DateTimePicker();
            textBoxNotes = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            comboBoxVet = new ComboBox();
            textBoxPrice = new NumericUpDown();
            dataGridView = new DataGridView();
            label6 = new Label();
            buttonAdd = new Button();
            label7 = new Label();
            comboBoxOwner = new ComboBox();
            comboBoxPet = new ComboBox();
            buttonDelete = new Button();
            buttonBackConsultation = new Button();
            ((System.ComponentModel.ISupportInitialize)textBoxPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 108);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "Veterinarian";
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(38, 223);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(200, 23);
            textBoxDate.TabIndex = 4;
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(38, 279);
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(197, 107);
            textBoxNotes.TabIndex = 6;
            textBoxNotes.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 152);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 205);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 9;
            label4.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 261);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 10;
            label5.Text = "Notes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 64);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 11;
            label2.Text = "Pet";
            // 
            // comboBoxVet
            // 
            comboBoxVet.FormattingEnabled = true;
            comboBoxVet.Location = new Point(38, 126);
            comboBoxVet.Name = "comboBoxVet";
            comboBoxVet.Size = new Size(121, 23);
            comboBoxVet.TabIndex = 12;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(38, 170);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(120, 23);
            textBoxPrice.TabIndex = 13;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(469, 39);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(295, 318);
            dataGridView.TabIndex = 14;
            dataGridView.CellEndEdit += dataGridView_CellEndEdit;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(469, 20);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 15;
            label6.Text = "Appointments";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.LimeGreen;
            buttonAdd.Location = new Point(469, 363);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(77, 23);
            buttonAdd.TabIndex = 16;
            buttonAdd.Text = "Create";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 20);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 18;
            label7.Text = "Owner";
            // 
            // comboBoxOwner
            // 
            comboBoxOwner.FormattingEnabled = true;
            comboBoxOwner.Location = new Point(38, 38);
            comboBoxOwner.Name = "comboBoxOwner";
            comboBoxOwner.Size = new Size(121, 23);
            comboBoxOwner.TabIndex = 19;
            comboBoxOwner.SelectedIndexChanged += comboBoxOwner_SelectedIndexChanged;
            // 
            // comboBoxPet
            // 
            comboBoxPet.FormattingEnabled = true;
            comboBoxPet.Location = new Point(38, 82);
            comboBoxPet.Name = "comboBoxPet";
            comboBoxPet.Size = new Size(121, 23);
            comboBoxPet.TabIndex = 20;
            comboBoxPet.SelectedIndexChanged += comboBoxPet_SelectedIndexChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Location = new Point(689, 363);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 21;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonBackConsultation
            // 
            buttonBackConsultation.BackColor = SystemColors.MenuHighlight;
            buttonBackConsultation.Location = new Point(12, 415);
            buttonBackConsultation.Name = "buttonBackConsultation";
            buttonBackConsultation.Size = new Size(75, 23);
            buttonBackConsultation.TabIndex = 22;
            buttonBackConsultation.Text = "Back";
            buttonBackConsultation.UseVisualStyleBackColor = false;
            buttonBackConsultation.Click += buttonBackConsultation_Click;
            // 
            // Consultation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBackConsultation);
            Controls.Add(buttonDelete);
            Controls.Add(comboBoxPet);
            Controls.Add(comboBoxOwner);
            Controls.Add(label7);
            Controls.Add(buttonAdd);
            Controls.Add(label6);
            Controls.Add(dataGridView);
            Controls.Add(textBoxPrice);
            Controls.Add(comboBoxVet);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxNotes);
            Controls.Add(textBoxDate);
            Controls.Add(label1);
            Name = "Consultation";
            Text = "Consultation";
            ((System.ComponentModel.ISupportInitialize)textBoxPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker textBoxDate;
        private RichTextBox textBoxNotes;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label2;
        private ComboBox comboBoxVet;
        private NumericUpDown textBoxPrice;
        private DataGridView dataGridView;
        private Label label6;
        private Button buttonAdd;
        private Label label7;
        private ComboBox comboBoxOwner;
        private ComboBox comboBoxPet;
        private Button buttonDelete;
        private Button buttonBackConsultation;
    }
}