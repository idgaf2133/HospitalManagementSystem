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

        [Key]

        public int patientID;
        public string name;
        public DateTime DOB;
        public string gender;
        public string contact;
        public string address;
        public string medicalHistory;




    }
}
