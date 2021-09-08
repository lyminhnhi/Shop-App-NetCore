using Microsoft.EntityFrameworkCore;
using ShopSolution.Data.Entities;
using ShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description" }
               );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation()
                  {
                      Id = 1,
                      CategoryId = 1,
                      Name = "Trái Cây",
                      LanguageId = "vi-VN",
                      SeoAlias = "trai-cay",
                      SeoDescription = "Sản phẩm trái cây",
                      SeoTitle = "Sản phẩm trái cây"
                  },
                  new CategoryTranslation()
                  {
                      Id = 2,
                      CategoryId = 1,
                      Name = "Fruit",
                      LanguageId = "en-US",
                      SeoAlias = "fruit",
                      SeoDescription = "The fruit products",
                      SeoTitle = "The fruit products"
                  },
                  new CategoryTranslation()
                  {
                      Id = 3,
                      CategoryId = 2,
                      Name = "Rau Củ Quả",
                      LanguageId = "vi-VN",
                      SeoAlias = "rau-cu-qua",
                      SeoDescription = "Rau Củ Quả",
                      SeoTitle = "Rau Củ Quả"
                  },
                  new CategoryTranslation()
                  {
                      Id = 4,
                      CategoryId = 2,
                      Name = "Vegetable",
                      LanguageId = "en-US",
                      SeoAlias = "vegetable",
                      SeoDescription = "Vegetable",
                      SeoTitle = "Vegetable"
                  }
                    );

            modelBuilder.Entity<Product>().HasData(
           new Product()
           {
               Id = 1,
               DateCreated = DateTime.Now,
               OriginalPrice = 10,
               Price = 20,
               Stock = 0,
               ViewCount = 0,
           });
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Táo",
                     LanguageId = "vi-VN",
                     SeoAlias = "tao",
                     SeoDescription = "tao",
                     SeoTitle = "tao",
                     Details = "Táo",
                     Description = "Táo"
                 },
                    new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 1,
                        Name = "Apple",
                        LanguageId = "en-US",
                        SeoAlias = "apple",
                        SeoDescription = "apple",
                        SeoTitle = "apple",
                        Details = "Apple",
                        Description = "Apple"
                    });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );
        }
    }
}



