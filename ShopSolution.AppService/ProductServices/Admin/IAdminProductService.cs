using ShopSolution.ViewModels.Products.Admin;
using ShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ShopSolution.AppService.ProductServices.Admin
{
    public interface IAdminProductService
    {
        Task<int> Create(AdminProductCreateRequest request);
        Task<int> Update(AdminProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewcount(int productId);
        Task<PageResult<ProductViewModel>> GetAllPaging(AdminProductPagingRequest request);
        Task<int> AddImages(int productId, List<IFormFile> files);
        Task<int> RemoveImages(int imageId);
        Task<int> UpdateImage(int imageId, string caption, bool isDefault);
        Task<List<AdminProductImageRequest>> GetListImage(int productId);
    }
}
