﻿// <auto-generated />
using DatabaseApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatabaseApp.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("DatabaseApp.Data.DTO.EmployeeDTO", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Department");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<decimal>("Salary");

                    b.HasKey("ID");

                    b.HasIndex("Department");

                    b.HasIndex("Salary");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}