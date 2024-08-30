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
        public DbSet<UserModel> Users { get; set; }
        public DbSet<ShelterModel> Shelters { get; set; }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.ApplyConfiguration(new UserMap());
            ModelBuilder.ApplyConfiguration(new ShelterMap());
            base.OnModelCreating(ModelBuilder);
        }
    }
}
