using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KargoTakip.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_mesaj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mesajlar",
                columns: table => new
                {
                    MesajID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GonderenAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesajIcerigi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfilFotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRight = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesajlar", x => x.MesajID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mesajlar");
        }
    }
}
