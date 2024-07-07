using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportX.Ui.Migrations
{
    /// <inheritdoc />
    public partial class Add_Remaining_Sessions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaidUntilDate",
                table: "Athletes");

            migrationBuilder.AddColumn<int>(
                name: "SessionCountFor",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RemainingSessionCounts",
                table: "Athletes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SessionCountFor",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "RemainingSessionCounts",
                table: "Athletes");

            migrationBuilder.AddColumn<string>(
                name: "PaidUntilDate",
                table: "Athletes",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);
        }
    }
}
