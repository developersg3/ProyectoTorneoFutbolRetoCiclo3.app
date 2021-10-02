//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace TorneoFutbolRetoCiclo3.App.Dominio {

    public class Estadio {
        public int EstadioId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Nombre")]
        public string nombre_estadio { get; set; }

        //[Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Direccion")]
        public string direccion_estadio { get; set; }

        [Required(ErrorMessage = "El municipio es obligatorio")]
        //[StringLength(4, ErrorMessage = "Maximo 4 caracteres")]
        [Display(Name = "Municipio")]
        public int MunicipioId { get; set; }
        public Municipio Municipio { get; set; }
    }
}