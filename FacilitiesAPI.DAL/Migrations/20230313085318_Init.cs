using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FacilitiesAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Volume = table.Column<int>(type: "integer", nullable: true),
                    MaxVolume = table.Column<int>(type: "integer", nullable: true),
                    UnitId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tanks_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Газофракционирующая установка", "ГФУ-2" },
                    { 2, "Атмосферно-вакуумная трубчатка", "АВТ-6" },
                    { 3, "Атмосферно-вакуумная трубчатка", "АВТ-10" }
                });

            migrationBuilder.InsertData(
                table: "Tanks",
                columns: new[] { "Id", "Description", "MaxVolume", "Name", "UnitId", "Volume" },
                values: new object[,]
                {
                    { 1, "Надземный - вертикальный", 2000, "Резервуар 1", 1, 1500 },
                    { 2, "Надземный - горизонтальный", 3000, "Резервуар 2", 1, 2500 },
                    { 3, "Надземный - горизонтальный", 3000, "Дополнительный резервуар 24", 2, 3000 },
                    { 4, "Надземный - вертикальный", 3000, "Резервуар 35", 2, 3000 },
                    { 5, "Подземный - двустенный", 5000, "Резервуар 47", 2, 4000 },
                    { 6, "Подводный", 500, "Резервуар 256", 3, 500 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tanks_UnitId",
                table: "Tanks",
                column: "UnitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tanks");

            migrationBuilder.DropTable(
                name: "Units");
        }
    }
}
