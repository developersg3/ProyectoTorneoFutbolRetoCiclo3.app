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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDesempeno_equipo _repoDesempeno_equipo;
        public IEnumerable<Desempeno_equipo> desempeno_equipos {get; set;}

        public IndexModel(IRepositorioDesempeno_equipo repoDesempeno_equipo)
        {
            _repoDesempeno_equipo = repoDesempeno_equipo;
        }

        public void OnGet()
        {
            desempeno_equipos = _repoDesempeno_equipo.GetAllDesempeno_equipos();
        }
    }
}
