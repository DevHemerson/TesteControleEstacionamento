using ControleEstacionamento.Application.Interfaces;
using ControleEstacionamento.Data.Context;
using ControleEstacionamento.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Application.Services
{
    public class VeiculoService : IVeiculoService<Veiculo>
    {
        private readonly ControleEstacionamentoContext _context;

        public VeiculoService(ControleEstacionamentoContext context)
        {
            _context = context;
        }

        public IEnumerable<Veiculo> GetAll()
        {
            return _context.Veiculos.ToList();
        }

        public Veiculo GetById(int id)
        {
            return _context.Veiculos.Find(id);
        }

        public void Add(Veiculo veiculo)
        {
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
        }        

        public void Delete(Veiculo veiculo)
        {
            _context.Veiculos.Remove(veiculo);
            _context.SaveChanges();
        }
    }
}
