using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinemango.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMoziSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Felhasznalo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Felhasznalo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImdbID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EredetiCim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kiadasEve = table.Column<int>(type: "int", nullable: false),
                    LeirasHTML = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ElozetesURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Boritokep = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JegyTipus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JegyTipus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Terem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vasarlas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FelhasznaloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vasarlas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vasarlas_Felhasznalo_FelhasznaloId",
                        column: x => x.FelhasznaloId,
                        principalTable: "Felhasznalo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ulohely",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Oldal = table.Column<int>(type: "int", nullable: true),
                    Sor = table.Column<int>(type: "int", nullable: false),
                    Szek = table.Column<int>(type: "int", nullable: false),
                    TeremId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulohely", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ulohely_Terem_TeremId",
                        column: x => x.TeremId,
                        principalTable: "Terem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vetites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idopont = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipus = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    TeremId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vetites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vetites_Film_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Film",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vetites_Terem_TeremId",
                        column: x => x.TeremId,
                        principalTable: "Terem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jegy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ar = table.Column<int>(type: "int", nullable: true),
                    TipusId = table.Column<int>(type: "int", nullable: true),
                    UlohelyId = table.Column<int>(type: "int", nullable: false),
                    VasarlasId = table.Column<int>(type: "int", nullable: true),
                    VetitesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jegy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jegy_JegyTipus_TipusId",
                        column: x => x.TipusId,
                        principalTable: "JegyTipus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Jegy_Ulohely_UlohelyId",
                        column: x => x.UlohelyId,
                        principalTable: "Ulohely",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jegy_Vasarlas_VasarlasId",
                        column: x => x.VasarlasId,
                        principalTable: "Vasarlas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Jegy_Vetites_VetitesId",
                        column: x => x.VetitesId,
                        principalTable: "Vetites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jegy_TipusId",
                table: "Jegy",
                column: "TipusId");

            migrationBuilder.CreateIndex(
                name: "IX_Jegy_UlohelyId_VasarlasId",
                table: "Jegy",
                columns: new[] { "UlohelyId", "VasarlasId" },
                unique: true,
                filter: "[VasarlasId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Jegy_VasarlasId",
                table: "Jegy",
                column: "VasarlasId");

            migrationBuilder.CreateIndex(
                name: "IX_Jegy_VetitesId",
                table: "Jegy",
                column: "VetitesId");

            migrationBuilder.CreateIndex(
                name: "IX_JegyTipus_Name",
                table: "JegyTipus",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Terem_Name",
                table: "Terem",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ulohely_TeremId_Oldal_Sor_Szek",
                table: "Ulohely",
                columns: new[] { "TeremId", "Oldal", "Sor", "Szek" });

            migrationBuilder.CreateIndex(
                name: "IX_Vasarlas_FelhasznaloId",
                table: "Vasarlas",
                column: "FelhasznaloId");

            migrationBuilder.CreateIndex(
                name: "IX_Vetites_FilmId",
                table: "Vetites",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Vetites_TeremId",
                table: "Vetites",
                column: "TeremId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jegy");

            migrationBuilder.DropTable(
                name: "JegyTipus");

            migrationBuilder.DropTable(
                name: "Ulohely");

            migrationBuilder.DropTable(
                name: "Vasarlas");

            migrationBuilder.DropTable(
                name: "Vetites");

            migrationBuilder.DropTable(
                name: "Felhasznalo");

            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.DropTable(
                name: "Terem");
        }
    }
}
