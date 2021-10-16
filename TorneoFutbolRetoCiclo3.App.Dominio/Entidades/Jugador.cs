//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace TorneoFutbolRetoCiclo3.App.Dominio {

    public class Jugador {
        public int JugadorId { get; set; }

        [Required(ErrorMessage = "El nombre del jugador es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Nombres")]
        public string nombre_jugador { get; set; }

        [Required(ErrorMessage = "El apellido del jugador es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Apellidos")]
        public string apellido_jugador { get; set; }

        [Required(ErrorMessage = "El numero del jugador es obligatorio")]
        //[StringLength(3, ErrorMessage = "Maximo 3 caracteres")]
        [Display(Name = "Numero")]
        public int numero_jugador { get; set; }
        
        [Required(ErrorMessage = "El nombre del equipo es obligatorio")]
        //[StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Equipo")]
        //Relacion Jugador -> Equipo
        public int EquipoId { get; set; }
        public Equipo Equipo { get; set; }

        [Required(ErrorMessage = "El la posicion es obligatoria")]
        //[StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Posicion de juego")]
        public int Posicion_jugadorId { get; set; }
        public Posicion_jugador Posicion_jugador { get; set; }
    }
}