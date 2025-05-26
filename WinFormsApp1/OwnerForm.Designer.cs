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
            textBoxPhone = new TextBox();
            textBoxAdress = new TextBox();
            textBoxEmail = new TextBox();
            FirstNameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            AdressLabel = new Label();
            EmailLabel = new Label();
            button1 = new Button();
            dataGridViewOwner = new DataGridView();
            AddOwnerEFCButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOwner).BeginInit();
            SuspendLayout();
            // 
            // AddOwnerButton
            // 
            AddOwnerButton.Location = new Point(161, 245);
            AddOwnerButton.Margin = new Padding(3, 4, 3, 4);
            AddOwnerButton.Name = "AddOwnerButton";
            AddOwnerButton.Size = new Size(114, 31);
            AddOwnerButton.TabIndex = 0;
            AddOwnerButton.Text = "Create";
            AddOwnerButton.UseVisualStyleBackColor = true;
            AddOwnerButton.Click += AddOwnerButton_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(31, 69);
            textBoxFirstName.Margin = new Padding(3, 4, 3, 4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(114, 27);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(161, 69);
            textBoxLastName.Margin = new Padding(3, 4, 3, 4);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(114, 27);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(31, 168);
            textBoxPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(114, 27);
            textBoxPhone.TabIndex = 3;
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(161, 168);
            textBoxAdress.Margin = new Padding(3, 4, 3, 4);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(114, 27);
            textBoxAdress.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(31, 247);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(114, 27);
            textBoxEmail.TabIndex = 5;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(31, 45);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(77, 20);
            FirstNameLabel.TabIndex = 6;
            FirstNameLabel.Text = "First name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 45);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 7;
            label1.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 144);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 8;
            label2.Text = "Phone Number";
            // 
            // AdressLabel
            // 
            AdressLabel.AutoSize = true;
            AdressLabel.Location = new Point(161, 144);
            AdressLabel.Name = "AdressLabel";
            AdressLabel.Size = new Size(53, 20);
            AdressLabel.TabIndex = 9;
            AdressLabel.Text = "Adress";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(31, 223);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(46, 20);
            EmailLabel.TabIndex = 10;
            EmailLabel.Text = "Email";
            // 
            // button1
            // 
            button1.Location = new Point(31, 524);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 12;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonBack_Click;
            // 
            // dataGridViewOwner
            // 
            dataGridViewOwner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOwner.Location = new Point(398, 69);
            dataGridViewOwner.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOwner.Name = "dataGridViewOwner";
            dataGridViewOwner.RowHeadersWidth = 51;
            dataGridViewOwner.Size = new Size(469, 380);
            dataGridViewOwner.TabIndex = 13;
            dataGridViewOwner.CellEndEdit += dataGridView_CellEndEditOwner;
            // 
            // AddOwnerEFCButton
            // 
            AddOwnerEFCButton.Location = new Point(161, 312);
            AddOwnerEFCButton.Margin = new Padding(3, 4, 3, 4);
            AddOwnerEFCButton.Name = "AddOwnerEFCButton";
            AddOwnerEFCButton.Size = new Size(114, 31);
            AddOwnerEFCButton.TabIndex = 14;
            AddOwnerEFCButton.Text = "CreateEFC";
            AddOwnerEFCButton.UseVisualStyleBackColor = true;
            AddOwnerEFCButton.Click += AddOwnerEFCButton_Click;
            // 
            // OwnerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(AddOwnerEFCButton);
            Controls.Add(dataGridViewOwner);
            Controls.Add(button1);
            Controls.Add(EmailLabel);
            Controls.Add(AdressLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FirstNameLabel);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxAdress);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(AddOwnerButton);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox textBoxPhone;
        private TextBox textBoxAdress;
        private TextBox textBoxEmail;
        private Label FirstNameLabel;
        private Label label1;
        private Label label2;
        private Label AdressLabel;
        private Label EmailLabel;
        private Button button1;
        private DataGridView dataGridViewOwner;
        private Button AddOwnerEFCButton;
    }
}