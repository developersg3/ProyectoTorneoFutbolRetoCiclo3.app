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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        public Partido partido {get; set;}

        private readonly IRepositorioEquipo _repoEquipo;
        public IEnumerable<Equipo> equipos {get; set;}

        private readonly IRepositorioArbitro _repoArbitro;
        public IEnumerable<Arbitro> arbitros {get; set;}

        private readonly IRepositorioEstadio _repoEstadio;
        public IEnumerable<Estadio> estadios {get; set;}

        public CreateModel(IRepositorioPartido repoPartido, IRepositorioEquipo repoEquipo, IRepositorioArbitro repoArbitro, IRepositorioEstadio repoEstadio)
        {
            _repoPartido = repoPartido;
            _repoEquipo = repoEquipo;
            _repoArbitro = repoArbitro;
            _repoEstadio = repoEstadio;
        }
        public void OnGet()
        {
            partido = new Partido();
            equipos = _repoEquipo.GetAllEquipos();
            arbitros = _repoArbitro.GetAllArbitros();
            estadios = _repoEstadio.GetAllEstadios();
        }

        public IActionResult OnPost(Partido partido)
        {
            if (ModelState.IsValid)
            {
                _repoPartido.AddPartido(partido);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
