using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database_12_12day19.Migrations
{
    public partial class projets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepId",
                table: "EmployeeInformations",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "projID",
                table: "EmployeeInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    projID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    projDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.projID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_DepId",
                table: "EmployeeInformations",
                column: "DepId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_projID",
                table: "EmployeeInformations",
                column: "projID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInformations_DepartmentEmps_DepId",
                table: "EmployeeInformations",
                column: "DepId",
                principalTable: "DepartmentEmps",
                principalColumn: "DepId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInformations_projects_projID",
                table: "EmployeeInformations",
                column: "projID",
                principalTable: "projects",
                principalColumn: "projID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInformations_DepartmentEmps_DepId",
                table: "EmployeeInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInformations_projects_projID",
                table: "EmployeeInformations");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeInformations_DepId",
                table: "EmployeeInformations");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeInformations_projID",
                table: "EmployeeInformations");

            migrationBuilder.DropColumn(
                name: "DepId",
                table: "EmployeeInformations");

            migrationBuilder.DropColumn(
                name: "projID",
                table: "EmployeeInformations");
        }
    }
}
