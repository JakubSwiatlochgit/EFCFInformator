﻿// <auto-generated />
using System;
using CodeFirstInformator.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirstInformator.Migrations
{
    [DbContext(typeof(InformatorDbContext))]
    [Migration("20230505220452_InformatorDB")]
    partial class InformatorDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodeFirstInformator.Models.Kategorie", b =>
                {
                    b.Property<int>("FKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_kategorii");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FKID"));

                    b.Property<string>("nazwa_kategorii")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FKID");

                    b.ToTable("Kategorie");
                });

            modelBuilder.Entity("CodeFirstInformator.Models.Oceny_Uzytkownikow", b =>
                {
                    b.Property<int>("FKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_oceny");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FKID"));

                    b.Property<int?>("UzytkownicyFKID")
                        .HasColumnType("int");

                    b.Property<int?>("WydarzenieFKID")
                        .HasColumnType("int");

                    b.Property<int>("ocena")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.HasKey("FKID");

                    b.HasIndex("UzytkownicyFKID");

                    b.HasIndex("WydarzenieFKID");

                    b.ToTable("Oceny_Uzytkownikow");
                });

            modelBuilder.Entity("CodeFirstInformator.Models.Organizatorzy", b =>
                {
                    b.Property<int>("FKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_organizatora");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FKID"));

                    b.Property<int?>("Tabela_KontFKID")
                        .HasColumnType("int");

                    b.Property<string>("nazwa_organizatora")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FKID");

                    b.HasIndex("Tabela_KontFKID");

                    b.ToTable("Organizatorzy");
                });

            modelBuilder.Entity("CodeFirstInformator.Models.Rezerwacje", b =>
                {
                    b.Property<int>("FKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_rezerwacji");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FKID"));

                    b.Property<int?>("id_urzytkownikaFKID")
                        .HasColumnType("int");

                    b.Property<int>("id_wydarzeniaFKID")
                        .HasColumnType("int");

                    b.Property<int>("ilosc_miejsc")
                        .HasMaxLength(100000)
                        .HasColumnType("int");

                    b.HasKey("FKID");

                    b.HasIndex("id_urzytkownikaFKID");

                    b.HasIndex("id_wydarzeniaFKID");

                    b.ToTable("Rezerwacje");
                });

            modelBuilder.Entity("CodeFirstInformator.Models.Tabela_Kont", b =>
                {
                    b.Property<int>("FKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_konta");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FKID"));

                    b.Property<string>("adres")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("haslo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FKID");

                    b.ToTable("Tabela_Kont");
                });

            modelBuilder.Entity("CodeFirstInformator.Models.Uzytkownicy", b =>
                {
                    b.Property<int>("FKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_uzytkownika");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FKID"));

                    b.Property<int?>("Tabela_KontFKID")
                        .HasColumnType("int");

                    b.Property<int>("imie")
                        .HasMaxLength(1019)
                        .HasColumnType("int");

                    b.Property<int>("nazwisko")
                        .HasMaxLength(51)
                        .HasColumnType("int");

                    b.HasKey("FKID");

                    b.HasIndex("Tabela_KontFKID");

                    b.ToTable("Uzytkownicy");
                });

            modelBuilder.Entity("CodeFirstInformator.Models.Wydarzenie", b =>
                {
                    b.Property<int>("FKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_wydarzenia");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FKID"));

                    b.Property<int?>("KategorieFKID")
                        .HasColumnType("int");

                    b.Property<int?>("OrganizatorzyFKID")
                        .HasColumnType("int");

                    b.Property<DateTime>("data_i_godzina_rozpoczecia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("data_i_godzina_zakonczenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("nazwa_wydarzenia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("opis")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("FKID");

                    b.HasIndex("KategorieFKID");

                    b.HasIndex("OrganizatorzyFKID");

                    b.ToTable("Wydarzenie");
                });

            modelBuilder.Entity("CodeFirstInformator.Models.Oceny_Uzytkownikow", b =>
                {
                    b.HasOne("CodeFirstInformator.Models.Uzytkownicy", "Uzytkownicy")
                        .WithMany("Oceny_Uzytkownikow")
                        .HasForeignKey("UzytkownicyFKID");

                    b.HasOne("CodeFirstInformator.Models.Wydarzenie", "Wydarzenie")
                        .WithMany("Oceny_Uzytkownikow")
                        .HasForeignKey("WydarzenieFKID");

                    b.Navigation("Uzytkownicy");

                    b.Navigation("Wydarzenie");
                });

            modelBuilder.Entity("CodeFirstInformator.Models.Organizatorzy", b =>
                {
                    b.HasOne("CodeFirstInformator.Models.Tabela_Kont", "Tabela_Kont")
                        .WithMany("Organizatorzy")
                        .HasForeignKey("Tabela_KontFKID");

                    b.Navigation("Tabela_Kont");
                });

            modelBuilder.Entity("CodeFirstInformator.Models.Rezerwacje", b =>
                {
                    b.HasOne("CodeFirstInformator.Models.Uzytkownicy", "id_urzytkownika")
                        .WithMany("Rezerwacje")
                        .HasForeignKey("id_urzytkownikaFKID");

                    b.HasOne("CodeFirstInformator.Models.Wydarzenie", "id_wydarzenia")
                        .WithMany("Rezerwacje")
                        .HasForeignKey("id_wydarzeniaFKID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("id_urzytkownika");

                    b.Navigation("id_wydarzenia");
                });

            modelBuilder.Entity("CodeFirstInformator.Models.Uzytkownicy", b =>
                {
                    b.HasOne("CodeFirstInformator.Models.Tabela_Kont", "Tabela_Kont")
                        .WithMany("Uzytkownicy")
                        .HasForeignKey("Tabela_KontFKID");

                    b.Navigation("Tabela_Kont");
                });

            modelBuilder.Entity("CodeFirstInformator.Models.Wydarzenie", b =>
                {
                    b.HasOne("CodeFirstInformator.Models.Kategorie", "Kategorie")
                        .WithMany("Wydarzenie")
                        .HasForeignKey("KategorieFKID");

                    b.HasOne("CodeFirstInformator.Models.Organizatorzy", "Organizatorzy")
                        .WithMany("Wydarzenie")
                        .HasForeignKey("OrganizatorzyFKID");

                    b.Navigation("Kategorie");

                    b.Navigation("Organizatorzy");
                });

            modelBuilder.Entity("CodeFirstInformator.Models.Kategorie", b =>
                {
                    b.Navigation("Wydarzenie");
                });

            modelBuilder.Entity("CodeFirstInformator.Models.Organizatorzy", b =>
                {
                    b.Navigation("Wydarzenie");
                });

            modelBuilder.Entity("CodeFirstInformator.Models.Tabela_Kont", b =>
                {
                    b.Navigation("Organizatorzy");

                    b.Navigation("Uzytkownicy");
                });

            modelBuilder.Entity("CodeFirstInformator.Models.Uzytkownicy", b =>
                {
                    b.Navigation("Oceny_Uzytkownikow");

                    b.Navigation("Rezerwacje");
                });

            modelBuilder.Entity("CodeFirstInformator.Models.Wydarzenie", b =>
                {
                    b.Navigation("Oceny_Uzytkownikow");

                    b.Navigation("Rezerwacje");
                });
#pragma warning restore 612, 618
        }
    }
}
