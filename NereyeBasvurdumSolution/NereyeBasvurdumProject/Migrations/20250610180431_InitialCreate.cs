using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NereyeBasvurdumProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Basvurularim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sirket = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Lokasyon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Pozisyon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deneyim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Araci = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BasvuruTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Durum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basvurularim", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Basvurularim");
        }
    }
}
