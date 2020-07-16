using ShopCET45.Web.Data.Entities;
using System.Threading.Tasks;
using System.Linq;
using ShopCET45.Web.Models;

namespace ShopCET45.Web.Data.Repositories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IQueryable<Order>> GetOrdersAsync(string userName);


        Task<IQueryable<OrderDetailTemp>> GetDetailTempsAsync(string userName);


        Task AddItemToOrderAsync(AddItemViewModel model, string userName);


        Task ModifyOrderDetailTempQuantityAsync(int id, double quantity);

        Task DeleteDetailTempAsync(int id);


        Task<bool> ConfirmOrderAsync(string userName);
    }
}
