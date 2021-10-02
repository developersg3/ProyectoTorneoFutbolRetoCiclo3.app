//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace TorneoFutbolRetoCiclo3.App.Dominio {

    public class Tipo_novedad {
        public int Tipo_novedadId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Nombre")]
        public string nombre_tipo_novedad { get; set; }
    }
}