using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recipes.Core.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCategory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InfoDishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Difficulty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CookingTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preparation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TagsId = table.Column<int>(type: "int", nullable: true),
                    CategoriesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoDishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfoDishes_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InfoDishes_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
<<<<<<< Updated upstream:Recipes/Recipes.Core/Migrations/20221112115320_init1.cs
                    { "03806760-b913-402f-81fa-8e2e1cb9f2b2", "9bdd5573-49bd-4e2e-8f7d-96468835ad28", "Admin", "ADMIN" },
                    { "4a4dfafd-57d1-4169-a238-b017f4e8a81a", "c8530f43-4c71-409b-9dda-4e15cd489645", "User", "USER" },
                    { "a97639bb-fbdd-46b4-ab20-5cc170c39bc6", "dd4c36de-0e9c-4856-a8a5-ac9b647bb79e", "Manager", "MANAGER" }
=======
                    { "0cd6284e-47fb-4d76-ba0b-587ff7091d4b", "7a77ad23-6209-4b6f-beee-d2b96343a210", "Manager", "MANAGER" },
                    { "5ee88ac3-2a1f-4f9f-b58b-2a51793d479c", "c5cf8cf7-88c8-4acd-bbd8-ac0b69341155", "User", "USER" },
                    { "dfc014e7-9f2d-4d8f-8320-4036afe25bfa", "f3ae5392-7011-4257-b3a9-70ec3ba8eb4a", "Admin", "ADMIN" }
>>>>>>> Stashed changes:Recipes/Recipes.Core/Migrations/20221112162934_init1.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<< Updated upstream:Recipes/Recipes.Core/Migrations/20221112115320_init1.cs
                    { "19e03eb0-dd08-4447-b305-917572b6554f", 0, "9ac99429-e049-4782-869b-5ca35e558037", "manager@recipes.com", true, null, null, false, null, "MANAGER@RECIPES.COM", "MANAGER@RECIPES.COM", "AQAAAAEAACcQAAAAECRFlppYOesWnjNO1CSx8cOeH9qJKrOamI7pT11MNHkxga5Mmj50fRtbtMMNFHSLcA==", null, false, "eb4d2d28-2cec-45a2-acb8-44056d17b959", false, "manager@recipes.com" },
                    { "8bd7d40c-1aa7-4288-81ee-2686511fc442", 0, "6707cc11-068d-424f-afc8-34ce0f413e16", "user@recipes.com", true, null, null, false, null, "USER@RECIPES.COM", "USER@RECIPES.COM", "AQAAAAEAACcQAAAAEKbH0yjocI/FkZ0dI3Vxv0ynp+RlvXTUi9e9gxL65rg1YDMmHlvVbtmevkGV/QQ2yQ==", null, false, "7b90e305-bbb5-4487-b3d6-f8266b82041d", false, "user@recipes.com" },
                    { "ca3f9430-8795-45b5-88eb-216c2fcd063e", 0, "899d2673-cd75-45b6-9715-87055b43de6f", "admin@recipes.com", true, null, null, false, null, "ADMIN@RECIPES.COM", "ADMIN@RECIPES.COM", "AQAAAAEAACcQAAAAEPcRQYb7dKQbBgeJkKOdWC5ZAW/TkJQMFlucb2bFmM968FtXcHDpFRloJyRYDhuDRQ==", null, false, "aceb4754-1310-45ed-b065-cada52c559a9", false, "admin@recipes.com" }
=======
                    { "08170544-0f90-48f8-91de-4b2d060c11fd", 0, "cf4f59f4-fecf-4dea-81f4-6077dabbfafe", "user@recipes.com", true, null, null, false, null, "USER@RECIPES.COM", "USER@RECIPES.COM", "AQAAAAEAACcQAAAAEKHUCu+WyoNDMh/zmbsNADoJlRaBhzgwrvT201h/RGRi6HSN4g5MkjMEOQKh6RJnPg==", null, false, "8770d008-e7a2-4859-b2d2-86c6433c824c", false, "user@recipes.com" },
                    { "568da135-a8a5-4687-bda9-c89f039fdb84", 0, "8b975300-4f59-4e83-9415-d77ac4fda27a", "manager@recipes.com", true, null, null, false, null, "MANAGER@RECIPES.COM", "MANAGER@RECIPES.COM", "AQAAAAEAACcQAAAAEPn8EcvMI8F0QcA2C+Si36B/i2t5ZLbjTfvNZiGIJPDFj3XxPpqRHqwAca+qs9USPg==", null, false, "993c76e9-7af1-4752-88ef-bc355e11e084", false, "manager@recipes.com" },
                    { "864624f5-a887-43f8-9e09-8ad194effef7", 0, "0ddaeb41-9669-4d77-8327-a82fe98fe6f3", "admin@recipes.com", true, null, null, false, null, "ADMIN@RECIPES.COM", "ADMIN@RECIPES.COM", "AQAAAAEAACcQAAAAEBySkYgV/itwdCghsHRqCjBS2kGpgEiciQPaTBLZhcgUjcfBALI4jZCiFsgMwBp8kQ==", null, false, "c689fdf9-8fc5-44d7-9c45-d86b33277907", false, "admin@recipes.com" }
>>>>>>> Stashed changes:Recipes/Recipes.Core/Migrations/20221112162934_init1.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
<<<<<<< Updated upstream:Recipes/Recipes.Core/Migrations/20221112115320_init1.cs
                    { "4a4dfafd-57d1-4169-a238-b017f4e8a81a", "19e03eb0-dd08-4447-b305-917572b6554f" },
                    { "a97639bb-fbdd-46b4-ab20-5cc170c39bc6", "19e03eb0-dd08-4447-b305-917572b6554f" },
                    { "4a4dfafd-57d1-4169-a238-b017f4e8a81a", "8bd7d40c-1aa7-4288-81ee-2686511fc442" },
                    { "03806760-b913-402f-81fa-8e2e1cb9f2b2", "ca3f9430-8795-45b5-88eb-216c2fcd063e" },
                    { "4a4dfafd-57d1-4169-a238-b017f4e8a81a", "ca3f9430-8795-45b5-88eb-216c2fcd063e" },
                    { "a97639bb-fbdd-46b4-ab20-5cc170c39bc6", "ca3f9430-8795-45b5-88eb-216c2fcd063e" }
=======
                    { "5ee88ac3-2a1f-4f9f-b58b-2a51793d479c", "08170544-0f90-48f8-91de-4b2d060c11fd" },
                    { "0cd6284e-47fb-4d76-ba0b-587ff7091d4b", "568da135-a8a5-4687-bda9-c89f039fdb84" },
                    { "5ee88ac3-2a1f-4f9f-b58b-2a51793d479c", "568da135-a8a5-4687-bda9-c89f039fdb84" },
                    { "0cd6284e-47fb-4d76-ba0b-587ff7091d4b", "864624f5-a887-43f8-9e09-8ad194effef7" },
                    { "5ee88ac3-2a1f-4f9f-b58b-2a51793d479c", "864624f5-a887-43f8-9e09-8ad194effef7" },
                    { "dfc014e7-9f2d-4d8f-8320-4036afe25bfa", "864624f5-a887-43f8-9e09-8ad194effef7" }
>>>>>>> Stashed changes:Recipes/Recipes.Core/Migrations/20221112162934_init1.cs
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_InfoDishes_CategoriesId",
                table: "InfoDishes",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_InfoDishes_TagsId",
                table: "InfoDishes",
                column: "TagsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "InfoDishes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
