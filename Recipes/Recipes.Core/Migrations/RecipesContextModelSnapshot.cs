﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recipes.Core;

#nullable disable

namespace Recipes.Core.Migrations
{
    [DbContext(typeof(RecipesContext))]
    partial class RecipesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "2ac81925-adc1-41b0-9c52-86233a00b86e",
                            ConcurrencyStamp = "06558f21-ee7c-4822-ba83-dd07b86daa47",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "8cdc1dd9-d1e2-40fc-b8f2-fda545e898d9",
                            ConcurrencyStamp = "8b35a0b8-d2f0-4231-8629-6448d3f174ff",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "ca82e312-0b5d-4757-baa6-2008c98dc425",
                            ConcurrencyStamp = "ff574481-5556-4344-9c5c-355bc1774903",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "0654538a-7dbe-4275-a59c-12f0350c1acc",
                            RoleId = "2ac81925-adc1-41b0-9c52-86233a00b86e"
                        },
                        new
                        {
                            UserId = "0654538a-7dbe-4275-a59c-12f0350c1acc",
                            RoleId = "8cdc1dd9-d1e2-40fc-b8f2-fda545e898d9"
                        },
                        new
                        {
                            UserId = "0654538a-7dbe-4275-a59c-12f0350c1acc",
                            RoleId = "ca82e312-0b5d-4757-baa6-2008c98dc425"
                        },
                        new
                        {
                            UserId = "a34b55ae-5624-439e-ade8-30098fad3b7a",
                            RoleId = "8cdc1dd9-d1e2-40fc-b8f2-fda545e898d9"
                        },
                        new
                        {
                            UserId = "a34b55ae-5624-439e-ade8-30098fad3b7a",
                            RoleId = "ca82e312-0b5d-4757-baa6-2008c98dc425"
                        },
                        new
                        {
                            UserId = "b5757499-3d34-491a-ade2-aee103d4a29f",
                            RoleId = "ca82e312-0b5d-4757-baa6-2008c98dc425"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Recipes.Core.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NameCategory")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Recipes.Core.InfoDish", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int?>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<string>("CookingTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Difficulty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preparation1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preparation2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preparation3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preparation4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.ToTable("InfoDishes");
                });

            modelBuilder.Entity("Recipes.Core.Save", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("infoDishId")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("infoDishId");

                    b.HasIndex("userId");

                    b.ToTable("Saves");
                });

            modelBuilder.Entity("Recipes.Core.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "0654538a-7dbe-4275-a59c-12f0350c1acc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8b3fd1d7-d76a-45d4-86c8-31b46b8f2749",
                            Email = "admin@recipes.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@RECIPES.COM",
                            NormalizedUserName = "ADMIN@RECIPES.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEO8gT02jcEDVejDdoIjksx6lHyKqgEhb+Bbqv3mtD/GTLaSWyQZWbxhg90BNjUqZzQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "779abf1a-c9c2-443d-8326-751236fd66fa",
                            TwoFactorEnabled = false,
                            UserName = "admin@recipes.com"
                        },
                        new
                        {
                            Id = "a34b55ae-5624-439e-ade8-30098fad3b7a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b14a9521-4fa5-4ce1-a49b-ebdfaaff247c",
                            Email = "manager@recipes.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER@RECIPES.COM",
                            NormalizedUserName = "MANAGER@RECIPES.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPvbZJxggLLOMpZHmUjJlGp43zXyv55YIhQqFlib+c9zv5QezVRUiDGEglY4Ann6Rg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6d06aca9-9106-4048-85f0-ef984906d41a",
                            TwoFactorEnabled = false,
                            UserName = "manager@recipes.com"
                        },
                        new
                        {
                            Id = "b5757499-3d34-491a-ade2-aee103d4a29f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cecc8efa-d44e-4c07-a0fe-dc7a99eb32b8",
                            Email = "user@recipes.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@RECIPES.COM",
                            NormalizedUserName = "USER@RECIPES.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEC1NA8KJSb4flF/qP2kzc5fnkLLVbpDBBUKHJSu90+7f/KerURRKy5IrfcnDPqItBw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "67eba42a-5da7-4638-b65e-b178021bfd9e",
                            TwoFactorEnabled = false,
                            UserName = "user@recipes.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Recipes.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Recipes.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Recipes.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Recipes.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Recipes.Core.InfoDish", b =>
                {
                    b.HasOne("Recipes.Core.Category", "Categories")
                        .WithMany("infoDish")
                        .HasForeignKey("CategoriesId");

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("Recipes.Core.Save", b =>
                {
                    b.HasOne("Recipes.Core.InfoDish", "infoDish")
                        .WithMany()
                        .HasForeignKey("infoDishId");

                    b.HasOne("Recipes.Core.User", "user")
                        .WithMany()
                        .HasForeignKey("userId");

                    b.Navigation("infoDish");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Recipes.Core.Category", b =>
                {
                    b.Navigation("infoDish");
                });
#pragma warning restore 612, 618
        }
    }
}
