# EFCFInformator
Tworzenie aplikacji bazodanowej z użyciem podejścia Code First

Tworzenie Bazy danych metodą CodeFirst uzywając EntityFramework Core, Baza danych która miała zostać wygenerowana za pomocą programu w c# posiada 7 tabel (Wydarzenie, Kategorie, Organizatorzy, Oceny_Uzytkownikow, Tabela_Kont, Uzytkownicy, Rezerwacje) w której są tylko relacje 1...N. Przedstawiona baza danych to Informator Kultularny który jest czwartym etapem w projekcie na przedmiot Bazy Danych. 

Schemat bazy danych:
https://app.quickdatabasediagrams.com/#/d/8NH613

W programie zostały zdefiniowane wszystkie potrzebne więzy.
Aby aplikacja zadziałała poprawnie trzeba pamiętać aby odpowiednio zmienić ConnectionString który jest zdefiniowany w DbContext.
