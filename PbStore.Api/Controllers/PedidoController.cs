using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidator;
using Microsoft.AspNetCore.Mvc;
using PbStore.Domain.Pedidos.Comandos;
using PbStore.Domain.Pedidos.Repositorios;

namespace PbStore.Api.Controllers
{
    public class PedidoController : BaseController
    {
        private readonly IRepositorioCliente _repositorioCliente;
        private readonly IRepositorioProduto _repositorioProduto;
        private readonly IRepositorioPedido _repositorioPedido;
        private readonly ManipuladorPedidos _handler;

        public PedidoController(IRepositorioPedido repositorioPedido,
            IRepositorioProduto repositorioProduto,
            IRepositorioCliente repositorioCliente,
            ManipuladorPedidos handler)
        {
            _repositorioPedido = repositorioPedido;
            _repositorioProduto = repositorioProduto;
            _repositorioCliente = repositorioCliente;
            _handler = handler;
        }

        [HttpPost]
        [Route("pedidos")]
        public Task<IActionResult> Post([FromBody]RegistrarPedido comando)
        {
            _handler.Manipular(comando);
            return Response(
                comando,
                "Pedido criado com sucesso",
                "Falha ao gerar pedidos",
                _handler.Notifications);
        }
    }
}
