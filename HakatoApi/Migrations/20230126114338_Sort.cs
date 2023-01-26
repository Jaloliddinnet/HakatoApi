using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HakatoApi.Migrations
{
    /// <inheritdoc />
    public partial class Sort : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sickness",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sicknessname = table.Column<string>(name: "sickness_name", type: "text", nullable: false),
                    inTheHospital = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    outTheHospital = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    info = table.Column<string>(type: "text", nullable: false),
                    doctorid = table.Column<int>(name: "doctor_id", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sickness", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sickness");
        }
    }
}
