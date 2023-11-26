using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Propuesta",
                columns: table => new
                {
                    PropuestaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TutorId = table.Column<int>(type: "int", nullable: false),
                    AcompananteId = table.Column<int>(type: "int", nullable: false),
                    InfoAdicional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Monto = table.Column<int>(type: "int", nullable: false),
                    EstadoPropuesta = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propuesta", x => x.PropuestaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Propuesta");
        }
    }
}
