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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDesempeno_equipo _repoDesempeno_equipo;
        public Desempeno_equipo desempeno_equipo {get; set;}
        
        public CreateModel(IRepositorioDesempeno_equipo repoDesempeno_equipo)
        {
            _repoDesempeno_equipo = repoDesempeno_equipo;
        }
        public void OnGet()
        {
            desempeno_equipo = new Desempeno_equipo();
        }

        public IActionResult OnPost(Desempeno_equipo desempeno_equipo)
        {
            if (ModelState.IsValid)
            {
                _repoDesempeno_equipo.AddDesempeno_equipo(desempeno_equipo);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
