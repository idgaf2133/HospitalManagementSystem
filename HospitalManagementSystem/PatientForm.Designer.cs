namespace HospitalManagementSystem
{
    partial class PatientForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnUpdatePatient = new System.Windows.Forms.Button();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(233, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 340);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(37, 338);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(143, 71);
            this.btnAddPatient.TabIndex = 2;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.Location = new System.Drawing.Point(614, 400);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(105, 51);
            this.btnUpdatePatient.TabIndex = 4;
            this.btnUpdatePatient.Text = "Update Patient ";
            this.btnUpdatePatient.UseVisualStyleBackColor = true;
            this.btnUpdatePatient.Click += new System.EventHandler(this.btnUpdatePatient_Click);
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Location = new System.Drawing.Point(337, 400);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(133, 51);
            this.btnDeletePatient.TabIndex = 5;
            this.btnDeletePatient.Text = "Delete Patient";
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(80, 134);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(100, 22);
            this.txtDOB.TabIndex = 6;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(80, 177);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 22);
            this.txtGender.TabIndex = 8;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(80, 223);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 22);
            this.txtContact.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(80, 278);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Contact ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "DOB";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 516);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.btnUpdatePatient);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnUpdatePatient;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}