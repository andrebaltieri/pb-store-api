using System;
using System.Collections.Generic;
using PbStore.Domain.Pedidos.Enums;

namespace PbStore.Domain.Pedidos.Comandos
{
    public class RegistrarPedido : IComando
    {
        public RegistrarPedido()
        {
            Itens = new List<ItemPedido>();
        }
        public Guid Cliente { get; set; }
        public IList<ItemPedido> Itens { get; set; }
        public ETipoPagamento TipoPagamento { get; set; }
        public decimal Desconto { get; set; }
    }

    public class ItemPedido : IComando
    {
        public ItemPedido(Guid produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public Guid Produto { get; set; }
        public int Quantidade  { get; set; }
    }
}
