using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportX.Ui.Migrations
{
    /// <inheritdoc />
    public partial class Add_Epc_Athlete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Athletes",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Epc",
                table: "Athletes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "Epc",
                table: "Athletes");
        }
    }
}
