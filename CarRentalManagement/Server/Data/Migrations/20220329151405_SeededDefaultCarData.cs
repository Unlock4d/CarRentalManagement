using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 3, 29, 16, 14, 5, 141, DateTimeKind.Local).AddTicks(9217), new DateTime(2022, 3, 29, 16, 14, 5, 146, DateTimeKind.Local).AddTicks(6685), "Black", "System" },
                    { 2, "System", new DateTime(2022, 3, 29, 16, 14, 5, 146, DateTimeKind.Local).AddTicks(7702), new DateTime(2022, 3, 29, 16, 14, 5, 146, DateTimeKind.Local).AddTicks(7715), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(3151), new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(3213), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(3742), new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(3752), "Mercedes", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(7460), new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(7480), "Série 1", "System" },
                    { 2, "System", new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(7486), new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(7489), "Série 3", "System" },
                    { 3, "System", new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(7494), new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(7497), "Classe A Compacto", "System" },
                    { 4, "System", new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(7502), new DateTime(2022, 3, 29, 16, 14, 5, 148, DateTimeKind.Local).AddTicks(7506), "Classe B Tourer", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
