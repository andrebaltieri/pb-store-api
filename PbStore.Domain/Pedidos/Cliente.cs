using System;
using PbStore.Domain.Pedidos.ObjetosValor;

namespace PbStore.Domain.Pedidos
{
    public class Cliente : Entidade
    {
        public Cliente(
            Nome nome, 
            Email email, 
            CPF cpf,
            Endereco endereco,
            string telefone,
            DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
            Endereco = endereco;
            Telefone = telefone;
            DataNascimento = dataNascimento;
        }
        
        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public CPF CPF { get; private set; }
        public Endereco Endereco { get; private set; }
        public string Telefone { get; private set; }
        public DateTime DataNascimento { get; private set; }

        public void AtualizarDocumento(string cpf)
        {
            // Validar CPF
        }
    }
}
