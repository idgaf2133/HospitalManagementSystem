using HospitalManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class AppointmentService
    {
        private readonly HospitalContext _context;

        public AppointmentService()
        {
            _context = new HospitalContext();
        }

        // Create a new appointment
        public void AddAppointment(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            _context.SaveChanges();
        }

        // Read all appointments
        public List<Appointment> GetAllAppointments()
        {
            return _context.Appointments
           .Include(a => a.Patient) // Include related Patient
           .Include(a => a.Doctor)  // Include related Doctor
           .ToList();
        }

        // Read a single appointment by ID
        public Appointment GetAppointmentById(int appointmentId)
        {
            return _context.Appointments
           .Include(a => a.Patient)
           .Include(a => a.Doctor)
           .FirstOrDefault(a => a.AppointmentId == appointmentId);
        }

        // Update an existing appointment
        public void UpdateAppointment(Appointment appointment)
        {
            _context.Appointments.Update(appointment);
            _context.SaveChanges();
        }

        // Delete an appointment by ID
        public void DeleteAppointment(int id)
        {
            var appointment = _context.Appointments.Find(id);
            if (appointment != null)
            {
                _context.Appointments.Remove(appointment);
                _context.SaveChanges();
            }
        }
    }

}
