using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleEstacionamento.ViewModels
{
    public class PrecoVM
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        [DisplayName("Valor Inicial")]
        public decimal ValorHoraInicial { get; set; }
        [DisplayName("Valor Adcional")]
        public decimal ValorHoraAdcional { get; set; }
    }
}