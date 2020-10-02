using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MedicineTrackingApp.Data
{
    public class MedicineDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [NotNull]
        public string FullName { get; set; }
        [NotNull]
        public string Brand { get; set; }
        [NotNull]
        public double Price { get; set; }
        [AllowNull]
        public int Quantity { get; set; }
        [NotNull]
        public DateTime ExpiryDate { get; set; }
        [AllowNull]
        public string Notes { get; set; }
    }
}
