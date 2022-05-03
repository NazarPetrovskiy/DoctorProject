﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServerDAL.Context;

namespace ServerDAL.Migrations
{
    [DbContext(typeof(DataLibrary))]
    [Migration("20220503210631_Add TableDataDoctor")]
    partial class AddTableDataDoctor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("ServerDAL.Model.Analysis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("TableDataAnalysis");
                });

            modelBuilder.Entity("ServerDAL.Model.Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameDesease")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PatientId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("TableDataDisease");
                });

            modelBuilder.Entity("ServerDAL.Model.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("InfoPeopleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Specialty")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("InfoPeopleId");

                    b.ToTable("TableDataDoctor");
                });

            modelBuilder.Entity("ServerDAL.Model.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("InfoPeopleId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LikarId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InfoPeopleId");

                    b.HasIndex("LikarId");

                    b.ToTable("TableDataPatient");
                });

            modelBuilder.Entity("ServerDAL.Model.PeopleInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TableDataPeopleInfo");
                });

            modelBuilder.Entity("ServerDAL.Model.Analysis", b =>
                {
                    b.HasOne("ServerDAL.Model.Patient", null)
                        .WithMany("Analyses")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("ServerDAL.Model.Disease", b =>
                {
                    b.HasOne("ServerDAL.Model.Patient", null)
                        .WithMany("Diseases")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("ServerDAL.Model.Doctor", b =>
                {
                    b.HasOne("ServerDAL.Model.PeopleInfo", "InfoPeople")
                        .WithMany()
                        .HasForeignKey("InfoPeopleId");

                    b.Navigation("InfoPeople");
                });

            modelBuilder.Entity("ServerDAL.Model.Patient", b =>
                {
                    b.HasOne("ServerDAL.Model.PeopleInfo", "InfoPeople")
                        .WithMany()
                        .HasForeignKey("InfoPeopleId");

                    b.HasOne("ServerDAL.Model.Doctor", "Likar")
                        .WithMany()
                        .HasForeignKey("LikarId");

                    b.Navigation("InfoPeople");

                    b.Navigation("Likar");
                });

            modelBuilder.Entity("ServerDAL.Model.Patient", b =>
                {
                    b.Navigation("Analyses");

                    b.Navigation("Diseases");
                });
#pragma warning restore 612, 618
        }
    }
}
