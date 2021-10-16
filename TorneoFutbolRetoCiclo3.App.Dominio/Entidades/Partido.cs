//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace TorneoFutbolRetoCiclo3.App.Dominio {

    public class Partido {
        public int PartidoId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        //[StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Equipo local")]
        public int cod_equipo_local { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        //[StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Equipo visitante")]
        public int cod_equipo_vistante { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        //[StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Goles equipo local")]
        public int goles_equipo_local { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        //[StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Goles equipo visitante")]
        public int goles_equipo_visitante { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(11, ErrorMessage = "Maximo 11 caracteres")]
        [Display(Name = "Fecha")]
        public string fecha_partido { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(11, ErrorMessage = "Maximo 11 caracteres")]
        [Display(Name = "Hora")]
        public string hora_partido { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        //[StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Arbitro")]
        //Relacion Partido -> Arbitro
        public int ArbitroId { get; set; }
        public Arbitro Arbitro { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        //[StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Estadio")]
        //Relacion Partido -> Estadio
        public int EstadioId { get; set; }
        public Estadio Estadio { get; set; }
    }
}