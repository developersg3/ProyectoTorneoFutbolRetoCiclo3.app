using System.Collections.Generic;
using System.Linq;
using TorneoFutbolRetoCiclo3.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace TorneoFutbolRetoCiclo3.App.Persistencia
{
    public class RepositorioNovedad : IRepositorioNovedad
    {
        private readonly AppContext _appContext = new AppContext();
/*
        public RepositorioNovedad(AppContext appContext)
        {
            _appContext = appContext;
        }
*/
        Novedad IRepositorioNovedad.AddNovedad(Novedad novedad)
        {
            var novedadAdicionado = _appContext.Novedades.Add(novedad);
            _appContext.SaveChanges();
            return novedadAdicionado.Entity;
        }

        void IRepositorioNovedad.DeleteNovedad(int idNovedad)
        {
            var novedadEncontrado = _appContext.Novedades.Find(idNovedad);
            if (novedadEncontrado == null)
                return;
            _appContext.Novedades.Remove(novedadEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Novedad> IRepositorioNovedad.GetAllNovedades()
        {
            return _appContext.Novedades;
        }

        Novedad IRepositorioNovedad.GetNovedad(int idNovedad)
        {
            return _appContext.Novedades.Find(idNovedad);
        }

        Novedad IRepositorioNovedad.UpdateNovedad(Novedad novedad)
        {
            var novedadEncontrado = _appContext.Novedades.Find(novedad.NovedadId);
            if (novedadEncontrado != null)
            {
                novedadEncontrado.minuto_novedad = novedad.minuto_novedad;
                novedadEncontrado.Tipo_novedadId = novedad.Tipo_novedadId;
                novedadEncontrado.EquipoId = novedad.EquipoId;
                novedadEncontrado.PartidoId = novedad.PartidoId;

                _appContext.SaveChanges();
            }
            return novedadEncontrado;
        }
        IEnumerable<Novedad> IRepositorioNovedad.SearchNovedades(string minuto_novedad)
        {
            return _appContext.Novedades
                        .Where(p => p.minuto_novedad.Contains(minuto_novedad));
        }


    }
}
