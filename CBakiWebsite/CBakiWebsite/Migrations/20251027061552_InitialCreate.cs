using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CBakiWebsite.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Move",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Damage = table.Column<float>(type: "real", nullable: false),
                    CD = table.Column<int>(type: "int", nullable: false),
                    MoveName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Move", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Styles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StyleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinStrength = table.Column<int>(type: "int", nullable: false),
                    MinDurability = table.Column<int>(type: "int", nullable: false),
                    MinAgility = table.Column<int>(type: "int", nullable: false),
                    MinIntellect = table.Column<int>(type: "int", nullable: false),
                    ZMove1Id = table.Column<int>(type: "int", nullable: true),
                    ZMove2Id = table.Column<int>(type: "int", nullable: true),
                    ZMove3Id = table.Column<int>(type: "int", nullable: true),
                    ZMove4Id = table.Column<int>(type: "int", nullable: true),
                    ZMove5Id = table.Column<int>(type: "int", nullable: true),
                    XMove1Id = table.Column<int>(type: "int", nullable: true),
                    XMove2Id = table.Column<int>(type: "int", nullable: true),
                    XMove3Id = table.Column<int>(type: "int", nullable: true),
                    XMove4Id = table.Column<int>(type: "int", nullable: true),
                    XMove5Id = table.Column<int>(type: "int", nullable: true),
                    CMove1Id = table.Column<int>(type: "int", nullable: true),
                    CMove2Id = table.Column<int>(type: "int", nullable: true),
                    CMove3Id = table.Column<int>(type: "int", nullable: true),
                    CMove4Id = table.Column<int>(type: "int", nullable: true),
                    CMove5Id = table.Column<int>(type: "int", nullable: true),
                    VMove1Id = table.Column<int>(type: "int", nullable: true),
                    VMove2Id = table.Column<int>(type: "int", nullable: true),
                    VMove3Id = table.Column<int>(type: "int", nullable: true),
                    VMove4Id = table.Column<int>(type: "int", nullable: true),
                    VMove5Id = table.Column<int>(type: "int", nullable: true),
                    BMove1Id = table.Column<int>(type: "int", nullable: true),
                    BMove2Id = table.Column<int>(type: "int", nullable: true),
                    BMove3Id = table.Column<int>(type: "int", nullable: true),
                    BMove4Id = table.Column<int>(type: "int", nullable: true),
                    BMove5Id = table.Column<int>(type: "int", nullable: true),
                    MiscMove1Id = table.Column<int>(type: "int", nullable: true),
                    MiscMove2Id = table.Column<int>(type: "int", nullable: true),
                    MiscMove3Id = table.Column<int>(type: "int", nullable: true),
                    MiscMove4Id = table.Column<int>(type: "int", nullable: true),
                    MiscMove5Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Styles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Styles_Move_BMove1Id",
                        column: x => x.BMove1Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_BMove2Id",
                        column: x => x.BMove2Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_BMove3Id",
                        column: x => x.BMove3Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_BMove4Id",
                        column: x => x.BMove4Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_BMove5Id",
                        column: x => x.BMove5Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_CMove1Id",
                        column: x => x.CMove1Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_CMove2Id",
                        column: x => x.CMove2Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_CMove3Id",
                        column: x => x.CMove3Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_CMove4Id",
                        column: x => x.CMove4Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_CMove5Id",
                        column: x => x.CMove5Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_MiscMove1Id",
                        column: x => x.MiscMove1Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_MiscMove2Id",
                        column: x => x.MiscMove2Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_MiscMove3Id",
                        column: x => x.MiscMove3Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_MiscMove4Id",
                        column: x => x.MiscMove4Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_MiscMove5Id",
                        column: x => x.MiscMove5Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_VMove1Id",
                        column: x => x.VMove1Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_VMove2Id",
                        column: x => x.VMove2Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_VMove3Id",
                        column: x => x.VMove3Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_VMove4Id",
                        column: x => x.VMove4Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_VMove5Id",
                        column: x => x.VMove5Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_XMove1Id",
                        column: x => x.XMove1Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_XMove2Id",
                        column: x => x.XMove2Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_XMove3Id",
                        column: x => x.XMove3Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_XMove4Id",
                        column: x => x.XMove4Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_XMove5Id",
                        column: x => x.XMove5Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_ZMove1Id",
                        column: x => x.ZMove1Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_ZMove2Id",
                        column: x => x.ZMove2Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_ZMove3Id",
                        column: x => x.ZMove3Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_ZMove4Id",
                        column: x => x.ZMove4Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Styles_Move_ZMove5Id",
                        column: x => x.ZMove5Id,
                        principalTable: "Move",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Durability = table.Column<int>(type: "int", nullable: false),
                    Agility = table.Column<int>(type: "int", nullable: false),
                    Intellect = table.Column<int>(type: "int", nullable: false),
                    StyleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Styles_StyleId",
                        column: x => x.StyleId,
                        principalTable: "Styles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_StyleId",
                table: "Players",
                column: "StyleId");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_BMove1Id",
                table: "Styles",
                column: "BMove1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_BMove2Id",
                table: "Styles",
                column: "BMove2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_BMove3Id",
                table: "Styles",
                column: "BMove3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_BMove4Id",
                table: "Styles",
                column: "BMove4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_BMove5Id",
                table: "Styles",
                column: "BMove5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_CMove1Id",
                table: "Styles",
                column: "CMove1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_CMove2Id",
                table: "Styles",
                column: "CMove2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_CMove3Id",
                table: "Styles",
                column: "CMove3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_CMove4Id",
                table: "Styles",
                column: "CMove4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_CMove5Id",
                table: "Styles",
                column: "CMove5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_MiscMove1Id",
                table: "Styles",
                column: "MiscMove1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_MiscMove2Id",
                table: "Styles",
                column: "MiscMove2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_MiscMove3Id",
                table: "Styles",
                column: "MiscMove3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_MiscMove4Id",
                table: "Styles",
                column: "MiscMove4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_MiscMove5Id",
                table: "Styles",
                column: "MiscMove5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_VMove1Id",
                table: "Styles",
                column: "VMove1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_VMove2Id",
                table: "Styles",
                column: "VMove2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_VMove3Id",
                table: "Styles",
                column: "VMove3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_VMove4Id",
                table: "Styles",
                column: "VMove4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_VMove5Id",
                table: "Styles",
                column: "VMove5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_XMove1Id",
                table: "Styles",
                column: "XMove1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_XMove2Id",
                table: "Styles",
                column: "XMove2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_XMove3Id",
                table: "Styles",
                column: "XMove3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_XMove4Id",
                table: "Styles",
                column: "XMove4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_XMove5Id",
                table: "Styles",
                column: "XMove5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_ZMove1Id",
                table: "Styles",
                column: "ZMove1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_ZMove2Id",
                table: "Styles",
                column: "ZMove2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_ZMove3Id",
                table: "Styles",
                column: "ZMove3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_ZMove4Id",
                table: "Styles",
                column: "ZMove4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_ZMove5Id",
                table: "Styles",
                column: "ZMove5Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Styles");

            migrationBuilder.DropTable(
                name: "Move");
        }
    }
}
