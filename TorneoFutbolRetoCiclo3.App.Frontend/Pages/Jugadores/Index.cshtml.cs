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
        public IEnumerable<Jugador> jugadores {get; set;}
        public Equipo equipo {get;set;}

        public IndexModel(IRepositorioJugador repoJugador, IRepositorioEquipo repoEquipo)
        {
            _repoJugador = repoJugador;
            _repoEquipo = repoEquipo;
        }

        public void OnGet()
        {
            jugadores = _repoJugador.GetAllJugadores();
            foreach (var player in jugadores)
            {
             equipo = _repoEquipo.GetEquipo(player.EquipoId);   
            }
        }
    }
}
