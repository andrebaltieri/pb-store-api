namespace PbStore.Domain.Pedidos
{
    public class Produto : Entidade
    {
        public Produto(string nome, string descricao, decimal preco, int quantidadeEmEstoque)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public int QuantidadeEmEstoque { get; private set; }
    }
}
