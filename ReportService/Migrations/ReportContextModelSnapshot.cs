﻿// <auto-generated />
using System;
using DirectoryService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ReportService.Migrations
{
    [DbContext(typeof(ReportContext))]
    partial class ReportContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ReportService.Models.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Details_Id")
                        .HasColumnType("integer");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Details_Id")
                        .IsUnique();

                    b.ToTable("Report", (string)null);
                });

            modelBuilder.Entity("ReportService.Models.ReportDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<int>("PersonCount")
                        .HasColumnType("integer");

                    b.Property<int>("PhoneNumberCount")
                        .HasColumnType("integer");

                    b.Property<int>("Report_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ReportDetails", (string)null);
                });

            modelBuilder.Entity("ReportService.Models.Report", b =>
                {
                    b.HasOne("ReportService.Models.ReportDetails", "Details")
                        .WithOne("Report")
                        .HasForeignKey("ReportService.Models.Report", "Details_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Details");
                });

            modelBuilder.Entity("ReportService.Models.ReportDetails", b =>
                {
                    b.Navigation("Report");
                });
#pragma warning restore 612, 618
        }
    }
}
