using ECommerce.Domain.Entities;

namespace ECommerce.Application.Abstract
{
    public interface IOrderDetailService
    {
        List<OrderDetail> GetAll();
        List<OrderDetail> GetAllByCategory(int orderDeatilId);
        OrderDetail GetById(int id);
        void Add(OrderDetail orderDetail);
        void Update(OrderDetail orderDetail);
        void Delete(int orderDetailId);
    }
}
