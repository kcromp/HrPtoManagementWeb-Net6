using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HrPtoManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bace8c3-27a5-4b17-b7a9-17251af9398z",
                column: "ConcurrencyStamp",
                value: "4522de82-e43f-4336-9bc6-fc99d1c5ae79");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fcbe8c1-27a3-4f47-b7b9-17755af9398z",
                column: "ConcurrencyStamp",
                value: "e7ff52d4-71d7-4e34-b82e-94f5e9333b54");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bcde2c1-24a5-4b27-a7b1-15523af8391a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6cb715fd-905b-47ab-8679-15d1d4d7dd09", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEMTD2ybAgSo/5eqy5p0x7RIDtLx8eqZwfvxF/T2WxSPcyhphTS0UTBJYjXyc9khkHQ==", "9d90bd6d-1a2b-46bf-84f8-a4bf42631f9b", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fcbe1c1-27a7-4f47-b7b1-17755af9398a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9d75f0f1-8feb-4faf-bc0e-8a9f86fbc0d0", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEDpBsnDSoxMrsWRHBxh4t5d2FsLY9KmcRsqBkmVLQMWrvUgyL0P9Sj4VBufRtOQCpg==", "784f262c-17e2-4de4-96a0-1b83c1dcb79b", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bace8c3-27a5-4b17-b7a9-17251af9398z",
                column: "ConcurrencyStamp",
                value: "2f83f3e3-d319-436e-ab58-eef4c37cde0a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fcbe8c1-27a3-4f47-b7b9-17755af9398z",
                column: "ConcurrencyStamp",
                value: "f92407d4-3c4e-4c55-b1c4-880f04c58d9c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bcde2c1-24a5-4b27-a7b1-15523af8391a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "99870747-7c05-4133-b5b8-6e938ada882c", false, null, "AQAAAAEAACcQAAAAEECSl63Ikic7tDw3bJ5qSRZXyiP+zK+wfo77f2yZBAJHAt8lY6SqDAYpt+irY4VWeA==", "41029c4e-dcb6-478c-8aa8-e4b5396d5fdb", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fcbe1c1-27a7-4f47-b7b1-17755af9398a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6d4835d8-78d8-47f5-a521-8470a5450a98", false, null, "AQAAAAEAACcQAAAAEKgPMdZcM5LPGjHj/dwnfl5o7Yuo4C9mz/T4w3Y4BHem8rIecdsNjnfntdver6VRGg==", "9668b3b0-567f-4953-8ff4-45fd8bae0a41", null });
        }
    }
}
