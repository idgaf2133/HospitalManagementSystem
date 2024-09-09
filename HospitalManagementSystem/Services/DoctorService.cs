using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class DoctorService
    {
        //create an context variable 

        private readonly HospitalContext _context;


        public DoctorService(HospitalContext context)
        {
            _context = context;

        }

        //CRUD



        //Create a Doctor

        public void AddDoctor(Doctor Doctor)
        {
            _context.Doctors.Add(Doctor);
            _context.SaveChanges();

        }


        //Read All doctior

        public List<Doctor> GetDoctors() { 
        

            return _context.Doctors.ToList();
        }

        //return a doctor from an id
        public Doctor getSingleDoctor(int id)
        {

         return _context.Doctors.Find(id);

        }
        //update an exssiting doctor
        
        public void UpdateDoctor(Doctor doctor)
        {

            var existingDoctor = _context.Doctors.Find(doctor.DoctorId);
            if (existingDoctor != null)
            {
                existingDoctor.Name = doctor.Name;
                existingDoctor.Description = doctor.Description;
                existingDoctor.Contact = doctor.Contact;
                existingDoctor.Email = doctor.Email;
              

                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Doctor not found.");
            }


        }
        //deelete an exisiting doctor from id

        public void DeleteDoctor(int id) 
        {

            Doctor doctor = _context.Doctors.Find(id);

            if (doctor != null) { 
            
                 _context.Doctors.Remove(doctor);

                _context.SaveChanges();
            
            }
        
        }

    }
}
