using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopSolution.AppService.ProductServices.Admin;
using ShopSolution.AppService.ProductServices.Public;
using ShopSolution.ViewModels.Products.Public;
using ShopSolution.ViewModels.Products.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopSolution.ViewModels.Products.Admin.ProductImages;

namespace ShopSolution.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IAdminProductService _adminProductService;
        public ProductsController(IPublicProductService publicProductService, IAdminProductService adminProductService)
        {
            _publicProductService = publicProductService;
            _adminProductService = adminProductService;
        }

        //---Public---

        //http://localhost:port/api/products/?pageIndex=1&pageSize=10&CategoryId=1/{languageId}
        [HttpGet("{languageId}")]
        public async Task<IActionResult> GetAllByCategoryId([FromQuery] PublicProductPagingRequest request, string languageId)
        {
            var dataProduct = await _publicProductService.GetAllByCategoryId(request, languageId);
            return Ok(dataProduct);
        }

        //---Admin---
        //http://localhost:port/products/{productId}/{languageId}
        [HttpGet("{productId}/{languageId}")]
        public async Task<IActionResult> GetByIdAndLanguage(int productId, string languageId)
        {
            var productViewModel = await _adminProductService.GetByIdAndLanguage(productId, languageId);
            if (productViewModel == null)
                return BadRequest("Cannot find product");
            return Ok(productViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] AdminProductCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var productId = await _adminProductService.Create(request);
            if (productId == 0)
                return BadRequest();

            var productViewModel = await _adminProductService.GetByIdAndLanguage(productId, request.LanguageId);

            return CreatedAtAction(nameof(GetByIdAndLanguage), new { id = productId }, productViewModel);
            // or Create(nameof(GetById), productViewModel)
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] AdminProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var Result = await _adminProductService.Update(request);
            if (Result == 0)
                return BadRequest();
            return Ok();
        }

        [HttpPatch("{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var isSuccessful = await _adminProductService.UpdatePrice(productId, newPrice);
            if (isSuccessful)
                return Ok();

            return BadRequest();
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var Result = await _adminProductService.Delete(productId);
            if (Result == 0)
                return BadRequest();
            return Ok();
        }

        //----------------Images-----------------
        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(int productId, int imageId)
        {
            var image = await _adminProductService.GetImageById(productId, imageId);
            if (image == null)
                return BadRequest("Cannot find product");
            return Ok(image);
        }

        [HttpPost("{productId}/images")]
        public async Task<IActionResult> AddImage(int productId, [FromForm] AdminProductImageAddRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var imageId = await _adminProductService.AddImage(productId, request);
            if (imageId == 0)
                return BadRequest();

            var image = await _adminProductService.GetImageById(productId, imageId);

            return CreatedAtAction(nameof(GetImageById), new { id = imageId }, image);
        }

        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImage(int productId, int imageId, [FromForm] AdminProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _adminProductService.UpdateImage(productId, imageId, request);
            if (result == 0)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> RemoveImage(int productId, int imageId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _adminProductService.RemoveImage(productId, imageId);
            if (result == 0)
                return BadRequest();

            return Ok();
        }
    }
}
