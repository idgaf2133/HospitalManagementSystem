﻿namespace HospitalManagementSystem
{
    partial class AppointmentForm
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
            this.btncreateappointment = new System.Windows.Forms.Button();
            this.btnupdatedappointment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.patientIDtxt = new System.Windows.Forms.TextBox();
            this.doctoriIdtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btncreateappointment
            // 
            this.btncreateappointment.Location = new System.Drawing.Point(71, 69);
            this.btncreateappointment.Name = "btncreateappointment";
            this.btncreateappointment.Size = new System.Drawing.Size(75, 76);
            this.btncreateappointment.TabIndex = 0;
            this.btncreateappointment.Text = "Create Appointment";
            this.btncreateappointment.UseVisualStyleBackColor = true;
            this.btncreateappointment.Click += new System.EventHandler(this.btncreateappointment_Click);
            // 
            // btnupdatedappointment
            // 
            this.btnupdatedappointment.Location = new System.Drawing.Point(71, 171);
            this.btnupdatedappointment.Name = "btnupdatedappointment";
            this.btnupdatedappointment.Size = new System.Drawing.Size(75, 60);
            this.btnupdatedappointment.TabIndex = 1;
            this.btnupdatedappointment.Text = "Update Appointment";
            this.btnupdatedappointment.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete Appointment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(424, 69);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(394, 267);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
            // 
            // patientIDtxt
            // 
            this.patientIDtxt.Location = new System.Drawing.Point(240, 140);
            this.patientIDtxt.Name = "patientIDtxt";
            this.patientIDtxt.Size = new System.Drawing.Size(100, 20);
            this.patientIDtxt.TabIndex = 5;
          
            // 
            // doctoriIdtxt
            // 
            this.doctoriIdtxt.Location = new System.Drawing.Point(240, 192);
            this.doctoriIdtxt.Name = "doctoriIdtxt";
            this.doctoriIdtxt.Size = new System.Drawing.Size(100, 20);
            this.doctoriIdtxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Patient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Doctor ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(236, 242);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctoriIdtxt);
            this.Controls.Add(this.patientIDtxt);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnupdatedappointment);
            this.Controls.Add(this.btncreateappointment);
            this.Name = "AppointmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreateappointment;
        private System.Windows.Forms.Button btnupdatedappointment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox patientIDtxt;
        private System.Windows.Forms.TextBox doctoriIdtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}