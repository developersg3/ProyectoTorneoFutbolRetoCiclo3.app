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
        public int gActual{get; set;}
        public string bActual{get; set;}

        public IndexModel(IRepositorioArbitro repoArbitro)
        {
            _repoArbitro = repoArbitro;
        }


        //public void OnGet(int? g, string b)
        public void OnGet(string b)
        {
            if(String.IsNullOrEmpty(b))
            {
                bActual = "";
                arbitros = _repoArbitro.GetAllArbitros();
            }
            else
            {
                bActual = b;
                arbitros = _repoArbitro.SearchArbitros(b);
            }
/*
            if(g.HasValue && g.Value != -1)
            {
                gActual = g.Value;
                arbitros = _repoArbitro.GetArbitrosGenero(g.Value);
            }
            else
            {
                gActual = -1;
                arbitros = _repoArbitro.GetAllArbitros();
            }
*/
        }

    }
}
