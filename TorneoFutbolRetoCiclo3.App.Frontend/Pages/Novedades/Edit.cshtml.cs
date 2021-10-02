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
    public class EditModel : PageModel
    {
        private readonly IRepositorioNovedad _repoNovedad;
        public Novedad novedad {get; set;}
        public EditModel(IRepositorioNovedad repoNovedad)
        {
            _repoNovedad = repoNovedad;
        }

        public IActionResult OnGet(int id)
        {
            novedad = _repoNovedad.GetNovedad(id);
            if(novedad == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(Novedad novedad)
        {
            _repoNovedad.UpdateNovedad(novedad);
            return RedirectToPage("Index");
        }
    }
}
