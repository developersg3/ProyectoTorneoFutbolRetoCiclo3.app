using System;
using System.Collections.Generic;
using TorneoFutbolRetoCiclo3.App.Dominio;
using TorneoFutbolRetoCiclo3.App.Persistencia;

namespace TorneoFutbolRetoCiclo3.App.Consola
{
    class Program
    {
        private static IRepositorioArbitro _repoArbitro = new RepositorioArbitro();
        //private static IRepositorioEquipo _repoEquipo = new RepositorioEquipo();
        //private static IRepositorioDesempeno_equipo _repoDesempeno_equipo = new RepositorioDesempeno_equipo();
        //private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioTipo_novedad _repoTipo_novedad = new RepositorioTipo_novedad();
        //private static IRepositorioEstadio _repoEstadio = new RepositorioEstadio();
        //private static IRepositorioPosicion_jugador _repoPosicion_jugador = new RepositorioPosicion_jugador();
        //private static IRepositorioTecnico _repoTecnico = new RepositorioTecnico();
        //private static IRepositorioJugador _repoJugador = new RepositorioJugador();
        //private static IRepositorioPartido _repoPartido = new RepositorioPartido();
        private static IRepositorioNovedad _repoNovedad = new RepositorioNovedad();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
