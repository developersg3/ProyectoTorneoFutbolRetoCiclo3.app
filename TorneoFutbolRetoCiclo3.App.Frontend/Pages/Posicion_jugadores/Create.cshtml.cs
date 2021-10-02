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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioPosicion_jugador _repoPosicion_jugador;
        public Posicion_jugador posicion_jugador {get; set;}
        public CreateModel(IRepositorioPosicion_jugador repoPosicion_jugador)
        {
            _repoPosicion_jugador = repoPosicion_jugador;
        }
        public void OnGet()
        {
            posicion_jugador = new Posicion_jugador();
        }

        public IActionResult OnPost(Posicion_jugador posicion_jugador)
        {
            if (ModelState.IsValid)
            {
                _repoPosicion_jugador.AddPosicion_jugador(posicion_jugador);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
