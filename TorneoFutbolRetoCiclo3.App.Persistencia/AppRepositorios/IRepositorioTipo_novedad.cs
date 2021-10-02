using System.Collections.Generic;
using TorneoFutbolRetoCiclo3.App.Dominio;
namespace TorneoFutbolRetoCiclo3.App.Persistencia
{
    public interface IRepositorioTipo_novedad
    {
        IEnumerable<Tipo_novedad> GetAllTipo_novedades();
        Tipo_novedad AddTipo_novedad(Tipo_novedad tipo_novedad);
        Tipo_novedad UpdateTipo_novedad(Tipo_novedad tipo_novedad);
        void DeleteTipo_novedad(int idTipo_novedad);    
        Tipo_novedad GetTipo_novedad(int idTipo_novedad);
   }
}
