using System;
using System.Collections.Generic;
using System.Linq;
using PbStore.Domain.Pedidos;
using PbStore.Domain.Pedidos.Repositorios;

namespace PbStore.Infra.Repositorios
{
    public class RepositorioProduto : IRepositorioProduto
    {
        public Produto Obter(Guid id)
        {
            return new Produto("Mouse", "Mouse", 299, 50);
        }

        public IEnumerable<Produto> Obter(int skip, int take)
        {
            var produtos = new List<Produto>();
            produtos.Add(new Produto("Mouse", "Mouse", 299, 50));
            return produtos.Skip(skip).Take(take);
        }
    }
}
