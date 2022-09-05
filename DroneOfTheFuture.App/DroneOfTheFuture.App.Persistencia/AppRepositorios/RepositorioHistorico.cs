using System;
using Microsoft.EntityFrameworkCore;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persitencia;
using System.Collections.Generic;
using System.Linq;

namespace DroneOfTheFuture.App.Persistencia
{
    public class RepositorioHistorico : IRepositorioHistorico
    {
        private readonly APPCT _appcontext;
        public RepositorioHistorico(APPCT appContext)
        {
            _appcontext = appContext;
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
            return _appcontext.Historicos.FirstOrDefault(h => h.Id == idHistorico);
        }

        public Historico UpdateHistorico(Historico historico)
        {
            var historicoEncontrado = _appcontext.Historicos.FirstOrDefault(h => h.Id == historico.Id);
            if (historicoEncontrado != null)
            {
                historicoEncontrado.Satisfacioncliente = historico.Satisfacioncliente;

                _appcontext.SaveChanges();
            }
            return historicoEncontrado;
        }
    }
}