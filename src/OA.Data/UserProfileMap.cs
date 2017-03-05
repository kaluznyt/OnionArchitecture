using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Data
{
    public class UserProfileMap
    {
        public UserProfileMap(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.FirstName).IsRequired();
            builder.Property(t => t.LastName).IsRequired();
            builder.Property(t => t.Address).IsRequired();
        }
    }
}
