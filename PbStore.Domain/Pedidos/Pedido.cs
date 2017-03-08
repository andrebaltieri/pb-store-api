using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidator;
using PbStore.Domain.Pedidos.Enums;

namespace PbStore.Domain.Pedidos
{
    public class Pedido : Entidade
    {
        private readonly IList<ItemPedido> _items;

        public Pedido(
            ETipoPagamento tipoPagamento,
            Cliente cliente)
        {
            Data = DateTime.Now;
            TipoPagamento = tipoPagamento;
            Cliente = cliente;
            Desconto = 0;
            _items = new List<ItemPedido>();

            new ValidationContract<Pedido>(this)
                .IsGreaterThan(x => x.Data, DateTime.Now.AddSeconds(-5));
        }

        public DateTime Data { get; private set; }
        public ETipoPagamento TipoPagamento { get; private set; }
        public Cliente Cliente { get; private set; }
        public decimal Desconto { get; private set; }

        public IReadOnlyCollection<ItemPedido> Items => _items.ToList();

        public decimal CalcularTotal()
        {
            var subTotal = _items.Sum(item => (item.Quantidade * item.Valor));
            return subTotal - Desconto;
        }

        public decimal CalcularSubTotal()
        {
            return _items.Sum(item => (item.Quantidade * item.Valor));
        }

        public void AdicionarItem(ItemPedido item)
        {
            _items.Add(item);
        }

        public void AdicionarItem(Produto produto, int quantidade)
        {
            _items.Add(new ItemPedido(produto, quantidade));
        }

        public void AplicarDesconto(decimal desconto)
        {
            if (Desconto > 0)
                AddNotification("Desconto", "Já há um desconto aplicado a este pedido");

            if (desconto >= CalcularSubTotal())
                AddNotification("Desconto", "O desconto é inválido");

            if (IsValid())
                Desconto = desconto;
        }
    }
}
