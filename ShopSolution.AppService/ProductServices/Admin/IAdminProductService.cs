using ShopSolution.ViewModels.Products.Admin;
using ShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ShopSolution.ViewModels.Products.Admin.ProductImages;

namespace ShopSolution.AppService.ProductServices.Admin
{
    public interface IAdminProductService
    {
        Task<int> Create(AdminProductCreateRequest request);
        Task<int> Update(AdminProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<ProductViewModel> GetByIdAndLanguage(int productId, string languageId);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewcount(int productId);
        Task<PageResult<ProductViewModel>> GetAllPaging(AdminProductPagingRequest request);
        Task<int> AddImage(int productId, AdminProductImageAddRequest request);
        Task<int> UpdateImage(int productId, int imageId, AdminProductImageUpdateRequest request);
        Task<int> RemoveImage(int productId, int imageId);
        Task<List<AdminProductImageViewModel>> GetListImage(int productId);
        Task<AdminProductImageViewModel> GetImageById(int productId, int imageId);
    }
}
