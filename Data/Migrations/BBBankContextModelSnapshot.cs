﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(BBBankContext))]
    partial class BBBankContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccountStatus")
                        .HasColumnType("int");

                    b.Property<string>("AccountTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CurrentBalance")
                        .HasColumnType("float");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("37846734-172e-4149-8cec-6f43d1eb3f60"),
                            AccountNumber = "0001-1001",
                            AccountStatus = 0,
                            AccountTitle = "Raas Masood",
                            CurrentBalance = 2342.3400000000001,
                            Email = "raasmasood@hotmail.com",
                            PhoneNumber = "6096647000",
                            UserId = new Guid("24ce7f8a-cbeb-4b33-8a3d-952830b92d04")
                        });
                });

            modelBuilder.Entity("Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("24ce7f8a-cbeb-4b33-8a3d-952830b92d04"),
                            AuthID = "7d27b4ad-4405-4da1-b872-4b331e7c1589",
                            Name = "Raas Masood",
                            ProfilePicUrl = "https://www.gravatar.com/avatar/205e460b479e2e5b48aec07710c08d50"
                        });
                });

            modelBuilder.Entity("Data.Entities.Account", b =>
                {
                    b.HasOne("Data.Entities.User", "User")
                        .WithOne("Account")
                        .HasForeignKey("Data.Entities.Account", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
