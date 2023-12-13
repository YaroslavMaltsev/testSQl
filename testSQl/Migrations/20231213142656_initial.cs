using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace testSQl.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoubleGlazedWindows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleSP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chamberness = table.Column<int>(type: "int", nullable: false),
                    ThicknessSP = table.Column<int>(type: "int", nullable: false),
                    GlassThickness = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoubleGlazedWindows", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoubleGlazedWindows");
        }
    }
}
