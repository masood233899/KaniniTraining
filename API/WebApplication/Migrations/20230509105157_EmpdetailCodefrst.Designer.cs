﻿// <auto-generated />
using System;
using CdefrstEfApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CdefrstEfApi.Migrations
{
    [DbContext(typeof(CfApiContxt))]
    [Migration("20230509105157_EmpdetailCodefrst")]
    partial class EmpdetailCodefrst
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CdefrstEfApi.Models.Dept", b =>
                {
                    b.Property<int>("Deptid")
                        .HasColumnType("int");

                    b.Property<string>("Deptname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Deptid");

                    b.ToTable("Depts");
                });

            modelBuilder.Entity("CdefrstEfApi.Models.Emp", b =>
                {
                    b.Property<int>("Empid")
                        .HasColumnType("int");

                    b.Property<int?>("Deptid")
                        .HasColumnType("int");

                    b.Property<string>("Empname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Empid");

                    b.HasIndex("Deptid");

                    b.ToTable("Emps");
                });

            modelBuilder.Entity("CdefrstEfApi.Models.EmpDetails", b =>
                {
                    b.Property<int>("empno")
                        .HasColumnType("int");

                    b.Property<long>("aadharno")
                        .HasColumnType("bigint");

                    b.Property<string>("panno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("empno");

                    b.ToTable("EmpDetails");
                });

            modelBuilder.Entity("CdefrstEfApi.Models.Emp", b =>
                {
                    b.HasOne("CdefrstEfApi.Models.Dept", "DeptNav")
                        .WithMany("Emp")
                        .HasForeignKey("Deptid");

                    b.Navigation("DeptNav");
                });

            modelBuilder.Entity("CdefrstEfApi.Models.Dept", b =>
                {
                    b.Navigation("Emp");
                });
#pragma warning restore 612, 618
        }
    }
}
