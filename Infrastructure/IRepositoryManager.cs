using Core.repos;

namespace Infrastructure;

public interface IRepositoryManager
{
    ITacheRepository Tache { get; }
    void Save();
}