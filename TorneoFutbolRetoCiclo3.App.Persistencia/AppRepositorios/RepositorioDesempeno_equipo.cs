using System.Collections.Generic;
using TorneoFutbolRetoCiclo3.App.Dominio;

namespace TorneoFutbolRetoCiclo3.App.Persistencia
{
    public class RepositorioDesempeno_equipo : IRepositorioDesempeno_equipo
    {
        private readonly AppContext _appContext = new AppContext();
/*
        public RepositorioDesempeno_equipo(AppContext appContext)
        {
            _appContext = appContext;
        }
*/
        Desempeno_equipo IRepositorioDesempeno_equipo.AddDesempeno_equipo(Desempeno_equipo desempeno_equipo)
        {
            var desempeno_equipoAdicionado = _appContext.Desempeno_equipos.Add(desempeno_equipo);
            _appContext.SaveChanges();
            return desempeno_equipoAdicionado.Entity;
        }

        void IRepositorioDesempeno_equipo.DeleteDesempeno_equipo(int idDesempeno_equipo)
        {
            var desempeno_equipoEncontrado = _appContext.Desempeno_equipos.Find(idDesempeno_equipo);
            if (desempeno_equipoEncontrado == null)
                return;
            _appContext.Desempeno_equipos.Remove(desempeno_equipoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Desempeno_equipo> IRepositorioDesempeno_equipo.GetAllDesempeno_equipos()
        {
            return _appContext.Desempeno_equipos;
        }

        Desempeno_equipo IRepositorioDesempeno_equipo.GetDesempeno_equipo(int idDesempeno_equipo)
        {
            return _appContext.Desempeno_equipos.Find(idDesempeno_equipo);
        }

        Desempeno_equipo IRepositorioDesempeno_equipo.UpdateDesempeno_equipo(Desempeno_equipo desempeno_equipo)
        {
            var desempeno_equipoEncontrado = _appContext.Desempeno_equipos.Find(desempeno_equipo.Desempeno_equipoId);
            if (desempeno_equipoEncontrado != null)
            {
                desempeno_equipoEncontrado.cantidad_partidos_jugados = desempeno_equipo.cantidad_partidos_jugados;
                desempeno_equipoEncontrado.cantidad_partidos_ganados = desempeno_equipo.cantidad_partidos_ganados;
                desempeno_equipoEncontrado.cantidad_partidos_empatados = desempeno_equipo.cantidad_partidos_empatados;
                desempeno_equipoEncontrado.cantidad_goles_a_favor = desempeno_equipo.cantidad_goles_a_favor;
                desempeno_equipoEncontrado.cantidad_goles_en_contra = desempeno_equipo.cantidad_goles_en_contra;
                desempeno_equipoEncontrado.cantidad_puntos = desempeno_equipo.cantidad_puntos;
                desempeno_equipoEncontrado.EquipoId = desempeno_equipo.EquipoId;

                _appContext.SaveChanges();
            }
            return desempeno_equipoEncontrado;
        }

    }
}
