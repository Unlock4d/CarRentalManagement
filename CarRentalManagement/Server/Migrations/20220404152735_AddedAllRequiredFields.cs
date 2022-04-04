using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class AddedAllRequiredFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicle",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicle",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Make",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
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
                value: "5eddc264-1e74-4670-af31-6604cfe5bfb8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "99aef8c1-8f97-43a2-a5d9-31ca8f8fc052");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89cf269d-8b8d-4119-b21a-02017eceafd9", "AQAAAAEAACcQAAAAEJcrhL46YEfDz7MRIbmHOeZkQoyb+2cnQ2ClWvw0xe+zyNFoUMbGj1nWdvFOOJHuLQ==", "77c81168-3014-4bae-8e1f-0332e3758608" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e71ec7a-858d-43b9-990f-86a17484cd38", "AQAAAAEAACcQAAAAEGkxOslEfNTeLwK/UPg/PUMWUOrEMU0bVBTSFWWN7xlu/v8w24vurVylcY8UhdNI8g==", "afcd0bc9-cc0b-43da-9076-c109beb0004b" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 4, 16, 27, 35, 247, DateTimeKind.Local).AddTicks(124), new DateTime(2022, 4, 4, 16, 27, 35, 249, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 4, 16, 27, 35, 249, DateTimeKind.Local).AddTicks(3710), new DateTime(2022, 4, 4, 16, 27, 35, 249, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 4, 16, 27, 35, 250, DateTimeKind.Local).AddTicks(5776), new DateTime(2022, 4, 4, 16, 27, 35, 250, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 4, 16, 27, 35, 250, DateTimeKind.Local).AddTicks(6057), new DateTime(2022, 4, 4, 16, 27, 35, 250, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 4, 16, 27, 35, 250, DateTimeKind.Local).AddTicks(8767), new DateTime(2022, 4, 4, 16, 27, 35, 250, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 4, 16, 27, 35, 250, DateTimeKind.Local).AddTicks(8786), new DateTime(2022, 4, 4, 16, 27, 35, 250, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 4, 16, 27, 35, 250, DateTimeKind.Local).AddTicks(8792), new DateTime(2022, 4, 4, 16, 27, 35, 250, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 4, 16, 27, 35, 250, DateTimeKind.Local).AddTicks(8798), new DateTime(2022, 4, 4, 16, 27, 35, 250, DateTimeKind.Local).AddTicks(8801) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicle",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicle",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Make",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
