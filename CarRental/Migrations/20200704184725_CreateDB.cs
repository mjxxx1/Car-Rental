using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "offerNames",
                columns: table => new
                {
                    OfferNameID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_offerNames", x => x.OfferNameID);
                });

            migrationBuilder.CreateTable(
                name: "CarVersions",
                columns: table => new
                {
                    CarVersionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Passengers = table.Column<int>(nullable: false),
                    Transmission = table.Column<string>(nullable: true),
                    AirConditioning = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Segment = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Fuel = table.Column<string>(nullable: true),
                    Doors = table.Column<int>(nullable: false),
                    BootCapacity = table.Column<int>(nullable: true),
                    EnginePower = table.Column<int>(nullable: true),
                    FuelConsumptionPer100km = table.Column<float>(nullable: true),
                    EngineSize = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    OfferNameID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarVersions", x => x.CarVersionID);
                    table.ForeignKey(
                        name: "FK_CarVersions_offerNames_OfferNameID",
                        column: x => x.OfferNameID,
                        principalTable: "offerNames",
                        principalColumn: "OfferNameID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pricelists",
                columns: table => new
                {
                    PriceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoanTimeFrom = table.Column<short>(nullable: false),
                    LoanTimeTo = table.Column<short>(nullable: false),
                    BasePricePerDay = table.Column<decimal>(type: "decimal(9, 2)", nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    OfferNameID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pricelists", x => x.PriceID);
                    table.ForeignKey(
                        name: "FK_Pricelists_offerNames_OfferNameID",
                        column: x => x.OfferNameID,
                        principalTable: "offerNames",
                        principalColumn: "OfferNameID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    VIN = table.Column<string>(nullable: false),
                    RegistrationNumber = table.Column<string>(nullable: true),
                    DateOfFirstRegistration = table.Column<DateTime>(nullable: true),
                    DateOfPurchase = table.Column<DateTime>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CarVersionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.VIN);
                    table.ForeignKey(
                        name: "FK_Cars_CarVersions_CarVersionID",
                        column: x => x.CarVersionID,
                        principalTable: "CarVersions",
                        principalColumn: "CarVersionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarVersionID",
                table: "Cars",
                column: "CarVersionID");

            migrationBuilder.CreateIndex(
                name: "IX_CarVersions_OfferNameID",
                table: "CarVersions",
                column: "OfferNameID");

            migrationBuilder.CreateIndex(
                name: "IX_Pricelists_OfferNameID",
                table: "Pricelists",
                column: "OfferNameID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Pricelists");

            migrationBuilder.DropTable(
                name: "CarVersions");

            migrationBuilder.DropTable(
                name: "offerNames");
        }
    }
}
