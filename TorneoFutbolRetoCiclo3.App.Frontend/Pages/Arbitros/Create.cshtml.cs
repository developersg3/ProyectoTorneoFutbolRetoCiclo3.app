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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioArbitro _repoArbitro;
        public Arbitro arbitro {get; set;}
        public CreateModel(IRepositorioArbitro repoArbitro)
        {
            _repoArbitro = repoArbitro;
        }
        public void OnGet()
        {
            arbitro = new Arbitro();
        }

        public IActionResult OnPost(Arbitro arbitro)
        {
            if (ModelState.IsValid)
            {
                _repoArbitro.AddArbitro(arbitro);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}