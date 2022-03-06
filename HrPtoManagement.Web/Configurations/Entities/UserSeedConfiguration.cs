using HrPtoManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HrPtoManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "7fcbe1c1-27a7-4f47-b7b1-17755af9398a",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    Firstname = "System", 
                    Lastname = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "3bcde2c1-24a5-4b27-a7b1-15523af8391a",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    UserName = "user@localhost.com",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    Firstname = "System",
                    Lastname = "USER",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                }
            );
        }
    }
}