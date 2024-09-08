namespace HospitalManagementSystem
{
    partial class DoctorForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textName = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textContact = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.descriptiontxt = new System.Windows.Forms.Label();
            this.contacttxt = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.Label();
            this.btnaddDoctor = new System.Windows.Forms.Button();
            this.btnDeleteDoctor = new System.Windows.Forms.Button();
            this.btnUpdateDoctor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(320, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(368, 218);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(131, 65);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 1;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(131, 107);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(100, 20);
            this.textDescription.TabIndex = 2;
            // 
            // textContact
            // 
            this.textContact.Location = new System.Drawing.Point(131, 171);
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(100, 20);
            this.textContact.TabIndex = 3;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(131, 229);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 4;
            // 
            // descriptiontxt
            // 
            this.descriptiontxt.AutoSize = true;
            this.descriptiontxt.Location = new System.Drawing.Point(35, 114);
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.Size = new System.Drawing.Size(60, 13);
            this.descriptiontxt.TabIndex = 6;
            this.descriptiontxt.Text = "Description";
            // 
            // contacttxt
            // 
            this.contacttxt.AutoSize = true;
            this.contacttxt.Location = new System.Drawing.Point(43, 178);
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(44, 13);
            this.contacttxt.TabIndex = 7;
            this.contacttxt.Text = "Contact";
            // 
            // emailtxt
            // 
            this.emailtxt.AutoSize = true;
            this.emailtxt.Location = new System.Drawing.Point(46, 236);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(32, 13);
            this.emailtxt.TabIndex = 8;
            this.emailtxt.Text = "Email";
            // 
            // nametxt
            // 
            this.nametxt.AutoSize = true;
            this.nametxt.Location = new System.Drawing.Point(43, 65);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(35, 13);
            this.nametxt.TabIndex = 9;
            this.nametxt.Text = "Name";
            // 
            // btnaddDoctor
            // 
            this.btnaddDoctor.Location = new System.Drawing.Point(66, 12);
            this.btnaddDoctor.Name = "btnaddDoctor";
            this.btnaddDoctor.Size = new System.Drawing.Size(95, 33);
            this.btnaddDoctor.TabIndex = 10;
            this.btnaddDoctor.Text = "Add Doctor";
            this.btnaddDoctor.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDoctor
            // 
            this.btnDeleteDoctor.Location = new System.Drawing.Point(76, 297);
            this.btnDeleteDoctor.Name = "btnDeleteDoctor";
            this.btnDeleteDoctor.Size = new System.Drawing.Size(85, 41);
            this.btnDeleteDoctor.TabIndex = 11;
            this.btnDeleteDoctor.Text = "Delete Doctor";
            this.btnDeleteDoctor.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDoctor
            // 
            this.btnUpdateDoctor.Location = new System.Drawing.Point(410, 297);
            this.btnUpdateDoctor.Name = "btnUpdateDoctor";
            this.btnUpdateDoctor.Size = new System.Drawing.Size(85, 41);
            this.btnUpdateDoctor.TabIndex = 12;
            this.btnUpdateDoctor.Text = "Update Doctor";
            this.btnUpdateDoctor.UseVisualStyleBackColor = true;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateDoctor);
            this.Controls.Add(this.btnDeleteDoctor);
            this.Controls.Add(this.btnaddDoctor);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.contacttxt);
            this.Controls.Add(this.descriptiontxt);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textContact);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.dataGridView2);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label descriptiontxt;
        private System.Windows.Forms.Label contacttxt;
        private System.Windows.Forms.Label emailtxt;
        private System.Windows.Forms.Label nametxt;
        private System.Windows.Forms.Button btnaddDoctor;
        private System.Windows.Forms.Button btnDeleteDoctor;
        private System.Windows.Forms.Button btnUpdateDoctor;
    }
}