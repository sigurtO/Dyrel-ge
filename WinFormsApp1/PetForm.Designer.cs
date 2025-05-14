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
            PetOwnerTextBoxID = new TextBox();
            PetDocIDTextBox = new TextBox();
            label7 = new Label();
            PetCreateButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            petDateTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(452, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 60);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 50);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 133);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 4;
            label3.Text = "Breed";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 133);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 5;
            label4.Text = "Species";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 60);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 6;
            label5.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(229, 206);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 7;
            label6.Text = "PetDocID";
            // 
            // OwnerID
            // 
            OwnerID.AutoSize = true;
            OwnerID.Location = new Point(50, 194);
            OwnerID.Name = "OwnerID";
            OwnerID.Size = new Size(67, 20);
            OwnerID.TabIndex = 8;
            OwnerID.Text = "OwnerID";
            // 
            // PetNameTextBox
            // 
            PetNameTextBox.Location = new Point(50, 83);
            PetNameTextBox.Name = "PetNameTextBox";
            PetNameTextBox.Size = new Size(125, 27);
            PetNameTextBox.TabIndex = 9;
            // 
            // PetBreedTextBox
            // 
            PetBreedTextBox.Location = new Point(50, 156);
            PetBreedTextBox.Name = "PetBreedTextBox";
            PetBreedTextBox.Size = new Size(125, 27);
            PetBreedTextBox.TabIndex = 11;
            // 
            // PetSpeciesTextBox
            // 
            PetSpeciesTextBox.Location = new Point(224, 156);
            PetSpeciesTextBox.Name = "PetSpeciesTextBox";
            PetSpeciesTextBox.Size = new Size(125, 27);
            PetSpeciesTextBox.TabIndex = 12;
            // 
            // PetOwnerTextBoxID
            // 
            PetOwnerTextBoxID.Location = new Point(50, 217);
            PetOwnerTextBoxID.Name = "PetOwnerTextBoxID";
            PetOwnerTextBoxID.Size = new Size(125, 27);
            PetOwnerTextBoxID.TabIndex = 13;
            // 
            // PetDocIDTextBox
            // 
            PetDocIDTextBox.Location = new Point(224, 229);
            PetDocIDTextBox.Name = "PetDocIDTextBox";
            PetDocIDTextBox.Size = new Size(125, 27);
            PetDocIDTextBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(224, 309);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 16;
            label7.Text = "Create Pet";
            // 
            // PetCreateButton
            // 
            PetCreateButton.Location = new Point(236, 336);
            PetCreateButton.Name = "PetCreateButton";
            PetCreateButton.Size = new Size(94, 29);
            PetCreateButton.TabIndex = 17;
            PetCreateButton.Text = "Create";
            PetCreateButton.UseVisualStyleBackColor = true;
            // 
            // petDateTimePicker
            // 
            petDateTimePicker.Location = new Point(224, 83);
            petDateTimePicker.Name = "petDateTimePicker";
            petDateTimePicker.Size = new Size(125, 27);
            petDateTimePicker.TabIndex = 18;
            // 
            // PetForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(petDateTimePicker);
            Controls.Add(PetCreateButton);
            Controls.Add(label7);
            Controls.Add(PetDocIDTextBox);
            Controls.Add(PetOwnerTextBoxID);
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
        private TextBox PetOwnerTextBoxID;
        private TextBox PetDocIDTextBox;
        private Label label7;
        private Button PetCreateButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DateTimePicker petDateTimePicker;
    }
}