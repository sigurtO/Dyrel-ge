﻿namespace WinFormsApp1
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
            dataGridViewItems.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Location = new Point(372, 29);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.RowHeadersWidth = 51;
            dataGridViewItems.Size = new Size(375, 256);
            dataGridViewItems.TabIndex = 0;
            // 
            // buttonTxt
            // 
            buttonTxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonTxt.BackColor = SystemColors.Info;
            buttonTxt.Location = new Point(647, 393);
            buttonTxt.Name = "buttonTxt";
            buttonTxt.Size = new Size(100, 31);
            buttonTxt.TabIndex = 1;
            buttonTxt.Text = ".txt";
            buttonTxt.UseVisualStyleBackColor = false;
            buttonTxt.Click += buttonTxt_Click;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.BackColor = SystemColors.MenuHighlight;
            buttonBack.Location = new Point(24, 393);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 31);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // Items
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(buttonTxt);
            Controls.Add(dataGridViewItems);
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