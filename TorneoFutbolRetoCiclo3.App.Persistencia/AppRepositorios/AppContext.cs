using Microsoft.EntityFrameworkCore;
using TorneoFutbolRetoCiclo3.App.Dominio;
namespace TorneoFutbolRetoCiclo3.App.Persistencia
{
  public class AppContext : DbContext
  {
    public DbSet<Arbitro> Arbitros { get; set; }
    public DbSet<Desempeno_equipo> Desempeno_equipos { get; set; }
    public DbSet<Equipo> Equipos { get; set; }
    public DbSet<Estadio> Estadios { get; set; }
    public DbSet<Jugador> Jugadores { get; set; }
    public DbSet<Municipio> Municipios { get; set; }
    public DbSet<Partido> Partidos { get; set; }
    public DbSet<Tecnico> Tecnicos { get; set; }
    public DbSet<Tipo_novedad> Tipo_novedades { get; set; }
    public DbSet<Novedad> Novedades { get; set; }
    public DbSet<Posicion_jugador> Posicion_jugadores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseSqlServer("server=127.0.0.1; user=sa; password=Administrator123; Initial Catalog=Reto");
        //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TorneoFutbolPrueba");
      }
    }
  }
}
