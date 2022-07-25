using System.Linq.Expressions;

namespace infrastructure.repos;

public interface IRepositoryBase<T>
{
    public IQueryable<T> FindAll(bool trackChanges);
    public IQueryable<T> FindByCondition(Expression<Func<T,bool>> expression, bool trackChanges);
    public void Create(T entity);
    public void Update(T entity);
    public void Delete(T entity);
    
}