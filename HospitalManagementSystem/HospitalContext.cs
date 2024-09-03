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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            /*Patitent has
                * public int patientID { get; set; }
                  public string name { get; set; }
                  public DateTime DOB { get; set; }
                  public string gender { get; set; }
                  public string contact { get; set; }
                 public string address { get; set; }
                 public string medicalHistory { get; set; }

               */
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(p => p.patientID); //primary key
                entity.Property(p => p.name).IsRequired();
                entity.Property(p => p.DOB).IsRequired();
                entity.Property(p => p.gender)
                      .HasMaxLength(1)
                      .IsRequired();
                entity.Property(p => p.contact)
                      .HasMaxLength(15)
                      .IsRequired();
                entity.Property(p => p.address)
                      .IsRequired();
                entity.Property(p => p.medicalHistory)
                     .IsRequired();
                //now configuring, the many to one relations bsed on the enitity classes+

                entity.HasMany(p => p.Appointments)
                      .WithOne(b => b.Patient)
                      .HasForeignKey(b=> b.Appointment_PatientID);
                entity.HasMany(p => p.Bills)
                      .WithOne(b => b.Patient)
                      .HasForeignKey(b => b.Bills_PatientID);
                entity.HasMany(p => p.MedicalRecords)
                 .WithOne(b => b.Patient)
                 .HasForeignKey(b => b.Records_Patient);


            });

            /*
             
                 
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Contact { get; set; }

        public string Email { get; set; }
        // Navigation properties
        public ICollection<Appointment> Appointments { get; set; }  // One-to-Many with Appointment
        public ICollection<MedicalRecord> MedicalRecords { get; set; }  // One-to-Many with MedicalRecord
             
             */

            modelBuilder.Entity<Doctor>(entity =>

            {

                entity.HasKey(d => d.DoctorId);  // Primary key
                entity.Property(d => d.Name).IsRequired();  // Required field

                entity.Property(d => d.Description).IsRequired();
                entity.Property(d=>d.Contact).IsRequired();

                entity.HasMany(d => d.Appointments)  // One-to-Many with Appointments
                      .WithOne(a => a.Doctor)
                      .HasForeignKey(a => a.Appointment_Doctor);

                entity.HasMany(d => d.MedicalRecords)  // One-to-Many with MedicalRecords
                      .WithOne(m => m.Doctor)
                      .HasForeignKey(m => m.DoctorID);

                // Configure Appointment entity
      

            }
            
            );

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(a => a.AppointmentId);  // Primary key
                entity.Property(a => a.Status).IsRequired();  // Required field
            });

            // Configure Billing entity
            modelBuilder.Entity<Billing>(entity =>
            {
                entity.HasKey(b => b.BillID);  // Primary key
                entity.Property(b => b.Amount).IsRequired();  // Required field
            });

            // Configure MedicalRecord entity
            modelBuilder.Entity<MedicalRecord>(entity =>
            {
                entity.HasKey(m => m.RecordID);  // Primary key
                entity.Property(m => m.Diagnosis).IsRequired();  // Required field
            });




        }


    }
}
