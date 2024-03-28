using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab7_1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Biomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnimalBiomes = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biomes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnimalClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClassName = table.Column<string>(type: "TEXT", nullable: false),
                    BiomesId = table.Column<int>(type: "INTEGER", nullable: true),
                    EatId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalClass_Biomes_BiomesId",
                        column: x => x.BiomesId,
                        principalTable: "Biomes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LimbCount = table.Column<int>(type: "INTEGER", nullable: false),
                    AnimalBiomesId = table.Column<int>(type: "INTEGER", nullable: false),
                    AnimalClassId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_AnimalClass_AnimalClassId",
                        column: x => x.AnimalClassId,
                        principalTable: "AnimalClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animals_Biomes_AnimalBiomesId",
                        column: x => x.AnimalBiomesId,
                        principalTable: "Biomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Eat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EatName = table.Column<string>(type: "TEXT", nullable: false),
                    Calories = table.Column<int>(type: "INTEGER", nullable: false),
                    AnimalId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Eat_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalClass_BiomesId",
                table: "AnimalClass",
                column: "BiomesId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalClass_EatId",
                table: "AnimalClass",
                column: "EatId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_AnimalBiomesId",
                table: "Animals",
                column: "AnimalBiomesId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_AnimalClassId",
                table: "Animals",
                column: "AnimalClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Eat_AnimalId",
                table: "Eat",
                column: "AnimalId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalClass_Eat_EatId",
                table: "AnimalClass",
                column: "EatId",
                principalTable: "Eat",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalClass_Biomes_BiomesId",
                table: "AnimalClass");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Biomes_AnimalBiomesId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_AnimalClass_Eat_EatId",
                table: "AnimalClass");

            migrationBuilder.DropTable(
                name: "Biomes");

            migrationBuilder.DropTable(
                name: "Eat");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "AnimalClass");
        }
    }
}
