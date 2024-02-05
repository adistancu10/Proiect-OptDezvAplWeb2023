﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect.Data;

#nullable disable

namespace Proiect.Migrations
{
    [DbContext(typeof(tableContext))]
    partial class tableContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proiect.Models.Clasa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NumeClasa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nrElevi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clase");
                });

            modelBuilder.Entity("Proiect.Models.Diriginte", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ClasaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Varsta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClasaId")
                        .IsUnique();

                    b.ToTable("Diriginti");
                });

            modelBuilder.Entity("Proiect.Models.Elev", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ClasaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProfesorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Varsta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClasaId");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Elevi");
                });

            modelBuilder.Entity("Proiect.Models.ElevMaterie", b =>
                {
                    b.Property<Guid>("ElevId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaterieId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ElevId", "MaterieId");

                    b.HasIndex("MaterieId");

                    b.ToTable("EleviMaterii");
                });

            modelBuilder.Entity("Proiect.Models.Materie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NumeMaterie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Materii");
                });

            modelBuilder.Entity("Proiect.Models.Profesor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profesori");
                });

            modelBuilder.Entity("Proiect.Models.Diriginte", b =>
                {
                    b.HasOne("Proiect.Models.Clasa", "Clasa")
                        .WithOne("Diriginte")
                        .HasForeignKey("Proiect.Models.Diriginte", "ClasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clasa");
                });

            modelBuilder.Entity("Proiect.Models.Elev", b =>
                {
                    b.HasOne("Proiect.Models.Clasa", "Clasa")
                        .WithMany("Elevi")
                        .HasForeignKey("ClasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect.Models.Profesor", "Profesor")
                        .WithMany("Elevi")
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clasa");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("Proiect.Models.ElevMaterie", b =>
                {
                    b.HasOne("Proiect.Models.Elev", "Elev")
                        .WithMany("ElevMaterie")
                        .HasForeignKey("ElevId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect.Models.Materie", "Materie")
                        .WithMany("ElevMaterie")
                        .HasForeignKey("MaterieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Elev");

                    b.Navigation("Materie");
                });

            modelBuilder.Entity("Proiect.Models.Clasa", b =>
                {
                    b.Navigation("Diriginte")
                        .IsRequired();

                    b.Navigation("Elevi");
                });

            modelBuilder.Entity("Proiect.Models.Elev", b =>
                {
                    b.Navigation("ElevMaterie");
                });

            modelBuilder.Entity("Proiect.Models.Materie", b =>
                {
                    b.Navigation("ElevMaterie");
                });

            modelBuilder.Entity("Proiect.Models.Profesor", b =>
                {
                    b.Navigation("Elevi");
                });
#pragma warning restore 612, 618
        }
    }
}
