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
            buttonAdd.BackColor = Color.LimeGreen;
            buttonAdd.Location = new Point(226, 264);
            buttonAdd.Margin = new Padding(2, 3, 2, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 31);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Create";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewVets
            // 
            dataGridViewVets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVets.Location = new Point(226, 17);
            dataGridViewVets.Margin = new Padding(2, 3, 2, 3);
            dataGridViewVets.Name = "dataGridViewVets";
            dataGridViewVets.RowHeadersWidth = 62;
            dataGridViewVets.Size = new Size(375, 241);
            dataGridViewVets.TabIndex = 1;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(9, 7);
            labelFirstName.Margin = new Padding(2, 0, 2, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(80, 20);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(9, 29);
            textBoxFirstName.Margin = new Padding(2, 3, 2, 3);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(121, 27);
            textBoxFirstName.TabIndex = 4;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(9, 57);
            labelLastName.Margin = new Padding(2, 0, 2, 0);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(79, 20);
            labelLastName.TabIndex = 5;
            labelLastName.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(9, 79);
            textBoxLastName.Margin = new Padding(2, 3, 2, 3);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(121, 27);
            textBoxLastName.TabIndex = 6;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(9, 107);
            labelUsername.Margin = new Padding(2, 0, 2, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(75, 20);
            labelUsername.TabIndex = 7;
            labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(9, 129);
            textBoxUsername.Margin = new Padding(2, 3, 2, 3);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(121, 27);
            textBoxUsername.TabIndex = 8;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(9, 165);
            labelPassword.Margin = new Padding(2, 0, 2, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(9, 188);
            textBoxPassword.Margin = new Padding(2, 3, 2, 3);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(121, 27);
            textBoxPassword.TabIndex = 10;
            // 
            // labelSpeciale
            // 
            labelSpeciale.AutoSize = true;
            labelSpeciale.Location = new Point(9, 218);
            labelSpeciale.Margin = new Padding(2, 0, 2, 0);
            labelSpeciale.Name = "labelSpeciale";
            labelSpeciale.Size = new Size(65, 20);
            labelSpeciale.TabIndex = 11;
            labelSpeciale.Text = "Speciale";
            // 
            // textBoxSpeciale
            // 
            textBoxSpeciale.Location = new Point(9, 241);
            textBoxSpeciale.Margin = new Padding(2, 3, 2, 3);
            textBoxSpeciale.Name = "textBoxSpeciale";
            textBoxSpeciale.Size = new Size(121, 27);
            textBoxSpeciale.TabIndex = 12;
            // 
            // buttonBackVet
            // 
            buttonBackVet.BackColor = SystemColors.MenuHighlight;
            buttonBackVet.Location = new Point(9, 313);
            buttonBackVet.Margin = new Padding(3, 4, 3, 4);
            buttonBackVet.Name = "buttonBackVet";
            buttonBackVet.Size = new Size(100, 31);
            buttonBackVet.TabIndex = 13;
            buttonBackVet.Text = "Back";
            buttonBackVet.UseVisualStyleBackColor = false;
            buttonBackVet.Click += buttonBackVet_Click;
            // 
            // VetForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
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
            Margin = new Padding(2, 3, 2, 3);
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