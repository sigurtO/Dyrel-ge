namespace WinFormsApp1
{
    partial class PetForm
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            OwnerID = new Label();
            PetNameTextBox = new TextBox();
            PetBreedTextBox = new TextBox();
            PetSpeciesTextBox = new TextBox();
            label7 = new Label();
            PetCreateButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            petDateTimePicker = new DateTimePicker();
            comboBoxPetOwnerID = new ComboBox();
            comboBoxPetDocID = new ComboBox();
            buttonBackPet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(338, 33);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(352, 241);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 45);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 38);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 100);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 4;
            label3.Text = "Breed";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 100);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 5;
            label4.Text = "Species";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 45);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 6;
            label5.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 154);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 7;
            label6.Text = "PetDocID";
            // 
            // OwnerID
            // 
            OwnerID.AutoSize = true;
            OwnerID.Location = new Point(44, 146);
            OwnerID.Name = "OwnerID";
            OwnerID.Size = new Size(53, 15);
            OwnerID.TabIndex = 8;
            OwnerID.Text = "OwnerID";
            // 
            // PetNameTextBox
            // 
            PetNameTextBox.Location = new Point(44, 62);
            PetNameTextBox.Margin = new Padding(3, 2, 3, 2);
            PetNameTextBox.Name = "PetNameTextBox";
            PetNameTextBox.Size = new Size(110, 23);
            PetNameTextBox.TabIndex = 9;
            // 
            // PetBreedTextBox
            // 
            PetBreedTextBox.Location = new Point(44, 117);
            PetBreedTextBox.Margin = new Padding(3, 2, 3, 2);
            PetBreedTextBox.Name = "PetBreedTextBox";
            PetBreedTextBox.Size = new Size(110, 23);
            PetBreedTextBox.TabIndex = 11;
            // 
            // PetSpeciesTextBox
            // 
            PetSpeciesTextBox.Location = new Point(196, 117);
            PetSpeciesTextBox.Margin = new Padding(3, 2, 3, 2);
            PetSpeciesTextBox.Name = "PetSpeciesTextBox";
            PetSpeciesTextBox.Size = new Size(110, 23);
            PetSpeciesTextBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(196, 232);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 16;
            label7.Text = "Create Pet";
            // 
            // PetCreateButton
            // 
            PetCreateButton.Location = new Point(206, 252);
            PetCreateButton.Margin = new Padding(3, 2, 3, 2);
            PetCreateButton.Name = "PetCreateButton";
            PetCreateButton.Size = new Size(82, 22);
            PetCreateButton.TabIndex = 17;
            PetCreateButton.Text = "Create";
            PetCreateButton.UseVisualStyleBackColor = true;
            PetCreateButton.Click += PetCreateButton_Click;
            // 
            // petDateTimePicker
            // 
            petDateTimePicker.Location = new Point(196, 62);
            petDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            petDateTimePicker.Name = "petDateTimePicker";
            petDateTimePicker.Size = new Size(110, 23);
            petDateTimePicker.TabIndex = 18;
            // 
            // comboBoxPetOwnerID
            // 
            comboBoxPetOwnerID.FormattingEnabled = true;
            comboBoxPetOwnerID.Location = new Point(33, 172);
            comboBoxPetOwnerID.Name = "comboBoxPetOwnerID";
            comboBoxPetOwnerID.Size = new Size(121, 23);
            comboBoxPetOwnerID.TabIndex = 19;
            // 
            // comboBoxPetDocID
            // 
            comboBoxPetDocID.FormattingEnabled = true;
            comboBoxPetDocID.Location = new Point(196, 172);
            comboBoxPetDocID.Name = "comboBoxPetDocID";
            comboBoxPetDocID.Size = new Size(121, 23);
            comboBoxPetDocID.TabIndex = 20;
            // 
            // buttonBackPet
            // 
            buttonBackPet.Location = new Point(22, 338);
            buttonBackPet.Name = "buttonBackPet";
            buttonBackPet.Size = new Size(75, 23);
            buttonBackPet.TabIndex = 21;
            buttonBackPet.Text = "Back";
            buttonBackPet.UseVisualStyleBackColor = true;
            buttonBackPet.Click += buttonBackPet_Click;
            // 
            // PetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 373);
            Controls.Add(buttonBackPet);
            Controls.Add(comboBoxPetDocID);
            Controls.Add(comboBoxPetOwnerID);
            Controls.Add(petDateTimePicker);
            Controls.Add(PetCreateButton);
            Controls.Add(label7);
            Controls.Add(PetSpeciesTextBox);
            Controls.Add(PetBreedTextBox);
            Controls.Add(PetNameTextBox);
            Controls.Add(OwnerID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PetForm";
            Text = "PetForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label OwnerID;
        private TextBox PetNameTextBox;
        private TextBox PetBreedTextBox;
        private TextBox PetSpeciesTextBox;
        private Label label7;
        private Button PetCreateButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DateTimePicker petDateTimePicker;
        private ComboBox comboBoxPetOwnerID;
        private ComboBox comboBoxPetDocID;
        private Button buttonBackPet;
    }
}