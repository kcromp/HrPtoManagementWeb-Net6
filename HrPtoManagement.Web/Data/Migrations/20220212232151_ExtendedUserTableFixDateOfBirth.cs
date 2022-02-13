using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HrPtoManagement.Web.Data.Migrations
{
    public partial class ExtendedUserTableFixDateOfBirth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "AspNetUsers",
                newName: "DateOfBirth");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "AspNetUsers",
                newName: "Date");
        }
    }
}
