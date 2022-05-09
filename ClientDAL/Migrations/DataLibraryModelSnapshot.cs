﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ClientDAL.Context;

namespace ClientDAL.Migrations
{
    [DbContext(typeof(DataLibrary))]
    partial class DataLibraryModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ClientDAL.Model.Analysis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<int?>("PatientId")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("TableDataAnalysis");
                });

            modelBuilder.Entity("ClientDAL.Model.Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("NameDesease")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<int?>("PatientId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("TableDataDisease");
                });

            modelBuilder.Entity("ClientDAL.Model.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("InfoPeopleId")
                        .HasColumnType("integer");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.HasKey("Id");

                    b.HasIndex("InfoPeopleId");

                    b.ToTable("TableDataDoctor");
                });

            modelBuilder.Entity("ClientDAL.Model.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("InfoPeopleId")
                        .HasColumnType("integer");

                    b.Property<int?>("LikarId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("InfoPeopleId");

                    b.HasIndex("LikarId");

                    b.ToTable("TableDataPatient");
                });

            modelBuilder.Entity("ClientDAL.Model.PeopleInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.HasKey("Id");

                    b.ToTable("TableDataPeopleInfo");
                });

            modelBuilder.Entity("ClientDAL.Model.Analysis", b =>
                {
                    b.HasOne("ClientDAL.Model.Patient", null)
                        .WithMany("Analyses")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("ClientDAL.Model.Disease", b =>
                {
                    b.HasOne("ClientDAL.Model.Patient", null)
                        .WithMany("Diseases")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("ClientDAL.Model.Doctor", b =>
                {
                    b.HasOne("ClientDAL.Model.PeopleInfo", "InfoPeople")
                        .WithMany()
                        .HasForeignKey("InfoPeopleId");

                    b.Navigation("InfoPeople");
                });

            modelBuilder.Entity("ClientDAL.Model.Patient", b =>
                {
                    b.HasOne("ClientDAL.Model.PeopleInfo", "InfoPeople")
                        .WithMany()
                        .HasForeignKey("InfoPeopleId");

                    b.HasOne("ClientDAL.Model.Doctor", "Likar")
                        .WithMany()
                        .HasForeignKey("LikarId");

                    b.Navigation("InfoPeople");

                    b.Navigation("Likar");
                });

            modelBuilder.Entity("ClientDAL.Model.Patient", b =>
                {
                    b.Navigation("Analyses");

                    b.Navigation("Diseases");
                });
#pragma warning restore 612, 618
        }
    }
}