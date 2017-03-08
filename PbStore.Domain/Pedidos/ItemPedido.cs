using System;

namespace PbStore.Domain.Pedidos
{
    public class ItemPedido : Entidade
    {
        public ItemPedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Valor = produto.Preco;
            Quantidade = quantidade;

            if (Quantidade > Produto.QuantidadeEmEstoque)
                throw new Exception("Quantidade excede a quantidade em estoque");
        }

        public Produto Produto { get; private set; }
        public decimal Valor { get; private set; }
        public int Quantidade { get; private set; }
    }
}
