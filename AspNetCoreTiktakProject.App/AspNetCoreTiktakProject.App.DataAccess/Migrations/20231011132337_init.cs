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
                    ImageDetailUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageDetailUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageDetailUrl3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageDetailUrl4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plaque = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPerson = table.Column<int>(type: "int", nullable: false),
                    Baggage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinutePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarProperties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
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
                name: "CarSales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartedPoint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CarPropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarSales_CarProperties_CarPropertyId",
                        column: x => x.CarPropertyId,
                        principalTable: "CarProperties",
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
                    VirtualPosId = table.Column<int>(type: "int", nullable: false),
                    CarPropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_CarProperties_CarPropertyId",
                        column: x => x.CarPropertyId,
                        principalTable: "CarProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_CarSales_CarSaleId",
                        column: x => x.CarSaleId,
                        principalTable: "CarSales",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "CarProperties",
                columns: new[] { "Id", "Baggage", "Brand", "FuelType", "GearType", "ImageDetailUrl1", "ImageDetailUrl2", "ImageDetailUrl3", "ImageDetailUrl4", "ImageUrl", "IsActive", "Location", "MinutePrice", "Model", "Plaque", "TotalPerson" },
                values: new object[,]
                {
                    { 1, "Station", "Renault Clio", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Kadıköy", 10m, "2023", "34KYN321", 4 },
                    { 2, "Station", "Renault Clio", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Kadıköy", 10m, "2023", "34KYN321", 4 },
                    { 3, "Station", "Renault Clio", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Kadıköy", 10m, "2023", "34KYN321", 4 },
                    { 4, "Station", "Mini Cooper", "Benzin", "Otomatik", "/Templete/car-rental-html-template/img/minidetay1.jpg", "/Templete/car-rental-html-template/img/minidetay2.jpg", "/Templete/car-rental-html-template/img/minidetay3.jpg", "/Templete/car-rental-html-template/img/minidetay4.jpeg", "/Templete/car-rental-html-template/img/miniana.jpg", true, "Kadıköy", 15m, "2022", "34KYN321", 4 },
                    { 5, "Station", "Mini Cooper", "Benzin", "Otomatik", "/Templete/car-rental-html-template/img/minidetay1.jpg", "/Templete/car-rental-html-template/img/minidetay2.jpg", "/Templete/car-rental-html-template/img/minidetay3.jpg", "/Templete/car-rental-html-template/img/minidetay4.jpeg", "/Templete/car-rental-html-template/img/miniana.jpg", true, "Kadıköy", 15m, "2022", "34KYN321", 4 },
                    { 7, "Station", "Mini Cooper", "Benzin", "Otomatik", "/Templete/car-rental-html-template/img/minidetay1.jpg", "/Templete/car-rental-html-template/img/minidetay2.jpg", "/Templete/car-rental-html-template/img/minidetay3.jpg", "/Templete/car-rental-html-template/img/minidetay4.jpeg", "/Templete/car-rental-html-template/img/miniana.jpg", true, "Kadıköy", 15m, "2022", "34KYN321", 4 },
                    { 8, "Station", "Renault Clio", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Beşiktaş", 10m, "2023", "34KYN321", 4 },
                    { 9, "Station", "Renault Clio", "Benzin", "Manuel", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Beşiktaş", 10m, "2023", "34KYN321", 4 },
                    { 10, "Station", "Renault Clio", "Dizel", "Manuel", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Beşiktaş", 10m, "2023", "34KYN321", 4 },
                    { 11, "Station", "Mini Cooper", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/minidetay1.jpg", "/Templete/car-rental-html-template/img/minidetay2.jpg", "/Templete/car-rental-html-template/img/minidetay3.jpg", "/Templete/car-rental-html-template/img/minidetay4.jpeg", "/Templete/car-rental-html-template/img/miniana.jpg", true, "Beşiktaş", 15m, "2022", "34KYN321", 4 },
                    { 12, "Station", "Mini Cooper", "Benzin", "Otomatik", "/Templete/car-rental-html-template/img/minidetay1.jpg", "/Templete/car-rental-html-template/img/minidetay2.jpg", "/Templete/car-rental-html-template/img/minidetay3.jpg", "/Templete/car-rental-html-template/img/minidetay4.jpeg", "/Templete/car-rental-html-template/img/miniana.jpg", true, "Beşiktaş", 15m, "2022", "34KYN321", 4 },
                    { 13, "Station", "Mini Cooper", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/minidetay1.jpg", "/Templete/car-rental-html-template/img/minidetay2.jpg", "/Templete/car-rental-html-template/img/minidetay3.jpg", "/Templete/car-rental-html-template/img/minidetay4.jpeg", "/Templete/car-rental-html-template/img/miniana.jpg", true, "Beşiktaş", 15m, "2022", "34KYN321", 4 },
                    { 14, "Station", "Mini Cooper", "Benzin", "Otomatik", "/Templete/car-rental-html-template/img/minidetay1.jpg", "/Templete/car-rental-html-template/img/minidetay2.jpg", "/Templete/car-rental-html-template/img/minidetay3.jpg", "/Templete/car-rental-html-template/img/minidetay4.jpeg", "/Templete/car-rental-html-template/img/miniana.jpg", true, "Beşiktaş", 15m, "2022", "34KYN321", 4 },
                    { 15, "Station", "Renault Clio", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Maltepe", 10m, "2023", "34KYN321", 4 },
                    { 16, "Station", "Renault Clio", "Benzin", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Maltepe", 10m, "2023", "34KYN321", 4 },
                    { 17, "Station", "Renault Clio", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Maltepe", 10m, "2023", "34KYN321", 4 },
                    { 18, "Station", "Renault Clio", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Maltepe", 10m, "2022", "34KYN321", 4 },
                    { 19, "Station", "Renault Clio", "Benzin", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Maltepe", 10m, "2022", "34KYN321", 4 },
                    { 20, "Station", "Renault Clio", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Maltepe", 10m, "2022", "34KYN321", 4 },
                    { 21, "Station", "Renault Clio", "Benzin", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Maltepe", 10m, "2022", "34KYN321", 4 },
                    { 22, "Station", "Renault Clio", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Bakırköy", 10m, "2023", "34KYN321", 4 },
                    { 23, "Station", "Renault Clio", "Benzin", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Bakırköy", 10m, "2023", "34KYN321", 4 },
                    { 24, "Station", "Renault Clio", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Bakırköy", 10m, "2023", "34KYN321", 4 },
                    { 25, "Station", "Renault Clio", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Bakırköy", 10m, "2022", "34KYN321", 4 },
                    { 26, "Station", "Renault Clio", "Benzin", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Bakırköy", 10m, "2022", "34KYN321", 4 },
                    { 27, "Station", "Renault Clio", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Bakırköy", 10m, "2022", "34KYN321", 4 },
                    { 28, "Station", "Renault Clio", "Benzin", "Otomatik", "/Templete/car-rental-html-template/img/renodetay1.jpg", "/Templete/car-rental-html-template/img/renodetay2.jpg", "/Templete/car-rental-html-template/img/renodetay3.jpg", "/Templete/car-rental-html-template/img/renodetay4.jpg", "/Templete/car-rental-html-template/img/renoana.jpg", true, "Bakırköy", 10m, "2022", "34KYN321", 4 },
                    { 30, "Station", "Volkswagen Golf", "Elektrik", "Otomatik", "/Templete/car-rental-html-template/img/vwgolfdetay1.jpg", "/Templete/car-rental-html-template/img/vwgolfdetay2.jpg", "/Templete/car-rental-html-template/img/vwgolfdetay3.jpg", "/Templete/car-rental-html-template/img/vwgolfdetay4.jpg", "/Templete/car-rental-html-template/img/vwgolfana.jpg", true, "Maltepe", 15m, "2022", "34AA300", 4 },
                    { 31, "Station", "Volkswagen Passat", "Elektrik", "Otomatik", "/Templete/car-rental-html-template/img/vwpassatdetay1.jpg", "/Templete/car-rental-html-template/img/vwpassatdetay2.jpg", "/Templete/car-rental-html-template/img/vwpassatdetay3.jpg", "/Templete/car-rental-html-template/img/vwpassatdetay4.jpg", "/Templete/car-rental-html-template/img/vwpassatana.jpg", true, "Maltepe", 15m, "2023", "34BB311", 4 },
                    { 32, "Station", "Mercedes Amg", "Benzinli", "Manuel", "/Templete/car-rental-html-template/img/mercedes1detay1.jpg", "/Templete/car-rental-html-template/img/mercedes1detay2.jpg", "/Templete/car-rental-html-template/img/mercedes1detay3.jpg", "/Templete/car-rental-html-template/img/mercedes1detay4.jpg", "/Templete/car-rental-html-template/img/mercedes1ana.jpg", true, "Bakırköy", 25m, "2023", "34BB311", 4 },
                    { 33, "Station", "Mercedes Amg", "Benzinli", "Manuel", "/Templete/car-rental-html-template/img/mercedes1detay1.jpeg", "/Templete/car-rental-html-template/img/mercedes1detay2.jpg", "/Templete/car-rental-html-template/img/mercedes1detay3.jpg", "/Templete/car-rental-html-template/img/mercedes1detay4.jpg", "/Templete/car-rental-html-template/img/mercedes1ana.jpg", true, "Bakırköy", 25m, "2023", "34BB311", 4 },
                    { 34, "Station", "Mercedes G63", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/g63siyahdetay1.jpg", "/Templete/car-rental-html-template/img/g63siyahdetay2.jpg", "/Templete/car-rental-html-template/img/g63siyahdetay3.jpg", "/Templete/car-rental-html-template/img/g63siyahdetay4.jpg", "/Templete/car-rental-html-template/img/g63siyahana.jpg", true, "Kadıköy", 25m, "2023", "34BB311", 4 },
                    { 35, "Station", "Mercedes G63", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/g63siyahdetay1.jpg", "/Templete/car-rental-html-template/img/g63siyahdetay2.jpg", "/Templete/car-rental-html-template/img/g63siyahdetay3.jpg", "/Templete/car-rental-html-template/img/g63siyahdetay4.jpg", "/Templete/car-rental-html-template/img/g63siyahana.jpg", true, "Kadıköy", 25m, "2023", "34BB311", 4 },
                    { 36, "Station", "Fiat Egea", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/egeadetay1.jpg", "/Templete/car-rental-html-template/img/egeadetay2.jpg", "/Templete/car-rental-html-template/img/egeadetay3.jpg", "/Templete/car-rental-html-template/img/egeadetay4.jpg", "/Templete/car-rental-html-template/img/egeaana.jpg", true, "Kadıköy", 13m, "2023", "34BB311", 4 },
                    { 37, "Station", "Fiat Egea", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/egeadetay1.jpg", "/Templete/car-rental-html-template/img/egeadetay2.jpg", "/Templete/car-rental-html-template/img/egeadetay3.jpg", "/Templete/car-rental-html-template/img/egeadetay4.jpg", "/Templete/car-rental-html-template/img/egeaana.jpg", true, "Kadıköy", 13m, "2023", "34BB311", 4 },
                    { 38, "Station", "Fiat Egea", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/egeadetay1.jpg", "/Templete/car-rental-html-template/img/egeadetay2.jpg", "/Templete/car-rental-html-template/img/egeadetay3.jpg", "/Templete/car-rental-html-template/img/egeadetay4.jpg", "/Templete/car-rental-html-template/img/egeaana.jpg", true, "Kadıköy", 13m, "2023", "34BB311", 4 },
                    { 39, "Station", "Fiat Egea", "Dizel", "Otomatik", "/Templete/car-rental-html-template/img/egeadetay1.jpg", "/Templete/car-rental-html-template/img/egeadetay2.jpg", "/Templete/car-rental-html-template/img/egeadetay3.jpg", "/Templete/car-rental-html-template/img/egeadetay4.jpg", "/Templete/car-rental-html-template/img/egeaana.jpg", true, "Kadıköy", 13m, "2023", "34BB311", 4 }
                });

            migrationBuilder.InsertData(
                table: "CarSales",
                columns: new[] { "Id", "CarPropertyId", "CustomerId", "StartedPoint", "StartedTime" },
                values: new object[,]
                {
                    { 1, 1, 1, "Beşiktaş", new DateTime(2023, 10, 11, 16, 23, 37, 616, DateTimeKind.Local).AddTicks(835) },
                    { 2, 2, 2, "Bakırköy", new DateTime(2023, 10, 11, 16, 23, 37, 616, DateTimeKind.Local).AddTicks(850) },
                    { 3, 3, 3, "Maltepe", new DateTime(2023, 10, 11, 16, 23, 37, 616, DateTimeKind.Local).AddTicks(851) }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Id", "CarPropertyId", "CarSaleId", "CustomerId", "DestinationPoint", "FinishedTime", "OccuredDate", "Price", "VirtualPosId" },
                values: new object[,]
                {
                    { 1, 2, 1, 1, "Maltepe", new DateTime(2023, 10, 11, 18, 23, 37, 616, DateTimeKind.Local).AddTicks(871), new DateTime(2023, 10, 11, 16, 23, 37, 616, DateTimeKind.Local).AddTicks(869), 275m, 0 },
                    { 2, 2, 2, 2, "Beşiktaş", new DateTime(2023, 10, 11, 17, 23, 37, 616, DateTimeKind.Local).AddTicks(877), new DateTime(2023, 10, 11, 16, 23, 37, 616, DateTimeKind.Local).AddTicks(876), 355m, 0 },
                    { 3, 2, 3, 3, "Kadıköy", new DateTime(2023, 10, 11, 17, 23, 37, 616, DateTimeKind.Local).AddTicks(879), new DateTime(2023, 10, 11, 16, 23, 37, 616, DateTimeKind.Local).AddTicks(879), 400m, 0 }
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
                name: "IX_Bills_CarPropertyId",
                table: "Bills",
                column: "CarPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_CarSaleId",
                table: "Bills",
                column: "CarSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_CarSales_CarPropertyId",
                table: "CarSales",
                column: "CarPropertyId");
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
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CarSales");

            migrationBuilder.DropTable(
                name: "CarProperties");
        }
    }
}
