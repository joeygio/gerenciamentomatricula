﻿// <auto-generated />
using System;
using MatriculaConsole.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MatriculaConsole.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Matricula.MatriculaConsole.Models.Disciplina", b =>
                {
                    b.Property<int>("DisciplinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DisciplinaId");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("Matricula.MatriculaConsole.Models.Mentor", b =>
                {
                    b.Property<int>("MentorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MentorId");

                    b.ToTable("Mentores");
                });

            modelBuilder.Entity("Matricula.MatriculaConsole.Models.MentorDisciplina", b =>
                {
                    b.Property<int>("MentorDisciplinasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int?>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<int?>("MentorId")
                        .HasColumnType("int");

                    b.HasKey("MentorDisciplinasId");

                    b.HasIndex("DisciplinaId");

                    b.HasIndex("MentorId");

                    b.ToTable("MentorDisciplinas");
                });

            modelBuilder.Entity("Matricula.MatriculaConsole.Models.MentorDisciplina", b =>
                {
                    b.HasOne("Matricula.MatriculaConsole.Models.Disciplina", "Disciplina")
                        .WithMany()
                        .HasForeignKey("DisciplinaId");

                    b.HasOne("Matricula.MatriculaConsole.Models.Mentor", "Mentor")
                        .WithMany()
                        .HasForeignKey("MentorId");
                });
#pragma warning restore 612, 618
        }
    }
}