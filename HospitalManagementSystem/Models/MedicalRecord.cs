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
    
        public int RecordID { get; set; }

        public int Records_Patient { get; set; }
        public Patient Patient { get; set; }

   
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }

        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public DateTime Date { get; set; }
    }
}
