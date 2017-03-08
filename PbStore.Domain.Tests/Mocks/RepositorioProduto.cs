using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PbStore.Domain.Pedidos;
using PbStore.Domain.Pedidos.Repositorios;

namespace UnitTestProject1.Mocks
{
    public class RepositorioProduto : IRepositorioProduto
    {
        public Produto Obter(Guid id)
        {
            return new Produto("Caneta", "Caneta Azul", 10, 80);
        }
    }
}
