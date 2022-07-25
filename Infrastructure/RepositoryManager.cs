using Core.repos;
using infrastructure.repos;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SAV.infrastructure;

namespace Infrastructure;

public class RepositoryManager:IRepositoryManager
{
    private readonly RepoContext _context;
    private ITacheRepository _tacheRepository;

   

    public RepositoryManager(RepoContext context)
    {
        _context = context;
    }
    public ITacheRepository Tache
    {
        get
        {
            if (_tacheRepository is null)
                _tacheRepository = new TacheRepository(_context);
            return _tacheRepository;
        }
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}