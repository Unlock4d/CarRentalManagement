using CarRentalManagement.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
           new ApplicationUser
           {
               Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
               Email = "admin@localhost.com",
               NormalizedEmail = "ADMIN@LOCALHOST.COM",
               FirstName = "Admin",
               LastName = "User",
               UserName = "Admin",
               NormalizedUserName = "ADMIN",
               PasswordHash = hasher.HashPassword(null, "P@ssword1")
           },
             new ApplicationUser
             {
                 Id = "9e224968-33e4-4652-b7b7-8574d048cdb9",
                 Email = "user@localhost.com",
                 NormalizedEmail = "USER@LOCALHOST.COM",
                 FirstName = "System",
                 LastName = "User",
                 UserName = "User@localhost.com",
                 NormalizedUserName = "USER@LOCALHOST.COM",
                 PasswordHash = hasher.HashPassword(null, "P@ssword1")
             }
            );
        }
    }
}
