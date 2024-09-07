using HospitalManagementSystem.Models;
using HospitalManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HospitalManagementSystem
{
    public partial class PatientForm : Form
    {

        //initilize a Patient Service Variable

        PatientServices patientServices;
        HospitalContext hospitalContext;
        public PatientForm()
        {
            InitializeComponent();
            hospitalContext = new HospitalContext();    
           patientServices = new PatientServices(hospitalContext);
           LoadPatients();
         
        }

        private void LoadPatients()
        {

            if (patientServices != null)  // Check if _patientService is not null
            {
                dataGridView1.DataSource = patientServices.GetAllPatients();  // Bind the data to DataGridView
            }
            else
            {
                MessageBox.Show("Service is not initialized.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadPatients(); //loads patients if the grid area is clicked 

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {

            try
            {
                // Create a new Patient object with data from text boxes
                Patient newPatient = new Patient
                {
                    name = txtName.Text,
                    DOB = DateTime.Parse(txtDOB.Text),  // Ensure proper date parsing
                    gender = txtGender.Text,
                    contact = txtContact.Text,
                    address = txtAddress.Text,
                    medicalHistory = "" // Set a default or allow user input in another control
                };

                // Add the patient to the database
                patientServices.AddPatient(newPatient);

                // Refresh the DataGridView to show the newly added patient
                LoadPatients();

                // Clear input fields after adding
                ClearInputFields();

                MessageBox.Show("Patient added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }




        }

        // Helper method to clear input fields
        private void ClearInputFields()
        {
            txtName.Clear();
            txtDOB.Clear();
            txtGender.Clear();
            txtContact.Clear();
            txtAddress.Clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var patient = (Patient)dataGridView1.CurrentRow.DataBoundItem;
                txtName.Text = patient.name;
                txtDOB.Text = patient.DOB.ToString("yyyy-MM-dd");  // Format DOB as needed
                txtGender.Text = patient.gender;
                txtContact.Text = patient.contact;
                txtAddress.Text = patient.address;
            }
        }
    }
}