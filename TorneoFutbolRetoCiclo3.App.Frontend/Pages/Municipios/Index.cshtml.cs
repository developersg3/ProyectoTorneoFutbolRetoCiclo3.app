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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioMunicipio _repoMunicipio;
        public IEnumerable<Municipio> municipios {get; set;}
        public int gActual{get; set;}
        public string nombre_municipioActual{get; set;}

        public IndexModel(IRepositorioMunicipio repoMunicipio)
        {
            _repoMunicipio = repoMunicipio;
        }

        //public void OnGet(int? g, string b)
        public void OnGet(string nombre_municipio)
        {
            if(String.IsNullOrEmpty(nombre_municipio))
            {
                nombre_municipioActual = "";
                municipios = _repoMunicipio.GetAllMunicipios();
            }
            else
            {
                nombre_municipioActual = nombre_municipio;
                municipios = _repoMunicipio.SearchMunicipios(nombre_municipio);
            }
        }
    }
}
