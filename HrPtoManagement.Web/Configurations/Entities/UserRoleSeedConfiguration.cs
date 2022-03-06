using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HrPtoManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "7fcbe8c1-27a3-4f47-b7b9-17755af9398z",
                    UserId = "7fcbe1c1-27a7-4f47-b7b1-17755af9398a"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "7bace8c3-27a5-4b17-b7a9-17251af9398z",
                    UserId = "3bcde2c1-24a5-4b27-a7b1-15523af8391a"
                }
            );
        }
    }
}