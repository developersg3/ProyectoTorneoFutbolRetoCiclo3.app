using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolRetoCiclo3.App.Dominio;
using TorneoFutbolRetoCiclo3.App.Persistencia;

namespace TorneoFutbolRetoCiclo3.App.Frontend.Pages.Arbitros
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioArbitro _repoArbitro;
        public IEnumerable<Arbitro> arbitros {get; set;}
        public string nombre_arbitroActual{get; set;}

        public IndexModel(IRepositorioArbitro repoArbitro)
        {
            _repoArbitro = repoArbitro;
        }


        public void OnGet(string nombre_arbitro)
        {
            if(String.IsNullOrEmpty(nombre_arbitro))
            {
                nombre_arbitroActual = "";
                arbitros = _repoArbitro.GetAllArbitros();
            }
            else
            {
                nombre_arbitroActual = nombre_arbitro;
                arbitros = _repoArbitro.SearchArbitros(nombre_arbitro);
            }
        }

    }
}
