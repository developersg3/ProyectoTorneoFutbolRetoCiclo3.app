
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolRetoCiclo3.App.Dominio;
using TorneoFutbolRetoCiclo3.App.Persistencia;

namespace TorneoFutbolRetoCiclo3.App.Frontend.Pages.Novedades
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioNovedad _repoNovedad;
        public IEnumerable<Novedad> novedades {get; set;}

        private readonly IRepositorioTipo_novedad _repoTipo_novedad;
        public IEnumerable<Tipo_novedad> Tipo_novedades {get; set;}

        private readonly IRepositorioEquipo _repoEquipo;
        public IEnumerable<Equipo> equipos {get; set;}

        private readonly IRepositorioPartido _repoPartido;
        public IEnumerable<Partido> partidos {get; set;}     
        
        public string minuto_novedadActual{get; set;}
         

        public IndexModel(IRepositorioNovedad repoNovedad, IRepositorioTipo_novedad repoTipo_novedad, IRepositorioEquipo repoEquipo, IRepositorioPartido repoPartido)
        {
            _repoNovedad= repoNovedad;
            _repoTipo_novedad = repoTipo_novedad;
            _repoEquipo = repoEquipo;
            _repoPartido = repoPartido;
        }

        //public void OnGet(int? g, string b)
        public void OnGet(string minuto_novedad)
        {
            if(String.IsNullOrEmpty(minuto_novedad))
            {
                minuto_novedadActual = "";
                novedades = _repoNovedad.GetAllNovedades();
                Tipo_novedades = _repoTipo_novedad.GetAllTipo_novedades();
                equipos = _repoEquipo.GetAllEquipos();
                partidos = _repoPartido.GetAllPartidos();
            }
            else
            {
                minuto_novedadActual = minuto_novedad;
                novedades = _repoNovedad.SearchNovedades(minuto_novedad);
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



