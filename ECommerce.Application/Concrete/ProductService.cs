using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Concrete;

public class ProductService(IProductDal productDal) : IProductService
{

    private readonly IProductDal _productDal = productDal;

    public void Add(Product product)
    {
        _productDal.Add(product);
    }

    public void Delete(int productId)
    {
        var product = _productDal.Get(p=>p.ProductId==productId);
        _productDal.Delete(product);
    }

    public List<Product> GetAll()
    {
        return _productDal.GetList();
    }

    public List<Product> GetAllByCategory(int categoryId)
    {
        return _productDal.GetList(p => p.CategoryId == categoryId);
    }

    public Product GetById(int id)
    {
        return _productDal.Get(p=>p.ProductId==id);
    }

    public void Update(Product product)
    {
        _productDal.Update(product);
    }
}
