namespace WinFormsApp1
{
    partial class Items
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
            dataGridViewItems = new DataGridView();
            buttonTxt = new Button();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Location = new Point(326, 22);
            dataGridViewItems.Margin = new Padding(3, 2, 3, 2);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.RowHeadersWidth = 51;
            dataGridViewItems.Size = new Size(328, 192);
            dataGridViewItems.TabIndex = 0;
            // 
            // buttonTxt
            // 
            buttonTxt.Location = new Point(571, 295);
            buttonTxt.Margin = new Padding(3, 2, 3, 2);
            buttonTxt.Name = "buttonTxt";
            buttonTxt.Size = new Size(82, 22);
            buttonTxt.TabIndex = 1;
            buttonTxt.Text = ".txt";
            buttonTxt.UseVisualStyleBackColor = true;
            buttonTxt.Click += buttonTxt_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(21, 295);
            buttonBack.Margin = new Padding(3, 2, 3, 2);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(82, 22);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // Items
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonBack);
            Controls.Add(buttonTxt);
            Controls.Add(dataGridViewItems);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Items";
            Text = "Items";
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewItems;
        private Button buttonTxt;
        private Button buttonBack;
    }
}