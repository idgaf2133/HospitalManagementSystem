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

namespace HospitalManagementSystem
{
    public partial class AppointmentForm : Form
    {

        public HospitalContext _context;

        public AppointmentService appointmentService;

        public PatientServices _patientService;

        public DoctorService _doctorService;
        public AppointmentForm()
        {
            InitializeComponent();

            _context = new HospitalContext();

            appointmentService = new AppointmentService();

            _patientService = new PatientServices(_context);
            _doctorService = new DoctorService(_context);

            LoadAppointments();
        }

        private void btncreateappointment_Click(object sender, EventArgs e)
        {
            //whatever data in the text boxes display it
            int patientId;
            int doctorId;
            DateTime appointmentDate = dateTimePicker1.Value;

            // Validate input for Patient ID and Doctor ID
            if (!int.TryParse(patientIDtxt.Text, out patientId))
            {
                MessageBox.Show("Please enter a valid Patient ID.");
                return;
            }

            if (!int.TryParse(doctoriIdtxt.Text, out doctorId))
            {
                MessageBox.Show("Please enter a valid Doctor ID.");
                return;
            }

            // Check if Patient ID exists in the database
            var patient = _patientService.getSinglePatient(patientId);
            if (patient == null)
            {
                MessageBox.Show("The Patient ID does not exist. Please enter a valid Patient ID.");
                return;
            }

            // Check if Doctor ID exists in the database
            var doctor = _doctorService.getSingleDoctor(doctorId);
            if (doctor == null)
            {
                MessageBox.Show("The Doctor ID does not exist. Please enter a valid Doctor ID.");
                return;
            }

            // Create new appointment if both Patient and Doctor IDs are valid
            var newAppointment = new Appointment
            {
                Appointment_PatientID = patientId,
                Appointment_Doctor = doctorId,
                AppointMentDate = appointmentDate,
                Status = "Scheduled" // Default status; you can modify as needed
            };

            // Add appointment to the database
            appointmentService.AddAppointment(newAppointment);

            // Refresh the DataGridView to show updated appointments
            LoadAppointments();

            // Inform the user
            MessageBox.Show("Appointment added successfully.");

        }

        private void LoadAppointments()
        {


            if (appointmentService != null)
            {
                dataGridView3.DataSource = appointmentService.GetAllAppointments();

            }
            else
            {
                MessageBox.Show("Service is not initialized.");
            }


        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow != null)
            {
                // Get the selected Appointment from the DataGridView
                var selectedAppointment = (Appointment)dataGridView3.CurrentRow.DataBoundItem;

                // Set the values in the text boxes and date picker
                patientIDtxt.Text = selectedAppointment.Appointment_PatientID.ToString(); // Convert int to string
                doctoriIdtxt.Text = selectedAppointment.Appointment_Doctor.ToString();  // Convert int to string
                dateTimePicker1.Value = selectedAppointment.AppointMentDate;  // Set the value of DateTimePicker
            }
        }
        }

     
    }

