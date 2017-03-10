using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PbStore.Domain.Pedidos;
using WebApi.OutputCache.V2;

namespace PbStore.Api.Controllers
{
    [Route("produtos")]
    public class ProdutoController : BaseController
    {
        [HttpGet]
        [Route("")]
        [CacheOutput(ClientTimeSpan = 100, ServerTimeSpan = 100)]
        public Task<IActionResult> Get()
        {
            return Response(
                new Produto("Mouse 2", "Mouse Legal 2", 299, 50),
                "", 
                "", null);
        }

        [HttpGet]
        [Route("v2")]
        public Produto GetV2()
        {
            return new Produto("Mouse 2", "Mouse Legal 2", 299, 50);
        }

        [HttpGet]
        [Route("{id}")]
        public Produto GetById(Guid id)
        {
            return new Produto("Mouse", "Mouse Legal", 299, 50);
        }

        [HttpPost]
        [Route("")]
        public Produto Post([FromBody]Produto produto)
        {
            return produto;
        }
    }
}
