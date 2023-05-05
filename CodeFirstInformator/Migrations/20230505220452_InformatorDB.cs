using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstInformator.Migrations
{
    /// <inheritdoc />
    public partial class InformatorDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorie",
                columns: table => new
                {
                    id_kategorii = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa_kategorii = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorie", x => x.id_kategorii);
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Kont",
                columns: table => new
                {
                    id_konta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    haslo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    adres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Kont", x => x.id_konta);
                });

            migrationBuilder.CreateTable(
                name: "Organizatorzy",
                columns: table => new
                {
                    id_organizatora = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa_organizatora = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tabela_KontFKID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizatorzy", x => x.id_organizatora);
                    table.ForeignKey(
                        name: "FK_Organizatorzy_Tabela_Kont_Tabela_KontFKID",
                        column: x => x.Tabela_KontFKID,
                        principalTable: "Tabela_Kont",
                        principalColumn: "id_konta");
                });

            migrationBuilder.CreateTable(
                name: "Uzytkownicy",
                columns: table => new
                {
                    id_uzytkownika = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imie = table.Column<int>(type: "int", maxLength: 1019, nullable: false),
                    nazwisko = table.Column<int>(type: "int", maxLength: 51, nullable: false),
                    Tabela_KontFKID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzytkownicy", x => x.id_uzytkownika);
                    table.ForeignKey(
                        name: "FK_Uzytkownicy_Tabela_Kont_Tabela_KontFKID",
                        column: x => x.Tabela_KontFKID,
                        principalTable: "Tabela_Kont",
                        principalColumn: "id_konta");
                });

            migrationBuilder.CreateTable(
                name: "Wydarzenie",
                columns: table => new
                {
                    id_wydarzenia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa_wydarzenia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    opis = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    data_i_godzina_rozpoczecia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_i_godzina_zakonczenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KategorieFKID = table.Column<int>(type: "int", nullable: true),
                    OrganizatorzyFKID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wydarzenie", x => x.id_wydarzenia);
                    table.ForeignKey(
                        name: "FK_Wydarzenie_Kategorie_KategorieFKID",
                        column: x => x.KategorieFKID,
                        principalTable: "Kategorie",
                        principalColumn: "id_kategorii");
                    table.ForeignKey(
                        name: "FK_Wydarzenie_Organizatorzy_OrganizatorzyFKID",
                        column: x => x.OrganizatorzyFKID,
                        principalTable: "Organizatorzy",
                        principalColumn: "id_organizatora");
                });

            migrationBuilder.CreateTable(
                name: "Oceny_Uzytkownikow",
                columns: table => new
                {
                    id_oceny = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ocena = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    UzytkownicyFKID = table.Column<int>(type: "int", nullable: true),
                    WydarzenieFKID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oceny_Uzytkownikow", x => x.id_oceny);
                    table.ForeignKey(
                        name: "FK_Oceny_Uzytkownikow_Uzytkownicy_UzytkownicyFKID",
                        column: x => x.UzytkownicyFKID,
                        principalTable: "Uzytkownicy",
                        principalColumn: "id_uzytkownika");
                    table.ForeignKey(
                        name: "FK_Oceny_Uzytkownikow_Wydarzenie_WydarzenieFKID",
                        column: x => x.WydarzenieFKID,
                        principalTable: "Wydarzenie",
                        principalColumn: "id_wydarzenia");
                });

            migrationBuilder.CreateTable(
                name: "Rezerwacje",
                columns: table => new
                {
                    id_rezerwacji = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ilosc_miejsc = table.Column<int>(type: "int", maxLength: 100000, nullable: false),
                    id_wydarzeniaFKID = table.Column<int>(type: "int", nullable: false),
                    id_urzytkownikaFKID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezerwacje", x => x.id_rezerwacji);
                    table.ForeignKey(
                        name: "FK_Rezerwacje_Uzytkownicy_id_urzytkownikaFKID",
                        column: x => x.id_urzytkownikaFKID,
                        principalTable: "Uzytkownicy",
                        principalColumn: "id_uzytkownika");
                    table.ForeignKey(
                        name: "FK_Rezerwacje_Wydarzenie_id_wydarzeniaFKID",
                        column: x => x.id_wydarzeniaFKID,
                        principalTable: "Wydarzenie",
                        principalColumn: "id_wydarzenia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oceny_Uzytkownikow_UzytkownicyFKID",
                table: "Oceny_Uzytkownikow",
                column: "UzytkownicyFKID");

            migrationBuilder.CreateIndex(
                name: "IX_Oceny_Uzytkownikow_WydarzenieFKID",
                table: "Oceny_Uzytkownikow",
                column: "WydarzenieFKID");

            migrationBuilder.CreateIndex(
                name: "IX_Organizatorzy_Tabela_KontFKID",
                table: "Organizatorzy",
                column: "Tabela_KontFKID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezerwacje_id_urzytkownikaFKID",
                table: "Rezerwacje",
                column: "id_urzytkownikaFKID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezerwacje_id_wydarzeniaFKID",
                table: "Rezerwacje",
                column: "id_wydarzeniaFKID");

            migrationBuilder.CreateIndex(
                name: "IX_Uzytkownicy_Tabela_KontFKID",
                table: "Uzytkownicy",
                column: "Tabela_KontFKID");

            migrationBuilder.CreateIndex(
                name: "IX_Wydarzenie_KategorieFKID",
                table: "Wydarzenie",
                column: "KategorieFKID");

            migrationBuilder.CreateIndex(
                name: "IX_Wydarzenie_OrganizatorzyFKID",
                table: "Wydarzenie",
                column: "OrganizatorzyFKID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oceny_Uzytkownikow");

            migrationBuilder.DropTable(
                name: "Rezerwacje");

            migrationBuilder.DropTable(
                name: "Uzytkownicy");

            migrationBuilder.DropTable(
                name: "Wydarzenie");

            migrationBuilder.DropTable(
                name: "Kategorie");

            migrationBuilder.DropTable(
                name: "Organizatorzy");

            migrationBuilder.DropTable(
                name: "Tabela_Kont");
        }
    }
}
