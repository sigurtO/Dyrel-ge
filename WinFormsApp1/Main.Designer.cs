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
            buttonInvoice = new Button();
            CreatePet = new Button();
            buttonItems = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            SuspendLayout();
            // 
            // buttonConsultation
            // 
            buttonConsultation.BackColor = SystemColors.Info;
            buttonConsultation.Location = new Point(270, 345);
            buttonConsultation.Margin = new Padding(3, 4, 3, 4);
            buttonConsultation.Name = "buttonConsultation";
            buttonConsultation.Size = new Size(128, 31);
            buttonConsultation.TabIndex = 0;
            buttonConsultation.Text = "Consultation";
            buttonConsultation.UseVisualStyleBackColor = false;
            buttonConsultation.Click += buttonConsultation_Click;
            // 
            // buttonVets
            // 
            buttonVets.BackColor = SystemColors.Info;
            buttonVets.Location = new Point(433, 345);
            buttonVets.Margin = new Padding(2, 3, 2, 3);
            buttonVets.Name = "buttonVets";
            buttonVets.Size = new Size(128, 31);
            buttonVets.TabIndex = 1;
            buttonVets.Text = "Vets";
            buttonVets.UseVisualStyleBackColor = false;
            buttonVets.Click += buttonVets_Click;
            // 
            // buttonOwner
            // 
            buttonOwner.BackColor = SystemColors.Info;
            buttonOwner.Location = new Point(117, 345);
            buttonOwner.Margin = new Padding(2, 3, 2, 3);
            buttonOwner.Name = "buttonOwner";
            buttonOwner.Size = new Size(128, 31);
            buttonOwner.TabIndex = 2;
            buttonOwner.Text = "Owner";
            buttonOwner.UseVisualStyleBackColor = false;
            buttonOwner.Click += buttonOwners_Click;
            // 
            // buttonTreatment
            // 
            buttonTreatment.BackColor = SystemColors.Info;
            buttonTreatment.Location = new Point(588, 345);
            buttonTreatment.Margin = new Padding(2, 3, 2, 3);
            buttonTreatment.Name = "buttonTreatment";
            buttonTreatment.Size = new Size(128, 31);
            buttonTreatment.TabIndex = 3;
            buttonTreatment.Text = "Treatment";
            buttonTreatment.UseVisualStyleBackColor = false;
            buttonTreatment.Click += buttonTreatment_Click;
            // 
            // buttonBackMain
            // 
            buttonBackMain.BackColor = SystemColors.MenuHighlight;
            buttonBackMain.Location = new Point(14, 553);
            buttonBackMain.Margin = new Padding(3, 4, 3, 4);
            buttonBackMain.Name = "buttonBackMain";
            buttonBackMain.Size = new Size(100, 31);
            buttonBackMain.TabIndex = 4;
            buttonBackMain.Text = "Back";
            buttonBackMain.UseVisualStyleBackColor = false;
            buttonBackMain.Click += buttonBackMain_Click;
            // 
            // buttonInvoice
            // 
            buttonInvoice.BackColor = SystemColors.Info;
            buttonInvoice.Location = new Point(370, 199);
            buttonInvoice.Name = "buttonInvoice";
            buttonInvoice.Size = new Size(128, 31);
            buttonInvoice.TabIndex = 5;
            buttonInvoice.Text = "Invoice";
            buttonInvoice.UseVisualStyleBackColor = false;
            buttonInvoice.Click += buttonInvoice_Click;
            // 
            // CreatePet
            // 
            CreatePet.BackColor = SystemColors.Info;
            CreatePet.Location = new Point(212, 199);
            CreatePet.Name = "CreatePet";
            CreatePet.Size = new Size(128, 31);
            CreatePet.TabIndex = 6;
            CreatePet.Text = "Pet";
            CreatePet.UseVisualStyleBackColor = false;
            CreatePet.Click += CreatePet_Click;
            // 
            // buttonItems
            // 
            buttonItems.BackColor = SystemColors.Info;
            buttonItems.Location = new Point(516, 199);
            buttonItems.Name = "buttonItems";
            buttonItems.Size = new Size(128, 31);
            buttonItems.TabIndex = 7;
            buttonItems.Text = "Items";
            buttonItems.UseVisualStyleBackColor = false;
            buttonItems.Click += buttonItems_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonItems);
            Controls.Add(CreatePet);
            Controls.Add(buttonInvoice);
            Controls.Add(buttonBackMain);
            Controls.Add(buttonTreatment);
            Controls.Add(buttonOwner);
            Controls.Add(buttonVets);
            Controls.Add(buttonConsultation);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button buttonInvoice;
        private Button CreatePet;
        private Button buttonItems;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}