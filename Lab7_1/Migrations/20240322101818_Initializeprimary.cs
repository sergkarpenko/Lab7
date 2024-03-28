using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab7_1.Migrations
{
    /// <inheritdoc />
    public partial class Initializeprimary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalEat");

            migrationBuilder.AddColumn<int>(
                name: "EatId",
                table: "Animals",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animals_EatId",
                table: "Animals",
                column: "EatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Eat_EatId",
                table: "Animals",
                column: "EatId",
                principalTable: "Eat",
                principalColumn: "EatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Eat_EatId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_EatId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "EatId",
                table: "Animals");

            migrationBuilder.CreateTable(
                name: "AnimalEat",
                columns: table => new
                {
                    AnimalEatsEatId = table.Column<int>(type: "INTEGER", nullable: false),
                    AnimalsAnimalId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalEat", x => new { x.AnimalEatsEatId, x.AnimalsAnimalId });
                    table.ForeignKey(
                        name: "FK_AnimalEat_Animals_AnimalsAnimalId",
                        column: x => x.AnimalsAnimalId,
                        principalTable: "Animals",
                        principalColumn: "AnimalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalEat_Eat_AnimalEatsEatId",
                        column: x => x.AnimalEatsEatId,
                        principalTable: "Eat",
                        principalColumn: "EatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalEat_AnimalsAnimalId",
                table: "AnimalEat",
                column: "AnimalsAnimalId");
        }
    }
}
