using ShopCET45.Web.Data.Entities;

namespace ShopCET45.Web.Data
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {

        }

    }
}
