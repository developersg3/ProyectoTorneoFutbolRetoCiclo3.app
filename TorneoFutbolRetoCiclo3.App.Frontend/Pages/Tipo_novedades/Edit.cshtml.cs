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
    public class EditModel : PageModel
    {
        private readonly IRepositorioTipo_novedad _repoTipo_novedad;
        public Tipo_novedad tipo_novedad {get; set;}
        public EditModel(IRepositorioTipo_novedad repoTipo_novedad)
        {
            _repoTipo_novedad = repoTipo_novedad;
        }

        public IActionResult OnGet(int id)
        {
            tipo_novedad = _repoTipo_novedad.GetTipo_novedad(id);
            if(tipo_novedad == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(Tipo_novedad tipo_novedad)
        {
            _repoTipo_novedad.UpdateTipo_novedad(tipo_novedad);
            return RedirectToPage("Index");
        }
    }
}
