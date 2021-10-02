using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolRetoCiclo3.App.Dominio;
using TorneoFutbolRetoCiclo3.App.Persistencia;

namespace TorneoFutbolRetoCiclo3.App.Frontend.Pages.Tipo_novedades
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioTipo_novedad _repoTipo_novedad;
        public Tipo_novedad tipo_novedad {get; set;}
        public CreateModel(IRepositorioTipo_novedad repoTipo_novedad)
        {
            _repoTipo_novedad = repoTipo_novedad;
        }
        public void OnGet()
        {
            tipo_novedad = new Tipo_novedad();
        }

        public IActionResult OnPost(Tipo_novedad tipo_novedad)
        {
            if (ModelState.IsValid)
            {
                _repoTipo_novedad.AddTipo_novedad(tipo_novedad);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
