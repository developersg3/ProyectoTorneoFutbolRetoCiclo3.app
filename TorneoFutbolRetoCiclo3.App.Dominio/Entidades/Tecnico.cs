//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace TorneoFutbolRetoCiclo3.App.Dominio {

    public class Tecnico {
        public int TecnicoId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Nombre")]
        public string nombre_tecnico { get; set; }

        [Required(ErrorMessage = "El equipo es obligatorio")]
        //[StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Equipo")]
        //Relacion Tecnico -> Equipo
        public int EquipoId { get; set; }
        public Equipo Equipo { get; set; }
    }
}