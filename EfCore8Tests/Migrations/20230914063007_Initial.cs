using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCore8Tests.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserContexts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyIdentificationData_Val = table.Column<bool>(type: "bit", nullable: false),
                    CompanyIdentificationData_Belgium_EntityBceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyIdentificationData_Belgium_HasVATNumber = table.Column<bool>(type: "bit", nullable: false),
                    CompanyIdentificationData_Belgium_SeatBceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContexts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserContexts");
        }
    }
}
