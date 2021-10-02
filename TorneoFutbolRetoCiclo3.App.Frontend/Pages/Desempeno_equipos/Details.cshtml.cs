using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolRetoCiclo3.App.Dominio;
using TorneoFutbolRetoCiclo3.App.Persistencia;

namespace TorneoFutbolRetoCiclo3.App.Frontend.Pages.Desempeno_equipos
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioDesempeno_equipo _repoDesempeno_equipo;
        public Desempeno_equipo desempeno_equipo {get; set;}
        public DetailsModel(IRepositorioDesempeno_equipo repoDesempeno_equipo)
        {
            _repoDesempeno_equipo = repoDesempeno_equipo;
        }
        public IActionResult OnGet(int id)
        {
            desempeno_equipo = _repoDesempeno_equipo.GetDesempeno_equipo(id);
            if(desempeno_equipo == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
