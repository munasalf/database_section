using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database_12_12day19.Migrations
{
    public partial class ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInformations_projects_projID",
                table: "EmployeeInformations");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeInformations_projID",
                table: "EmployeeInformations");

            migrationBuilder.DropColumn(
                name: "projID",
                table: "EmployeeInformations");

            migrationBuilder.CreateTable(
                name: "EmployeeInformationProject",
                columns: table => new
                {
                    EmployeeInformationsEmployeeID = table.Column<int>(type: "int", nullable: false),
                    projectsprojID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInformationProject", x => new { x.EmployeeInformationsEmployeeID, x.projectsprojID });
                    table.ForeignKey(
                        name: "FK_EmployeeInformationProject_EmployeeInformations_EmployeeInformationsEmployeeID",
                        column: x => x.EmployeeInformationsEmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeInformationProject_projects_projectsprojID",
                        column: x => x.projectsprojID,
                        principalTable: "projects",
                        principalColumn: "projID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformationProject_projectsprojID",
                table: "EmployeeInformationProject",
                column: "projectsprojID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeInformationProject");

            migrationBuilder.AddColumn<int>(
                name: "projID",
                table: "EmployeeInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_projID",
                table: "EmployeeInformations",
                column: "projID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInformations_projects_projID",
                table: "EmployeeInformations",
                column: "projID",
                principalTable: "projects",
                principalColumn: "projID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
