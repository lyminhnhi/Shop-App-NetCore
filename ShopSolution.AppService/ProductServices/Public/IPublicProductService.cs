using ShopSolution.ViewModels.Products.Public;
using ShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopSolution.AppService.ProductServices.Public
{
    public interface IPublicProductService
    {
        Task<PageResult<ProductViewModel>> GetAllByCategoryId(PublicProductPagingRequest request, string languageId);
        Task<List<ProductViewModel>> GetAll(string languageId);
    }
}
