using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KargoTakip.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_kargo_hareket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KargoHareketleri",
                columns: table => new
                {
                    KargoHareketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakipKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Istasyon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KargoHareketleri", x => x.KargoHareketID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KargoHareketleri");
        }
    }
}
