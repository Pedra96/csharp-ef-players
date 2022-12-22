using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharpEntityFrameworkPlayers.Migrations
{
    /// <inheritdoc />
    public partial class DBInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "giocatori",
                columns: table => new
                {
                    primaryKey = table.Column<int>(name: "primary_Key", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    punteggio = table.Column<float>(type: "real", nullable: false),
                    partitegiocate = table.Column<int>(name: "partite_giocate", type: "int", nullable: false),
                    partitevinte = table.Column<int>(name: "partite_vinte", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_giocatori", x => x.primaryKey);
                });

            migrationBuilder.CreateIndex(
                name: "IX_giocatori_primary_Key",
                table: "giocatori",
                column: "primary_Key",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "giocatori");
        }
    }
}
