using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstInformator.Migrations
{
    /// <inheritdoc />
    public partial class InformatorDB1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oceny_Uzytkownikow_Uzytkownicy_UzytkownicyFKID",
                table: "Oceny_Uzytkownikow");

            migrationBuilder.DropForeignKey(
                name: "FK_Oceny_Uzytkownikow_Wydarzenie_WydarzenieFKID",
                table: "Oceny_Uzytkownikow");

            migrationBuilder.DropForeignKey(
                name: "FK_Organizatorzy_Tabela_Kont_Tabela_KontFKID",
                table: "Organizatorzy");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezerwacje_Uzytkownicy_id_urzytkownikaFKID",
                table: "Rezerwacje");

            migrationBuilder.DropForeignKey(
                name: "FK_Uzytkownicy_Tabela_Kont_Tabela_KontFKID",
                table: "Uzytkownicy");

            migrationBuilder.DropForeignKey(
                name: "FK_Wydarzenie_Kategorie_KategorieFKID",
                table: "Wydarzenie");

            migrationBuilder.DropForeignKey(
                name: "FK_Wydarzenie_Organizatorzy_OrganizatorzyFKID",
                table: "Wydarzenie");

            migrationBuilder.RenameColumn(
                name: "OrganizatorzyFKID",
                table: "Wydarzenie",
                newName: "id_organizatoraFKID");

            migrationBuilder.RenameColumn(
                name: "KategorieFKID",
                table: "Wydarzenie",
                newName: "id_kategoriiFKID");

            migrationBuilder.RenameIndex(
                name: "IX_Wydarzenie_OrganizatorzyFKID",
                table: "Wydarzenie",
                newName: "IX_Wydarzenie_id_organizatoraFKID");

            migrationBuilder.RenameIndex(
                name: "IX_Wydarzenie_KategorieFKID",
                table: "Wydarzenie",
                newName: "IX_Wydarzenie_id_kategoriiFKID");

            migrationBuilder.RenameColumn(
                name: "Tabela_KontFKID",
                table: "Uzytkownicy",
                newName: "id_kontaFKID");

            migrationBuilder.RenameIndex(
                name: "IX_Uzytkownicy_Tabela_KontFKID",
                table: "Uzytkownicy",
                newName: "IX_Uzytkownicy_id_kontaFKID");

            migrationBuilder.RenameColumn(
                name: "id_urzytkownikaFKID",
                table: "Rezerwacje",
                newName: "id_uzytkownikaFKID");

            migrationBuilder.RenameIndex(
                name: "IX_Rezerwacje_id_urzytkownikaFKID",
                table: "Rezerwacje",
                newName: "IX_Rezerwacje_id_uzytkownikaFKID");

            migrationBuilder.RenameColumn(
                name: "Tabela_KontFKID",
                table: "Organizatorzy",
                newName: "id_kontaFKID");

            migrationBuilder.RenameIndex(
                name: "IX_Organizatorzy_Tabela_KontFKID",
                table: "Organizatorzy",
                newName: "IX_Organizatorzy_id_kontaFKID");

            migrationBuilder.RenameColumn(
                name: "WydarzenieFKID",
                table: "Oceny_Uzytkownikow",
                newName: "id_wydarzeniaFKID");

            migrationBuilder.RenameColumn(
                name: "UzytkownicyFKID",
                table: "Oceny_Uzytkownikow",
                newName: "id_uzytkownikaFKID");

            migrationBuilder.RenameIndex(
                name: "IX_Oceny_Uzytkownikow_WydarzenieFKID",
                table: "Oceny_Uzytkownikow",
                newName: "IX_Oceny_Uzytkownikow_id_wydarzeniaFKID");

            migrationBuilder.RenameIndex(
                name: "IX_Oceny_Uzytkownikow_UzytkownicyFKID",
                table: "Oceny_Uzytkownikow",
                newName: "IX_Oceny_Uzytkownikow_id_uzytkownikaFKID");

            migrationBuilder.AddForeignKey(
                name: "FK_Oceny_Uzytkownikow_Uzytkownicy_id_uzytkownikaFKID",
                table: "Oceny_Uzytkownikow",
                column: "id_uzytkownikaFKID",
                principalTable: "Uzytkownicy",
                principalColumn: "id_uzytkownika");

            migrationBuilder.AddForeignKey(
                name: "FK_Oceny_Uzytkownikow_Wydarzenie_id_wydarzeniaFKID",
                table: "Oceny_Uzytkownikow",
                column: "id_wydarzeniaFKID",
                principalTable: "Wydarzenie",
                principalColumn: "id_wydarzenia");

            migrationBuilder.AddForeignKey(
                name: "FK_Organizatorzy_Tabela_Kont_id_kontaFKID",
                table: "Organizatorzy",
                column: "id_kontaFKID",
                principalTable: "Tabela_Kont",
                principalColumn: "id_konta");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezerwacje_Uzytkownicy_id_uzytkownikaFKID",
                table: "Rezerwacje",
                column: "id_uzytkownikaFKID",
                principalTable: "Uzytkownicy",
                principalColumn: "id_uzytkownika");

            migrationBuilder.AddForeignKey(
                name: "FK_Uzytkownicy_Tabela_Kont_id_kontaFKID",
                table: "Uzytkownicy",
                column: "id_kontaFKID",
                principalTable: "Tabela_Kont",
                principalColumn: "id_konta");

            migrationBuilder.AddForeignKey(
                name: "FK_Wydarzenie_Kategorie_id_kategoriiFKID",
                table: "Wydarzenie",
                column: "id_kategoriiFKID",
                principalTable: "Kategorie",
                principalColumn: "id_kategorii");

            migrationBuilder.AddForeignKey(
                name: "FK_Wydarzenie_Organizatorzy_id_organizatoraFKID",
                table: "Wydarzenie",
                column: "id_organizatoraFKID",
                principalTable: "Organizatorzy",
                principalColumn: "id_organizatora");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oceny_Uzytkownikow_Uzytkownicy_id_uzytkownikaFKID",
                table: "Oceny_Uzytkownikow");

            migrationBuilder.DropForeignKey(
                name: "FK_Oceny_Uzytkownikow_Wydarzenie_id_wydarzeniaFKID",
                table: "Oceny_Uzytkownikow");

            migrationBuilder.DropForeignKey(
                name: "FK_Organizatorzy_Tabela_Kont_id_kontaFKID",
                table: "Organizatorzy");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezerwacje_Uzytkownicy_id_uzytkownikaFKID",
                table: "Rezerwacje");

            migrationBuilder.DropForeignKey(
                name: "FK_Uzytkownicy_Tabela_Kont_id_kontaFKID",
                table: "Uzytkownicy");

            migrationBuilder.DropForeignKey(
                name: "FK_Wydarzenie_Kategorie_id_kategoriiFKID",
                table: "Wydarzenie");

            migrationBuilder.DropForeignKey(
                name: "FK_Wydarzenie_Organizatorzy_id_organizatoraFKID",
                table: "Wydarzenie");

            migrationBuilder.RenameColumn(
                name: "id_organizatoraFKID",
                table: "Wydarzenie",
                newName: "OrganizatorzyFKID");

            migrationBuilder.RenameColumn(
                name: "id_kategoriiFKID",
                table: "Wydarzenie",
                newName: "KategorieFKID");

            migrationBuilder.RenameIndex(
                name: "IX_Wydarzenie_id_organizatoraFKID",
                table: "Wydarzenie",
                newName: "IX_Wydarzenie_OrganizatorzyFKID");

            migrationBuilder.RenameIndex(
                name: "IX_Wydarzenie_id_kategoriiFKID",
                table: "Wydarzenie",
                newName: "IX_Wydarzenie_KategorieFKID");

            migrationBuilder.RenameColumn(
                name: "id_kontaFKID",
                table: "Uzytkownicy",
                newName: "Tabela_KontFKID");

            migrationBuilder.RenameIndex(
                name: "IX_Uzytkownicy_id_kontaFKID",
                table: "Uzytkownicy",
                newName: "IX_Uzytkownicy_Tabela_KontFKID");

            migrationBuilder.RenameColumn(
                name: "id_uzytkownikaFKID",
                table: "Rezerwacje",
                newName: "id_urzytkownikaFKID");

            migrationBuilder.RenameIndex(
                name: "IX_Rezerwacje_id_uzytkownikaFKID",
                table: "Rezerwacje",
                newName: "IX_Rezerwacje_id_urzytkownikaFKID");

            migrationBuilder.RenameColumn(
                name: "id_kontaFKID",
                table: "Organizatorzy",
                newName: "Tabela_KontFKID");

            migrationBuilder.RenameIndex(
                name: "IX_Organizatorzy_id_kontaFKID",
                table: "Organizatorzy",
                newName: "IX_Organizatorzy_Tabela_KontFKID");

            migrationBuilder.RenameColumn(
                name: "id_wydarzeniaFKID",
                table: "Oceny_Uzytkownikow",
                newName: "WydarzenieFKID");

            migrationBuilder.RenameColumn(
                name: "id_uzytkownikaFKID",
                table: "Oceny_Uzytkownikow",
                newName: "UzytkownicyFKID");

            migrationBuilder.RenameIndex(
                name: "IX_Oceny_Uzytkownikow_id_wydarzeniaFKID",
                table: "Oceny_Uzytkownikow",
                newName: "IX_Oceny_Uzytkownikow_WydarzenieFKID");

            migrationBuilder.RenameIndex(
                name: "IX_Oceny_Uzytkownikow_id_uzytkownikaFKID",
                table: "Oceny_Uzytkownikow",
                newName: "IX_Oceny_Uzytkownikow_UzytkownicyFKID");

            migrationBuilder.AddForeignKey(
                name: "FK_Oceny_Uzytkownikow_Uzytkownicy_UzytkownicyFKID",
                table: "Oceny_Uzytkownikow",
                column: "UzytkownicyFKID",
                principalTable: "Uzytkownicy",
                principalColumn: "id_uzytkownika");

            migrationBuilder.AddForeignKey(
                name: "FK_Oceny_Uzytkownikow_Wydarzenie_WydarzenieFKID",
                table: "Oceny_Uzytkownikow",
                column: "WydarzenieFKID",
                principalTable: "Wydarzenie",
                principalColumn: "id_wydarzenia");

            migrationBuilder.AddForeignKey(
                name: "FK_Organizatorzy_Tabela_Kont_Tabela_KontFKID",
                table: "Organizatorzy",
                column: "Tabela_KontFKID",
                principalTable: "Tabela_Kont",
                principalColumn: "id_konta");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezerwacje_Uzytkownicy_id_urzytkownikaFKID",
                table: "Rezerwacje",
                column: "id_urzytkownikaFKID",
                principalTable: "Uzytkownicy",
                principalColumn: "id_uzytkownika");

            migrationBuilder.AddForeignKey(
                name: "FK_Uzytkownicy_Tabela_Kont_Tabela_KontFKID",
                table: "Uzytkownicy",
                column: "Tabela_KontFKID",
                principalTable: "Tabela_Kont",
                principalColumn: "id_konta");

            migrationBuilder.AddForeignKey(
                name: "FK_Wydarzenie_Kategorie_KategorieFKID",
                table: "Wydarzenie",
                column: "KategorieFKID",
                principalTable: "Kategorie",
                principalColumn: "id_kategorii");

            migrationBuilder.AddForeignKey(
                name: "FK_Wydarzenie_Organizatorzy_OrganizatorzyFKID",
                table: "Wydarzenie",
                column: "OrganizatorzyFKID",
                principalTable: "Organizatorzy",
                principalColumn: "id_organizatora");
        }
    }
}
