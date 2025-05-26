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
            dataGridView1.Location = new Point(482, 55);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(502, 401);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 64);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 166);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 4;
            label3.Text = "Breed";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 166);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 5;
            label4.Text = "Species";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 75);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 6;
            label5.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(286, 256);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 7;
            label6.Text = "PetDocID";
            // 
            // OwnerID
            // 
            OwnerID.AutoSize = true;
            OwnerID.Location = new Point(62, 244);
            OwnerID.Margin = new Padding(4, 0, 4, 0);
            OwnerID.Name = "OwnerID";
            OwnerID.Size = new Size(82, 25);
            OwnerID.TabIndex = 8;
            OwnerID.Text = "OwnerID";
            // 
            // PetNameTextBox
            // 
            PetNameTextBox.Location = new Point(62, 104);
            PetNameTextBox.Margin = new Padding(4, 4, 4, 4);
            PetNameTextBox.Name = "PetNameTextBox";
            PetNameTextBox.Size = new Size(155, 31);
            PetNameTextBox.TabIndex = 9;
            // 
            // PetBreedTextBox
            // 
            PetBreedTextBox.Location = new Point(62, 195);
            PetBreedTextBox.Margin = new Padding(4, 4, 4, 4);
            PetBreedTextBox.Name = "PetBreedTextBox";
            PetBreedTextBox.Size = new Size(155, 31);
            PetBreedTextBox.TabIndex = 11;
            // 
            // PetSpeciesTextBox
            // 
            PetSpeciesTextBox.Location = new Point(280, 195);
            PetSpeciesTextBox.Margin = new Padding(4, 4, 4, 4);
            PetSpeciesTextBox.Name = "PetSpeciesTextBox";
            PetSpeciesTextBox.Size = new Size(155, 31);
            PetSpeciesTextBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(482, 460);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 16;
            label7.Text = "Create Pet";
            // 
            // PetCreateButton
            // 
            PetCreateButton.BackColor = Color.LimeGreen;
            PetCreateButton.Location = new Point(482, 482);
            PetCreateButton.Margin = new Padding(4, 4, 4, 4);
            PetCreateButton.Name = "PetCreateButton";
            PetCreateButton.Size = new Size(125, 39);
            PetCreateButton.TabIndex = 17;
            PetCreateButton.Text = "Create";
            PetCreateButton.UseVisualStyleBackColor = false;
            PetCreateButton.Click += PetCreateButton_Click;
            // 
            // petDateTimePicker
            // 
            petDateTimePicker.Location = new Point(280, 104);
            petDateTimePicker.Margin = new Padding(4, 4, 4, 4);
            petDateTimePicker.Name = "petDateTimePicker";
            petDateTimePicker.Size = new Size(155, 31);
            petDateTimePicker.TabIndex = 18;
            // 
            // comboBoxPetOwnerID
            // 
            comboBoxPetOwnerID.FormattingEnabled = true;
            comboBoxPetOwnerID.Location = new Point(48, 286);
            comboBoxPetOwnerID.Margin = new Padding(4, 5, 4, 5);
            comboBoxPetOwnerID.Name = "comboBoxPetOwnerID";
            comboBoxPetOwnerID.Size = new Size(172, 33);
            comboBoxPetOwnerID.TabIndex = 19;
            // 
            // comboBoxPetDocID
            // 
            comboBoxPetDocID.FormattingEnabled = true;
            comboBoxPetDocID.Location = new Point(280, 286);
            comboBoxPetDocID.Margin = new Padding(4, 5, 4, 5);
            comboBoxPetDocID.Name = "comboBoxPetDocID";
            comboBoxPetDocID.Size = new Size(172, 33);
            comboBoxPetDocID.TabIndex = 20;
            // 
            // buttonBackPet
            // 
            buttonBackPet.BackColor = SystemColors.MenuHighlight;
            buttonBackPet.Location = new Point(31, 564);
            buttonBackPet.Margin = new Padding(4, 5, 4, 5);
            buttonBackPet.Name = "buttonBackPet";
            buttonBackPet.Size = new Size(125, 39);
            buttonBackPet.TabIndex = 21;
            buttonBackPet.Text = "Back";
            buttonBackPet.UseVisualStyleBackColor = false;
            buttonBackPet.Click += buttonBackPet_Click;
            // 
            // PetForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 621);
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
            Margin = new Padding(4, 4, 4, 4);
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