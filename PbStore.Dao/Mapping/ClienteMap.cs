using PbStore.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbStore.Dao.Mapping
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");

            HasKey(x => x.Id);
            Property(x => x.Nome.PrimeiroNome).HasMaxLength(30).HasColumnName("PrimeiroNome").IsRequired();
            Property(x => x.Nome.SegundoNome).HasMaxLength(30).HasColumnName("SegundoNome").IsRequired();
            Property(x => x.Email.Endereco).HasMaxLength(100).HasColumnName("Email").IsRequired();
            Property(x => x.CPF.Numero).HasMaxLength(11).HasColumnName("CPF").IsRequired();
            Property(x => x.Endereco.Logradouro).HasMaxLength(80).HasColumnName("Logradouro").IsRequired();
            Property(x => x.Endereco.CEP).HasMaxLength(8).HasColumnName("CEP").IsRequired();
            Property(x => x.Endereco.Numero).HasMaxLength(5).HasColumnName("Numero").IsOptional();
            Property(x => x.Endereco.Bairro).HasMaxLength(30).HasColumnName("Bairro").IsRequired();
            Property(x => x.Endereco.Cidade).HasMaxLength(50).HasColumnName("Cidade").IsRequired();
            Property(x => x.Endereco.Estado).HasMaxLength(50).HasColumnName("Estado").IsRequired();
            Property(x => x.Endereco.Pais).HasMaxLength(50).HasColumnName("Pais").IsRequired();
            Property(x => x.Telefone).HasMaxLength(10).IsOptional();
            Property(x => x.DataNascimento).IsRequired();            
        }
    }
}
