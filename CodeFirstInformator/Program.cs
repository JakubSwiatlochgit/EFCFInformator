using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CodeFirstInformator.Models;

namespace CodeFirstInformator
{
    class Program
    {
        static void Main(string[] args)
        {


            using (var context = new InformatorDbContext())
            {
                //insert, utworzenie nowego wydarzenia
                var noweWydarzenie = new Wydarzenie
                {
                    nazwa_wydarzenia = "Przykładowe wydarzenie2",
                    opis = "To jest przykładowe wydarzenie2",
                    data_i_godzina_rozpoczecia = DateTime.Now,
                    data_i_godzina_zakonczenia = DateTime.Now.AddHours(2)
                };

                // dodanie tego wydarzenia do bazy danych
                context.Wydarzenie.Add(noweWydarzenie);
                context.SaveChanges();

                // pobranie wszystkich wydarzeni
                var wydarzenia = context.Wydarzenie.ToList();

                // wsywietlenie nazwy wydarzen
                foreach (var wydarzenie in wydarzenia)
                {
                    Console.WriteLine(wydarzenie.nazwa_wydarzenia);
                }
            }
        }
    }
}