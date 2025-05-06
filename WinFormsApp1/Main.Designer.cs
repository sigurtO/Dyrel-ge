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
            buttonVets = new Button();
            SuspendLayout();
            // 
            // buttonConsultation
            // 
            buttonConsultation.Location = new Point(337, 428);
            buttonConsultation.Margin = new Padding(4, 5, 4, 5);
            buttonConsultation.Name = "buttonConsultation";
            buttonConsultation.Size = new Size(160, 38);
            buttonConsultation.TabIndex = 0;
            buttonConsultation.Text = "Consultation";
            buttonConsultation.UseVisualStyleBackColor = true;
            buttonConsultation.Click += buttonConsultation_Click;
            // 
            // buttonVets
            // 
            buttonVets.Location = new Point(575, 428);
            buttonVets.Name = "buttonVets";
            buttonVets.Size = new Size(112, 34);
            buttonVets.TabIndex = 1;
            buttonVets.Text = "Vets";
            buttonVets.UseVisualStyleBackColor = true;
            buttonVets.Click += buttonVets_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(buttonVets);
            Controls.Add(buttonConsultation);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonConsultation;
        private Button buttonVets;
    }
}