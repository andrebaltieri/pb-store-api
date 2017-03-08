using System;

namespace PbStore.Domain.Pedidos.Repositorios
{
    public interface IRepositorioCliente
    {
        Cliente Obter(Guid id);
    }
}
