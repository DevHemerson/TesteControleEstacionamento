using ControleEstacionamento.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleEstacionamento.ViewModels
{
    public class VeiculoVM
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite a placa do veículo")]
        public string Placa { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }
        public Preco Preco { get; set; }
    }
}