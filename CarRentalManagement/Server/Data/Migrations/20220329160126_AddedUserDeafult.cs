using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedUserDeafult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "6d64fbaa-f7ca-48df-a65c-03339df9caac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "e3c0676b-8812-40bb-b60c-a0ac9c3b5bb8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f491fc7-92f3-4831-a579-5e150530f3e1", "AQAAAAEAACcQAAAAEEEBTVtO0hvTyB6Qfv8m6qBaU+tjze3krweVVzdSdEVOPjtyaC3/kGXIN+TsUaOY1Q==", "1799cbde-71bd-4ca5-8b4b-bd93008d58b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39782514-6387-47da-8aea-698a588cbb11", "AQAAAAEAACcQAAAAEHmQQju5SuKBoxX/GZZmUMF7l9DYD8Zd4X2HDKJ6n2QY3Fpj4ixw/X2H+s9ofZzzWg==", "e87fd768-c341-408b-b318-8c51084e701c" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 1, 25, 867, DateTimeKind.Local).AddTicks(5364), new DateTime(2022, 3, 29, 17, 1, 25, 870, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 1, 25, 870, DateTimeKind.Local).AddTicks(924), new DateTime(2022, 3, 29, 17, 1, 25, 870, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 1, 25, 871, DateTimeKind.Local).AddTicks(6958), new DateTime(2022, 3, 29, 17, 1, 25, 871, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 1, 25, 871, DateTimeKind.Local).AddTicks(7457), new DateTime(2022, 3, 29, 17, 1, 25, 871, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 1, 25, 872, DateTimeKind.Local).AddTicks(2685), new DateTime(2022, 3, 29, 17, 1, 25, 872, DateTimeKind.Local).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 1, 25, 872, DateTimeKind.Local).AddTicks(2754), new DateTime(2022, 3, 29, 17, 1, 25, 872, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 1, 25, 872, DateTimeKind.Local).AddTicks(2761), new DateTime(2022, 3, 29, 17, 1, 25, 872, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 1, 25, 872, DateTimeKind.Local).AddTicks(2768), new DateTime(2022, 3, 29, 17, 1, 25, 872, DateTimeKind.Local).AddTicks(2771) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "05555f35-b788-4a14-9a51-c01e692325e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "2e911896-f196-4f42-a77e-f02a027948ce");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "565f5c55-5ada-4b2a-8c8c-c12a3f13795f", "AQAAAAEAACcQAAAAEPZ1fQML8jJNSWoUKa2zt0cmwcXh9Ds2l6N43KjoLQV/D8P7JoQBUhTA8rpa6jYrZg==", "50166fb8-1cf2-4d96-ad21-ead5c1f61c75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18e57e0b-4a90-48e8-a24f-fa310aefc8e6", "AQAAAAEAACcQAAAAEOOuOO5LFuhV9P+4aHFAjLebk+38btrhTIb1I0IxzEIXXIvdSqy4ruhG0GcQNOKhcA==", "31c7ade1-f4e8-4afa-9802-7889cc51a4f8" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 59, 47, 703, DateTimeKind.Local).AddTicks(714), new DateTime(2022, 3, 29, 16, 59, 47, 705, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 59, 47, 705, DateTimeKind.Local).AddTicks(2263), new DateTime(2022, 3, 29, 16, 59, 47, 705, DateTimeKind.Local).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 59, 47, 706, DateTimeKind.Local).AddTicks(3827), new DateTime(2022, 3, 29, 16, 59, 47, 706, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 59, 47, 706, DateTimeKind.Local).AddTicks(4115), new DateTime(2022, 3, 29, 16, 59, 47, 706, DateTimeKind.Local).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 59, 47, 706, DateTimeKind.Local).AddTicks(6960), new DateTime(2022, 3, 29, 16, 59, 47, 706, DateTimeKind.Local).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 59, 47, 706, DateTimeKind.Local).AddTicks(6983), new DateTime(2022, 3, 29, 16, 59, 47, 706, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 59, 47, 706, DateTimeKind.Local).AddTicks(6989), new DateTime(2022, 3, 29, 16, 59, 47, 706, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 59, 47, 706, DateTimeKind.Local).AddTicks(6995), new DateTime(2022, 3, 29, 16, 59, 47, 706, DateTimeKind.Local).AddTicks(6998) });
        }
    }
}
