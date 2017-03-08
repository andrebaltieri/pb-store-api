using System;
using System.Collections.Generic;
using PbStore.Domain.Pedidos.Enums;

namespace PbStore.Domain.Pedidos.Comandos
{
    public class RegistrarPedido : IComando
    {
        public RegistrarPedido()
        {
            Itens = new Dictionary<Guid, int>();
        }
        public Guid Cliente { get; set; }
        public Dictionary<Guid, int> Itens { get; set; }
        public ETipoPagamento TipoPagamento { get; set; }
        public decimal Desconto { get; set; }
    }
}
