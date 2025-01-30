using ECommerce.Domain.Abstraction;
using System.Linq.Expressions;

namespace ECommerce.Repository;

public interface IEntityRepository<T> where T : class , IEntity , new()
{
    T Get(Expression<Func<T, bool>> filter = null); // .Get(x=>x.id == id)
    List<T> GetList(Expression<Func<T, bool>> filter = null);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}