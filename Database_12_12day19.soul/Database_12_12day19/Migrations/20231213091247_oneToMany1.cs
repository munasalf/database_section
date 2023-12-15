using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database_12_12day19.Migrations
{
    public partial class oneToMany1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Salart",
                table: "EmployeeInformations",
                newName: "Salary");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "EmployeeInformations",
                newName: "Salart");
        }
    }
}
