using System.Collections.Generic;
using System.Linq;
using TorneoFutbolRetoCiclo3.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace TorneoFutbolRetoCiclo3.App.Persistencia
{
    public class RepositorioTecnico : IRepositorioTecnico
    {
        private readonly AppContext _appContext = new AppContext();
        //-------------------------------------------------------------------------------------------//
        Tecnico IRepositorioTecnico.AddTecnico(Tecnico tecnico)
        {
            var tecnicoAdicionado = _appContext.Tecnicos.Add(tecnico);
            _appContext.SaveChanges();
            return tecnicoAdicionado.Entity;
        }
        //-------------------------------------------------------------------------------------------//
        void IRepositorioTecnico.DeleteTecnico(int idTecnico)
        {
            var tecnicoEncontrado = _appContext.Tecnicos.Find(idTecnico);
            if (tecnicoEncontrado == null)
                return;
            _appContext.Tecnicos.Remove(tecnicoEncontrado);
            _appContext.SaveChanges();
        }
        //-------------------------------------------------------------------------------------------//
        IEnumerable<Tecnico> IRepositorioTecnico.GetAllTecnicos()
        {
            return _appContext.Tecnicos;
        }
        //-------------------------------------------------------------------------------------------//
        Tecnico IRepositorioTecnico.GetTecnico(int idTecnico)
        {
            return _appContext.Tecnicos.Find(idTecnico);
        }
        //-------------------------------------------------------------------------------------------//
        Tecnico IRepositorioTecnico.UpdateTecnico(Tecnico tecnico)
        {
            var tecnicoEncontrado = _appContext.Tecnicos.Find(tecnico.TecnicoId);
            if (tecnicoEncontrado != null)
            {
                tecnicoEncontrado.nombre_tecnico = tecnico.nombre_tecnico;
                tecnicoEncontrado.EquipoId = tecnico.EquipoId;
                _appContext.SaveChanges();
            }
            return tecnicoEncontrado;
        }
        //-------------------------------------------------------------------------------------------//
        IEnumerable<Tecnico> IRepositorioTecnico.SearchTecnicos(string nombre_tecnico)
        {
            return _appContext.Tecnicos
                        .Where(p => p.nombre_tecnico.Contains(nombre_tecnico));
        }
        //-------------------------------------------------------------------------------------------//
    }
}
