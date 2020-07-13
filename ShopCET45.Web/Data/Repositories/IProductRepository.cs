using ShopCET45.Web.Data.Entities;
using System.Linq;

namespace ShopCET45.Web.Data.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable GetAllWithUsers();
    }
}
