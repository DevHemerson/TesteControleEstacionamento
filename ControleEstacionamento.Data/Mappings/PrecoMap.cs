using ControleEstacionamento.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Data.Mappings
{
    public class PrecoMap : EntityTypeConfiguration<Preco>
    {
        public PrecoMap()
        {
            HasKey(t => t.Id);
        }
    }
}
