﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RestTest;

#nullable disable

namespace ScholarMeServer.Migrations
{
    [DbContext(typeof(ScholarMeDbContext))]
    partial class ScholarMeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RestTest.Models.Flashcard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("FlashcardDeckId")
                        .HasColumnType("integer");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("FlashcardDeckId");

                    b.ToTable("Flashcards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 12, 10, 9, 48, 28, 985, DateTimeKind.Utc).AddTicks(1925),
                            FlashcardDeckId = 1,
                            Question = "What is the capital of France?",
                            UpdatedAt = new DateTime(2024, 12, 10, 9, 48, 28, 985, DateTimeKind.Utc).AddTicks(2100)
                        });
                });

            modelBuilder.Entity("RestTest.Models.FlashcardChoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Choice")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("FlashcardId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsAnswer")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("FlashcardId");

                    b.ToTable("FlashcardChoices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Choice = "Paris",
                            CreatedAt = new DateTime(2024, 12, 10, 9, 48, 28, 985, DateTimeKind.Utc).AddTicks(3110),
                            FlashcardId = 1,
                            IsAnswer = true,
                            UpdatedAt = new DateTime(2024, 12, 10, 9, 48, 28, 985, DateTimeKind.Utc).AddTicks(3244)
                        },
                        new
                        {
                            Id = 2,
                            Choice = "London",
                            CreatedAt = new DateTime(2024, 12, 10, 9, 48, 28, 985, DateTimeKind.Utc).AddTicks(3402),
                            FlashcardId = 1,
                            IsAnswer = false,
                            UpdatedAt = new DateTime(2024, 12, 10, 9, 48, 28, 985, DateTimeKind.Utc).AddTicks(3402)
                        },
                        new
                        {
                            Id = 3,
                            Choice = "Berlin",
                            CreatedAt = new DateTime(2024, 12, 10, 9, 48, 28, 985, DateTimeKind.Utc).AddTicks(3404),
                            FlashcardId = 1,
                            IsAnswer = false,
                            UpdatedAt = new DateTime(2024, 12, 10, 9, 48, 28, 985, DateTimeKind.Utc).AddTicks(3404)
                        });
                });

            modelBuilder.Entity("RestTest.Models.FlashcardDeck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserAccountId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserAccountId");

                    b.ToTable("FlashcardDecks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 12, 10, 9, 48, 28, 985, DateTimeKind.Utc).AddTicks(636),
                            Description = "This is the first flashcard set",
                            Title = "Flashcard Set 1",
                            UpdatedAt = new DateTime(2024, 12, 10, 9, 48, 28, 985, DateTimeKind.Utc).AddTicks(809),
                            UserAccountId = 1
                        });
                });

            modelBuilder.Entity("RestTest.Models.UserAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserAccounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 12, 10, 9, 48, 28, 984, DateTimeKind.Utc).AddTicks(2635),
                            Email = "cher@gmail.com",
                            FirstName = "Teach",
                            LastName = "Cher",
                            Password = "$2a$11$gmNDL/jS7gca2lzEiL25j.HBKUjS.YT2XBRvhURmGxm8TDZyY.dCK",
                            UpdatedAt = new DateTime(2024, 12, 10, 9, 48, 28, 984, DateTimeKind.Utc).AddTicks(2894),
                            Username = "cher"
                        });
                });

            modelBuilder.Entity("RestTest.Models.Flashcard", b =>
                {
                    b.HasOne("RestTest.Models.FlashcardDeck", "FlashcardDeck")
                        .WithMany("Flashcards")
                        .HasForeignKey("FlashcardDeckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FlashcardDeck");
                });

            modelBuilder.Entity("RestTest.Models.FlashcardChoice", b =>
                {
                    b.HasOne("RestTest.Models.Flashcard", "Flashcard")
                        .WithMany("Choices")
                        .HasForeignKey("FlashcardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flashcard");
                });

            modelBuilder.Entity("RestTest.Models.FlashcardDeck", b =>
                {
                    b.HasOne("RestTest.Models.UserAccount", "UserAccount")
                        .WithMany("FlashcardDecks")
                        .HasForeignKey("UserAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("RestTest.Models.Flashcard", b =>
                {
                    b.Navigation("Choices");
                });

            modelBuilder.Entity("RestTest.Models.FlashcardDeck", b =>
                {
                    b.Navigation("Flashcards");
                });

            modelBuilder.Entity("RestTest.Models.UserAccount", b =>
                {
                    b.Navigation("FlashcardDecks");
                });
#pragma warning restore 612, 618
        }
    }
}
