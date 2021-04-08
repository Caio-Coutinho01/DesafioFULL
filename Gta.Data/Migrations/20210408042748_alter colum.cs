using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gta.Data.Migrations
{
    public partial class altercolum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 1, 27, 47, 924, DateTimeKind.Local).AddTicks(2543),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 7, 16, 14, 57, 736, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.AlterColumn<float>(
                name: "Fine",
                table: "Parcels",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Fees",
                table: "Parcels",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Parcels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 1, 27, 47, 911, DateTimeKind.Local).AddTicks(4285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 7, 16, 14, 57, 723, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fees", "Fine" },
                values: new object[] { 1f, 1f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 7, 16, 14, 57, 736, DateTimeKind.Local).AddTicks(2067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 8, 1, 27, 47, 924, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.AlterColumn<int>(
                name: "Fine",
                table: "Parcels",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "Fees",
                table: "Parcels",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Parcels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 7, 16, 14, 57, 723, DateTimeKind.Local).AddTicks(7076),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 8, 1, 27, 47, 911, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fees", "Fine" },
                values: new object[] { 1, 1 });
        }
    }
}
