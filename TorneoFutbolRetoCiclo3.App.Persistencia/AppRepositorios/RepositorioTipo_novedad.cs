using System.Collections.Generic;
using TorneoFutbolRetoCiclo3.App.Dominio;

namespace TorneoFutbolRetoCiclo3.App.Persistencia
{
    public class RepositorioTipo_novedad : IRepositorioTipo_novedad
    {
        private readonly AppContext _appContext = new AppContext();
/*
        public RepositorioTipo_novedad(AppContext appContext)
        {
            _appContext = appContext;
        }
*/
        Tipo_novedad IRepositorioTipo_novedad.AddTipo_novedad(Tipo_novedad tipo_novedad)
        {
            var tipo_novedadAdicionado = _appContext.Tipo_novedades.Add(tipo_novedad);
            _appContext.SaveChanges();
            return tipo_novedadAdicionado.Entity;
        }

        void IRepositorioTipo_novedad.DeleteTipo_novedad(int idTipo_novedad)
        {
            var tipo_novedadEncontrado = _appContext.Tipo_novedades.Find(idTipo_novedad);
            if (tipo_novedadEncontrado == null)
                return;
            _appContext.Tipo_novedades.Remove(tipo_novedadEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Tipo_novedad> IRepositorioTipo_novedad.GetAllTipo_novedades()
        {
            return _appContext.Tipo_novedades;
        }

        Tipo_novedad IRepositorioTipo_novedad.GetTipo_novedad(int idTipo_novedad)
        {
            return _appContext.Tipo_novedades.Find(idTipo_novedad);
        }

        Tipo_novedad IRepositorioTipo_novedad.UpdateTipo_novedad(Tipo_novedad tipo_novedad)
        {
            var tipo_novedadEncontrado = _appContext.Tipo_novedades.Find(tipo_novedad.Tipo_novedadId);
            if (tipo_novedadEncontrado != null)
            {
                tipo_novedadEncontrado.nombre_tipo_novedad = tipo_novedad.nombre_tipo_novedad;
                _appContext.SaveChanges();
            }
            return tipo_novedadEncontrado;
        }

    }
}
