using PbStore.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbStore.Dao.Mapping
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable("Produto");

            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(80).IsRequired();
            Property(x => x.Descricao).HasMaxLength(200).IsRequired();
            Property(x => x.Preco).IsRequired();
            Property(x => x.QuantidadeEmEstoque).IsRequired();
        }
    }
}
