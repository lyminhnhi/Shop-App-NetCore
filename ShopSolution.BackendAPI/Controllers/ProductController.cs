using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopSolution.AppService.ProductServices.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSolution.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        public ProductController(IPublicProductService publicProductService)
        {
            _publicProductService = publicProductService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var dataProduct = await _publicProductService.GetAll();
            return Ok(dataProduct);
        }
    }
}
