using System.Collections.Generic;
using TorneoFutbolRetoCiclo3.App.Dominio;
namespace TorneoFutbolRetoCiclo3.App.Persistencia
{
    public interface IRepositorioTecnico
    {
        IEnumerable<Tecnico> GetAllTecnicos();
        Tecnico AddTecnico(Tecnico tecnico);
        Tecnico UpdateTecnico(Tecnico tecnico);
        void DeleteTecnico(int idTecnico);    
        Tecnico GetTecnico(int idTecnico);
        IEnumerable<Tecnico> SearchTecnicos(string nombre_tecnico);
   }
}
