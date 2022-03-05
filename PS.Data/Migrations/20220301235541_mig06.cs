using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class mig06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Departementid",
                table: "employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_Departementid",
                table: "employees",
                column: "Departementid");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_Departements_Departementid",
                table: "employees",
                column: "Departementid",
                principalTable: "Departements",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_Departements_Departementid",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_Departementid",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "Departementid",
                table: "employees");
        }
    }
}
