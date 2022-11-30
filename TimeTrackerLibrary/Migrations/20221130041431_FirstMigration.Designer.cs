﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeTrackerLibrary.Data;

#nullable disable

namespace TimeTrackerLibrary.Migrations
{
    [DbContext(typeof(TimeTrackerDbContext))]
    [Migration("20221130041431_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.11");

            modelBuilder.Entity("TimeTrackerLibrary.Model.TimeSheet", b =>
                {
                    b.Property<int>("TimesheetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Activity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly>("BeginTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("WorkDate")
                        .HasColumnType("TEXT");

                    b.HasKey("TimesheetId");

                    b.HasIndex("UserId");

                    b.ToTable("TimeSheets");
                });

            modelBuilder.Entity("TimeTrackerLibrary.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TimeTrackerLibrary.Model.TimeSheet", b =>
                {
                    b.HasOne("TimeTrackerLibrary.Model.User", "User")
                        .WithMany("TimeSheets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TimeTrackerLibrary.Model.User", b =>
                {
                    b.Navigation("TimeSheets");
                });
#pragma warning restore 612, 618
        }
    }
}
