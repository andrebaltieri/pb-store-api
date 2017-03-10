using System;
using System.Collections.Generic;

namespace PbStore.Domain.Pedidos.Repositorios
{
    public interface IRepositorioProduto
    {
        Produto Obter(Guid id);
        IEnumerable<Produto> Obter(int skip, int take);
    }
}
