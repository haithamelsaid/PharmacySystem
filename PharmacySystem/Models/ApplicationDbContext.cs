using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PharmacySystem.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pharmacy> Pharmacies { get; set; }
    }
}
