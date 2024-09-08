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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.descriptiontxt = new System.Windows.Forms.Label();
            this.contacttxt = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.Label();
            this.btnaddDoctor = new System.Windows.Forms.Button();
            this.btnDeleteDoctor = new System.Windows.Forms.Button();
            this.btnUpdateDoctor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(131, 229);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
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
            this.contacttxt.Size = new System.Drawing.Size(43, 13);
            this.contacttxt.TabIndex = 7;
            this.contacttxt.Text = "contact";
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
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label descriptiontxt;
        private System.Windows.Forms.Label contacttxt;
        private System.Windows.Forms.Label emailtxt;
        private System.Windows.Forms.Label nametxt;
        private System.Windows.Forms.Button btnaddDoctor;
        private System.Windows.Forms.Button btnDeleteDoctor;
        private System.Windows.Forms.Button btnUpdateDoctor;
    }
}