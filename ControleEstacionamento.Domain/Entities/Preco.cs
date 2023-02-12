using System;

namespace ControleEstacionamento.Domain.Entities
{
    public class Preco
    {
        public int Id { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public decimal ValorHoraInicial { get; set; }
        public decimal ValorHoraAdcional { get; set; }
    }
}
