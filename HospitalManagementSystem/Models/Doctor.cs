using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Doctor
    {

    
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Contact { get; set; }

        public string Email { get; set; }
        // Navigation properties
        public ICollection<Appointment> Appointments { get; set; }  // One-to-Many with Appointment
        public ICollection<MedicalRecord> MedicalRecords { get; set; }  // One-to-Many with MedicalRecord


    }
}
