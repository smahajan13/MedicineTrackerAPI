using MedicineTrackingApp.Data;
using MedicineTrackingApp.ViewModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MedicineTrackingApp.Service
{
    public class MedicineService : IMedicineService
    {
        public readonly IMedicineRepository _repository;
        public MedicineService(IMedicineRepository repository)
        {
            _repository = repository;
        }

        public bool AddMedicineDetails(MedicineViewModel medicine)
        {
            try
            {
                double price;
                if (double.TryParse(medicine.Price, out price))
                {
                    price = Math.Round(price, 2);
                }
               
                var medicineDetails = new MedicineDetails
                {
                    FullName = medicine.FullName,
                    Brand = medicine.Brand,
                    Price = price,
                    ExpiryDate = medicine.ExpiryDate,
                    Notes = medicine.Notes,
                    Quantity = medicine.Quantity
                };
                return _repository.AddMedicineDetails(medicineDetails);

                //else
                //{
                //    medExists.Price = price;
                //    medExists.ExpiryDate = medicine.ExpiryDate;
                //    medExists.Notes = medicine.Notes;
                //    medExists.Quantity = medicine.Quantity;
                //    _context.MedicineDetails.Update(medExists);
                //    _context.SaveChanges();
                //    return true;
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MedicineDetails GetMedicineDetails(ViewMedicineViewModel model)
        {
            return _repository.GetMedicineDetails(model.FullName);
        }
        public List<MedicineDetails> GetMedicinesList()
        {
            return _repository.GetMedicinesList();
        }

        public bool UpdateMedicineDetails(UpdateMedicineViewModel model)
        {
            return _repository.UpdateMedicineDetails(model.FullName,model.Notes);
        }
    }
}
