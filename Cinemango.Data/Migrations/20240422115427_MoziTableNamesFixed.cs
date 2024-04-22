using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinemango.Data.Migrations
{
    /// <inheritdoc />
    public partial class MoziTableNamesFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jegy_JegyTipus_TipusId",
                table: "Jegy");

            migrationBuilder.DropForeignKey(
                name: "FK_Jegy_Ulohely_UlohelyId",
                table: "Jegy");

            migrationBuilder.DropForeignKey(
                name: "FK_Jegy_Vasarlas_VasarlasId",
                table: "Jegy");

            migrationBuilder.DropForeignKey(
                name: "FK_Jegy_Vetites_VetitesId",
                table: "Jegy");

            migrationBuilder.DropForeignKey(
                name: "FK_Ulohely_Terem_TeremId",
                table: "Ulohely");

            migrationBuilder.DropForeignKey(
                name: "FK_Vasarlas_Felhasznalo_FelhasznaloId",
                table: "Vasarlas");

            migrationBuilder.DropForeignKey(
                name: "FK_Vetites_Film_FilmId",
                table: "Vetites");

            migrationBuilder.DropForeignKey(
                name: "FK_Vetites_Terem_TeremId",
                table: "Vetites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vetites",
                table: "Vetites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vasarlas",
                table: "Vasarlas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ulohely",
                table: "Ulohely");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Terem",
                table: "Terem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JegyTipus",
                table: "JegyTipus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jegy",
                table: "Jegy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Film",
                table: "Film");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Felhasznalo",
                table: "Felhasznalo");

            migrationBuilder.RenameTable(
                name: "Vetites",
                newName: "Vetitesek");

            migrationBuilder.RenameTable(
                name: "Vasarlas",
                newName: "Vasarlasok");

            migrationBuilder.RenameTable(
                name: "Ulohely",
                newName: "Ulohelyek");

            migrationBuilder.RenameTable(
                name: "Terem",
                newName: "Termek");

            migrationBuilder.RenameTable(
                name: "JegyTipus",
                newName: "JegyTipusok");

            migrationBuilder.RenameTable(
                name: "Jegy",
                newName: "Jegyek");

            migrationBuilder.RenameTable(
                name: "Film",
                newName: "Filmek");

            migrationBuilder.RenameTable(
                name: "Felhasznalo",
                newName: "Felhasznalok");

            migrationBuilder.RenameIndex(
                name: "IX_Vetites_TeremId",
                table: "Vetitesek",
                newName: "IX_Vetitesek_TeremId");

            migrationBuilder.RenameIndex(
                name: "IX_Vetites_FilmId",
                table: "Vetitesek",
                newName: "IX_Vetitesek_FilmId");

            migrationBuilder.RenameIndex(
                name: "IX_Vasarlas_FelhasznaloId",
                table: "Vasarlasok",
                newName: "IX_Vasarlasok_FelhasznaloId");

            migrationBuilder.RenameIndex(
                name: "IX_Ulohely_TeremId_Oldal_Sor_Szek",
                table: "Ulohelyek",
                newName: "IX_Ulohelyek_TeremId_Oldal_Sor_Szek");

            migrationBuilder.RenameIndex(
                name: "IX_Terem_Name",
                table: "Termek",
                newName: "IX_Termek_Name");

            migrationBuilder.RenameIndex(
                name: "IX_JegyTipus_Name",
                table: "JegyTipusok",
                newName: "IX_JegyTipusok_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Jegy_VetitesId",
                table: "Jegyek",
                newName: "IX_Jegyek_VetitesId");

            migrationBuilder.RenameIndex(
                name: "IX_Jegy_VasarlasId",
                table: "Jegyek",
                newName: "IX_Jegyek_VasarlasId");

            migrationBuilder.RenameIndex(
                name: "IX_Jegy_UlohelyId_VasarlasId",
                table: "Jegyek",
                newName: "IX_Jegyek_UlohelyId_VasarlasId");

            migrationBuilder.RenameIndex(
                name: "IX_Jegy_TipusId",
                table: "Jegyek",
                newName: "IX_Jegyek_TipusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vetitesek",
                table: "Vetitesek",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vasarlasok",
                table: "Vasarlasok",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ulohelyek",
                table: "Ulohelyek",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Termek",
                table: "Termek",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JegyTipusok",
                table: "JegyTipusok",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jegyek",
                table: "Jegyek",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filmek",
                table: "Filmek",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Felhasznalok",
                table: "Felhasznalok",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jegyek_JegyTipusok_TipusId",
                table: "Jegyek",
                column: "TipusId",
                principalTable: "JegyTipusok",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jegyek_Ulohelyek_UlohelyId",
                table: "Jegyek",
                column: "UlohelyId",
                principalTable: "Ulohelyek",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jegyek_Vasarlasok_VasarlasId",
                table: "Jegyek",
                column: "VasarlasId",
                principalTable: "Vasarlasok",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jegyek_Vetitesek_VetitesId",
                table: "Jegyek",
                column: "VetitesId",
                principalTable: "Vetitesek",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ulohelyek_Termek_TeremId",
                table: "Ulohelyek",
                column: "TeremId",
                principalTable: "Termek",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vasarlasok_Felhasznalok_FelhasznaloId",
                table: "Vasarlasok",
                column: "FelhasznaloId",
                principalTable: "Felhasznalok",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vetitesek_Filmek_FilmId",
                table: "Vetitesek",
                column: "FilmId",
                principalTable: "Filmek",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vetitesek_Termek_TeremId",
                table: "Vetitesek",
                column: "TeremId",
                principalTable: "Termek",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jegyek_JegyTipusok_TipusId",
                table: "Jegyek");

            migrationBuilder.DropForeignKey(
                name: "FK_Jegyek_Ulohelyek_UlohelyId",
                table: "Jegyek");

            migrationBuilder.DropForeignKey(
                name: "FK_Jegyek_Vasarlasok_VasarlasId",
                table: "Jegyek");

            migrationBuilder.DropForeignKey(
                name: "FK_Jegyek_Vetitesek_VetitesId",
                table: "Jegyek");

            migrationBuilder.DropForeignKey(
                name: "FK_Ulohelyek_Termek_TeremId",
                table: "Ulohelyek");

            migrationBuilder.DropForeignKey(
                name: "FK_Vasarlasok_Felhasznalok_FelhasznaloId",
                table: "Vasarlasok");

            migrationBuilder.DropForeignKey(
                name: "FK_Vetitesek_Filmek_FilmId",
                table: "Vetitesek");

            migrationBuilder.DropForeignKey(
                name: "FK_Vetitesek_Termek_TeremId",
                table: "Vetitesek");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vetitesek",
                table: "Vetitesek");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vasarlasok",
                table: "Vasarlasok");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ulohelyek",
                table: "Ulohelyek");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Termek",
                table: "Termek");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JegyTipusok",
                table: "JegyTipusok");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jegyek",
                table: "Jegyek");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filmek",
                table: "Filmek");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Felhasznalok",
                table: "Felhasznalok");

            migrationBuilder.RenameTable(
                name: "Vetitesek",
                newName: "Vetites");

            migrationBuilder.RenameTable(
                name: "Vasarlasok",
                newName: "Vasarlas");

            migrationBuilder.RenameTable(
                name: "Ulohelyek",
                newName: "Ulohely");

            migrationBuilder.RenameTable(
                name: "Termek",
                newName: "Terem");

            migrationBuilder.RenameTable(
                name: "JegyTipusok",
                newName: "JegyTipus");

            migrationBuilder.RenameTable(
                name: "Jegyek",
                newName: "Jegy");

            migrationBuilder.RenameTable(
                name: "Filmek",
                newName: "Film");

            migrationBuilder.RenameTable(
                name: "Felhasznalok",
                newName: "Felhasznalo");

            migrationBuilder.RenameIndex(
                name: "IX_Vetitesek_TeremId",
                table: "Vetites",
                newName: "IX_Vetites_TeremId");

            migrationBuilder.RenameIndex(
                name: "IX_Vetitesek_FilmId",
                table: "Vetites",
                newName: "IX_Vetites_FilmId");

            migrationBuilder.RenameIndex(
                name: "IX_Vasarlasok_FelhasznaloId",
                table: "Vasarlas",
                newName: "IX_Vasarlas_FelhasznaloId");

            migrationBuilder.RenameIndex(
                name: "IX_Ulohelyek_TeremId_Oldal_Sor_Szek",
                table: "Ulohely",
                newName: "IX_Ulohely_TeremId_Oldal_Sor_Szek");

            migrationBuilder.RenameIndex(
                name: "IX_Termek_Name",
                table: "Terem",
                newName: "IX_Terem_Name");

            migrationBuilder.RenameIndex(
                name: "IX_JegyTipusok_Name",
                table: "JegyTipus",
                newName: "IX_JegyTipus_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Jegyek_VetitesId",
                table: "Jegy",
                newName: "IX_Jegy_VetitesId");

            migrationBuilder.RenameIndex(
                name: "IX_Jegyek_VasarlasId",
                table: "Jegy",
                newName: "IX_Jegy_VasarlasId");

            migrationBuilder.RenameIndex(
                name: "IX_Jegyek_UlohelyId_VasarlasId",
                table: "Jegy",
                newName: "IX_Jegy_UlohelyId_VasarlasId");

            migrationBuilder.RenameIndex(
                name: "IX_Jegyek_TipusId",
                table: "Jegy",
                newName: "IX_Jegy_TipusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vetites",
                table: "Vetites",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vasarlas",
                table: "Vasarlas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ulohely",
                table: "Ulohely",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Terem",
                table: "Terem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JegyTipus",
                table: "JegyTipus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jegy",
                table: "Jegy",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Film",
                table: "Film",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Felhasznalo",
                table: "Felhasznalo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jegy_JegyTipus_TipusId",
                table: "Jegy",
                column: "TipusId",
                principalTable: "JegyTipus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jegy_Ulohely_UlohelyId",
                table: "Jegy",
                column: "UlohelyId",
                principalTable: "Ulohely",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jegy_Vasarlas_VasarlasId",
                table: "Jegy",
                column: "VasarlasId",
                principalTable: "Vasarlas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jegy_Vetites_VetitesId",
                table: "Jegy",
                column: "VetitesId",
                principalTable: "Vetites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ulohely_Terem_TeremId",
                table: "Ulohely",
                column: "TeremId",
                principalTable: "Terem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vasarlas_Felhasznalo_FelhasznaloId",
                table: "Vasarlas",
                column: "FelhasznaloId",
                principalTable: "Felhasznalo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vetites_Film_FilmId",
                table: "Vetites",
                column: "FilmId",
                principalTable: "Film",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vetites_Terem_TeremId",
                table: "Vetites",
                column: "TeremId",
                principalTable: "Terem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
