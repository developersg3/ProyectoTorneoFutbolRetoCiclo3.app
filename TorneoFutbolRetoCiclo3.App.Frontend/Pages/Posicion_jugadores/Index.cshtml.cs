using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolRetoCiclo3.App.Dominio;
using TorneoFutbolRetoCiclo3.App.Persistencia;

namespace TorneoFutbolRetoCiclo3.App.Frontend.Pages.Posicion_jugadores
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPosicion_jugador _repoPosicion_jugador;
        public IEnumerable<Posicion_jugador> posicion_jugadores {get; set;}

        public IndexModel(IRepositorioPosicion_jugador repoPosicion_jugador)
        {
            _repoPosicion_jugador = repoPosicion_jugador;
        }

        public void OnGet()
        {
            posicion_jugadores = _repoPosicion_jugador.GetAllPosicion_jugadores();
        }
    }
}
