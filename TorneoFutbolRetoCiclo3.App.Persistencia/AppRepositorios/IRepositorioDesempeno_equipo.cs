using System.Collections.Generic;
using TorneoFutbolRetoCiclo3.App.Dominio;
namespace TorneoFutbolRetoCiclo3.App.Persistencia
{
    public interface IRepositorioDesempeno_equipo
    {
        IEnumerable<Desempeno_equipo> GetAllDesempeno_equipos();
        Desempeno_equipo AddDesempeno_equipo(Desempeno_equipo desempeno_equipo);
        Desempeno_equipo UpdateDesempeno_equipo(Desempeno_equipo desempeno_equipo);
        void DeleteDesempeno_equipo(int idDesempeno_equipo);    
        Desempeno_equipo GetDesempeno_equipo(int idDesempeno_equipo);
   }
}
