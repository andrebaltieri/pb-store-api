using System.Data.Entity.ModelConfiguration;
using PbStore.Domain.Pedidos;

namespace DAO.Mapping
{
    public class ClienteMapping : EntityTypeConfiguration<Cliente>
    {
        public ClienteMapping()
        {
            ToTable("Clientes");
            HasKey(x => x.Id);

            Property(x => x.Nome.PrimeiroNome).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            Property(x => x.Nome.SegundoNome).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            Property(x => x.CPF.Numero).HasColumnType("varchar").HasMaxLength(11).HasColumnName("CPF").IsRequired();
            Property(x => x.Email.Endereco).HasColumnType("varchar").HasMaxLength(200).HasColumnName("Email").IsRequired();

            Property(x => x.Endereco.Logradouro).HasColumnType("varchar").HasMaxLength(120).IsRequired();
            Property(x => x.Endereco.Numero).HasColumnType("varchar").HasMaxLength(10).IsRequired();
            Property(x => x.Endereco.CEP).HasColumnType("varchar").HasMaxLength(8).IsRequired();
            Property(x => x.Endereco.Bairro).HasColumnType("varchar").HasMaxLength(60).IsRequired();
            Property(x => x.Endereco.Cidade).HasColumnType("varchar").HasMaxLength(60).IsRequired();
            Property(x => x.Endereco.Estado).HasColumnType("varchar").HasMaxLength(60).IsRequired();
            Property(x => x.Endereco.Pais).HasColumnType("varchar").HasMaxLength(60).IsRequired();

            Property(x => x.Telefone).HasColumnType("varchar").HasMaxLength(14).IsRequired();
            Property(x => x.DataNascimento).IsOptional();

        }
    }
}
