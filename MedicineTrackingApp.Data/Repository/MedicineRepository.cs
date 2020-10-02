using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MedicineTrackingApp.Data
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly MedicineDbContext _context;
        public MedicineRepository(MedicineDbContext context)
        {
            _context = context;
        }
        public bool AddMedicineDetails(MedicineDetails medicine)
        {
            _context.MedicineDetails.Add(medicine);
            _context.SaveChanges();
            return true;
        }

        public MedicineDetails GetMedicineDetails(string FullName)
        {
           return _context.MedicineDetails.FirstOrDefault(x => x.FullName == FullName);
        }

        public List<MedicineDetails> GetMedicinesList()
        {
            return _context.MedicineDetails.ToList();
        }

        public bool UpdateMedicineDetails(string fullName,string notes)
        {
           var MedicineDetails = _context.MedicineDetails.FirstOrDefault(x=>x.FullName==fullName);
           MedicineDetails.Notes = notes;
           _context.MedicineDetails.Update(MedicineDetails);
           _context.SaveChanges();
           return true;
        }
    }
}
