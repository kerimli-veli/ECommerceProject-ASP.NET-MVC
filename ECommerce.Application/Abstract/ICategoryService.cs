using ECommerce.Domain.Entities;

namespace ECommerce.Application.Abstract;

public interface ICategoryService
{
    List<Category> GetAll();
}
