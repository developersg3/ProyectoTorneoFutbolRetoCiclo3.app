using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolRetoCiclo3.App.Dominio;
using TorneoFutbolRetoCiclo3.App.Persistencia;

namespace TorneoFutbolRetoCiclo3.App.Frontend.Pages.Municipios
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioMunicipio _repoMunicipio;
        public Municipio municipio {get; set;}
        public DetailsModel(IRepositorioMunicipio repoMunicipio)
        {
            _repoMunicipio = repoMunicipio;
        }
        public IActionResult OnGet(int id)
        {
            municipio = _repoMunicipio.GetMunicipio(id);
            if(municipio == null)
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
