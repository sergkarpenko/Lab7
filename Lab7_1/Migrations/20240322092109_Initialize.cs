using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab7_1.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalClass_Eat_EatId",
                table: "AnimalClass");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_AnimalClass_AnimalClassId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Biomes_AnimalBiomesId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Eat_Animals_AnimalId",
                table: "Eat");

            migrationBuilder.DropIndex(
                name: "IX_Eat_AnimalId",
                table: "Eat");

            migrationBuilder.DropIndex(
                name: "IX_AnimalClass_EatId",
                table: "AnimalClass");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "Eat");

            migrationBuilder.DropColumn(
                name: "EatId",
                table: "AnimalClass");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Eat",
                newName: "EatId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Biomes",
                newName: "BiomesId");

            migrationBuilder.RenameColumn(
                name: "AnimalClassId",
                table: "Animals",
                newName: "AnimalClassClassId");

            migrationBuilder.RenameColumn(
                name: "AnimalBiomesId",
                table: "Animals",
                newName: "AnimalBiomesBiomesId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Animals",
                newName: "AnimalId");

            migrationBuilder.RenameIndex(
                name: "IX_Animals_AnimalClassId",
                table: "Animals",
                newName: "IX_Animals_AnimalClassClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Animals_AnimalBiomesId",
                table: "Animals",
                newName: "IX_Animals_AnimalBiomesBiomesId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AnimalClass",
                newName: "ClassId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_AnimalClass_AnimalClassClassId",
                table: "Animals",
                column: "AnimalClassClassId",
                principalTable: "AnimalClass",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Biomes_AnimalBiomesBiomesId",
                table: "Animals",
                column: "AnimalBiomesBiomesId",
                principalTable: "Biomes",
                principalColumn: "BiomesId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_AnimalClass_AnimalClassClassId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Biomes_AnimalBiomesBiomesId",
                table: "Animals");

            migrationBuilder.DropTable(
                name: "AnimalEat");

            migrationBuilder.RenameColumn(
                name: "EatId",
                table: "Eat",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BiomesId",
                table: "Biomes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AnimalClassClassId",
                table: "Animals",
                newName: "AnimalClassId");

            migrationBuilder.RenameColumn(
                name: "AnimalBiomesBiomesId",
                table: "Animals",
                newName: "AnimalBiomesId");

            migrationBuilder.RenameColumn(
                name: "AnimalId",
                table: "Animals",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Animals_AnimalClassClassId",
                table: "Animals",
                newName: "IX_Animals_AnimalClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Animals_AnimalBiomesBiomesId",
                table: "Animals",
                newName: "IX_Animals_AnimalBiomesId");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "AnimalClass",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "Eat",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EatId",
                table: "AnimalClass",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Eat_AnimalId",
                table: "Eat",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalClass_EatId",
                table: "AnimalClass",
                column: "EatId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalClass_Eat_EatId",
                table: "AnimalClass",
                column: "EatId",
                principalTable: "Eat",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_AnimalClass_AnimalClassId",
                table: "Animals",
                column: "AnimalClassId",
                principalTable: "AnimalClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Biomes_AnimalBiomesId",
                table: "Animals",
                column: "AnimalBiomesId",
                principalTable: "Biomes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Eat_Animals_AnimalId",
                table: "Eat",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id");
        }
    }
}
