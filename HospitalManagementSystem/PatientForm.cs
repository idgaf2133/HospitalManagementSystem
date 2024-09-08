using HospitalManagementSystem.Helpers;
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
            //load the conponentrs first.
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

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            try
            {
                // Show input dialog to enter the Patient ID
                string input = InputBox.Show("Please enter Patient ID:", "Delete Patient");

                // Check if input is valid and parse the Patient ID
                if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int patientID))
                {
                    // Call the service method to delete the patient
                    patientServices.RemovePatient(patientID);

                    // Refresh the DataGridView to reflect the deletion
                    LoadPatients();

                    MessageBox.Show("Patient deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Please enter a valid Patient ID.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }


        }

        private bool isUpdating = false;  // Flag to track if the update process is in progress
        private int currentPatientID = -1;  // To store the current Patient ID being updated

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            if (!isUpdating)
            {
                try
                {
                    // Show input dialog to enter the Patient ID
                    string input = InputBox.Show("Please enter Patient ID:", "Update Patient");

                    // Check if input is valid and parse the Patient ID
                    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int patientID))
                    {
                        // Retrieve the patient details by ID
                        Patient patient = patientServices.getSinglePatient(patientID);

                        if (patient != null)
                        {
                            // Step 2: Load patient details into existing text boxes
                            txtName.Text = patient.name;
                            txtDOB.Text = patient.DOB.ToString("yyyy-MM-dd");
                            txtGender.Text = patient.gender;
                            txtContact.Text = patient.contact;
                            txtAddress.Text = patient.address;

                            // Store the current Patient ID and set the flag to true
                            currentPatientID = patientID;
                            isUpdating = true;

                            // Enable the user to edit the text boxes
                            EnableTextBoxes();

                            // Change button text to indicate saving
                            btnUpdatePatient.Text = "Save Changes";
                        }
                        else
                        {
                            MessageBox.Show("Patient not found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Patient ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                // Step 4: Save the updated details
                try
                {
                    // Validate the input fields
                    if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtDOB.Text) ||
                        string.IsNullOrEmpty(txtGender.Text) || string.IsNullOrEmpty(txtContact.Text) ||
                        string.IsNullOrEmpty(txtAddress.Text))
                    {
                        MessageBox.Show("Please fill in all the fields.");
                        return;
                    }

                    // Create a new Patient object with updated data
                    Patient updatedPatient = new Patient
                    {
                        patientID = currentPatientID,
                        name = txtName.Text,
                        DOB = DateTime.Parse(txtDOB.Text),  // Ensure correct date format is used
                        gender = txtGender.Text,
                        contact = txtContact.Text,
                        address = txtAddress.Text,
                        medicalHistory = ""  // Update if required
                    };

                    // Update patient details in the database
                    patientServices.UpdatePatient(updatedPatient);

                    // Refresh the DataGridView to show updated details
                    LoadPatients();

                    MessageBox.Show("Patient details updated successfully!");

                    // Step 5: Reset the form to its normal state
                    ResetFormToNormalState();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }


            }
        }

        // Method to reset the form to its normal state
        private void ResetFormToNormalState()
        {

            ClearInputFields();           // Clear text boxes
            EnableTextBoxes();           // enable text boxes
            isUpdating = false;           // Reset update flag
            currentPatientID = -1;        // Reset current patient ID
            btnUpdatePatient.Text = "Update Patient";  // Revert button text
        }

        private void EnableTextBoxes()
        {
            txtName.Enabled = true;
            txtDOB.Enabled = true;
            txtGender.Enabled = true;
            txtContact.Enabled = true;
            txtAddress.Enabled = true;
        }
    }
}