using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Appointment
    {


        //to showcase forign keys, format
        //Forigenkey("Table name")]
        //get and set the table value;
        //get set the path using a forign key object'

        [Key]

        public int AppointmentId { get; set; }

        public int PatientID {  get; set; }//many appointments to one patient
        Patient Patient { get; set; }

        public int DoctorId { get; set; }//many appointmnets to one doctor
        Doctor Doctor { get; set; }

        public DateTime AppointMentDate { get; set; }

        public string Status { get; set; }


    }
}
