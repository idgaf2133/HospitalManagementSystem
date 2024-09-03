using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace HospitalManagementSystem
{
    public class HospitalContext : DbContext //hospital context class inherits from the built in class DBcontext and is used as bridge 
        //between the entities and the database
    {

        // step 1 db set for all the entities  //convert the domain classes into entities

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        
        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<MedicalRecord> MedicalRecords { get; set; }

        public DbSet<Billing> Bills { get; set; }

        //DbSet<TEntity> allows EF Core to query and save instances of the specified entity to the database


        //step 2 configure the database connection string



        //step3 

    }
}
