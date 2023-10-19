using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSO.IdentityServer.Migrations
{
    public partial class AddClaimToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("31ae204b-99ef-477b-8c1e-062d41dd78d9"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("526ab16a-df31-4d09-b026-140626f50d63"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("53ae8c47-3c9f-493c-a874-0ef010cb2bf7"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7e0fd1b2-1c59-46d7-ba72-19fbd077c67b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("913a59a8-56f3-477c-967e-97c9e64aa623"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a04ffdee-7f8f-400d-a778-cf868505ba90"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ab68f6b9-bd6a-43f7-89a7-6b1bf48b5f3a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d70eda36-4573-477c-b534-db5dad015e1a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("df44ea78-baf3-4ea1-bf19-ef266736194b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("e68c22c5-5957-4b14-8bf7-866f601d1b8b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("e8bc0c2f-f57f-475a-8aae-ba35ff958b42"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("eeb0d180-c6d7-45f4-91e9-35b4fb316d29"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("31ae204b-99ef-477b-8c1e-062d41dd78d9"), "7f560f58-882e-425a-90c0-69443a229a47", "client", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "client2" },
                    { new Guid("526ab16a-df31-4d09-b026-140626f50d63"), "aa613731-14ca-4ff4-bfa6-b975df180560", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("53ae8c47-3c9f-493c-a874-0ef010cb2bf7"), "d52d6d94-9cb0-4237-9a78-85aed6585488", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "pk" },
                    { new Guid("7e0fd1b2-1c59-46d7-ba72-19fbd077c67b"), "11311d12-6fc7-4eba-9973-4266f8f93884", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("913a59a8-56f3-477c-967e-97c9e64aa623"), "1866c5b2-2687-4544-ac43-3bdbdf910395", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Yusuf" },
                    { new Guid("a04ffdee-7f8f-400d-a778-cf868505ba90"), "c36059c9-4af9-47f5-8acc-78974707ce03", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Naheem" },
                    { new Guid("ab68f6b9-bd6a-43f7-89a7-6b1bf48b5f3a"), "25757547-5617-4af9-bbd3-14b26ce3bd4b", "client", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "client1" },
                    { new Guid("d70eda36-4573-477c-b534-db5dad015e1a"), "d783cbf1-c6bd-44ce-9f84-6ded61d4e14b", "given_name", new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"), "Muhammad" },
                    { new Guid("df44ea78-baf3-4ea1-bf19-ef266736194b"), "17a75ac9-f07e-4ccc-bf8e-151025e3bbe6", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("e68c22c5-5957-4b14-8bf7-866f601d1b8b"), "1c9ca9ee-e3d0-4ab2-9bd9-a02760ebf902", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("e8bc0c2f-f57f-475a-8aae-ba35ff958b42"), "1c1ce199-e88b-4b7e-afe6-9ab99c3e90fd", "client", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "client1" },
                    { new Guid("eeb0d180-c6d7-45f4-91e9-35b4fb316d29"), "8c7153ec-1e86-4a2c-acdc-c0be3cabedfb", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "5fea5574-56a5-4b9f-841c-f78b63186956");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"),
                column: "ConcurrencyStamp",
                value: "4376b111-f6a5-4e8b-8ef5-fade4118ed55");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "7feebb55-6faf-4e97-8720-5740b3288073");
        }
    }
}
