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
        public Equipo equipo {get;set;}
        public Posicion_jugador PosJugador {get; set;}

        public IndexModel(IRepositorioJugador repoJugador, IRepositorioEquipo repoEquipo, IRepositorioPosicion_jugador repoPosicion_jugador)
        {
            _repoJugador = repoJugador;
            _repoEquipo = repoEquipo;
            _repoPosJugador = repoPosicion_jugador;
        }

        public void OnGet()
        {
            jugadores = _repoJugador.GetAllJugadores();
            foreach (var player in jugadores)
            {
                equipo = _repoEquipo.GetEquipo(player.EquipoId);
                PosJugador = _repoPosJugador.GetPosicion_jugador(player.Posicion_jugadorId);
            }
        }
    }
}
