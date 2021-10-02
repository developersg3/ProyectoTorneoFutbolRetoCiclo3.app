//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace TorneoFutbolRetoCiclo3.App.Dominio 
{
    public class Arbitro 
    {
        public int ArbitroId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Nombre")]
        public string nombre_arbitro { get; set; }

        [Required(ErrorMessage = "El documento es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Documento")]
        public string documento_arbitro { get; set; }

        [Required(ErrorMessage = "El telefono es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 20 caracteres")]
        [Display(Name = "Telefono")]
        public string telefono_arbitro { get; set; }

        [Required(ErrorMessage = "El Nombre del Colegio es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Colegio")]
        public string nombre_colegio { get; set; }

    }
}