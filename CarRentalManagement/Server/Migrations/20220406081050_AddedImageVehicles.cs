using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class AddedImageVehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "fa892148-f530-4145-8062-cb2f1d91c633");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "fef539a6-5128-4e93-a5e8-5153188e41a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "527fa614-34aa-47ca-98a7-2b2dca398a03", "AQAAAAEAACcQAAAAEL9EJxnonqMyJe9FbMHiWorXMowVElpk7yo4UhoMpn0bQ2dDS6qgb0zlzA6oKv04zw==", "5a0ee45a-7ac6-4454-95cb-eddee9611361" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "166eecbd-68b6-418b-afa5-c079a54bff0b", "AQAAAAEAACcQAAAAEJyy3oW83wOhoIT82+dPSkMUmwp7tJomrbnLaO0orJQRmEm8MzGEnKJaUCrnsoiVNA==", "3cc4baa1-0b39-4964-8157-d51de6302fbb" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 6, 9, 10, 49, 616, DateTimeKind.Local).AddTicks(5293), new DateTime(2022, 4, 6, 9, 10, 49, 620, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 6, 9, 10, 49, 620, DateTimeKind.Local).AddTicks(8929), new DateTime(2022, 4, 6, 9, 10, 49, 620, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 6, 9, 10, 49, 622, DateTimeKind.Local).AddTicks(1342), new DateTime(2022, 4, 6, 9, 10, 49, 622, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 6, 9, 10, 49, 622, DateTimeKind.Local).AddTicks(1697), new DateTime(2022, 4, 6, 9, 10, 49, 622, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 6, 9, 10, 49, 622, DateTimeKind.Local).AddTicks(4503), new DateTime(2022, 4, 6, 9, 10, 49, 622, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 6, 9, 10, 49, 622, DateTimeKind.Local).AddTicks(4522), new DateTime(2022, 4, 6, 9, 10, 49, 622, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 6, 9, 10, 49, 622, DateTimeKind.Local).AddTicks(4528), new DateTime(2022, 4, 6, 9, 10, 49, 622, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2022, 4, 6, 9, 10, 49, 622, DateTimeKind.Local).AddTicks(4534), new DateTime(2022, 4, 6, 9, 10, 49, 622, DateTimeKind.Local).AddTicks(4537) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicle");

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
    }
}
