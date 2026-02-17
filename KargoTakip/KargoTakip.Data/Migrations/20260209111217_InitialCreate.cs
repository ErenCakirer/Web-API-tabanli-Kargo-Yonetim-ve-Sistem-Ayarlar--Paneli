using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KargoTakip.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SevkiyatGeçmişleri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SevkiyatID = table.Column<int>(type: "int", nullable: false),
                    SevkiyatAçıklaması = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İşlemTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Konum = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SevkiyatGeçmişleri", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sevkiyatlar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakipNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gönderen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alıcı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeslimatAdresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OluşturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sevkiyatlar", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SevkiyatGeçmişleri");

            migrationBuilder.DropTable(
                name: "Sevkiyatlar");
        }
    }
}
