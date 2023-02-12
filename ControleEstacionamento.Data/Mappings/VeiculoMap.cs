using ControleEstacionamento.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ControleEstacionamento.Data.Mappings
{
    public class VeiculoMap : EntityTypeConfiguration<Veiculo>
    {
        public VeiculoMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Placa)
                .IsRequired()
                .HasMaxLength(10);
            Property(t => t.HoraEntrada)
                .IsRequired();
            Property(t => t.HoraSaida)
                .IsRequired();
        }
    }
}
