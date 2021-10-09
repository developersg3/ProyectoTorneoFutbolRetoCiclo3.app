using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolRetoCiclo3.App.Dominio;
using TorneoFutbolRetoCiclo3.App.Persistencia;

namespace TorneoFutbolRetoCiclo3.App.Frontend.Pages.Jugadores
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioJugador _repoJugador;
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioPosicion_jugador _repoPosJugador;

        public IEnumerable<Jugador> jugadores {get; set;}
        public IEnumerable <Equipo> equipos {get;set;}
        public IEnumerable <Posicion_jugador> PosJugadores {get; set;}

        public IndexModel(IRepositorioJugador repoJugador, IRepositorioEquipo repoEquipo, IRepositorioPosicion_jugador repoPosicion_jugador)
        {
            _repoJugador = repoJugador;
            _repoEquipo = repoEquipo;
            _repoPosJugador = repoPosicion_jugador;
        }

        public void OnGet()
        {
            jugadores = _repoJugador.GetAllJugadores();
            equipos = _repoEquipo.GetAllEquipos();
            PosJugadores = _repoPosJugador.GetAllPosicion_jugadores();
        }
    }
}
