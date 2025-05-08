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
            buttonOwner = new Button();
            buttonTreatment = new Button();
            buttonBackMain = new Button();
            SuspendLayout();
            // 
            // buttonConsultation
            // 
            buttonConsultation.Location = new Point(236, 257);
            buttonConsultation.Name = "buttonConsultation";
            buttonConsultation.Size = new Size(112, 23);
            buttonConsultation.TabIndex = 0;
            buttonConsultation.Text = "Consultation";
            buttonConsultation.UseVisualStyleBackColor = true;
            buttonConsultation.Click += buttonConsultation_Click;
            // 
            // buttonVets
            // 
            buttonVets.Location = new Point(402, 257);
            buttonVets.Margin = new Padding(2);
            buttonVets.Name = "buttonVets";
            buttonVets.Size = new Size(78, 20);
            buttonVets.TabIndex = 1;
            buttonVets.Text = "Vets";
            buttonVets.UseVisualStyleBackColor = true;
            buttonVets.Click += buttonVets_Click;
            // 
            // buttonOwner
            // 
            buttonOwner.Location = new Point(102, 259);
            buttonOwner.Margin = new Padding(2);
            buttonOwner.Name = "buttonOwner";
            buttonOwner.Size = new Size(78, 20);
            buttonOwner.TabIndex = 2;
            buttonOwner.Text = "Owner";
            buttonOwner.UseVisualStyleBackColor = true;
            buttonOwner.Click += buttonOwners_Click;
            // 
            // buttonTreatment
            // 
            buttonTreatment.Location = new Point(541, 259);
            buttonTreatment.Margin = new Padding(2);
            buttonTreatment.Name = "buttonTreatment";
            buttonTreatment.Size = new Size(78, 20);
            buttonTreatment.TabIndex = 3;
            buttonTreatment.Text = "Treatment";
            buttonTreatment.UseVisualStyleBackColor = true;
            buttonTreatment.Click += buttonTreatment_Click;
            // 
            // buttonBackMain
            // 
            buttonBackMain.Location = new Point(12, 415);
            buttonBackMain.Name = "buttonBackMain";
            buttonBackMain.Size = new Size(75, 23);
            buttonBackMain.TabIndex = 4;
            buttonBackMain.Text = "Back";
            buttonBackMain.UseVisualStyleBackColor = true;
            buttonBackMain.Click += buttonBackMain_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBackMain);
            Controls.Add(buttonTreatment);
            Controls.Add(buttonOwner);
            Controls.Add(buttonVets);
            Controls.Add(buttonConsultation);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonConsultation;
        private Button buttonVets;
        private Button buttonOwner;
        private Button buttonTreatment;
        private Button buttonBackMain;
    }
}