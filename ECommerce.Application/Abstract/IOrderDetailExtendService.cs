using ECommerce.Domain.Entities;

namespace ECommerce.Application.Abstract
{
    public interface IOrderDetailExtendService
    {
        List<OrderDetailsExtended> GetAll();
        List<OrderDetailsExtended> GetAllByCategory(int orderDeatilExtendId);
        OrderDetailsExtended GetById(int id);
        void Add(OrderDetailsExtended orderDetailsExtended);
        void Update(OrderDetailsExtended orderDetailsExtended);
        void Delete(int orderDetailExtendId);
    }
}
