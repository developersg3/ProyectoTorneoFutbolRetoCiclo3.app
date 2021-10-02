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
    public class EditModel : PageModel
    {
        private readonly IRepositorioTecnico _repoTecnico;
        public Tecnico tecnico {get; set;}
        public EditModel(IRepositorioTecnico repoTecnico)
        {
            _repoTecnico = repoTecnico;
        }

        public IActionResult OnGet(int id)
        {
            tecnico = _repoTecnico.GetTecnico(id);
            if(tecnico == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(Tecnico tecnico)
        {
            _repoTecnico.UpdateTecnico(tecnico);
            return RedirectToPage("Index");
        }
    }
}
