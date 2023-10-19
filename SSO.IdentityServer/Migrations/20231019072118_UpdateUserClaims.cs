using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSO.IdentityServer.Migrations
{
    public partial class UpdateUserClaims : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("17aedc9c-a4d9-4479-aaea-6447d2bd08c7"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("3a4b652d-b38c-4ca6-8e9a-eca757ab1b2d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("419954c1-b6dd-408b-a560-dd13bb4bc495"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("5c6aa399-d0f3-4713-ab9b-ef978cf3a069"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("6cae2191-4d3b-4fde-84ba-28447dda1ac4"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("77b81cb9-c86a-44d5-b39a-5b31f5aae240"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7a3a2b22-9796-4c29-bbc1-88a5e1092275"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b578a6a9-dbeb-4630-ac64-f8cece69ee87"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("cc4f7af0-42f5-46cf-96bd-bb224afaf90d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ccc45599-02fd-4d16-af1c-4382368eb721"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d092429e-62e5-4c4d-a240-5c88bc30ae42"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("e7a61660-5c92-4f98-ae2e-1a96ec457c02"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "e2212708-7004-4259-ab1f-3e5cd79f2950");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"),
                column: "ConcurrencyStamp",
                value: "583b91d9-60b5-4895-b6f0-14361025134b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "a3eb8de0-6c0a-4e43-93b2-d05d1bb30ebc");
        }
    }
}
