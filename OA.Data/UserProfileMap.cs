using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OA.Data
{
  public   class UserProfileMap
    {
        public UserProfileMap(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasKey(t => t.ID);
            builder.Property(t => t.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.LastName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.Address);           
        }
    }
}
