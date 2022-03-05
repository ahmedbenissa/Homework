using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class mig07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "DepartementEmployee",
                columns: table => new
                {
                    departementsid = table.Column<int>(type: "int", nullable: false),
                    employeesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartementEmployee", x => new { x.departementsid, x.employeesid });
                    table.ForeignKey(
                        name: "FK_DepartementEmployee_Departements_departementsid",
                        column: x => x.departementsid,
                        principalTable: "Departements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartementEmployee_employees_employeesid",
                        column: x => x.employeesid,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartementEmployee_employeesid",
                table: "DepartementEmployee",
                column: "employeesid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartementEmployee");

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
    }
}
