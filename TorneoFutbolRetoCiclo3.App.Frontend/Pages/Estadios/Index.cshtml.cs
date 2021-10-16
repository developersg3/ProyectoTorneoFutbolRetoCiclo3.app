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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEstadio _repoEstadio;
        private readonly IRepositorioMunicipio _repoMunicipio;

        public IEnumerable<Estadio> estadios {get; set;}
        public IEnumerable <Municipio> municipios {get;set;}
        public string nombre_estadioActual{get; set;}

        public IndexModel(IRepositorioEstadio repoEstadio, IRepositorioMunicipio repoMunicipio)
        {
            _repoEstadio = repoEstadio;
            _repoMunicipio = repoMunicipio;
        }

        //public void OnGet(int? g, string b)
        public void OnGet(string nombre_estadio)
        {
            if(String.IsNullOrEmpty(nombre_estadio))
            {
                nombre_estadioActual = "";
                estadios = _repoEstadio.GetAllEstadios();
                municipios = _repoMunicipio.GetAllMunicipios();
            }
            else
            {
                nombre_estadioActual = nombre_estadio;
                estadios = _repoEstadio.SearchEstadios(nombre_estadio);
            }
/*
            if(g.HasValue && g.Value != -1)
            {
                gActual = g.Value;
                estadios = _repoEstadio.GetEstadiosGenero(g.Value);
            }
            else
            {
                gActual = -1;
                estadios = _repoEstadio.GetAllEstadios();
            }
*/
        }


    }
}
