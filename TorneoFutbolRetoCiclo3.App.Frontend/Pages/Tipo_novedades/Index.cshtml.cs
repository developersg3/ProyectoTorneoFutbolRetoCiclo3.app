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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioTipo_novedad _repoTipo_novedad;
        public IEnumerable<Tipo_novedad> tipo_novedades {get; set;}

        public IndexModel(IRepositorioTipo_novedad repoTipo_novedad)
        {
            _repoTipo_novedad = repoTipo_novedad;
        }

        public void OnGet()
        {
            tipo_novedades = _repoTipo_novedad.GetAllTipo_novedades();
        }
    }
}
