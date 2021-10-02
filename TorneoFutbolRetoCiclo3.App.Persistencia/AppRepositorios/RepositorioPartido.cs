using System.Collections.Generic;
using TorneoFutbolRetoCiclo3.App.Dominio;

namespace TorneoFutbolRetoCiclo3.App.Persistencia
{
    public class RepositorioPartido : IRepositorioPartido
    {
        private readonly AppContext _appContext = new AppContext();
/*
        public RepositorioPartido(AppContext appContext)
        {
            _appContext = appContext;
        }
*/
        Partido IRepositorioPartido.AddPartido(Partido partido)
        {
            var partidoAdicionado = _appContext.Partidos.Add(partido);
            _appContext.SaveChanges();
            return partidoAdicionado.Entity;
        }

        void IRepositorioPartido.DeletePartido(int idPartido)
        {
            var partidoEncontrado = _appContext.Partidos.Find(idPartido);
            if (partidoEncontrado == null)
                return;
            _appContext.Partidos.Remove(partidoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Partido> IRepositorioPartido.GetAllPartidos()
        {
            return _appContext.Partidos;
        }

        Partido IRepositorioPartido.GetPartido(int idPartido)
        {
            return _appContext.Partidos.Find(idPartido);
        }

        Partido IRepositorioPartido.UpdatePartido(Partido partido)
        {
            var partidoEncontrado = _appContext.Partidos.Find(partido.PartidoId);
            if (partidoEncontrado != null)
            {
                partidoEncontrado.cod_equipo_local = partido.cod_equipo_local;
                partidoEncontrado.cod_equipo_vistante = partido.cod_equipo_vistante;
                partidoEncontrado.goles_equipo_local = partido.goles_equipo_local;
                partidoEncontrado.goles_equipo_visitante = partido.goles_equipo_visitante;
                partidoEncontrado.fecha_partido = partido.fecha_partido;
                partidoEncontrado.hora_partido = partido.hora_partido;
                partidoEncontrado.ArbitroId = partido.ArbitroId;
                partidoEncontrado.EstadioId = partido.EstadioId;

                _appContext.SaveChanges();
            }
            return partidoEncontrado;
        }

    }
}
