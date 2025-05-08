namespace WinFormsApp1
{
    partial class TreatmentForm
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
            buttonBackTreatment = new Button();
            SuspendLayout();
            // 
            // buttonBackTreatment
            // 
            buttonBackTreatment.Location = new Point(28, 411);
            buttonBackTreatment.Name = "buttonBackTreatment";
            buttonBackTreatment.Size = new Size(75, 23);
            buttonBackTreatment.TabIndex = 0;
            buttonBackTreatment.Text = "Back";
            buttonBackTreatment.UseVisualStyleBackColor = true;
            buttonBackTreatment.Click += buttonBackTreatment_Click;
            // 
            // TreatmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBackTreatment);
            Name = "TreatmentForm";
            Text = "TreatmentForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBackTreatment;
    }
}