﻿// <auto-generated />
using MakeupProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MakeupProject.Migrations
{
    [DbContext(typeof(MakeupProjectDbContext))]
    partial class MakeupProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("MakeupProject.Models.Products", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand")
                        .IsRequired();

                    b.Property<string>("BuyAt")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("MakeupProject.Models.Review", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProductsID");

                    b.Property<string>("ReviewText")
                        .HasMaxLength(250);

                    b.Property<int>("Stars");

                    b.HasKey("ID");

                    b.HasIndex("ProductsID");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("MakeupProject.Models.Review", b =>
                {
                    b.HasOne("MakeupProject.Models.Products", "Products")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductsID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
