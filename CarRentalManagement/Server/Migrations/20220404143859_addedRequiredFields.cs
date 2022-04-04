using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class addedRequiredFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "be357aa7-37cb-4949-88a5-4fb72041fbba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "d49e716b-60ba-43ed-8373-472e9a8c1039");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ad3f2a3-67d1-44be-9e4b-8b5215bf9b97", "AQAAAAEAACcQAAAAEEeevb8gF0u78WTUqwcKC18/j/eMaCPwTwhzviKL1QrS5qAjh+CLEMAcjMdN94c4ug==", "80ebc511-5f3d-48d3-9db0-c6c8ba055649" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "758f0aa8-61f8-4143-8463-c9713884a369", "AQAAAAEAACcQAAAAEI/x1zTAaHe28lAwhC03U3X/UuOgFDfvmiuRkKt7z1W1dO9SjM2lAO1+YUwL2wv4Rg==", "fa45edc2-3cce-495f-884d-34d84755951c" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 4, 15, 38, 58, 285, DateTimeKind.Local).AddTicks(8624), new DateTime(2022, 4, 4, 15, 38, 58, 289, DateTimeKind.Local).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 4, 15, 38, 58, 289, DateTimeKind.Local).AddTicks(7582), new DateTime(2022, 4, 4, 15, 38, 58, 289, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 4, 15, 38, 58, 291, DateTimeKind.Local).AddTicks(6347), new DateTime(2022, 4, 4, 15, 38, 58, 291, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 4, 15, 38, 58, 291, DateTimeKind.Local).AddTicks(7217), new DateTime(2022, 4, 4, 15, 38, 58, 291, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 4, 15, 38, 58, 292, DateTimeKind.Local).AddTicks(4273), new DateTime(2022, 4, 4, 15, 38, 58, 292, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 4, 15, 38, 58, 292, DateTimeKind.Local).AddTicks(4385), new DateTime(2022, 4, 4, 15, 38, 58, 292, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 4, 15, 38, 58, 292, DateTimeKind.Local).AddTicks(4397), new DateTime(2022, 4, 4, 15, 38, 58, 292, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 4, 15, 38, 58, 292, DateTimeKind.Local).AddTicks(4409), new DateTime(2022, 4, 4, 15, 38, 58, 292, DateTimeKind.Local).AddTicks(4414) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "cbd8e888-3c3c-4b1a-888f-750191e4bc06");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "18496c27-ff53-4b52-b34c-38cbfc015b8f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dae19c8b-5af7-4a0e-b6fb-babc3fa93203", "AQAAAAEAACcQAAAAEAbugCovN22TvYk9xJFF6uKfUjw91PIcVU8kel67d62SWQ9yD7olPdnid57nbRoEcw==", "02f216a5-2809-440b-bcbd-b14d50bc9ed5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2620016-0416-4328-b8ca-b7e0ad11e156", "AQAAAAEAACcQAAAAEGaglNPDASn7cnwkof0EHISHwOJOt845lbss1iAFkgN2PY/WHorIOYm88uHsKFiNFg==", "026a341e-850e-46a6-bf11-8c4c13aced6d" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 58, 51, 249, DateTimeKind.Local).AddTicks(839), new DateTime(2022, 4, 1, 14, 58, 51, 251, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 58, 51, 251, DateTimeKind.Local).AddTicks(5767), new DateTime(2022, 4, 1, 14, 58, 51, 251, DateTimeKind.Local).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 58, 51, 253, DateTimeKind.Local).AddTicks(378), new DateTime(2022, 4, 1, 14, 58, 51, 253, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 58, 51, 253, DateTimeKind.Local).AddTicks(723), new DateTime(2022, 4, 1, 14, 58, 51, 253, DateTimeKind.Local).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 58, 51, 253, DateTimeKind.Local).AddTicks(3859), new DateTime(2022, 4, 1, 14, 58, 51, 253, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 58, 51, 253, DateTimeKind.Local).AddTicks(3878), new DateTime(2022, 4, 1, 14, 58, 51, 253, DateTimeKind.Local).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 58, 51, 253, DateTimeKind.Local).AddTicks(3885), new DateTime(2022, 4, 1, 14, 58, 51, 253, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 58, 51, 253, DateTimeKind.Local).AddTicks(3892), new DateTime(2022, 4, 1, 14, 58, 51, 253, DateTimeKind.Local).AddTicks(3894) });
        }
    }
}
