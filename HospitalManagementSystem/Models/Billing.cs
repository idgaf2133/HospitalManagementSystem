using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Billing
    {
        [Key]
        public int BillID { get; set; }

        [ForeignKey("Patient")]   //many bills to one patient
        public int PatientID { get; set; }
        public Patient Patient { get; set; }

        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Details { get; set; }
    }
}
