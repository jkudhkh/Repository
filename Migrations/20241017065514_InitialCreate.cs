using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Min.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eemployeess",
                columns: table => new
                {
                    EID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    DID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eemployeess", x => x.EID);
                });

            migrationBuilder.CreateTable(
                name: "EemployeessLeaves",
                columns: table => new
                {
                    LeaveID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EemployeID = table.Column<int>(type: "INTEGER", nullable: false),
                    NumOfDays = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EemployeessLeaves", x => x.LeaveID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eemployeess");

            migrationBuilder.DropTable(
                name: "EemployeessLeaves");
        }
    }
}
