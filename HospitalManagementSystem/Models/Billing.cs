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

    
        public int Bills_PatientID { get; set; }
        public Patient Patient { get; set; }

        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Details { get; set; }
    }
}
