using ShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.ViewModels.Products.Admin
{
    public class AdminProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryId { get; set; }
    }
}
