using System;
using PbStore.Domain.Pedidos;
using PbStore.Domain.Pedidos.Repositorios;
using PbStore.Infra.Contexts;

namespace PbStore.Infra.Repositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly PbStoreDataContext _context;
        public RepositorioCliente(PbStoreDataContext context)
        {
            _context = context;
        }

        public Cliente Obter(Guid id)
        {
            return _context.Clientes.Find(id);
        }
    }
}
