using ShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.ViewModels.Products.Public
{
    public class PublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
