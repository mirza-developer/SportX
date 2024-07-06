using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportX.Ui.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Athletes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IsMale = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PaidUntilDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Membership = table.Column<int>(type: "int", nullable: true),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyDatetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Athletes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriceInTomans = table.Column<long>(type: "bigint", nullable: false),
                    PayDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ReceiptNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    PaymentType = table.Column<int>(type: "int", nullable: true),
                    AthleteId = table.Column<int>(type: "int", nullable: true),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyDatetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Athletes_AthleteId",
                        column: x => x.AthleteId,
                        principalTable: "Athletes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AthleteId = table.Column<int>(type: "int", nullable: false),
                    IsEntered = table.Column<bool>(type: "bit", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyDatetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usages_Athletes_AthleteId",
                        column: x => x.AthleteId,
                        principalTable: "Athletes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_AthleteId",
                table: "Payments",
                column: "AthleteId");

            migrationBuilder.CreateIndex(
                name: "IX_Usages_AthleteId",
                table: "Usages",
                column: "AthleteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Usages");

            migrationBuilder.DropTable(
                name: "Athletes");
        }
    }
}
