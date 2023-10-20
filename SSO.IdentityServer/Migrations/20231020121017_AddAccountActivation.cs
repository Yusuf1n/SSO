using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSO.IdentityServer.Migrations
{
    public partial class AddAccountActivation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("1367569b-390e-428e-a75f-c1ebb95285b4"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("16345d0c-8b63-4486-9cb4-42b8837a8a3d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("23651d20-a20c-42a8-a549-009e1c2ac3a7"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("262a8968-3c48-44b5-babe-c0555fc8170e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("469ca304-e9a1-4a34-93be-8247bbcc88d2"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("47cfa9f1-a170-486c-9ea7-dc506b04284c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("62d2b84e-a0d3-46d5-a22c-1cd0d80ddb0d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("69e2d356-12a6-43a1-9df9-6c8cd5a6596f"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7967dc90-7530-40b4-a163-5af4b8518c0f"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("847a59d1-e6e4-4f1f-9c09-7d976e26cabd"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("8ba3ca5d-00b9-400a-817c-14e41de5e77e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a545e7fb-e19c-4ced-b20f-74e91f6a6b2c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b130cf1d-8a4f-476c-9c08-712fc3c5c372"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                columns: new[] { "ConcurrencyStamp", "Email" },
                values: new object[] { "c59bae21-48d8-431c-888f-71f74cc940f3", "david@someprovider.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"),
                columns: new[] { "ConcurrencyStamp", "Email" },
                values: new object[] { "3edaebcc-780d-4015-acb1-1fbe711f3995", "muhammad@someprovider.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "Email" },
                values: new object[] { "25121c9b-a6ee-4122-80f6-6a5f5879c1ae", "yusufnaheem1@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("1367569b-390e-428e-a75f-c1ebb95285b4"), "1bce4889-0c15-43e0-9ed8-a28195db0eb8", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("16345d0c-8b63-4486-9cb4-42b8837a8a3d"), "39f10d13-8c99-4699-9183-f8e22252af71", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "pk" },
                    { new Guid("23651d20-a20c-42a8-a549-009e1c2ac3a7"), "8f367ee3-fb83-41af-9c95-7b5ff376cfce", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("262a8968-3c48-44b5-babe-c0555fc8170e"), "b1adf250-ced3-4f15-b0c7-f632ea964050", "client", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "client1" },
                    { new Guid("469ca304-e9a1-4a34-93be-8247bbcc88d2"), "94fec055-d555-46e1-86f3-61ee0594a024", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("47cfa9f1-a170-486c-9ea7-dc506b04284c"), "09e3b45d-9a64-4dd6-a4d9-a7db2582a72a", "client", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "client2" },
                    { new Guid("62d2b84e-a0d3-46d5-a22c-1cd0d80ddb0d"), "7c7e3f7b-5d79-414b-8a4d-e6d27523fb7d", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("69e2d356-12a6-43a1-9df9-6c8cd5a6596f"), "999096d7-4f32-471b-8941-03472b78dc7d", "given_name", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "Muhammad" },
                    { new Guid("7967dc90-7530-40b4-a163-5af4b8518c0f"), "bdb6df9f-f4e5-46ff-a20d-3671358f9cf4", "client", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "clientblazor" },
                    { new Guid("847a59d1-e6e4-4f1f-9c09-7d976e26cabd"), "085ea63d-0e0f-4bac-91bf-04167bd5216a", "client", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "client1" },
                    { new Guid("8ba3ca5d-00b9-400a-817c-14e41de5e77e"), "b6b6c1ad-164f-4d29-8168-127938fe9d87", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Naheem" },
                    { new Guid("a545e7fb-e19c-4ced-b20f-74e91f6a6b2c"), "e16fa0b7-bbd7-4f7e-9baa-7b518cbaf70a", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Yusuf" },
                    { new Guid("b130cf1d-8a4f-476c-9c08-712fc3c5c372"), "8167902f-733e-41bf-9911-1bc2f0a9983a", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "60bb9522-f7a5-46db-af08-ce66e013a217");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"),
                column: "ConcurrencyStamp",
                value: "48c24717-69be-4a3a-9253-e8989af2854b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "6bc4f59b-0c92-4049-a827-dd2de7b9ca35");
        }
    }
}
