﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using SchoolActivity.Model;

namespace Model.Migrations
{
    [DbContext(typeof(SchoolActivityContext))]
    [Migration("20210322234829_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("Model.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Model.Models.Submission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ActivityId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Score")
                        .HasColumnType("TEXT");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.ToTable("Submissions");
                });

            modelBuilder.Entity("Model.Models.Submission", b =>
                {
                    b.HasOne("Model.Models.Activity", "Activity")
                        .WithMany("Submissions")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("Model.Models.Activity", b =>
                {
                    b.Navigation("Submissions");
                });
#pragma warning restore 612, 618
        }
    }
}