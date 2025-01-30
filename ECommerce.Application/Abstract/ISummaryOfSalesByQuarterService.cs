using ECommerce.Domain.Entities;

namespace ECommerce.Application.Abstract
{
    public interface ISummaryOfSalesByQuarterService
    {
        List<SummaryOfSalesByQuarter> GetAll();
        List<SummaryOfSalesByQuarter> GetAllByCategory(int summarySalesQuarterId);
        SummaryOfSalesByQuarter GetById(int id);
        void Add(SummaryOfSalesByQuarter summarySalesQuarter);
        void Update(SummaryOfSalesByQuarter summarySalesQuarter);
        void Delete(int orderId);
    }
}
