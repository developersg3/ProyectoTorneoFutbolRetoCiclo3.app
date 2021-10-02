using System.Collections.Generic;
using TorneoFutbolRetoCiclo3.App.Dominio;
namespace TorneoFutbolRetoCiclo3.App.Persistencia
{
    public interface IRepositorioPosicion_jugador
    {
        IEnumerable<Posicion_jugador> GetAllPosicion_jugadores();
        Posicion_jugador AddPosicion_jugador(Posicion_jugador posicion_jugador);
        Posicion_jugador UpdatePosicion_jugador(Posicion_jugador posicion_jugador);
        void DeletePosicion_jugador(int idPosicion_jugador);    
        Posicion_jugador GetPosicion_jugador(int idPosicion_jugador);
   }
}
