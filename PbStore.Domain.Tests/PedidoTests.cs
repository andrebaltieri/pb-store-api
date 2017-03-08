using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PbStore.Domain.Pedidos;
using PbStore.Domain.Pedidos.Comandos;
using PbStore.Domain.Pedidos.Enums;
using PbStore.Domain.Pedidos.ObjetosValor;
using UnitTestProject1.Mocks;

namespace UnitTestProject1
{
    [TestClass]
    public class TestesPedido
    {
        private readonly Nome _nome = new Nome("André", "Baltieri");
        private readonly Email _email = new Email("contato@andrebaltieri.net");
        private readonly Endereco _endereco = new Endereco("1111111", "Av dos Marins", "1200", "Glébas Califórnia", "Piracicaba", "SP", "BR");
        private readonly CPF _cpf = new CPF("12312312333");

        // Registra o cliente (Ou obtem do banco)
        private readonly Cliente _cliente;

        // Registra o produto (Ou obtem do banco)
        private readonly Produto _caneta = new Produto("Caneta", "Linda caneta azul oceano", 5M, 30);

        public TestesPedido()
        {
            _cliente = new Cliente(_nome, _email, _cpf, _endereco, "99999999", new DateTime(1985, 10, 28));
        }

        [TestMethod]
        [TestCategory("Pedido - Novo Pedido")]
        public void Dada_a_compra_de_duas_canetas_no_valor_de_5_o_total_deve_ser_10()
        {            
            var pedido = new Pedido(ETipoPagamento.CartaoCredito, _cliente);
            pedido.AdicionarItem(_caneta, 2);

            Assert.AreEqual(10, pedido.CalcularTotal());
        }

        [TestMethod]
        [TestCategory("Pedido - Novo Pedido")]
        public void Dado_o_total_da_compra_de_15_quando_desconto_for_5_o_resultado_deve_ser_10()
        {
            var pedido = new Pedido(ETipoPagamento.CartaoCredito, _cliente);
            pedido.AdicionarItem(_caneta, 3);
            pedido.AplicarDesconto(5);

            Assert.AreEqual(10, pedido.CalcularTotal());
        }

        [TestMethod]
        public void Dado_um_pedido_valido_o_mesmo_deve_ser_gerado()
        {
            var comando = new RegistrarPedido();
            comando.Cliente = Guid.NewGuid();
            comando.Desconto = 5;
            comando.Itens.Add(Guid.NewGuid(), 3);
            comando.TipoPagamento = ETipoPagamento.CartaoCredito;

            var manipulador  =new ManipuladorPedidos(
                new RepositorioCliente(), 
                new RepositorioPedido(), 
                new RepositorioProduto());
            manipulador.Manipular(comando);

            Assert.AreEqual(0, manipulador.Notifications);
        }
    }
}
