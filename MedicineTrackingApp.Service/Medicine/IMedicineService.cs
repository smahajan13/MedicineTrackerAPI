using MedicineTrackingApp.Data;
using MedicineTrackingApp.ViewModal;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicineTrackingApp.Service
{
    public interface IMedicineService
    {
        bool AddMedicineDetails(MedicineViewModel medicine);
        MedicineDetails GetMedicineDetails(ViewMedicineViewModel viewMedicine);
        List<MedicineDetails> GetMedicinesList();
        bool UpdateMedicineDetails(UpdateMedicineViewModel model);
    }
}
