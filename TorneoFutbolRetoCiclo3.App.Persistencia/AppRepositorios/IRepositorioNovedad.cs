using System.Collections.Generic;
using TorneoFutbolRetoCiclo3.App.Dominio;
namespace TorneoFutbolRetoCiclo3.App.Persistencia
{
    public interface IRepositorioNovedad
    {
        IEnumerable<Novedad> GetAllNovedades();
        Novedad AddNovedad(Novedad novedad);
        Novedad UpdateNovedad(Novedad novedad);
        void DeleteNovedad(int idNovedad);    
        Novedad GetNovedad(int idNovedad);
        IEnumerable<Novedad> SearchNovedades(string minuto_novedad);
   }
}
