using Core.Entities;

namespace Core.repos;

public interface ITacheRepository
{
    IEnumerable<Taches> GetAll(bool trackChanges);
    void CreateTache(Taches tache);
    Taches? GetTache(int id,bool trackChanges);
    void DeleteTache(Taches tache);
}