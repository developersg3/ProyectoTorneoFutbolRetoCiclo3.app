using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolRetoCiclo3.App.Dominio;
using TorneoFutbolRetoCiclo3.App.Persistencia;

namespace TorneoFutbolRetoCiclo3.App.Frontend.Pages.Partidos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        public IEnumerable<Partido> partidos {get; set;}

        private readonly IRepositorioEquipo _repoEquipo;
        public IEnumerable<Equipo> equipos {get; set;}

        private readonly IRepositorioArbitro _repoArbitro;
        public IEnumerable<Arbitro> arbitros {get; set;}

        private readonly IRepositorioEstadio _repoEstadio;
        public IEnumerable<Estadio> estadios {get; set;}     
        
         public string fecha_partidoActual{get; set;}

        public IndexModel(IRepositorioPartido repoPartido, IRepositorioEquipo repoEquipo, IRepositorioArbitro repoArbitro, IRepositorioEstadio repoEstadio)
        {
            _repoPartido = repoPartido;
            _repoEquipo = repoEquipo;
            _repoArbitro = repoArbitro;
            _repoEstadio = repoEstadio;
        }

        //public void OnGet(int? g, string b)
        public void OnGet(string fecha_partido)
        {
            if(String.IsNullOrEmpty(fecha_partido))
            {
                fecha_partidoActual = "";
                partidos = _repoPartido.GetAllPartidos();
                equipos = _repoEquipo.GetAllEquipos();
                arbitros = _repoArbitro.GetAllArbitros();
                estadios = _repoEstadio.GetAllEstadios();
            }
            else
            {
                fecha_partidoActual = fecha_partido;
                partidos = _repoPartido.SearchPartidos(fecha_partido);
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
