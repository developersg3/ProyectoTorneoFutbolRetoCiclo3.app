using System.Collections.Generic;
using TorneoFutbolRetoCiclo3.App.Dominio;

namespace TorneoFutbolRetoCiclo3.App.Persistencia
{
    public class RepositorioPosicion_jugador : IRepositorioPosicion_jugador
    {
        private readonly AppContext _appContext = new AppContext();
/*
        public RepositorioPosicion_jugador(AppContext appContext)
        {
            _appContext = appContext;
        }
*/
        Posicion_jugador IRepositorioPosicion_jugador.AddPosicion_jugador(Posicion_jugador posicion_jugador)
        {
            var posicion_jugadorAdicionado = _appContext.Posicion_jugadores.Add(posicion_jugador);
            _appContext.SaveChanges();
            return posicion_jugadorAdicionado.Entity;
        }

        void IRepositorioPosicion_jugador.DeletePosicion_jugador(int idPosicion_jugador)
        {
            var posicion_jugadorEncontrado = _appContext.Posicion_jugadores.Find(idPosicion_jugador);
            if (posicion_jugadorEncontrado == null)
                return;
            _appContext.Posicion_jugadores.Remove(posicion_jugadorEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Posicion_jugador> IRepositorioPosicion_jugador.GetAllPosicion_jugadores()
        {
            return _appContext.Posicion_jugadores;
        }

        Posicion_jugador IRepositorioPosicion_jugador.GetPosicion_jugador(int idPosicion_jugador)
        {
            return _appContext.Posicion_jugadores.Find(idPosicion_jugador);
        }

        Posicion_jugador IRepositorioPosicion_jugador.UpdatePosicion_jugador(Posicion_jugador posicion_jugador)
        {
            var posicion_jugadorEncontrado = _appContext.Posicion_jugadores.Find(posicion_jugador.Posicion_jugadorId);
            if (posicion_jugadorEncontrado != null)
            {
                posicion_jugadorEncontrado.nombre_posicion_jugador = posicion_jugador.nombre_posicion_jugador;
                _appContext.SaveChanges();
            }
            return posicion_jugadorEncontrado;
        }

    }
}
