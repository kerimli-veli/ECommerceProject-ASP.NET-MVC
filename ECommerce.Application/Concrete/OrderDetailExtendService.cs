using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Implementation;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Concrete
{
    public class OrderDetailExtendService(IOrderDetailExtendDal orderDetailExtend) : IOrderDetailExtendService
    {
        private readonly IOrderDetailExtendDal _orderDetailExtend = orderDetailExtend;

        public void Add(OrderDetailsExtended orderDetailsExtended)
        {
            _orderDetailExtend.Add(orderDetailsExtended);
        }

        public void Delete(int orderDetailExtendId)
        {
            var orderDetailsExtended = _orderDetailExtend.Get(p => p.ProductId == orderDetailExtendId);
            _orderDetailExtend.Delete(orderDetailsExtended);
        }

        public List<OrderDetailsExtended> GetAll()
        {
            return _orderDetailExtend.GetList();
        }

        public List<OrderDetailsExtended> GetAllByCategory(int orderDeatilExtendId)
        {
            return _orderDetailExtend.GetList(p => p.OrderId == orderDeatilExtendId);
        }

        public OrderDetailsExtended GetById(int id)
        {
            return _orderDetailExtend.Get(p => p.ProductId == id);
        }

        public void Update(OrderDetailsExtended orderDetailsExtended)
        {
            _orderDetailExtend.Update(orderDetailsExtended);
        }
    }
}
