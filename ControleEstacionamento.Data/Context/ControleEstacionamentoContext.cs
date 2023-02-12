using ControleEstacionamento.Data.Mappings;
using ControleEstacionamento.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Data.Context
{
    public class ControleEstacionamentoContext : DbContext
    {
        public ControleEstacionamentoContext()
            :base("ControleEstacionamento")
        {

        }

        #region "DbSets"
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Preco> Precos { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            
            modelBuilder.Properties()
                .Where(p => p.Name == "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(80));

            modelBuilder.Properties()
                .Where(p => p.Name == "HoraEntrada")
                .Configure(p => p.IsRequired());

            modelBuilder.Properties()
                .Where(p => p.Name == "HoraSaida")
                .Configure(p => p.IsRequired());

            modelBuilder.Properties()
                .Where(p => p.Name == "Preco")
                .Configure(p => p.IsRequired());

            modelBuilder.Configurations.Add(new VeiculoMap());
            modelBuilder.Configurations.Add(new PrecoMap());
        }

    }
}
