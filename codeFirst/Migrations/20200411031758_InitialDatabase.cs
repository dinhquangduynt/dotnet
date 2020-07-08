using Microsoft.EntityFrameworkCore.Migrations;

namespace codeFirst.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lop",
                columns: table => new
                {
                    IdLop = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameLop = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop", x => x.IdLop);
                });

            migrationBuilder.CreateTable(
                name: "SinhVien",
                columns: table => new
                {
                    Mssv = table.Column<string>(nullable: false),
                    NameSv = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: true),
                    IdLop = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVien", x => x.Mssv);
                    table.ForeignKey(
                        name: "FK_SinhVien_Lop_IdLop",
                        column: x => x.IdLop,
                        principalTable: "Lop",
                        principalColumn: "IdLop",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Lop",
                columns: new[] { "IdLop", "NameLop" },
                values: new object[] { 1, "16T3" });

            migrationBuilder.InsertData(
                table: "SinhVien",
                columns: new[] { "Mssv", "Age", "IdLop", "NameSv" },
                values: new object[] { "102160135", 22, 1, "Duy" });

            migrationBuilder.CreateIndex(
                name: "IX_SinhVien_IdLop",
                table: "SinhVien",
                column: "IdLop");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhVien");

            migrationBuilder.DropTable(
                name: "Lop");
        }
    }
}
