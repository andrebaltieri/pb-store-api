using System.Data.Entity.ModelConfiguration;
using PbStore.Domain.Pedidos;

namespace PbStore.Infra.Mappings
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            HasKey(x => x.Id);
            Property(x => x.Nome.PrimeiroNome);
            Property(x => x.Nome.SegundoNome);
            Property(x => x.DataNascimento);
            Property(x => x.Telefone);
            Property(x => x.CPF.Numero);
            Property(x => x.Email.Endereco);
        }
    }
}
