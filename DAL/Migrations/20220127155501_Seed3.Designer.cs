﻿// <auto-generated />
using System;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(EconomiqContext))]
    [Migration("20220127155501_Seed3")]
    partial class Seed3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL.Models.Email", b =>
                {
                    b.Property<int>("UserNavId")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserNavId", "Mail");

                    b.ToTable("Email");

                    b.HasData(
                        new
                        {
                            UserNavId = 1,
                            Mail = "JuliaH@test.com"
                        },
                        new
                        {
                            UserNavId = 2,
                            Mail = "AlexV@test.com"
                        },
                        new
                        {
                            UserNavId = 3,
                            Mail = "Peppo@test.com"
                        },
                        new
                        {
                            UserNavId = 4,
                            Mail = "WinnieH@test.com"
                        },
                        new
                        {
                            UserNavId = 5,
                            Mail = "Ericx@test.com"
                        },
                        new
                        {
                            UserNavId = 6,
                            Mail = "AndersB@test.com"
                        },
                        new
                        {
                            UserNavId = 7,
                            Mail = "PeterH@test.com"
                        });
                });

            modelBuilder.Entity("DAL.Models.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<int?>("CategoryNavId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpenseDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RecipientId")
                        .HasColumnType("int");

                    b.Property<int>("UserNavId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryNavId");

                    b.HasIndex("RecipientId");

                    b.HasIndex("UserNavId");

                    b.ToTable("Expenses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 25f,
                            CategoryNavId = 1,
                            Comment = "Glass",
                            ExpenseDate = new DateTime(2022, 1, 27, 16, 55, 1, 430, DateTimeKind.Local).AddTicks(4132),
                            UserNavId = 1
                        });
                });

            modelBuilder.Entity("DAL.Models.ExpenseCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserNavId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserNavId");

                    b.ToTable("ExpensesCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Snacks",
                            CreationDate = new DateTime(2022, 1, 27, 16, 55, 1, 430, DateTimeKind.Local).AddTicks(4116),
                            UserNavId = 1
                        });
                });

            modelBuilder.Entity("DAL.Models.Recipient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Recipients");
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2022, 1, 27, 16, 55, 1, 430, DateTimeKind.Local).AddTicks(3903),
                            Fname = "Julia",
                            Lname = "Hook",
                            Password = "Testing123",
                            UserName = "JuliaH"
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2022, 1, 27, 16, 55, 1, 430, DateTimeKind.Local).AddTicks(3948),
                            Fname = "Alexander",
                            Lname = "Volonen",
                            Password = "Testing234",
                            UserName = "AlexV"
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2022, 1, 27, 16, 55, 1, 430, DateTimeKind.Local).AddTicks(3950),
                            Fname = "Stefan",
                            Lname = "Krakowsky",
                            Password = "Testing345",
                            UserName = "Peppo"
                        },
                        new
                        {
                            Id = 4,
                            CreationDate = new DateTime(2022, 1, 27, 16, 55, 1, 430, DateTimeKind.Local).AddTicks(3953),
                            Fname = "Winnie",
                            Lname = "Huynh",
                            Password = "Testing456",
                            UserName = "WinnieH"
                        },
                        new
                        {
                            Id = 5,
                            CreationDate = new DateTime(2022, 1, 27, 16, 55, 1, 430, DateTimeKind.Local).AddTicks(3955),
                            Fname = "Eric",
                            Lname = "Flodin",
                            Password = "Testing567",
                            UserName = "Ericx"
                        },
                        new
                        {
                            Id = 6,
                            CreationDate = new DateTime(2022, 1, 27, 16, 55, 1, 430, DateTimeKind.Local).AddTicks(3958),
                            Fname = "Anders",
                            Lname = "Bergstrom",
                            Password = "Testing678",
                            UserName = "AndersB"
                        },
                        new
                        {
                            Id = 7,
                            CreationDate = new DateTime(2022, 1, 27, 16, 55, 1, 430, DateTimeKind.Local).AddTicks(3960),
                            Fname = "Peter",
                            Lname = "Hafid",
                            Password = "Testing789",
                            UserName = "PeterH"
                        });
                });

            modelBuilder.Entity("DAL.Models.Email", b =>
                {
                    b.HasOne("DAL.Models.User", "UserNav")
                        .WithMany("Emails")
                        .HasForeignKey("UserNavId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserNav");
                });

            modelBuilder.Entity("DAL.Models.Expense", b =>
                {
                    b.HasOne("DAL.Models.ExpenseCategory", "CategoryNav")
                        .WithMany("ExpensesNav")
                        .HasForeignKey("CategoryNavId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("DAL.Models.Recipient", "Recipient")
                        .WithMany()
                        .HasForeignKey("RecipientId");

                    b.HasOne("DAL.Models.User", "UserNav")
                        .WithMany("UserExpensesNav")
                        .HasForeignKey("UserNavId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CategoryNav");

                    b.Navigation("Recipient");

                    b.Navigation("UserNav");
                });

            modelBuilder.Entity("DAL.Models.ExpenseCategory", b =>
                {
                    b.HasOne("DAL.Models.User", "UserNav")
                        .WithMany("ExpensesCategoryNav")
                        .HasForeignKey("UserNavId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("UserNav");
                });

            modelBuilder.Entity("DAL.Models.ExpenseCategory", b =>
                {
                    b.Navigation("ExpensesNav");
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Navigation("Emails");

                    b.Navigation("ExpensesCategoryNav");

                    b.Navigation("UserExpensesNav");
                });
#pragma warning restore 612, 618
        }
    }
}
