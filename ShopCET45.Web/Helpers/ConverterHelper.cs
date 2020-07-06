using ShopCET45.Web.Data.Entities;
using ShopCET45.Web.Models;

namespace ShopCET45.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        public Product ToProduct(ProductViewModel model, string path, bool isNew)
        {
            return new Product
            {
                Id = isNew ? 0 : model.Id,
                ImageUrl = path,
                IsAvailable = model.IsAvailable,
                LastPurchase = model.LastPurchase,
                LastSale = model.LastSale,
                Name = model.Name,
                Price = model.Price,
                Stock = model.Stock,
                User = model.User
            };
        }




        public ProductViewModel ToProductViewModel(Product model)
        {
            return new ProductViewModel
            {
                Id = model.Id,
                IsAvailable = model.IsAvailable,
                LastPurchase = model.LastPurchase,
                LastSale = model.LastSale,
                ImageUrl = model.ImageUrl,
                Name = model.Name,
                Price = model.Price,
                Stock = model.Stock,
                User = model.User
            };
        }
    }
}
