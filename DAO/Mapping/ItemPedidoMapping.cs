using System;
using System.Data.Entity.ModelConfiguration;
using PbStore.Domain.Pedidos;

namespace DAO.Mapping
{
    public class ItemPedidoMapping : EntityTypeConfiguration<ItemPedido>
    {
        public ItemPedidoMapping()
        {
            ToTable("ItemPedido");
            HasKey(x => x.Id);

            Property(x => x.Quantidade).IsRequired();
            Property(x => x.Valor).IsRequired();

            // Verificar Relacionamentos Necessários

        }
    }
}
