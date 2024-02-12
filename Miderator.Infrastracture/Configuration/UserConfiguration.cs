using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Miderator.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miderator.Infrastracture.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
           builder.HasKey(x => x.Id);
           builder
                  .Property(x => x.Id)
                  .ValueGeneratedOnAdd();

            builder
                .HasOne(x=>x.Department)
                .WithMany(x=>x.Users)
                .HasForeignKey(x=>x.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
