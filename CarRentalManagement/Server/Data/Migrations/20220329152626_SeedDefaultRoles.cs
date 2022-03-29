using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "574ffe52-7813-44e4-a51c-5bb3e5ca572a", "c45e5389-9361-4da0-a12f-335b45c257e0", "User", "USER" },
                    { "368571bd-3b3a-40f2-95ce-af47c0e3aebc", "e8641557-3e8d-4121-a3cd-4f1d48ea6e8e", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 26, 25, 355, DateTimeKind.Local).AddTicks(7283), new DateTime(2022, 3, 29, 16, 26, 25, 357, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 26, 25, 357, DateTimeKind.Local).AddTicks(9552), new DateTime(2022, 3, 29, 16, 26, 25, 357, DateTimeKind.Local).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 26, 25, 359, DateTimeKind.Local).AddTicks(982), new DateTime(2022, 3, 29, 16, 26, 25, 359, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 26, 25, 359, DateTimeKind.Local).AddTicks(1257), new DateTime(2022, 3, 29, 16, 26, 25, 359, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 26, 25, 359, DateTimeKind.Local).AddTicks(4754), new DateTime(2022, 3, 29, 16, 26, 25, 359, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 26, 25, 359, DateTimeKind.Local).AddTicks(4774), new DateTime(2022, 3, 29, 16, 26, 25, 359, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 26, 25, 359, DateTimeKind.Local).AddTicks(4780), new DateTime(2022, 3, 29, 16, 26, 25, 359, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 26, 25, 359, DateTimeKind.Local).AddTicks(4787), new DateTime(2022, 3, 29, 16, 26, 25, 359, DateTimeKind.Local).AddTicks(4789) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "368571bd-3b3a-40f2-95ce-af47c0e3aebc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "574ffe52-7813-44e4-a51c-5bb3e5ca572a");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 14, 5, 141, DateTimeKind.Local).AddTicks(9217), new DateTime(2022, 3, 29, 16, 14, 5, 146, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 14, 5, 146, DateTimeKind.Local).AddTicks(7702), new DateTime(2022, 3, 29, 16, 14, 5, 146, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(3151), new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(3742), new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(7460), new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(7486), new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(7494), new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(7502), new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(7506) });
        }
    }
}
