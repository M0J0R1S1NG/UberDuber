using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UberDuber.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address1 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<decimal>(nullable: false),
                    Photo = table.Column<byte[]>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    SpecialInstructions = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Inventorys",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BestBefore = table.Column<DateTime>(nullable: false),
                    CBDContent = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    Likes = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    OnHand = table.Column<bool>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    Photo = table.Column<byte[]>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Supplier = table.Column<string>(nullable: true),
                    THCContent = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventorys", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address1 = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    DriverId = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    PostalCode = table.Column<string>(nullable: true),
                    SpecialInstructions = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Inventorys");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
