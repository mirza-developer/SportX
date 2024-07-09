using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportX.Ui.Migrations
{
    /// <inheritdoc />
    public partial class Re_Add_EndMembership : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateEndMembership",
                table: "Payments",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateEndMembership",
                table: "Athletes",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEndMembership",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "DateEndMembership",
                table: "Athletes");
        }
    }
}
