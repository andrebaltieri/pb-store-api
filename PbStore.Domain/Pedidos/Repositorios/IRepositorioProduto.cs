using System;

namespace PbStore.Domain.Pedidos.Repositorios
{
    public interface IRepositorioProduto
    {
        Produto Obter(Guid id);
    }
}
