using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "368571bd-3b3a-40f2-95ce-af47c0e3aebc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "574ffe52-7813-44e4-a51c-5bb3e5ca572a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "05555f35-b788-4a14-9a51-c01e692325e6", "User", "USER" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "2e911896-f196-4f42-a77e-f02a027948ce", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "565f5c55-5ada-4b2a-8c8c-c12a3f13795f", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEPZ1fQML8jJNSWoUKa2zt0cmwcXh9Ds2l6N43KjoLQV/D8P7JoQBUhTA8rpa6jYrZg==", null, false, "50166fb8-1cf2-4d96-ad21-ead5c1f61c75", false, "Admin" },
                    { "9e224968-33e4-4652-b7b7-8574d048cdb9", 0, "18e57e0b-4a90-48e8-a24f-fa310aefc8e6", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEOOuOO5LFuhV9P+4aHFAjLebk+38btrhTIb1I0IxzEIXXIvdSqy4ruhG0GcQNOKhcA==", null, false, "31c7ade1-f4e8-4afa-9802-7889cc51a4f8", false, "User@localhost.com" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9");

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
    }
}
