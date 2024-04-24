using lmsbackend.Models.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace lmsbackend.DAL
{
    public class CoursesDbContext : DbContext
    {
        public CoursesDbContext(DbContextOptions<CoursesDbContext> options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
    }
}
