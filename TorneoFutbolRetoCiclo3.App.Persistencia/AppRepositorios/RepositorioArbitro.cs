using System.Collections.Generic;
using TorneoFutbolRetoCiclo3.App.Dominio;

namespace TorneoFutbolRetoCiclo3.App.Persistencia
{
    public class RepositorioArbitro : IRepositorioArbitro
    {
        private readonly AppContext _appContext = new AppContext();
/*
        public RepositorioArbitro(AppContext appContext)
        {
            _appContext = appContext;
        }
*/
        Arbitro IRepositorioArbitro.AddArbitro(Arbitro arbitro)
        {
            var arbitroAdicionado = _appContext.Arbitros.Add(arbitro);
            _appContext.SaveChanges();
            return arbitroAdicionado.Entity;
        }

        void IRepositorioArbitro.DeleteArbitro(int idArbitro)
        {
            var arbitroEncontrado = _appContext.Arbitros.Find(idArbitro);
            if (arbitroEncontrado == null)
                return;
            _appContext.Arbitros.Remove(arbitroEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Arbitro> IRepositorioArbitro.GetAllArbitros()
        {
            return _appContext.Arbitros;
        }

        Arbitro IRepositorioArbitro.GetArbitro(int idArbitro)
        {
            return _appContext.Arbitros.Find(idArbitro);
        }

        Arbitro IRepositorioArbitro.UpdateArbitro(Arbitro arbitro)
        {
            var arbitroEncontrado = _appContext.Arbitros.Find(arbitro.ArbitroId);
            if (arbitroEncontrado != null)
            {
                arbitroEncontrado.nombre_arbitro = arbitro.nombre_arbitro;
                arbitroEncontrado.documento_arbitro = arbitro.documento_arbitro;
                arbitroEncontrado.telefono_arbitro = arbitro.telefono_arbitro;
                arbitroEncontrado.nombre_colegio = arbitro.nombre_colegio;
                _appContext.SaveChanges();
            }
            return arbitroEncontrado;
        }

    }
}
