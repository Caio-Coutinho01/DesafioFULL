using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gta.Data.Migrations
{
    public partial class columNUmparcel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 4, 34, 9, 288, DateTimeKind.Local).AddTicks(7764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 8, 1, 27, 47, 924, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Parcels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 4, 34, 9, 275, DateTimeKind.Local).AddTicks(542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 8, 1, 27, 47, 911, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.AddColumn<int>(
                name: "NumParcel",
                table: "Parcels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumParcel",
                table: "Parcels");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 1, 27, 47, 924, DateTimeKind.Local).AddTicks(2543),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 8, 4, 34, 9, 288, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Parcels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 1, 27, 47, 911, DateTimeKind.Local).AddTicks(4285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 8, 4, 34, 9, 275, DateTimeKind.Local).AddTicks(542));
        }
    }
}
