using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HakatoApi.Migrations
{
    /// <inheritdoc />
    public partial class Secnd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "born",
                table: "patient",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "born",
                table: "patient");
        }
    }
}
