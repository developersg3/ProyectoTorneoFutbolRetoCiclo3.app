using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolRetoCiclo3.App.Dominio;
using TorneoFutbolRetoCiclo3.App.Persistencia;

namespace TorneoFutbolRetoCiclo3.App.Frontend.Pages.Tecnicos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioTecnico _repoTecnico;
        public IEnumerable<Tecnico> tecnicos {get; set;}

        public IndexModel(IRepositorioTecnico repoTecnico)
        {
            _repoTecnico = repoTecnico;
        }

        public void OnGet()
        {
            tecnicos = _repoTecnico.GetAllTecnicos();
        }
    }
}
