using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SAV.infrastructure;

namespace infrastructure.repos;

public abstract class BaseRepo<T>: IRepositoryBase<T> where T: class
{
    private readonly RepoContext _repoContext;

    public BaseRepo(RepoContext repoContext)
    {
        _repoContext = repoContext;
    }
    public IQueryable<T> FindAll(bool trackChanges)
    {
        return !trackChanges ? _repoContext.Set<T>().AsNoTracking() : _repoContext.Set<T>();
    }

   

    public IQueryable<T> FindByCondition(Expression<Func<T,bool>> expression, bool trackChanges)
    {
        return !trackChanges
            ? _repoContext.Set<T>().Where(expression).AsNoTracking()
            : _repoContext.Set<T>().Where(expression);
    }

    public void Create(T entity)
    {
       _repoContext.Set<T>().Add(entity);
        
    }

    public void Update(T entity)
    {
        _repoContext.Set<T>().Update(entity);
    }

    public void Delete(T entity)
    {
        _repoContext.Set<T>().Remove(entity);
    }
}