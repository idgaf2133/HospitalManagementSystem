using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HospitalManagementSystem.Models
{
    public class Patient
    {

    
        public int patientID { get; set; }
        public string name { get; set; }
        public DateTime DOB { get; set; }
        public string gender { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string medicalHistory { get; set; }


        //setting navigation properties

        //many to one realtionships

        public ICollection<Appointment> Appointments { get; set; } //one patient many appointments path
        public ICollection<Billing> Bills { get; set; } //one patient many bills
        
        public ICollection <MedicalRecord> MedicalRecords { get; set; } //one patient many bills







    }
}
