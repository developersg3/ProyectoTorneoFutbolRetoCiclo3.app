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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioTecnico _repoTecnico;
        public Tecnico tecnico {get; set;}
        public CreateModel(IRepositorioTecnico repoTecnico)
        {
            _repoTecnico = repoTecnico;
        }
        public void OnGet()
        {
            tecnico = new Tecnico();
        }

        public IActionResult OnPost(Tecnico tecnico)
        {
            if (ModelState.IsValid)
            {
                _repoTecnico.AddTecnico(tecnico);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
