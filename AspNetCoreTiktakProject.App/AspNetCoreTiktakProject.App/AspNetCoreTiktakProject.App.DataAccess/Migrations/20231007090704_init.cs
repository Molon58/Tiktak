using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetCoreTiktakProject.App.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverLicence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpireDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CvvNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsOnDrive = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GearType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plaque = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPerson = table.Column<int>(type: "int", nullable: false),
                    Baggage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinutePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarProperties_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarSales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartedPoint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarSales_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OccuredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DestinationPoint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CarSaleId = table.Column<int>(type: "int", nullable: false),
                    VirtualPosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_CarSales_CarSaleId",
                        column: x => x.CarSaleId,
                        principalTable: "CarSales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "IsActive", "Location" },
                values: new object[,]
                {
                    { 1, true, "Beşiktaş" },
                    { 2, true, "Beşiktaş" },
                    { 3, true, "Beşiktaş" },
                    { 4, true, "Beşiktaş" },
                    { 5, true, "Beşiktaş" },
                    { 6, true, "Beşiktaş" },
                    { 7, true, "Beşiktaş" },
                    { 8, true, "Kadıköy" },
                    { 9, true, "Kadıköy" },
                    { 10, true, "Kadıköy" },
                    { 11, true, "Kadıköy" },
                    { 12, true, "Kadıköy" },
                    { 13, true, "Kadıköy" },
                    { 14, true, "Kadıköy" },
                    { 15, true, "Bakırköy" },
                    { 16, true, "Bakırköy" },
                    { 17, true, "Bakırköy" },
                    { 18, true, "Bakırköy" },
                    { 19, true, "Bakırköy" },
                    { 20, true, "Bakırköy" },
                    { 21, true, "Bakırköy" },
                    { 22, true, "Maltepe" },
                    { 23, true, "Maltepe" },
                    { 24, true, "Maltepe" },
                    { 25, true, "Maltepe" },
                    { 26, true, "Maltepe" },
                    { 27, true, "Maltepe" },
                    { 28, true, "Maltepe" }
                });

            migrationBuilder.InsertData(
                table: "CarProperties",
                columns: new[] { "Id", "Baggage", "Brand", "CarId", "FuelType", "GearType", "ImageUrl", "MinutePrice", "Model", "Plaque", "TotalPerson" },
                values: new object[,]
                {
                    { 1, "Station", "Renault Clio", 5, "Dizel", "Otomatik", "/images/resim", 5m, "2023", "34KYN321", 4 },
                    { 2, "Station", "Renault Clio", 6, "Dizel", "Otomatik", "/images/resim", 5m, "2023", "34KYN321", 4 },
                    { 3, "Station", "Renault Clio", 7, "Dizel", "Otomatik", "/images/resim", 5m, "2023", "34KYN321", 4 },
                    { 4, "Station", "Toyota Corolla", 1, "Benzin", "Otomatik", "/images/resim", 7m, "2022", "34KYN321", 4 },
                    { 5, "Station", "Toyota Corolla", 2, "Benzin", "Otomatik", "/images/resim", 7m, "2022", "34KYN321", 4 },
                    { 6, "Station", "Toyota Corolla", 3, "Benzin", "Otomatik", "/images/resim", 7m, "2022", "34KYN321", 4 },
                    { 7, "Station", "Toyota Corolla", 4, "Benzin", "Otomatik", "/images/resim", 7m, "2022", "34KYN321", 4 },
                    { 8, "Station", "Renault Clio", 12, "Dizel", "Otomatik", "/images/resim", 5m, "2023", "34KYN321", 4 },
                    { 9, "Station", "Renault Clio", 13, "Benzin", "Otomatik", "/images/resim", 5m, "2023", "34KYN321", 4 },
                    { 10, "Station", "Renault Clio", 14, "Dizel", "Otomatik", "/images/resim", 5m, "2023", "34KYN321", 4 },
                    { 11, "Station", "Toyota Corolla", 8, "Dizel", "Otomatik", "/images/resim", 7m, "2022", "34KYN321", 4 },
                    { 12, "Station", "Toyota Corolla", 9, "Benzin", "Otomatik", "/images/resim", 7m, "2022", "34KYN321", 4 },
                    { 13, "Station", "Toyota Corolla", 10, "Dizel", "Otomatik", "/images/resim", 7m, "2022", "34KYN321", 4 },
                    { 14, "Station", "Toyota Corolla", 11, "Benzin", "Otomatik", "/images/resim", 7m, "2022", "34KYN321", 4 },
                    { 15, "Station", "Renault Clio", 19, "Dizel", "Otomatik", "/images/resim", 5m, "2023", "34KYN321", 4 },
                    { 16, "Station", "Renault Clio", 20, "Benzin", "Otomatik", "/images/resim", 5m, "2023", "34KYN321", 4 },
                    { 17, "Station", "Renault Clio", 21, "Dizel", "Otomatik", "/images/resim", 5m, "2023", "34KYN321", 4 },
                    { 18, "Station", "Toyota Corolla", 15, "Dizel", "Otomatik", "/images/resim", 7m, "2022", "34KYN321", 4 },
                    { 19, "Station", "Toyota Corolla", 16, "Benzin", "Otomatik", "/images/resim", 7m, "2022", "34KYN321", 4 },
                    { 20, "Station", "Toyota Corolla", 17, "Dizel", "Otomatik", "/images/resim", 7m, "2022", "34KYN321", 4 },
                    { 21, "Station", "Toyota Corolla", 18, "Benzin", "Otomatik", "/images/resim", 7m, "2022", "34KYN321", 4 },
                    { 22, "Station", "Renault Clio", 26, "Dizel", "Otomatik", "/images/resim", 5m, "2023", "34KYN321", 4 },
                    { 23, "Station", "Renault Clio", 27, "Benzin", "Otomatik", "/images/resim", 5m, "2023", "34KYN321", 4 },
                    { 24, "Station", "Renault Clio", 28, "Dizel", "Otomatik", "/images/resim", 5m, "2023", "34KYN321", 4 },
                    { 25, "Station", "Toyota Corolla", 22, "Dizel", "Otomatik", "/images/resim", 7m, "2022", "34KYN321", 4 },
                    { 26, "Station", "Toyota Corolla", 23, "Benzin", "Otomatik", "/images/resim", 7m, "2022", "34KYN321", 4 },
                    { 27, "Station", "Toyota Corolla", 24, "Dizel", "Otomatik", "/images/resim", 7m, "2022", "34KYN321", 4 },
                    { 28, "Station", "Toyota Corolla", 25, "Benzin", "Otomatik", "/images/resim", 7m, "2022", "34KYN321", 4 }
                });

            migrationBuilder.InsertData(
                table: "CarSales",
                columns: new[] { "Id", "CarId", "CustomerId", "StartedPoint", "StartedTime" },
                values: new object[,]
                {
                    { 1, 3, 1, "Beşiktaş", new DateTime(2023, 10, 7, 12, 7, 3, 905, DateTimeKind.Local).AddTicks(5921) },
                    { 2, 11, 2, "Bakırköy", new DateTime(2023, 10, 7, 12, 7, 3, 905, DateTimeKind.Local).AddTicks(5938) },
                    { 3, 1, 3, "Maltepe", new DateTime(2023, 10, 7, 12, 7, 3, 905, DateTimeKind.Local).AddTicks(5940) }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Id", "CarSaleId", "CustomerId", "DestinationPoint", "FinishedTime", "OccuredDate", "Price", "VirtualPosId" },
                values: new object[,]
                {
                    { 1, 1, 1, "Maltepe", new DateTime(2023, 10, 7, 14, 7, 3, 905, DateTimeKind.Local).AddTicks(5986), new DateTime(2023, 10, 7, 12, 7, 3, 905, DateTimeKind.Local).AddTicks(5984), 275m, 0 },
                    { 2, 2, 2, "Beşiktaş", new DateTime(2023, 10, 7, 13, 7, 3, 905, DateTimeKind.Local).AddTicks(5994), new DateTime(2023, 10, 7, 12, 7, 3, 905, DateTimeKind.Local).AddTicks(5993), 355m, 0 },
                    { 3, 3, 3, "Kadıköy", new DateTime(2023, 10, 7, 13, 7, 3, 905, DateTimeKind.Local).AddTicks(5996), new DateTime(2023, 10, 7, 12, 7, 3, 905, DateTimeKind.Local).AddTicks(5995), 400m, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_CarSaleId",
                table: "Bills",
                column: "CarSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_CarProperties_CarId",
                table: "CarProperties",
                column: "CarId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarSales_CarId",
                table: "CarSales",
                column: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "CarProperties");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CarSales");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
