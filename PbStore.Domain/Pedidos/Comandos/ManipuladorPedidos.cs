using FluentValidator;
using PbStore.Domain.Pedidos.ObjetosValor;
using PbStore.Domain.Pedidos.Repositorios;

namespace PbStore.Domain.Pedidos.Comandos
{
    public class ManipuladorPedidos :
        Notifiable,
        IManipulador<RegistrarPedido>
    {
        private readonly IRepositorioPedido _repositorioPedido;
        private readonly IRepositorioProduto _repositorioProduto;
        private readonly IRepositorioCliente _repositorioCliente;

        public ManipuladorPedidos(
            IRepositorioCliente repositorioCliente,
            IRepositorioPedido repositorioPedido,
            IRepositorioProduto repositorioProduto)
        {
            _repositorioPedido = repositorioPedido;
            _repositorioCliente = repositorioCliente;
            _repositorioProduto = repositorioProduto;
        }

        public void Manipular(RegistrarPedido comando)
        {
            // Registra o cliente (Ou obtem do banco)
            var cliente = _repositorioCliente.Obter(comando.Cliente);

            // Gera um novo pedido
            var pedido = new Pedido(comando.TipoPagamento, cliente);

            // Adiciona um item ao pedido
            foreach (var item in comando.Itens)
            {
                var produto = _repositorioProduto.Obter(item.Key);
                pedido.AdicionarItem(produto, item.Value);
            }

            // Aplica o desconto
            pedido.AplicarDesconto(comando.Desconto);

            // Adiciona as notificações
            AddNotifications(pedido.Notifications);

            // Salva no banco
            if (IsValid())
                _repositorioPedido.Salvar(pedido);
        }
    }
}
