using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Data
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Email).IsRequired();
            builder.Property(t => t.Password).IsRequired();
            builder.Property(t => t.Email).IsRequired();
            builder.HasOne(t => t.UserProfile)
                   .WithOne(u => u.User)
                   .HasForeignKey<UserProfile>(x => x.Id);
          
        }
    }
}
