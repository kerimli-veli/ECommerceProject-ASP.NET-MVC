using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Implementation;
using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Concrete
{
    public class SummaryOfSalesByQuarterService(ISummaryOfSalesByQuarterDal summaryOfSalesByQuarterDal) : ISummaryOfSalesByQuarterService
    {
        private readonly ISummaryOfSalesByQuarterDal _summaryOfSalesByQuarterDal = summaryOfSalesByQuarterDal;

        public void Add(SummaryOfSalesByQuarter summarySalesQuarter)
        {
            _summaryOfSalesByQuarterDal.Add(summarySalesQuarter);
        }

        public void Delete(int orderId)
        {
            var summaryQuarter = _summaryOfSalesByQuarterDal.Get(p => p.OrderId == orderId);
            _summaryOfSalesByQuarterDal.Delete(summaryQuarter);
        }

        public List<SummaryOfSalesByQuarter> GetAll()
        {
            return _summaryOfSalesByQuarterDal.GetList();
        }

        public List<SummaryOfSalesByQuarter> GetAllByCategory(int summarySalesQuarterId)
        {
            return _summaryOfSalesByQuarterDal.GetList(p => p.OrderId == summarySalesQuarterId);
        }

        public SummaryOfSalesByQuarter GetById(int id)
        {
            return _summaryOfSalesByQuarterDal.Get(p => p.OrderId == id);
        }

        public void Update(SummaryOfSalesByQuarter summarySalesQuarter)
        {
            _summaryOfSalesByQuarterDal.Update(summarySalesQuarter);
        }
    }
}
