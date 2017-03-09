using System.Data.Entity.ModelConfiguration;
using PbStore.Domain.Pedidos;

namespace DAO.Mapping
{
    public class PedidosMapping : EntityTypeConfiguration<Pedido>
    {
        public PedidosMapping()
        {
            ToTable("Pedidos");
            HasKey(x => x.Id);

            Property(x => x.Data).IsRequired();
            Property(x => x.Desconto).IsOptional();
            Property(x => x.TipoPagamento).IsRequired();

            // Verificar Relacionamentos Necessários

        }
    }
}
