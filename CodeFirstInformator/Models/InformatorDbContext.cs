using Microsoft.EntityFrameworkCore;

namespace CodeFirstInformator.Models;
public class InformatorDbContext : DbContext{
    public InformatorDbContext() { }
    public InformatorDbContext(DbContextOptions<InformatorDbContext> options)
        : base(options) { 
    
    }


    //dbset to tabele ktore beda odpowieadac w bazie dancyh (można wykonywać operacje CRUD dzieki temu)

    public virtual DbSet<Wydarzenie> Wydarzenie { get; set; }
    public virtual DbSet<Rezerwacje> Rezerwacje { get; set; }
    public virtual DbSet<Uzytkownicy> Uzytkownicy { get; set; }
    public virtual DbSet<Wydarzenie> Tabela_Kont { get; set; }
    public virtual DbSet<Rezerwacje> Organizatorzy { get; set; }
    public virtual DbSet<Uzytkownicy> Kategorie { get; set; }
    public virtual DbSet<Wydarzenie> Oceny_Uzytkownikow { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlServer("" +
            "Data Source=(localdb)\\LocalServer;" +
            "Database=InformatorDB;"+
            "Trusted_Connection=True;"+
            "TrustServerCertificate=True;");
    }

    //konfiguracja relacji wiele do wiele jak by byla potrzebna
    //N..N (FlightLog - Airport)
    //protected override void OnModelCreating(ModelBuilder modelBuilder) {
    //    modelBuilder.Entity<FlightLog>().HasMany(e => e.Airports).WithMany(e => e.FlightLogs);
    //}
}
