using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HrPtoManagement.Web.Data.Migrations
{
    public partial class AddedDefaultRolesAndUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaxId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7bace8c3-27a5-4b17-b7a9-17251af9398z", "2f83f3e3-d319-436e-ab58-eef4c37cde0a", "User", "USER" },
                    { "7fcbe8c1-27a3-4f47-b7b9-17755af9398z", "f92407d4-3c4e-4c55-b1c4-880f04c58d9c", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3bcde2c1-24a5-4b27-a7b1-15523af8391a", 0, "99870747-7c05-4133-b5b8-6e938ada882c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "USER", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEECSl63Ikic7tDw3bJ5qSRZXyiP+zK+wfo77f2yZBAJHAt8lY6SqDAYpt+irY4VWeA==", null, false, "41029c4e-dcb6-478c-8aa8-e4b5396d5fdb", false, null },
                    { "7fcbe1c1-27a7-4f47-b7b1-17755af9398a", 0, "6d4835d8-78d8-47f5-a521-8470a5450a98", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEKgPMdZcM5LPGjHj/dwnfl5o7Yuo4C9mz/T4w3Y4BHem8rIecdsNjnfntdver6VRGg==", null, false, "9668b3b0-567f-4953-8ff4-45fd8bae0a41", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7bace8c3-27a5-4b17-b7a9-17251af9398z", "3bcde2c1-24a5-4b27-a7b1-15523af8391a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7fcbe8c1-27a3-4f47-b7b9-17755af9398z", "7fcbe1c1-27a7-4f47-b7b1-17755af9398a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7bace8c3-27a5-4b17-b7a9-17251af9398z", "3bcde2c1-24a5-4b27-a7b1-15523af8391a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7fcbe8c1-27a3-4f47-b7b9-17755af9398z", "7fcbe1c1-27a7-4f47-b7b1-17755af9398a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bace8c3-27a5-4b17-b7a9-17251af9398z");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fcbe8c1-27a3-4f47-b7b9-17755af9398z");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bcde2c1-24a5-4b27-a7b1-15523af8391a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fcbe1c1-27a7-4f47-b7b1-17755af9398a");

            migrationBuilder.AddColumn<string>(
                name: "TaxId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
