using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolRetoCiclo3.App.Dominio;
using TorneoFutbolRetoCiclo3.App.Persistencia;

namespace TorneoFutbolRetoCiclo3.App.Frontend.Pages.Novedades
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioNovedad _repoNovedad;
        public Novedad novedad {get; set;}
        public CreateModel(IRepositorioNovedad repoNovedad)
        {
            _repoNovedad = repoNovedad;
        }
        public void OnGet()
        {
            novedad = new Novedad();
        }

        public IActionResult OnPost(Novedad novedad)
        {
            if (ModelState.IsValid)
            {
                _repoNovedad.AddNovedad(novedad);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
