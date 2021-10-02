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
    public class EditModel : PageModel
    {
        private readonly IRepositorioPosicion_jugador _repoPosicion_jugador;
        public Posicion_jugador posicion_jugador {get; set;}
        public EditModel(IRepositorioPosicion_jugador repoPosicion_jugador)
        {
            _repoPosicion_jugador = repoPosicion_jugador;
        }

        public IActionResult OnGet(int id)
        {
            posicion_jugador = _repoPosicion_jugador.GetPosicion_jugador(id);
            if(posicion_jugador == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(Posicion_jugador posicion_jugador)
        {
            _repoPosicion_jugador.UpdatePosicion_jugador(posicion_jugador);
            return RedirectToPage("Index");
        }
    }
}
