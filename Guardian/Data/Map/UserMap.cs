using Guardian.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Guardian.Data.Map
{
    public class UserMap : IEntityTypeConfiguration <UserModel> 
   
    {
        public void Configure(EntityTypeBuilder<UserModel> builder) 
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(225);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(6);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(128);       

        }
    }
}
