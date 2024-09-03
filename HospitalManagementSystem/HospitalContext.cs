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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalDB;Integrated Security=True;");
        }

        /* 
         In the above code, the optionsBuilder.UseSqlServer() is an extension method used to configure EF to use 
        SQL Server as the database provider by specifying a database connection string.

          The string "Server=(localdb)\\mssqllocaldb; Database=SchoolDb; Trusted_Connection=True;" 
        is a connection string to a database which we will communicate with. EF API will create the specified database if it does not exist.
         
         
         */



        //step3: Use Fluent API to configure relationships

    }
}
