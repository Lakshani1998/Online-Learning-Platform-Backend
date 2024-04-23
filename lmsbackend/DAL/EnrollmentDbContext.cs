using lmsbackend.Models.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace lmsbackend.DAL
{
    public class EnrollmentDbContext : DbContext
    {
        public EnrollmentDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
