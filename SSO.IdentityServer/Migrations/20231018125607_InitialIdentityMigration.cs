using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSO.IdentityServer.Migrations
{
    public partial class InitialIdentityMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "ConcurrencyStamp", "Password", "Subject", "UserName" },
                values: new object[] { new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), true, "e2212708-7004-4259-ab1f-3e5cd79f2950", "AQAAAAEAACcQAAAAEIi0HEeTvqcxwhA+dR/RKOEIfdGn1VIKy0P+AhKOp5vIdsb80zmPxqbhxllt5AmkKg==", "d860efca-22d9-47fd-8249-791ba61b07c7", "David" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "ConcurrencyStamp", "Password", "Subject", "UserName" },
                values: new object[] { new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), true, "583b91d9-60b5-4895-b6f0-14361025134b", "AQAAAAEAACcQAAAAEHgXILmaP4pu/Kz8M2cASmfD/XsHykcmTNyFTvQQiwyWaLWjWAlxBH1L5pQfSyRYqw==", "e7ea84c8-b140-4e56-85a8-b0df8b4b4fc6", "Muhammad" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "ConcurrencyStamp", "Password", "Subject", "UserName" },
                values: new object[] { new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), true, "a3eb8de0-6c0a-4e43-93b2-d05d1bb30ebc", "AQAAAAEAACcQAAAAEHgXILmaP4pu/Kz8M2cASmfD/XsHykcmTNyFTvQQiwyWaLWjWAlxBH1L5pQfSyRYqw==", "b7539694-97e7-4dfe-84da-b4256e1ff5c7", "Yusuf" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("17aedc9c-a4d9-4479-aaea-6447d2bd08c7"), "cf395f8f-6824-42f9-a918-b0a9d5271c8d", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("3a4b652d-b38c-4ca6-8e9a-eca757ab1b2d"), "81a142a7-2949-4e73-95f8-e951eb2582ef", "client", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "client2" },
                    { new Guid("419954c1-b6dd-408b-a560-dd13bb4bc495"), "031ef9ff-8d44-4df4-814b-2c6036c51eb1", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("5c6aa399-d0f3-4713-ab9b-ef978cf3a069"), "e38fc9bb-88bf-4482-8c7b-5d719ef30885", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "pk" },
                    { new Guid("6cae2191-4d3b-4fde-84ba-28447dda1ac4"), "7d3e9d45-195c-40da-ace7-659498517e8d", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Yusuf" },
                    { new Guid("77b81cb9-c86a-44d5-b39a-5b31f5aae240"), "77ec475c-7b90-4bf6-9539-be11b5c18c5e", "given_name", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "Muhammad" },
                    { new Guid("7a3a2b22-9796-4c29-bbc1-88a5e1092275"), "261bdfc6-1f20-443b-a7f8-5ebd0e1b3fba", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Naheem" },
                    { new Guid("b578a6a9-dbeb-4630-ac64-f8cece69ee87"), "175e81f8-8695-4e4a-bb3c-f53756befd6a", "client", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "client1" },
                    { new Guid("cc4f7af0-42f5-46cf-96bd-bb224afaf90d"), "ef469599-369e-4aa3-9a8d-4445fb0378fc", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("ccc45599-02fd-4d16-af1c-4382368eb721"), "59f1e010-5d85-41a0-b48e-e1bc407deafd", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("d092429e-62e5-4c4d-a240-5c88bc30ae42"), "f83ddcda-7eaf-43a1-a8a0-b4a6a086854a", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("e7a61660-5c92-4f98-ae2e-1a96ec457c02"), "a92f8c25-bbea-485d-a88c-99bc78e8ac01", "client", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "client1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Subject",
                table: "Users",
                column: "Subject",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
