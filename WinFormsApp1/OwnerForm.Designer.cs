namespace WinFormsApp1
{
    partial class OwnerForm
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
            AddOwnerButton = new Button();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxAdress = new TextBox();
            textBoxEmail = new TextBox();
            FirstNameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            AdressLabel = new Label();
            EmailLabel = new Label();
            dataGridViewOwner = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOwner).BeginInit();
            SuspendLayout();
            // 
            // AddOwnerButton
            // 
            AddOwnerButton.Location = new Point(141, 184);
            AddOwnerButton.Name = "AddOwnerButton";
            AddOwnerButton.Size = new Size(100, 23);
            AddOwnerButton.TabIndex = 0;
            AddOwnerButton.Text = "Create";
            AddOwnerButton.UseVisualStyleBackColor = true;
            AddOwnerButton.Click += AddOwnerButton_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(27, 52);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(100, 23);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(141, 52);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(100, 23);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(27, 126);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(100, 23);
            textBoxPhoneNumber.TabIndex = 3;
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(141, 126);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(100, 23);
            textBoxAdress.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(27, 185);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(100, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(27, 22);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(62, 15);
            FirstNameLabel.TabIndex = 6;
            FirstNameLabel.Text = "First name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 22);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 7;
            label1.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 93);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 8;
            label2.Text = "Phone Number";
            // 
            // AdressLabel
            // 
            AdressLabel.AutoSize = true;
            AdressLabel.Location = new Point(141, 93);
            AdressLabel.Name = "AdressLabel";
            AdressLabel.Size = new Size(42, 15);
            AdressLabel.TabIndex = 9;
            AdressLabel.Text = "Adress";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(27, 167);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 10;
            EmailLabel.Text = "Email";
            // 
            // dataGridViewOwner
            // 
            dataGridViewOwner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOwner.Location = new Point(326, 36);
            dataGridViewOwner.Name = "dataGridViewOwner";
            dataGridViewOwner.Size = new Size(387, 335);
            dataGridViewOwner.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(27, 393);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OwnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridViewOwner);
            Controls.Add(EmailLabel);
            Controls.Add(AdressLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FirstNameLabel);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxAdress);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(AddOwnerButton);
            Name = "OwnerForm";
            Text = "OwnerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOwner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddOwnerButton;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxAdress;
        private TextBox textBoxEmail;
        private Label FirstNameLabel;
        private Label label1;
        private Label label2;
        private Label AdressLabel;
        private Label EmailLabel;
        private DataGridView dataGridViewOwner;
        private Button button1;
    }
}