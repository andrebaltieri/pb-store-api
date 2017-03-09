using System.Data.Entity.ModelConfiguration;
using PbStore.Domain.Pedidos;

namespace DAO.Mapping
{
    public class ProdutoMapping : EntityTypeConfiguration<Produto>
    {
        public ProdutoMapping()
        {
            ToTable("Produtos");
            HasKey(x => x.Id);

            Property(x => x.Nome).HasColumnType("varchar").HasMaxLength(60).IsRequired();
            Property(x => x.Descricao).HasColumnType("varchar").HasMaxLength(160).IsOptional();
            Property(x => x.Preco).IsRequired();
            Property(x => x.QuantidadeEmEstoque).IsRequired();
        }
    }
}
