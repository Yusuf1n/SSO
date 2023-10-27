using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSO.IdentityServer.Migrations
{
    public partial class AddUserSecret : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("08206a33-b49f-431b-b7b9-748c076f93cc"), "d90fa55b-7cc9-484c-af66-772fb8e6d128", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("16bef855-dcb1-45c7-8793-41bb60a0cba9"), "a593a810-9ee7-40dd-9814-a57ebc8d69b3", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Yusuf" },
                    { new Guid("43ea4f19-47c1-43ad-905a-cb4177d6f399"), "a25b5497-d277-44a8-a365-9446f865195b", "client", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "client1" },
                    { new Guid("60fb0021-aca5-45b6-b9b2-00d00aba4b45"), "0e1a910a-1633-450f-8e05-53a786376fd9", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Naheem" },
                    { new Guid("67e76600-a996-4f92-aca0-2bffe674f70b"), "c11f480f-f96e-4c44-a34b-fc90c15dcaba", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "pk" },
                    { new Guid("90f2f76c-af7b-4720-a84c-d74f8deb25be"), "78e4b9f0-29d9-417e-ad58-b6a7e00b1e9d", "given_name", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "Muhammad" },
                    { new Guid("9d66a053-6d5f-498a-9cc4-0828528328a2"), "9280c25e-4df7-4811-b7f5-ec2d36bdcd67", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("9dabd42e-0e0a-4806-8148-25e071000d0b"), "e426513c-194c-4a6e-98bc-c8347394df22", "client", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "clientblazor" },
                    { new Guid("af6544ed-8689-4b9b-8639-92a8a594e395"), "668174d8-a6f8-4277-8a6f-d1869f4cf6df", "client", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "client1" },
                    { new Guid("befc836b-6df8-47ad-8450-646ba84231f8"), "7baaf7d6-841d-45c8-b52f-cf0a7b6a6ca3", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("c46b78ff-423e-4a8c-8ab9-95d748e38801"), "15f18f3a-0036-42b0-9ed4-a8d7950ddb8a", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("d879fb53-43b5-4dae-90c7-d43df7c0ec9a"), "f4d466f9-4b74-470d-a668-b55700af14de", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("e2119228-58ab-4ddf-8b96-540a137dab21"), "a86b20c6-43bc-4cfa-b161-d5691bc48798", "client", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "client2" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "7eb14b3e-e31b-494b-b43f-89fa2bc9a6be");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"),
                column: "ConcurrencyStamp",
                value: "0620d475-51bb-4f9e-8379-1aa61aca03e9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "5e004f45-048c-4b27-aa7f-6ba881586325");

            migrationBuilder.CreateIndex(
                name: "IX_UserSecrets_UserId",
                table: "UserSecrets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSecrets");

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("08206a33-b49f-431b-b7b9-748c076f93cc"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("16bef855-dcb1-45c7-8793-41bb60a0cba9"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("43ea4f19-47c1-43ad-905a-cb4177d6f399"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("60fb0021-aca5-45b6-b9b2-00d00aba4b45"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("67e76600-a996-4f92-aca0-2bffe674f70b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("90f2f76c-af7b-4720-a84c-d74f8deb25be"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9d66a053-6d5f-498a-9cc4-0828528328a2"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9dabd42e-0e0a-4806-8148-25e071000d0b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("af6544ed-8689-4b9b-8639-92a8a594e395"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("befc836b-6df8-47ad-8450-646ba84231f8"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c46b78ff-423e-4a8c-8ab9-95d748e38801"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d879fb53-43b5-4dae-90c7-d43df7c0ec9a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("e2119228-58ab-4ddf-8b96-540a137dab21"));

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
        }
    }
}
