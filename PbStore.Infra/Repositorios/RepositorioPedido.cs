using PbStore.Domain.Pedidos;
using PbStore.Domain.Pedidos.Repositorios;
using PbStore.Infra.Contexts;

namespace PbStore.Infra.Repositorios
{
    public class RepositorioPedido : IRepositorioPedido
    {
        private readonly PbStoreDataContext _context;
        public RepositorioPedido(PbStoreDataContext context)
        {
            _context = context;
        }

        public void Salvar(Pedido pedido)
        {
            // TODO: Implementar
        }
    }
}
