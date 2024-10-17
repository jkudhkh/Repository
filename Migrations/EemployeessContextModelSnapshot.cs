﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

#nullable disable

namespace Min.Migrations
{
    [DbContext(typeof(EemployeessContext))]
    partial class EemployeessContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Models.Eemployeess", b =>
                {
                    b.Property<int>("EID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EID");

                    b.ToTable("Eemployeess");
                });

            modelBuilder.Entity("Models.EemployeessLeave", b =>
                {
                    b.Property<int>("LeaveID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EemployeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumOfDays")
                        .HasColumnType("INTEGER");

                    b.HasKey("LeaveID");

                    b.ToTable("EemployeessLeaves");
                });
#pragma warning restore 612, 618
        }
    }
}
