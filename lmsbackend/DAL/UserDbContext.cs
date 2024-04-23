using lmsbackend.Models.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace lmsbackend.DAL
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
