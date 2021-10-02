//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace TorneoFutbolRetoCiclo3.App.Dominio {

    public class Desempeno_equipo {
        public int Desempeno_equipoId { get; set; }

        [Required(ErrorMessage = "La cantidad de partidos jugados es obligatorio")]
        //[StringLength(4, ErrorMessage = "Maximo 4 caracteres")]
        [Display(Name = "Cantidad de partidos jugados")]
        public int cantidad_partidos_jugados { get; set; }

        [Required(ErrorMessage = "La cantidad de partidos ganados es obligatorio")]
        //[StringLength(4, ErrorMessage = "Maximo 4 caracteres")]
        [Display(Name = "Cantidad de partidos ganados")]
        public int cantidad_partidos_ganados { get; set; }

        [Required(ErrorMessage = "La cantidad de partidos empatados es obligatorio")]
        //[StringLength(4, ErrorMessage = "Maximo 4 caracteres")]
        [Display(Name = "Cantidad de partidos empatados")]
        public int cantidad_partidos_empatados { get; set; }

        [Required(ErrorMessage = "La cantidad de goles a favor es obligatorio")]
        //[StringLength(4, ErrorMessage = "Maximo 4 caracteres")]
        [Display(Name = "Cantidad goles a favor")]
        public int cantidad_goles_a_favor { get; set; }

        [Required(ErrorMessage = "La cantidad de goles en contra es obligatorio")]
        //[StringLength(4, ErrorMessage = "Maximo 4 caracteres")]
        [Display(Name = "Cantidad goles en contra")]
        public int cantidad_goles_en_contra { get; set; }

        [Required(ErrorMessage = "La cantidad de puntos es obligatorio")]
        //[StringLength(4, ErrorMessage = "Maximo 4 caracteres")]
        [Display(Name = "Cantidad puntos")]
        public int cantidad_puntos { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        //[StringLength(4, ErrorMessage = "Maximo 4 caracteres")]
        [Display(Name = "Nombre del equipo")]
        public int EquipoId { get; set; }
        public Equipo Equipo { get; set; }
    }
}