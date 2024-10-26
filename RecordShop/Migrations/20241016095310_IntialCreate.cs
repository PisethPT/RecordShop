using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecordShop.Migrations
{
    /// <inheritdoc />
    public partial class IntialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buyer",
                columns: table => new
                {
                    BuyerId = table.Column<int>(type: "int", nullable: false),
                    BuyerName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Created = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Buyer__4B81C62A85753BF4", x => x.BuyerId);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    GenreName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Genre__0385057E7DC4D7E9", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    PublisherId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Contact = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Publishe__4C657FAB77A47D9A", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "Seller",
                columns: table => new
                {
                    SellerId = table.Column<int>(type: "int", nullable: false),
                    SellerName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Created = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Seller__7FE3DB8132E57C05", x => x.SellerId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__1788CC4CD30348B1", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Band",
                columns: table => new
                {
                    BandId = table.Column<int>(type: "int", nullable: false),
                    BandName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: true),
                    Origin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NumberOfAlbums = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Band__A03693A8A0E6EE70", x => x.BandId);
                    table.ForeignKey(
                        name: "FK__Band__GenreId__3B75D760",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "GenreId");
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "int", nullable: false),
                    SellerId = table.Column<int>(type: "int", nullable: true),
                    BuyerId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Paid = table.Column<double>(type: "float", nullable: true),
                    Remain = table.Column<double>(type: "float", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Sale__1EE3C3FFBFD42E75", x => x.SaleId);
                    table.ForeignKey(
                        name: "FK__Sale__BuyerId__4BAC3F29",
                        column: x => x.BuyerId,
                        principalTable: "Buyer",
                        principalColumn: "BuyerId");
                    table.ForeignKey(
                        name: "FK__Sale__SellerId__4AB81AF0",
                        column: x => x.SellerId,
                        principalTable: "Seller",
                        principalColumn: "SellerId");
                });

            migrationBuilder.CreateTable(
                name: "Vinyl",
                columns: table => new
                {
                    VinylId = table.Column<int>(type: "int", nullable: false),
                    VinylName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BandId = table.Column<int>(type: "int", nullable: true),
                    PublisherId = table.Column<int>(type: "int", nullable: true),
                    NumberOfTrack = table.Column<int>(type: "int", nullable: false),
                    DateOfPublishing = table.Column<DateTime>(type: "datetime", nullable: true),
                    PrimeCost = table.Column<double>(type: "float", nullable: false),
                    SalePrice = table.Column<double>(type: "float", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Vinyl__52D1755795B2D11D", x => x.VinylId);
                    table.ForeignKey(
                        name: "FK__Vinyl__BandId__403A8C7D",
                        column: x => x.BandId,
                        principalTable: "Band",
                        principalColumn: "BandId");
                    table.ForeignKey(
                        name: "FK__Vinyl__Publisher__412EB0B6",
                        column: x => x.PublisherId,
                        principalTable: "Publisher",
                        principalColumn: "PublisherId");
                });

            migrationBuilder.CreateTable(
                name: "SaleDetail",
                columns: table => new
                {
                    SaleDetailId = table.Column<int>(type: "int", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: true),
                    VinylId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SaleDeta__70DB14FEF14198AA", x => x.SaleDetailId);
                    table.ForeignKey(
                        name: "FK__SaleDetai__SaleI__4E88ABD4",
                        column: x => x.SaleId,
                        principalTable: "Sale",
                        principalColumn: "SaleId");
                    table.ForeignKey(
                        name: "FK__SaleDetai__Vinyl__4F7CD00D",
                        column: x => x.VinylId,
                        principalTable: "Vinyl",
                        principalColumn: "VinylId");
                });

            migrationBuilder.CreateTable(
                name: "VinylForDiscount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    VinylId = table.Column<int>(type: "int", nullable: true),
                    DiscountDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    SellingPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VinylFor__3214EC07D5F9DEDF", x => x.Id);
                    table.ForeignKey(
                        name: "FK__VinylForD__Vinyl__440B1D61",
                        column: x => x.VinylId,
                        principalTable: "Vinyl",
                        principalColumn: "VinylId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Band_GenreId",
                table: "Band",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_BuyerId",
                table: "Sale",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_SellerId",
                table: "Sale",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetail_SaleId",
                table: "SaleDetail",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetail_VinylId",
                table: "SaleDetail",
                column: "VinylId");

            migrationBuilder.CreateIndex(
                name: "IX_Vinyl_BandId",
                table: "Vinyl",
                column: "BandId");

            migrationBuilder.CreateIndex(
                name: "IX_Vinyl_PublisherId",
                table: "Vinyl",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_VinylForDiscount_VinylId",
                table: "VinylForDiscount",
                column: "VinylId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleDetail");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VinylForDiscount");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Vinyl");

            migrationBuilder.DropTable(
                name: "Buyer");

            migrationBuilder.DropTable(
                name: "Seller");

            migrationBuilder.DropTable(
                name: "Band");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
