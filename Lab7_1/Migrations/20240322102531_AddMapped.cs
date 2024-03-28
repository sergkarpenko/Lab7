using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab7_1.Migrations
{
    /// <inheritdoc />
    public partial class AddMapped : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimalEat",
                columns: table => new
                {
                    AnimalEatId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnimalId = table.Column<int>(type: "INTEGER", nullable: false),
                    EatId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalEat", x => x.AnimalEatId);
                    table.ForeignKey(
                        name: "FK_AnimalEat_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "AnimalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalEat_Eat_EatId",
                        column: x => x.EatId,
                        principalTable: "Eat",
                        principalColumn: "EatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalEat_AnimalId",
                table: "AnimalEat",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalEat_EatId",
                table: "AnimalEat",
                column: "EatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalEat");
        }
    }
}
