using System.Collections.Generic;
using TorneoFutbolRetoCiclo3.App.Dominio;

namespace TorneoFutbolRetoCiclo3.App.Persistencia
{
    public class RepositorioJugador : IRepositorioJugador
    {
        private readonly AppContext _appContext = new AppContext();
/*
        public RepositorioJugador(AppContext appContext)
        {
            _appContext = appContext;
        }
*/
        Jugador IRepositorioJugador.AddJugador(Jugador jugador)
        {
            var jugadorAdicionado = _appContext.Jugadores.Add(jugador);
            _appContext.SaveChanges();
            return jugadorAdicionado.Entity;
        }

        void IRepositorioJugador.DeleteJugador(int idJugador)
        {
            var jugadorEncontrado = _appContext.Jugadores.Find(idJugador);
            if (jugadorEncontrado == null)
                return;
            _appContext.Jugadores.Remove(jugadorEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Jugador> IRepositorioJugador.GetAllJugadores()
        {
            return _appContext.Jugadores;
        }

        Jugador IRepositorioJugador.GetJugador(int idJugador)
        {
            return _appContext.Jugadores.Find(idJugador);
        }

        Jugador IRepositorioJugador.UpdateJugador(Jugador jugador)
        {
            var jugadorEncontrado = _appContext.Jugadores.Find(jugador.JugadorId);
            if (jugadorEncontrado != null)
            {
                jugadorEncontrado.nombre_jugador = jugador.nombre_jugador;
                jugadorEncontrado.apellido_jugador = jugador.apellido_jugador;
                jugadorEncontrado.numero_jugador = jugador.numero_jugador;
                jugadorEncontrado.EquipoId = jugador.EquipoId;
                jugadorEncontrado.Posicion_jugadorId = jugador.Posicion_jugadorId;

                _appContext.SaveChanges();
            }
            return jugadorEncontrado;
        }

    }
}
