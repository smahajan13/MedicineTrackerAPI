using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicineTrackingApp.Data
{
    public class MedicineDbContext : DbContext
    {
        public MedicineDbContext(DbContextOptions<MedicineDbContext> options)
            : base(options)
        { }

        public DbSet<MedicineDetails> MedicineDetails { get; set; }
    }
}
