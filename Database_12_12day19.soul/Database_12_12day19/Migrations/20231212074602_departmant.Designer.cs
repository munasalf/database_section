﻿// <auto-generated />
using Database_12_12day19.ApplicationDbcontexet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database_12_12day19.Migrations
{
    [DbContext(typeof(ApplicationCompanyDBContact))]
    [Migration("20231212074602_departmant")]
    partial class departmant
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Database_12_12day19.DataBasesEmp.DepartmentEmp", b =>
                {
                    b.Property<int>("DepId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepId"), 1L, 1);

                    b.Property<string>("DepName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.HasKey("DepId");

                    b.ToTable("DepartmentEmps");
                });

            modelBuilder.Entity("Database_12_12day19.Modeels.EmployeeInformation", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Salart")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmployeeID");

                    b.ToTable("EmployeeInformations");
                });
#pragma warning restore 612, 618
        }
    }
}
