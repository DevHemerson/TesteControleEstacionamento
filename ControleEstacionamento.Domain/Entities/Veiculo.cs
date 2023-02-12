using System;

namespace ControleEstacionamento.Domain.Entities
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }
        public Preco Preco { get; set; }

        //public decimal CalcularEstacionamento(DateTime horaEntrada, DateTime horaSaida, string placa)
        //{
        //    TimeSpan duracao = horaSaida - horaEntrada;

        //    if (duracao <= TimeSpan.FromMinutes(30))
        //        return ValorHoraInicial / 2;

        //    int horas = (int)Math.Ceiling(duracao.TotalHours);
        //    int extraMinutes = (int)(duracao - TimeSpan.FromHours(horas)).TotalMinutes;

        //    decimal valor = ValorHoraInicial + (horas - 1) * ValorHoraAdcional;

        //    if (extraMinutes > 0 && extraMinutes <= 10)
        //        valor += ValorHoraAdcional;

        //    return valor;
        //}

    }
    
}

//public class ParkingService
//{
//    public decimal CalculateParkingFee(ParkingRate rate, DateTime entryTime, DateTime exitTime)
//    {
//        decimal totalAmount = 0;
//        TimeSpan duration = exitTime - entryTime;

//        int fullHours = (int)duration.TotalHours;
//        int additionalMinutes = (int)duration.TotalMinutes - (fullHours * 60);

//        if (duration.TotalMinutes <= 30)
//        {
//            totalAmount = rate.InitialHourRate / 2;
//        }
//        else
//        {
//            totalAmount = rate.InitialHourRate;
//            if (fullHours > 0)
//            {
//                totalAmount += rate.AdditionalHourRate * fullHours;
//            }
//            if (additionalMinutes > 0)
//            {
//                totalAmount += rate.AdditionalHourRate;
//            }
//        }

//        return totalAmount;
//    }
