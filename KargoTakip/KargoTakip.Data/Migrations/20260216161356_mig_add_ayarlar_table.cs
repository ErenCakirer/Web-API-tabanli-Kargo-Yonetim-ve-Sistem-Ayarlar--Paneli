using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KargoTakip.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_ayarlar_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ayarlars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Siteisim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destekhattı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Şubeiletişim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesaiSaatleri = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ayarlars", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ayarlars");
        }
    }
}
