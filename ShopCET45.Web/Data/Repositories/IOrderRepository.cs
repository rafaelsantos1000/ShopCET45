using ShopCET45.Web.Data.Entities;
using System.Threading.Tasks;
using System.Linq;

namespace ShopCET45.Web.Data.Repositories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IQueryable<Order>> GetOrdersAsync(string userName);
    }
}
