using Guardian.Data.Map;
using Guardian.Models;
using Microsoft.EntityFrameworkCore;


namespace Guardian.Data
{
    public class GuardianDB : DbContext
    {
        public GuardianDB(DbContextOptions<GuardianDB> options)
            :base(options) 
        {

        }
        public DbSet<UserRepository> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.ApplyConfiguration(new UserMap());
            base.OnModelCreating(ModelBuilder);
        }
    }
}
