using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_FrameWork_Giris_Meyveler.Migrations
{
    public partial class IlkGoc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meyveler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meyveler", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Meyveler",
                columns: new[] { "Id", "Ad" },
                values: new object[,]
                {
                    { 1, "Elma" },
                    { 2, "Armut" },
                    { 3, "Portakal" },
                    { 4, "Muz" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meyveler");
        }
    }
}
