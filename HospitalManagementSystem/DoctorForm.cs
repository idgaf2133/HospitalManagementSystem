using HospitalManagementSystem.Helpers;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Services;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace HospitalManagementSystem
{
    public partial class DoctorForm : Form
    {
        public HospitalContext _context;
        public DoctorService docService;

        public DoctorForm()
        {
            //create an instace of the context variable
            _context = new HospitalContext();

            //inilitze the doctor services field with the context variable
            docService = new DoctorService(_context);
            InitializeComponent();
            LoadDoctors();
        }


        //create a load method to load all the patients.

        public void LoadDoctors()
        {

            //check if PatientServies are not null then load it using .DataSrources connected to the gridview
            //use the getAllDoctors method in doctor Services.

            if(docService != null)
            {
                dataGridView2.DataSource = docService.GetDoctors();

            }
            else
            {
                MessageBox.Show("Service is not initialized.");
            }

            //else display an error message

        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                var Doctor = (Doctor)dataGridView2.CurrentRow.DataBoundItem;
                textName.Text = Doctor.Name;
                textDescription.Text = Doctor.Description;
                textContact.Text = Doctor.Contact;
                textEmail.Text = Doctor.Email;


            }
        }

        private void btnaddDoctor_Click(object sender, EventArgs e)
        {
            //try catch for errors

            try
            {
                Doctor newDoctor = new Doctor
                {
                    Name = textName.Text,
                    Description = textDescription.Text,
                    Contact = textContact.Text,
                    Email = textEmail.Text
                };

                docService.AddDoctor(newDoctor);
                LoadDoctors();
                ClearInputField();
                MessageBox.Show("Doctor added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void ClearInputField()
        {

            textName.Clear();
            textDescription.Clear();
            textContact.Clear();
            textEmail.Clear();
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {

            try
            {
                // Show input dialog to enter the Patient ID
                string input = InputBox.Show("Please enter Doctor ID:", "Delete Patient");

                // Check if input is valid and parse the Doctor ID
                if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int patientID))
                {
                    // Call the service method to delete the patient
                    docService.DeleteDoctor(patientID);

                    // Refresh the DataGridView to reflect the deletion
                    LoadDoctors();

                    MessageBox.Show("Doctor deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Please enter a valid Doctor ID.");
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
        bool isUpdating = false;
        int currentDocID = -1;  // To store the current Patient ID being upd

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {

            if (!isUpdating)
            {
                try
                {
                    // Show input dialog to enter the Doctor ID
                    string input = InputBox.Show("Please enter Doctor ID", "Doctor Id");

                    if (!string.IsNullOrEmpty(input))
                    {
                        // Try to parse the input to an integer
                        if (int.TryParse(input, out int doctorId))
                        {
                            // Retrieve the Doctor details by ID
                            Doctor newDoc = docService.getSingleDoctor(doctorId);

                            if (newDoc != null)
                            {
                                // Load doctor details into existing text boxes
                                textName.Text = newDoc.Name;
                                textDescription.Text = newDoc.Description;
                                textContact.Text = newDoc.Contact;
                                textEmail.Text = newDoc.Email;

                                currentDocID = doctorId; // Set the current Doctor ID
                                isUpdating = true;

                                EnableTextBoxes(); // Enable the user to edit the text boxes

                                btnUpdateDoctor.Text = "Save Changes"; // Change button text to indicate saving
                            }
                            else
                            {
                                MessageBox.Show("Doctor not found.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid Doctor ID.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a Doctor ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                // Validate that all required fields are filled
                if (string.IsNullOrEmpty(textName.Text) || string.IsNullOrEmpty(textDescription.Text) || string.IsNullOrEmpty(textContact.Text) || string.IsNullOrEmpty(textEmail.Text))
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }

                // Create a new Doctor object with updated details
                Doctor doc = new Doctor
                {
                    DoctorId = currentDocID,  // Ensure DoctorId is set
                    Name = textName.Text,
                    Description = textDescription.Text,
                    Contact = textContact.Text,
                    Email = textEmail.Text
                };

                try
                {
                    // Update the doctor in the service
                    docService.UpdateDoctor(doc);

                    // Reload the doctor list to reflect changes
                    LoadDoctors();

                    MessageBox.Show("Doctor details updated successfully!");

                    // Reset the form to normal state after update
                    ResetFormToNormalState();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating: " + ex.Message);
                }
            }
          

                // Change button text to indicate saving

            

        }

        public void EnableTextBoxes()
        {

            textName.Enabled = true;
            textDescription.Enabled = true;
            textContact.Enabled = true;
            textEmail.Enabled = true;


        }

        private void ResetFormToNormalState()
        {

            ClearInputFields();           // Clear text boxes
            EnableTextBoxes();           // enable text boxes
            isUpdating = false;          
            currentDocID = -1;        // Reset current patient ID
            btnUpdateDoctor.Text = "Update Doctor";  // Revert button text
        }

        // Helper method to clear input fields
        private void ClearInputFields()
        {
            textName.Clear();
             textDescription.Clear();
            textContact.Clear();
            textEmail.Clear();
        }


    }



}

