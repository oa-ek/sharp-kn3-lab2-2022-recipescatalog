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
                            Id = "cb76ba20-b170-412c-86d5-ef8c7a634561",
                            ConcurrencyStamp = "32538c27-a9b0-429a-800f-1f5366a69197",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "4b343352-1023-4d36-b925-795d7ec11953",
                            ConcurrencyStamp = "6672a5c5-9b7d-4374-8dc5-21fbdc831ea6",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "64c1bc41-d7f8-4c02-b66a-755bd8e8467a",
                            ConcurrencyStamp = "49297e4b-db09-4099-a9b8-f9b0514e18bd",
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
                            UserId = "f3b1723d-398c-459b-bcae-ceb4269efb68",
                            RoleId = "cb76ba20-b170-412c-86d5-ef8c7a634561"
                        },
                        new
                        {
                            UserId = "f3b1723d-398c-459b-bcae-ceb4269efb68",
                            RoleId = "4b343352-1023-4d36-b925-795d7ec11953"
                        },
                        new
                        {
                            UserId = "f3b1723d-398c-459b-bcae-ceb4269efb68",
                            RoleId = "64c1bc41-d7f8-4c02-b66a-755bd8e8467a"
                        },
                        new
                        {
                            UserId = "d9339d58-456e-4348-b3ea-8f1e012b0a5d",
                            RoleId = "4b343352-1023-4d36-b925-795d7ec11953"
                        },
                        new
                        {
                            UserId = "d9339d58-456e-4348-b3ea-8f1e012b0a5d",
                            RoleId = "64c1bc41-d7f8-4c02-b66a-755bd8e8467a"
                        },
                        new
                        {
                            UserId = "7355ae1f-f738-4922-87af-c0d031617a84",
                            RoleId = "64c1bc41-d7f8-4c02-b66a-755bd8e8467a"
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

                    b.Property<string>("Ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preparation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TagsId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("TagsId");

                    b.ToTable("InfoDishes");
                });

            modelBuilder.Entity("Recipes.Core.InfoDishTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Recipes.Core.Save", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("infoDishId")
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
                            Id = "f3b1723d-398c-459b-bcae-ceb4269efb68",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "da1148e5-a466-4bc9-83bd-9ea40501d105",
                            Email = "admin@recipes.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@RECIPES.COM",
                            NormalizedUserName = "ADMIN@RECIPES.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEvIL39BqX8ulGHdddDI7ZGpv5TH7aVIvq5jL3gHep25HRMezo2PrGk6dWZrhv0t3A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bffdaba5-60c4-4ea1-944f-713eed2ac72b",
                            TwoFactorEnabled = false,
                            UserName = "admin@recipes.com"
                        },
                        new
                        {
                            Id = "d9339d58-456e-4348-b3ea-8f1e012b0a5d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "345c96d0-76ae-4f48-be57-e358bb51b8f3",
                            Email = "manager@recipes.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER@RECIPES.COM",
                            NormalizedUserName = "MANAGER@RECIPES.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKizbjtOoFYcx2t9/Yqu1RZ6WBI1IdEEEjImkjW6ht6c1esmvinkLg+mYtcygW+NeQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0480f694-5872-466a-8150-c570bd9bfe17",
                            TwoFactorEnabled = false,
                            UserName = "manager@recipes.com"
                        },
                        new
                        {
                            Id = "7355ae1f-f738-4922-87af-c0d031617a84",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d6871870-f8b6-4143-8c73-579e3995f511",
                            Email = "user@recipes.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@RECIPES.COM",
                            NormalizedUserName = "USER@RECIPES.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEH47IyOcAhkV2OMC1+WdRGbhFAEZmDd5sF6V2DTA5cRKcgi929R8GD4AFSguN9AAzA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "25e2fd6a-c5c2-43e4-ab20-3c6eda557d28",
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

                    b.HasOne("Recipes.Core.InfoDishTag", "Tags")
                        .WithMany("infoDish")
                        .HasForeignKey("TagsId");

                    b.Navigation("Categories");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("Recipes.Core.Save", b =>
                {
                    b.HasOne("Recipes.Core.InfoDish", "infoDish")
                        .WithMany()
                        .HasForeignKey("infoDishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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

            modelBuilder.Entity("Recipes.Core.InfoDishTag", b =>
                {
                    b.Navigation("infoDish");
                });
#pragma warning restore 612, 618
        }
    }
}
