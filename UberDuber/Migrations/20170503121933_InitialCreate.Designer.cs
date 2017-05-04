using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using UberDuber.Data;

namespace UberDuber.Migrations
{
    [DbContext(typeof(UberDuberContext))]
    [Migration("20170503121933_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UberDuber.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("City");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<decimal>("PhoneNumber");

                    b.Property<byte[]>("Photo");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Province");

                    b.Property<DateTime>("RegistrationDate");

                    b.Property<string>("SpecialInstructions");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("Status");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("UberDuber.Models.Inventory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BestBefore");

                    b.Property<double>("CBDContent");

                    b.Property<double>("Cost");

                    b.Property<string>("Description");

                    b.Property<string>("Label");

                    b.Property<int>("Likes");

                    b.Property<string>("Notes");

                    b.Property<bool>("OnHand");

                    b.Property<DateTime>("OrderDate");

                    b.Property<byte[]>("Photo");

                    b.Property<double>("Price");

                    b.Property<double>("Quantity");

                    b.Property<int>("Status");

                    b.Property<string>("Supplier");

                    b.Property<double>("THCContent");

                    b.HasKey("ID");

                    b.ToTable("Inventorys");
                });

            modelBuilder.Entity("UberDuber.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("DeliveryDate");

                    b.Property<string>("Details");

                    b.Property<int>("DriverId");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("PaymentType");

                    b.Property<string>("PostalCode");

                    b.Property<string>("SpecialInstructions");

                    b.Property<int>("Status");

                    b.Property<decimal>("Total");

                    b.Property<decimal>("Weight");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });
        }
    }
}
