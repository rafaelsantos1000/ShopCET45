using ShopCET45.Web.Data.Entities;
using ShopCET45.Web.Models;

namespace ShopCET45.Web.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel model, string path, bool isNew);



        ProductViewModel ToProductViewModel(Product model);
    }
}
