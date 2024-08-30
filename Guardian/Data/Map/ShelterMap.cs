using Guardian.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Guardian.Data.Map
{
    public class ShelterMap : IEntityTypeConfiguration <ShelterModel> 
   
    {
        public void Configure(EntityTypeBuilder<ShelterModel> builder) 
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(225);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(20);
                 

        }
    }
}
