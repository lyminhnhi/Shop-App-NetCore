using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.ViewModels.Products.Admin
{
    public class AdminProductImageRequest
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public bool IsDefault { get; set; }
        public long FileSize { get; set; }
    }
}
