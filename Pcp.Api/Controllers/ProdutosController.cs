using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pcp.Domain.Entities;
using Pcp.Infrastructure.Data;

namespace Pcp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {

    


        [HttpGet]
        public ActionResult<Produto> GetProdutos()
        {
            return 
        }
    }
}
