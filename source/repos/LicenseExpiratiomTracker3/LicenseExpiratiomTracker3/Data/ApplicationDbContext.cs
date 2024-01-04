using LicenseExpiratiomTracker3.Models;
using Microsoft.EntityFrameworkCore;

namespace LicenseExpiratiomTracker3.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<License> licensesTable3 { get; set; }
    }
}
