using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSO.IdentityServer.Migrations
{
    public partial class AddUserLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("09b07d9a-4923-4177-b9ec-4e5f6c930de9"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("2362f050-b336-4fcf-ad04-a72e070d4746"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("3c8bf238-9f3b-45c5-a2a5-453be2967375"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4646e3ca-8c1a-4f11-8dc7-036762e780e3"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("497d39cf-13ea-46e9-88cb-97e5020b4a99"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4e0aac2f-bfdd-4ca1-b424-fd718cee8aff"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("643c56e0-c314-4f00-a42c-fe276ff7f4bc"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("6b5cf8ae-075e-4e3d-a412-98625c64d239"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("8f2bdfbb-404b-4dbd-9549-5e5ec48d1d70"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b5e5613f-3d30-4b07-a378-5e7f24286eb8"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("bc300c84-a19a-4277-999c-0570b7fd271f"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c85627c8-e441-4c81-bea9-d10663a18601"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d8b77d60-ef3a-47dd-987b-1f19732c0e01"));

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

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("064cc784-ec16-4f59-8947-63d142d74f53"), "d7e03c3b-1f10-4d56-b401-c54b63828ba2", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("168d1113-3099-48d5-9922-7080a34cfbe5"), "e880afcd-c709-4c69-8027-547622cc525d", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("273ef8df-9de3-433f-a51c-cc24dffe10c6"), "6bf3d2e5-b955-4daa-9220-e4082e4c2d17", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "pk" },
                    { new Guid("2771aeaa-e4d4-4f3e-992d-c8894618aa77"), "ce71ed37-f99c-4270-ba80-84ae48ae0810", "client", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "clientblazor" },
                    { new Guid("4e02e039-0df9-4ca3-8b43-9d8e347e0601"), "46d77711-fbf9-4aba-bb36-0bb1f43617db", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("551f9d19-c850-463c-9892-ea3577e913af"), "e15d2861-124b-4cec-96cd-cf9f418681cd", "given_name", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "Muhammad" },
                    { new Guid("80f7439d-ccdf-4c1f-b2d3-fcbc7fa76aa3"), "d4c61af9-1ff9-460e-a6ac-70a0768ba13e", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Naheem" },
                    { new Guid("9059fb67-1be8-4e8a-be14-a67a651b3a6a"), "65c7d26a-317a-42b4-b321-82533c224b1f", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("a980f048-4196-49e4-929f-0c157d6bbc06"), "1bf777da-b439-4723-89a2-d50dc8752cba", "client", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "client1" },
                    { new Guid("b64b694e-6fc5-44e2-a403-ef3f2b9bda30"), "c40a1100-59a1-4b2e-94e0-8ebb235235fe", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Yusuf" },
                    { new Guid("bfa799b1-5f9e-459d-a259-3691d2cb5e28"), "7c91e1a3-aeec-4bfd-b5cb-368779d99f24", "client", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "client1" },
                    { new Guid("e379f8e4-1d3f-4d41-91da-b370953464e9"), "d2717f0c-0248-4b73-908a-26f6f0849238", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("f9933c16-737d-40f3-bf59-3515c6475ce1"), "5882fa9a-e8e8-455c-8899-fae1acb37d39", "client", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "client2" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "919181f2-a512-4ad7-b59c-f87a01487c08");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"),
                column: "ConcurrencyStamp",
                value: "a712e1c3-d831-4219-a9b8-0f375baab99a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "4b9fe59b-e739-4f14-86f0-c1ca72c511f5");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("064cc784-ec16-4f59-8947-63d142d74f53"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("168d1113-3099-48d5-9922-7080a34cfbe5"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("273ef8df-9de3-433f-a51c-cc24dffe10c6"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("2771aeaa-e4d4-4f3e-992d-c8894618aa77"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4e02e039-0df9-4ca3-8b43-9d8e347e0601"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("551f9d19-c850-463c-9892-ea3577e913af"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("80f7439d-ccdf-4c1f-b2d3-fcbc7fa76aa3"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9059fb67-1be8-4e8a-be14-a67a651b3a6a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a980f048-4196-49e4-929f-0c157d6bbc06"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b64b694e-6fc5-44e2-a403-ef3f2b9bda30"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("bfa799b1-5f9e-459d-a259-3691d2cb5e28"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("e379f8e4-1d3f-4d41-91da-b370953464e9"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("f9933c16-737d-40f3-bf59-3515c6475ce1"));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("09b07d9a-4923-4177-b9ec-4e5f6c930de9"), "ce5fdc9e-6dda-428c-b28d-540f280f1459", "client", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "client1" },
                    { new Guid("2362f050-b336-4fcf-ad04-a72e070d4746"), "c944dcca-aa44-4125-9675-62bbdc30352a", "given_name", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "Muhammad" },
                    { new Guid("3c8bf238-9f3b-45c5-a2a5-453be2967375"), "423db4f1-3079-407f-bbb0-5813d2621dde", "client", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "client1" },
                    { new Guid("4646e3ca-8c1a-4f11-8dc7-036762e780e3"), "dc1afc38-98fc-4a5b-880e-61e60d9a967e", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("497d39cf-13ea-46e9-88cb-97e5020b4a99"), "146a56e6-afd3-4b1e-ad9b-01dc5adca70a", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Yusuf" },
                    { new Guid("4e0aac2f-bfdd-4ca1-b424-fd718cee8aff"), "fb7ed456-1be2-48e8-85d6-f7dccfe6d67f", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "pk" },
                    { new Guid("643c56e0-c314-4f00-a42c-fe276ff7f4bc"), "32737bff-93c1-4967-81eb-8e25cfbebbdc", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Naheem" },
                    { new Guid("6b5cf8ae-075e-4e3d-a412-98625c64d239"), "2762d254-0506-4cca-8bb3-ac14bb873bea", "client", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "client2" },
                    { new Guid("8f2bdfbb-404b-4dbd-9549-5e5ec48d1d70"), "5cc699ef-f5dc-4a38-a9e4-79638b16fd4b", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("b5e5613f-3d30-4b07-a378-5e7f24286eb8"), "67f592cf-1f81-404c-a177-80893b7e5859", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("bc300c84-a19a-4277-999c-0570b7fd271f"), "c1850d4d-d743-4079-877f-ef07c5eb27e9", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("c85627c8-e441-4c81-bea9-d10663a18601"), "c05a63fd-1721-4d87-98de-a9ff36e20aa5", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("d8b77d60-ef3a-47dd-987b-1f19732c0e01"), "60a6db21-fe29-4db0-9935-0e9b8087d804", "client", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "clientblazor" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "c59bae21-48d8-431c-888f-71f74cc940f3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"),
                column: "ConcurrencyStamp",
                value: "3edaebcc-780d-4015-acb1-1fbe711f3995");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "25121c9b-a6ee-4122-80f6-6a5f5879c1ae");
        }
    }
}
