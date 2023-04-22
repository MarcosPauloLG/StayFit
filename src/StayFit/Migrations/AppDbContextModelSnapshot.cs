﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StayFit.Context;

#nullable disable

namespace StayFit.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StayFit.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("FichaId")
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("Matricula")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Pontuacao")
                        .HasColumnType("int");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("ClienteId");

                    b.HasIndex("FichaId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("StayFit.Models.Exercicio", b =>
                {
                    b.Property<int>("ExercicioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExercicioId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("GroupMuscle")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Photo")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TypeExercice")
                        .HasColumnType("int");

                    b.Property<string>("Video")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ExercicioId");

                    b.ToTable("Exercicios");
                });

            modelBuilder.Entity("StayFit.Models.Ficha", b =>
                {
                    b.Property<int>("FichaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FichaId"));

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.HasKey("FichaId");

                    b.ToTable("Fichas");
                });

            modelBuilder.Entity("StayFit.Models.Treino", b =>
                {
                    b.Property<int>("TreinoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TreinoId"));

                    b.Property<float?>("Distance")
                        .HasColumnType("real");

                    b.Property<int>("ExercicioId")
                        .HasColumnType("int");

                    b.Property<int?>("FichaId")
                        .HasColumnType("int");

                    b.Property<int>("RepetitionNumber")
                        .HasColumnType("int");

                    b.Property<int>("RestTime")
                        .HasColumnType("int");

                    b.Property<int>("Series")
                        .HasColumnType("int");

                    b.Property<float?>("Weight")
                        .HasColumnType("real");

                    b.HasKey("TreinoId");

                    b.HasIndex("ExercicioId");

                    b.HasIndex("FichaId");

                    b.ToTable("Treinos");
                });

            modelBuilder.Entity("StayFit.Models.Cliente", b =>
                {
                    b.HasOne("StayFit.Models.Ficha", "Ficha")
                        .WithMany()
                        .HasForeignKey("FichaId");

                    b.Navigation("Ficha");
                });

            modelBuilder.Entity("StayFit.Models.Treino", b =>
                {
                    b.HasOne("StayFit.Models.Exercicio", "Exercicio")
                        .WithMany()
                        .HasForeignKey("ExercicioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StayFit.Models.Ficha", null)
                        .WithMany("Treinos")
                        .HasForeignKey("FichaId");

                    b.Navigation("Exercicio");
                });

            modelBuilder.Entity("StayFit.Models.Ficha", b =>
                {
                    b.Navigation("Treinos");
                });
#pragma warning restore 612, 618
        }
    }
}
