using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class MedicalRecord
    {
        [Key]
        public int RecordID { get; set; }

        [ForeignKey("Patient")] //many records one patient 
        public int PatientID { get; set; }
        public Patient Patient { get; set; }

        [ForeignKey("Doctor")] //many records one doctor
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }

        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public DateTime Date { get; set; }
    }
}
