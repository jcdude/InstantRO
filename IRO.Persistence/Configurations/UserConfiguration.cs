using IRO.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IRO.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Id)
               .HasMaxLength(36)
               .ValueGeneratedOnAdd();

            builder.Property(e => e.FirstName).HasMaxLength(55);
            builder.Property(e => e.LastName).HasMaxLength(55);
            builder.Property(e => e.UserName).HasMaxLength(65);
            builder.Property(e => e.Email).HasMaxLength(100);
            builder.Property(e => e.Cell).HasMaxLength(10);
        }
    }
}
