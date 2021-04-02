using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gta.Data.Migrations
{
    public partial class Updatingdefaultuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Email", "IsDeleted", "Name" },
                values: new object[] { new Guid("c2dce21b-d207-4869-bf5f-08eb138bb919"), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "userdefault@gta.com", false, "User Default" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2dce21b-d207-4869-bf5f-08eb138bb919"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
