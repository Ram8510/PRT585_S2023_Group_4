using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication_API.Migrations
{
    /// <inheritdoc />
    public partial class Second_Initiation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Published_Date",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Books",
                newName: "ID");

            migrationBuilder.AddColumn<long>(
                name: "Published_Year",
                table: "Books",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Published_Year",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Books",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "Published_Date",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
