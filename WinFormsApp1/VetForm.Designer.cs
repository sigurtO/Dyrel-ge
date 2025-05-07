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
            ((System.ComponentModel.ISupportInitialize)dataGridViewVets).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(256, 213);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 34);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewVets
            // 
            dataGridViewVets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVets.Location = new Point(392, 22);
            dataGridViewVets.Name = "dataGridViewVets";
            dataGridViewVets.RowHeadersWidth = 62;
            dataGridViewVets.Size = new Size(360, 225);
            dataGridViewVets.TabIndex = 1;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(12, 9);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(97, 25);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(12, 37);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(150, 31);
            textBoxFirstName.TabIndex = 4;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(12, 71);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(95, 25);
            labelLastName.TabIndex = 5;
            labelLastName.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(12, 99);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(150, 31);
            textBoxLastName.TabIndex = 6;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(12, 133);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(91, 25);
            labelUsername.TabIndex = 7;
            labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(12, 161);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(150, 31);
            textBoxUsername.TabIndex = 8;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(12, 195);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(87, 25);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 223);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(150, 31);
            textBoxPassword.TabIndex = 10;
            // 
            // labelSpeciale
            // 
            labelSpeciale.AutoSize = true;
            labelSpeciale.Location = new Point(12, 257);
            labelSpeciale.Name = "labelSpeciale";
            labelSpeciale.Size = new Size(76, 25);
            labelSpeciale.TabIndex = 11;
            labelSpeciale.Text = "Speciale";
            // 
            // textBoxSpeciale
            // 
            textBoxSpeciale.Location = new Point(12, 285);
            textBoxSpeciale.Name = "textBoxSpeciale";
            textBoxSpeciale.Size = new Size(150, 31);
            textBoxSpeciale.TabIndex = 12;
            // 
            // VetForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}