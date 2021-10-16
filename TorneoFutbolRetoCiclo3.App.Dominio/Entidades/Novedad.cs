//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace TorneoFutbolRetoCiclo3.App.Dominio {

    public class Novedad {
        public int NovedadId { get; set; }  

        [Required(ErrorMessage = "El minuto de la novedad es obligatorio")]
        //[StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Minuto de la novedad")]
        public int minuto_novedad { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        //[StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Tipo de novedad")]
        public int Tipo_novedadId { get; set; }
        public Tipo_novedad Tipo_novedad { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        //[StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Equipo")]
        //Relacion Novedad -> Equipo
        public int EquipoId { get; set; }
        public Equipo Equipo { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        //[StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Partido")]
        //Relacion Novedad -> Partido
        public int PartidoId { get; set; }
        public Partido Partido { get; set; }
    }
}