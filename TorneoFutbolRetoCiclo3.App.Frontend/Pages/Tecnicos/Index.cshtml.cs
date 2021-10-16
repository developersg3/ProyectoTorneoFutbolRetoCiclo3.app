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
        public int gActual{get; set;}
        public string nombre_tecnicoActual{get; set;}

        public IndexModel(IRepositorioTecnico repoTecnico)
        {
            _repoTecnico = repoTecnico;
        }


        //public void OnGet(int? g, string b)
        public void OnGet(string nombre_tecnico)
        {
            if(String.IsNullOrEmpty(nombre_tecnico))
            {
                nombre_tecnicoActual = "";
                tecnicos = _repoTecnico.GetAllTecnicos();
            }
            else
            {
                nombre_tecnicoActual = nombre_tecnico;
                tecnicos = _repoTecnico.SearchTecnicos(nombre_tecnico);
            }
/*
            if(g.HasValue && g.Value != -1)
            {
                gActual = g.Value;
                tecnicos = _repoTecnico.GetTecnicosGenero(g.Value);
            }
            else
            {
                gActual = -1;
                tecnicos = _repoTecnico.GetAllTecnicos();
            }
*/
        }

    }
}
