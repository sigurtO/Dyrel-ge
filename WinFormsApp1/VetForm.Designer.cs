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
            label1 = new Label();
            textBoxName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVets).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(175, 164);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 47);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(175, 89);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 31);
            textBoxName.TabIndex = 4;
            // 
            // VetForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxName);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox textBoxName;
    }
}