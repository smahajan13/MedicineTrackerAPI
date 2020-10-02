using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MedicineTrackingApp.ViewModal
{
    public class MedicineViewModel
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Price { get; set; }
       
        public int Quantity { get; set; }
        
        public DateTime ExpiryDate { get; set; }
        
        public string Notes { get; set; }
    }
}
