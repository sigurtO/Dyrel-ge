namespace WinFormsApp1
{
    partial class Main
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
            buttonConsultation = new Button();
            SuspendLayout();
            // 
            // buttonConsultation
            // 
            buttonConsultation.Location = new Point(346, 236);
            buttonConsultation.Name = "buttonConsultation";
            buttonConsultation.Size = new Size(112, 23);
            buttonConsultation.TabIndex = 0;
            buttonConsultation.Text = "Consultation";
            buttonConsultation.UseVisualStyleBackColor = true;
            buttonConsultation.Click += buttonConsultation_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConsultation);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonConsultation;
    }
}