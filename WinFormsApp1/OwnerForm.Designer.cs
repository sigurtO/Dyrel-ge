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
            AddOwnerButton.Location = new Point(201, 307);
            AddOwnerButton.Margin = new Padding(4, 5, 4, 5);
            AddOwnerButton.Name = "AddOwnerButton";
            AddOwnerButton.Size = new Size(143, 38);
            AddOwnerButton.TabIndex = 0;
            AddOwnerButton.Text = "Create";
            AddOwnerButton.UseVisualStyleBackColor = true;
            AddOwnerButton.Click += AddOwnerButton_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(39, 87);
            textBoxFirstName.Margin = new Padding(4, 5, 4, 5);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(141, 31);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(201, 87);
            textBoxLastName.Margin = new Padding(4, 5, 4, 5);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(141, 31);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(39, 210);
            textBoxPhoneNumber.Margin = new Padding(4, 5, 4, 5);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(141, 31);
            textBoxPhoneNumber.TabIndex = 3;
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(201, 210);
            textBoxAdress.Margin = new Padding(4, 5, 4, 5);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(141, 31);
            textBoxAdress.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(39, 308);
            textBoxEmail.Margin = new Padding(4, 5, 4, 5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(141, 31);
            textBoxEmail.TabIndex = 5;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(39, 37);
            FirstNameLabel.Margin = new Padding(4, 0, 4, 0);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(94, 25);
            FirstNameLabel.TabIndex = 6;
            FirstNameLabel.Text = "First name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 7;
            label1.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 8;
            label2.Text = "Phone Number";
            // 
            // AdressLabel
            // 
            AdressLabel.AutoSize = true;
            AdressLabel.Location = new Point(201, 155);
            AdressLabel.Margin = new Padding(4, 0, 4, 0);
            AdressLabel.Name = "AdressLabel";
            AdressLabel.Size = new Size(66, 25);
            AdressLabel.TabIndex = 9;
            AdressLabel.Text = "Adress";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(39, 278);
            EmailLabel.Margin = new Padding(4, 0, 4, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(54, 25);
            EmailLabel.TabIndex = 10;
            EmailLabel.Text = "Email";
            // 
            // dataGridViewOwner
            // 
            dataGridViewOwner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOwner.Location = new Point(466, 60);
            dataGridViewOwner.Margin = new Padding(4, 5, 4, 5);
            dataGridViewOwner.Name = "dataGridViewOwner";
            dataGridViewOwner.RowHeadersWidth = 62;
            dataGridViewOwner.Size = new Size(553, 558);
            dataGridViewOwner.TabIndex = 11;
            dataGridViewOwner.CellContentClick += dataGridViewOwner_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(39, 655);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 12;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OwnerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
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
            Margin = new Padding(4, 5, 4, 5);
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