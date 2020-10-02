using System;
using System.Collections.Generic;
using System.Text;

namespace MedicineTrackingApp.Data
{
    public interface IMedicineRepository
    {
        bool AddMedicineDetails(MedicineDetails medicine);
        MedicineDetails GetMedicineDetails(string FullName);
        List<MedicineDetails> GetMedicinesList();
        bool UpdateMedicineDetails(string fullName, string notes);
    }
}
