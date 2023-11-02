using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSO.IdentityServer.Migrations
{
    public partial class InitialUserDataMigration : Migration
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
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SecurityCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SecurityCodeExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Provider = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProviderIdentityKey = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSecrets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Secret = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSecrets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSecrets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "ConcurrencyStamp", "Email", "Password", "SecurityCode", "SecurityCodeExpirationDate", "Subject", "UserName" },
                values: new object[] { new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), true, "9a169b93-cc34-4c66-9fe0-8847bc9ad6fa", "david@someprovider.com", "AQAAAAEAACcQAAAAEIi0HEeTvqcxwhA+dR/RKOEIfdGn1VIKy0P+AhKOp5vIdsb80zmPxqbhxllt5AmkKg==", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d860efca-22d9-47fd-8249-791ba61b07c7", "David" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "ConcurrencyStamp", "Email", "Password", "SecurityCode", "SecurityCodeExpirationDate", "Subject", "UserName" },
                values: new object[] { new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), true, "560bf87d-ec16-4ef3-93f7-47ec25f4f672", "muhammad@someprovider.com", "AQAAAAEAACcQAAAAEHgXILmaP4pu/Kz8M2cASmfD/XsHykcmTNyFTvQQiwyWaLWjWAlxBH1L5pQfSyRYqw==", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e7ea84c8-b140-4e56-85a8-b0df8b4b4fc6", "Muhammad" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "ConcurrencyStamp", "Email", "Password", "SecurityCode", "SecurityCodeExpirationDate", "Subject", "UserName" },
                values: new object[] { new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), true, "94ed9d30-d4ad-446d-92a2-a5c1e73820a0", "yusufnaheem1@gmail.com", "AQAAAAEAACcQAAAAEHgXILmaP4pu/Kz8M2cASmfD/XsHykcmTNyFTvQQiwyWaLWjWAlxBH1L5pQfSyRYqw==", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b7539694-97e7-4dfe-84da-b4256e1ff5c7", "Yusuf" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("00885495-fe83-4c2b-af3b-26d241f77d64"), "ba249950-8d8b-4bc6-8456-8797fcb2d5f1", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Yusuf" },
                    { new Guid("3bcded89-a90b-46da-9c3f-bc1c69d88df0"), "30f6e2f9-e84f-4874-b886-fa1abdbbeedd", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("3cbf75c7-2924-42ca-99c0-e13dd1355c70"), "d88f3d24-9960-43e2-9063-de493f9ea1a1", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("7bbad84b-126a-4dfb-9688-3cc9914124b9"), "e8a2a3ed-00f2-4b9f-bf27-9d83c252d626", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "pk" },
                    { new Guid("a5e7a7e3-587f-4b7a-8c62-07f8ab00daaa"), "131eefaf-0c3f-4ccf-97bc-b0ab714f95d5", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("a6bd4a07-aaab-4984-bb36-c1c9efbc19a4"), "99c997b5-9a5f-4463-9014-e60d8adf9ecf", "client", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "client2" },
                    { new Guid("bb9fafc9-c52c-4b6e-b52c-c0fc492bcb98"), "4108040b-533c-466e-b27e-b0c9e64a2784", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("bf8aca1c-d054-4be3-82e4-cfed04c1322c"), "ac020ffc-d3ba-4031-b1c4-687226f7febc", "client", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "client1" },
                    { new Guid("c54c9d41-8312-4c32-be4e-09d35d178743"), "96bf8a58-8121-4ee6-b1db-c3dd6c907ff7", "client", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "client1" },
                    { new Guid("c995139d-c44d-4c2c-a7e8-f5e994c3250c"), "83a74057-af50-438f-9f6c-d3739af72037", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Naheem" },
                    { new Guid("d66ba438-48de-452b-8c44-4917c93276e6"), "3b6f1e25-06b9-4ad9-84f4-80c689447939", "client", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "clientblazor" },
                    { new Guid("dd9aaa1f-aca5-459c-9a5f-6b58ed7166ba"), "49660e4e-1587-4cb9-b0b9-162af47ecfae", "given_name", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "Muhammad" },
                    { new Guid("f0a6b357-8fdf-41b6-b9bc-ae468308647e"), "c399a656-1557-4bf6-8673-5eb94c4d5bbb", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
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

            migrationBuilder.CreateIndex(
                name: "IX_UserSecrets_UserId",
                table: "UserSecrets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserSecrets");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
