using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OA.Data
{
   public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(t => t.ID);
            builder.Property(t => t.UserName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.Email).IsRequired();
            builder.Property(t => t.Password).IsRequired();
            builder.HasOne(t => t.UserProfile).WithOne(u => u.User).
                HasForeignKey<UserProfile>(x => x.ID);
        }
    }
}
