﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entities.Round", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumberOfPlayers")
                        .HasColumnType("int");

                    b.Property<int>("RoundWords")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("Core.Entities.RoundWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CorrectAnswers")
                        .HasColumnType("int");

                    b.Property<int>("GiveUps")
                        .HasColumnType("int");

                    b.Property<int?>("RoundId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int>("WordId")
                        .HasColumnType("int");

                    b.Property<int>("WrongAnswers")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoundId");

                    b.HasIndex("WordId");

                    b.ToTable("RoundWords");
                });

            modelBuilder.Entity("Core.Entities.Trial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CorrectWords")
                        .HasColumnType("int");

                    b.Property<int>("GiveUps")
                        .HasColumnType("int");

                    b.Property<string>("IPAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mistakes")
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int>("RoundId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmittedAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("Time")
                        .HasColumnType("float");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoundId");

                    b.ToTable("Trials");
                });

            modelBuilder.Entity("Core.Entities.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LeftWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RightWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("Core.Entities.RoundWord", b =>
                {
                    b.HasOne("Core.Entities.Round", "Round")
                        .WithMany()
                        .HasForeignKey("RoundId");

                    b.HasOne("Core.Entities.Word", "Word")
                        .WithMany()
                        .HasForeignKey("WordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Round");

                    b.Navigation("Word");
                });

            modelBuilder.Entity("Core.Entities.Trial", b =>
                {
                    b.HasOne("Core.Entities.Round", "Round")
                        .WithMany()
                        .HasForeignKey("RoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Round");
                });
#pragma warning restore 612, 618
        }
    }
}
