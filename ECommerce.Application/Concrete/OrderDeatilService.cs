using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Implementation;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Concrete
{
    public class OrderDeatilService(IOrderDetailDal orderDetailDal) : IOrderDetailService
    {
        private readonly IOrderDetailDal orderDetailDal = orderDetailDal;

        public void Add(OrderDetail orderDetail)
        {
            orderDetailDal.Add(orderDetail);
        }

        public void Delete(int Id)
        {
            var orderDeatil = orderDetailDal.Get(p => p.OrderId == Id);
            orderDetailDal.Delete(orderDeatil);
        }

        public List<OrderDetail> GetAll()
        {
            return orderDetailDal.GetList();
        }

        public List<OrderDetail> GetAllByCategory(int orderDetailId)
        {
            return orderDetailDal.GetList(p => p.OrderId == orderDetailId);
        }

        public OrderDetail GetById(int id)
        {
            return orderDetailDal.Get(p => p.OrderId == id);
        }

        public void Update(OrderDetail orderDetail)
        {
            orderDetailDal.Update(orderDetail);
        }
    }
}
