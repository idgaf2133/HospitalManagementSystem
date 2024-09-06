namespace HospitalManagementSystem
{
    partial class Home
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
            System.Windows.Forms.Button btnManagePatients;
            this.btnManageDoctors = new System.Windows.Forms.Button();
            this.btnManageAppointments = new System.Windows.Forms.Button();
            this.btnManageBilling = new System.Windows.Forms.Button();
            btnManagePatients = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManagePatients
            // 
            btnManagePatients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnManagePatients.Location = new System.Drawing.Point(174, 32);
            btnManagePatients.Name = "btnManagePatients";
            btnManagePatients.Size = new System.Drawing.Size(127, 48);
            btnManagePatients.TabIndex = 0;
            btnManagePatients.Text = "Manage Patients";
            btnManagePatients.UseVisualStyleBackColor = false;
            btnManagePatients.Click += new System.EventHandler(this.btnManagePatients_Click);
            // 
            // btnManageDoctors
            // 
            this.btnManageDoctors.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageDoctors.Location = new System.Drawing.Point(376, 32);
            this.btnManageDoctors.Name = "btnManageDoctors";
            this.btnManageDoctors.Size = new System.Drawing.Size(122, 48);
            this.btnManageDoctors.TabIndex = 1;
            this.btnManageDoctors.Text = "Manage Doctors";
            this.btnManageDoctors.UseVisualStyleBackColor = false;
            this.btnManageDoctors.Click += new System.EventHandler(this.btnManageDoctors_Click);
            // 
            // btnManageAppointments
            // 
            this.btnManageAppointments.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageAppointments.Location = new System.Drawing.Point(155, 107);
            this.btnManageAppointments.Name = "btnManageAppointments";
            this.btnManageAppointments.Size = new System.Drawing.Size(157, 43);
            this.btnManageAppointments.TabIndex = 2;
            this.btnManageAppointments.Text = "ManageAppointments";
            this.btnManageAppointments.UseVisualStyleBackColor = false;
            // 
            // btnManageBilling
            // 
            this.btnManageBilling.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageBilling.Location = new System.Drawing.Point(376, 107);
            this.btnManageBilling.Name = "btnManageBilling";
            this.btnManageBilling.Size = new System.Drawing.Size(177, 43);
            this.btnManageBilling.TabIndex = 3;
            this.btnManageBilling.Text = "Manage Billing";
            this.btnManageBilling.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(699, 392);
            this.Controls.Add(this.btnManageBilling);
            this.Controls.Add(this.btnManageAppointments);
            this.Controls.Add(this.btnManageDoctors);
            this.Controls.Add(btnManagePatients);
            this.Name = "Home";
            this.Text = "Hospital Management System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageDoctors;
        private System.Windows.Forms.Button btnManageAppointments;
        private System.Windows.Forms.Button btnManageBilling;
    }
}