using ControleEstacionamento.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Application.ViewModel
{
    public class VeiculoViewModel
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }
        public Preco Preco { get; set; }
    }
}
