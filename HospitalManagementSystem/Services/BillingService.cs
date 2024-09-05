using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class BillingService
    {

        private readonly HospitalContext _context;

        public BillingService()
        {
            _context = new HospitalContext();
        }

        // Create a new billing record
        public void AddBilling(Billing billing)
        {
            _context.Bills.Add(billing);
            _context.SaveChanges();
        }

        // Read all billing records
        public List<Billing> GetAllBillings()
        {
            return _context.Bills.ToList();
        }

        // Read a single billing record by ID
        public Billing GetBillingById(int id)
        {
            return _context.Bills.Find(id);
        }

        // Update an existing billing record
        public void UpdateBilling(Billing billing)
        {
            _context.Bills.Update(billing);
            _context.SaveChanges();
        }

        // Delete a billing record by ID
        public void DeleteBilling(int id)
        {
            var billing = _context.Bills.Find(id);
            if (billing != null)
            {
                _context.Bills.Remove(billing);
                _context.SaveChanges();
            }
        }
    }
}
