namespace WinFormsApp1
{
    partial class VetForm
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
            buttonAdd = new Button();
            dataGridViewVets = new DataGridView();
            labelFirstName = new Label();
            textBoxFirstName = new TextBox();
            labelLastName = new Label();
            textBoxLastName = new TextBox();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelSpeciale = new Label();
            textBoxSpeciale = new TextBox();
            buttonBackVet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVets).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(198, 198);
            buttonAdd.Margin = new Padding(2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewVets
            // 
            dataGridViewVets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVets.Location = new Point(198, 13);
            dataGridViewVets.Margin = new Padding(2);
            dataGridViewVets.Name = "dataGridViewVets";
            dataGridViewVets.RowHeadersWidth = 62;
            dataGridViewVets.Size = new Size(328, 181);
            dataGridViewVets.TabIndex = 1;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(8, 5);
            labelFirstName.Margin = new Padding(2, 0, 2, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(64, 15);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(8, 22);
            textBoxFirstName.Margin = new Padding(2);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(106, 23);
            textBoxFirstName.TabIndex = 4;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(8, 43);
            labelLastName.Margin = new Padding(2, 0, 2, 0);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(63, 15);
            labelLastName.TabIndex = 5;
            labelLastName.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(8, 59);
            textBoxLastName.Margin = new Padding(2);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(106, 23);
            textBoxLastName.TabIndex = 6;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(8, 80);
            labelUsername.Margin = new Padding(2, 0, 2, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(60, 15);
            labelUsername.TabIndex = 7;
            labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(8, 97);
            textBoxUsername.Margin = new Padding(2);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(106, 23);
            textBoxUsername.TabIndex = 8;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(8, 117);
            labelPassword.Margin = new Padding(2, 0, 2, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(8, 134);
            textBoxPassword.Margin = new Padding(2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(106, 23);
            textBoxPassword.TabIndex = 10;
            // 
            // labelSpeciale
            // 
            labelSpeciale.AutoSize = true;
            labelSpeciale.Location = new Point(8, 154);
            labelSpeciale.Margin = new Padding(2, 0, 2, 0);
            labelSpeciale.Name = "labelSpeciale";
            labelSpeciale.Size = new Size(50, 15);
            labelSpeciale.TabIndex = 11;
            labelSpeciale.Text = "Speciale";
            // 
            // textBoxSpeciale
            // 
            textBoxSpeciale.Location = new Point(8, 171);
            textBoxSpeciale.Margin = new Padding(2);
            textBoxSpeciale.Name = "textBoxSpeciale";
            textBoxSpeciale.Size = new Size(106, 23);
            textBoxSpeciale.TabIndex = 12;
            // 
            // buttonBackVet
            // 
            buttonBackVet.Location = new Point(8, 235);
            buttonBackVet.Name = "buttonBackVet";
            buttonBackVet.Size = new Size(75, 23);
            buttonBackVet.TabIndex = 13;
            buttonBackVet.Text = "Back";
            buttonBackVet.UseVisualStyleBackColor = true;
            buttonBackVet.Click += buttonBackVet_Click;
            // 
            // VetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(buttonBackVet);
            Controls.Add(textBoxSpeciale);
            Controls.Add(labelSpeciale);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelUsername);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(dataGridViewVets);
            Controls.Add(buttonAdd);
            Margin = new Padding(2);
            Name = "VetForm";
            Text = "VetForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private DataGridView dataGridViewVets;
        private Label labelFirstName;
        private TextBox textBoxFirstName;
        private Label labelLastName;
        private TextBox textBoxLastName;
        private Label labelUsername;
        private TextBox textBoxUsername;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label labelSpeciale;
        private TextBox textBoxSpeciale;
        private Button buttonBackVet;
    }
}