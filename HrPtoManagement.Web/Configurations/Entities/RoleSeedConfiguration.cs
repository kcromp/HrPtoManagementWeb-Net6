using HrPtoManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HrPtoManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "7fcbe8c1-27a3-4f47-b7b9-17755af9398z",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "7bace8c3-27a5-4b17-b7a9-17251af9398z",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
             );
        }
    }
}