using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolRetoCiclo3.App.Dominio;
using TorneoFutbolRetoCiclo3.App.Persistencia;

namespace TorneoFutbolRetoCiclo3.App.Frontend.Pages.Estadios
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioEstadio _repoEstadio;
        private readonly IRepositorioMunicipio _repoMunicipio;
        public Estadio estadio {get; set;}
        public IEnumerable<Municipio> municipios {get; set;}
        
        //public CreateModel(IRepositorioEstadio repoEstadio, IRepositorioMunicipio repoMunicipio)
        public CreateModel(IRepositorioEstadio repoEstadio, IRepositorioMunicipio repoMunicipio)
        {
            _repoEstadio = repoEstadio;
            _repoMunicipio = repoMunicipio;
        }
        public void OnGet()
        {
            estadio = new Estadio();
            municipios = _repoMunicipio.GetAllMunicipios();
        }

        public IActionResult OnPost(Estadio estadio)
        {
            if (ModelState.IsValid)
            {
                _repoEstadio.AddEstadio(estadio);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
