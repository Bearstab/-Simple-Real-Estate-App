using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    public partial class EvlerDbInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblEvler",
                columns: table => new
                {
                    Evid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanNo = table.Column<long>(type: "bigint", nullable: false),
                    OdaSayisi = table.Column<byte>(type: "tinyint", nullable: false),
                    KatNo = table.Column<short>(type: "smallint", nullable: false),
                    Alan = table.Column<double>(type: "float", nullable: false),
                    Semt = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEvler", x => x.Evid);
                });

            migrationBuilder.CreateTable(
                name: "tblUsers",
                columns: table => new
                {
                    Kullaniciid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Sifre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsers", x => x.Kullaniciid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblEvler");

            migrationBuilder.DropTable(
                name: "tblUsers");
        }
    }
}
