using PbStore.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbStore.Dao.Mapping
{
    public class PedidoMap : EntityTypeConfiguration<Pedido>
    {
        public PedidoMap()
        {
            ToTable("Pedido");

            HasKey(x => x.Id);
            Property(x => x.Data).IsRequired();
            Property(x => x.TipoPagamento).IsRequired().HasColumnType("int");
            Property(x => x.Cliente.Id).IsRequired();
            Property(x => x.Desconto).IsOptional();
        }
    }
}
