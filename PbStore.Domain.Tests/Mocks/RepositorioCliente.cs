using System;
using PbStore.Domain.Pedidos;
using PbStore.Domain.Pedidos.ObjetosValor;
using PbStore.Domain.Pedidos.Repositorios;

namespace UnitTestProject1.Mocks
{
    public class RepositorioCliente : IRepositorioCliente
    {
        public Cliente Obter(Guid id)
        {
            var nome = new Nome("André", "Baltieri");
            var email = new Email("contato@andrebaltieri.net");
            var documento= new CPF("12345678901");
            var cliente = new Cliente(nome, email, documento, null, "", DateTime.Now);
            return cliente;
        }
    }
}
