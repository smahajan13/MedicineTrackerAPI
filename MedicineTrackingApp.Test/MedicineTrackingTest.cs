using MedicineTrackingApp.Data;
using MedicineTrackingApp.Service;
using MedicineTrackingApp.ViewModal;
using Moq;
using System;
using Xunit;

namespace MedicineTrackingApp.Test
{
    public class MedicineTrackingTest
    {
        /// <summary>
        /// GetMedicineDetail
        /// </summary>
        [Fact]
        public void GetMedicineDetailTest()
        {
            MedicineDetails  details = new MedicineDetails
            {
                Id = 1,
                FullName = "Aspirin",
                Brand = "Ranbaxy",
                ExpiryDate = new DateTime(2020,09,1),
                Quantity = 10,
                Price = 10.05
            };
            ViewMedicineViewModel viewparams = new ViewMedicineViewModel
            {
                FullName = "Aspirin"
            };

            //Mock the data access
            var _medicineAcces = new Mock<IMedicineService>();
            var _medicineRepo = new Mock<IMedicineRepository>();
            _medicineAcces.Setup(x => x.GetMedicineDetails(viewparams)).Returns(details);
            var firstName = GetMedicineDetail(_medicineRepo.Object, viewparams);
            Assert.Equal(details.FullName,firstName);
        }


        private string GetMedicineDetail(IMedicineRepository service,ViewMedicineViewModel model)
        {
            var _service = new MedicineService(service);

            var fullName = (_service.GetMedicineDetails(model).FullName);

            return fullName;
        }
    }
}

