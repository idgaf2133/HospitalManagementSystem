using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class PatientServices
    {
        //create a context field of the DBContext.

        private readonly HospitalContext _context;

        //initialize it with the constrcutor

        public PatientServices(HospitalContext context)
        {

            _context = context;
        }


        //CRUD operations for trhe patient class.\



        //creating a new patient

        public void AddPatient(Patient Patient)
        {
            try
            {

                _context.Patients.Add(Patient);
                _context.SaveChanges();


            }
            catch (Exception ex) 
            {

                // Log the exception or handle it as needed
                throw new ApplicationException("There was a problem adding the patient.", ex);



            }
        }

        //deleting a patient by Id

        public void RemovePatient(int id)
        {
            //remove the patitent, by his id which is an in


            //first find the patient from his id
            //

            var Patient = _context.Patients.Find(id);


            if (Patient != null)
            {
                    //remove from the database
                    _context.Patients.Remove(Patient);
                    _context.SaveChanges();


            }
        }

        //getting single patient by ID
         public Patient getSinglePatient(int id)
        {
            Patient patient = _context.Patients.Find(id);

            return patient;
        }

        //read all patients
         public List<Patient> GetAllPatients()

        {

            return _context.Patients.ToList();
        }



        // Update an existing patient

        public void UpdatePatient(Patient patient)
        {

            _context.Patients.Update(patient);
            _context.SaveChanges();
        }


    }
}
