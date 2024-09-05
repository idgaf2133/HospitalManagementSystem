using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class MedicalRecordService
    {
        private readonly HospitalContext _context;

        public MedicalRecordService()
        {
            _context = new HospitalContext();
        }

        // Create a new medical record
        public void AddMedicalRecord(MedicalRecord medicalRecord)
        {
            _context.MedicalRecords.Add(medicalRecord);
            _context.SaveChanges();
        }

        // Read all medical records
        public List<MedicalRecord> GetAllMedicalRecords()
        {
            return _context.MedicalRecords.ToList();
        }

        // Read a single medical record by ID
        public MedicalRecord GetMedicalRecordById(int id)
        {
            return _context.MedicalRecords.Find(id);
        }

        // Update an existing medical record
        public void UpdateMedicalRecord(MedicalRecord medicalRecord)
        {
            _context.MedicalRecords.Update(medicalRecord);
            _context.SaveChanges();
        }

        // Delete a medical record by ID
        public void DeleteMedicalRecord(int id)
        {
            var medicalRecord = _context.MedicalRecords.Find(id);
            if (medicalRecord != null)
            {
                _context.MedicalRecords.Remove(medicalRecord);
                _context.SaveChanges();
            }
        }
    }
}
