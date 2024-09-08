using HospitalManagementSystem.Models;
using HospitalManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

    }
}
