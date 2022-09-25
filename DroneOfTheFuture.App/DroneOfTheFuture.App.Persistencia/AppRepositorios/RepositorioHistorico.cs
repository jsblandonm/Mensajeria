using System;
using Microsoft.EntityFrameworkCore;
using DroneOfTheFuture.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace DroneOfTheFuture.App.Persistencia
{
    public class RepositorioHistorico : IRepositorioHistorico
    {
        private readonly AppContexto _appcontext;
        public RepositorioHistorico(AppContexto appContext)
        {
            _appcontext = appContext;
        }
        public RepositorioHistorico()
        {
            _appcontext = new AppContexto();
        }
        public Historico AddHistorico(Historico historico)
        {
            var historicoAgregado = _appcontext.Historicos.Add(historico);
            _appcontext.SaveChanges();
            return historicoAgregado.Entity;
        }

        public void DeleteHistorico(int idHistorico)
        {
            var historicoEncontrado = _appcontext.Historicos.FirstOrDefault(h => h.Id == idHistorico);
            if (historicoEncontrado == null)
            {
                return;
            }
            _appcontext.Historicos.Remove(historicoEncontrado);
            _appcontext.SaveChanges();
        }

        public IEnumerable<Historico> GetAllHistorico()
        {
            return _appcontext.Historicos;
        }

        public Historico GetHistorico(int idHistorico)
        {
            return _appcontext.Historicos.Where(h => h.Id == idHistorico).Include(h => h.SusReportes).Include(h => h.SusReportes.pedidos).FirstOrDefault();
        }

        public Historico UpdateHistorico(Historico historico)
        {
            var historicoEncontrado = _appcontext.Historicos.FirstOrDefault(h => h.Id == historico.Id);
            if (historicoEncontrado != null)
            {
                historicoEncontrado.Satisfacioncliente = historico.Satisfacioncliente;
                historicoEncontrado.SusReportes = historico.SusReportes;
                _appcontext.SaveChanges();
            }
            return historicoEncontrado;
        }
    }
}