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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();


             

            
        }

        private void btnManagePatients_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.ShowDialog();
        }

        private void btnManageDoctors_Click(object sender, EventArgs e)
        {

        }

        private void btnManageAppointments_Click(object sender, EventArgs e)
        {

        }

        private void btnManageBilling_Click(object sender, EventArgs e)
        {

        }
    }
}
