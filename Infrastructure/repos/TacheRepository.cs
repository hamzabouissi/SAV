using Core.Entities;
using Core.repos;
using SAV.infrastructure;

namespace infrastructure.repos;

public class TacheRepository: BaseRepo<Taches>,ITacheRepository
{
    public TacheRepository(RepoContext repoContext) : base(repoContext)
    {
    }

    public IEnumerable<Taches> GetAll(bool trackChanges)
    {
        return FindAll(trackChanges);
    }

    public void CreateTache(Taches taches)
    {
       Create(taches);
    }

    

    public Taches? GetTache(int id,bool trackChanges)
    {
        return FindByCondition(item => item.Id == id,trackChanges).SingleOrDefault();
    }

    public void DeleteTache(Taches Tache)
    {
        Delete(Tache);
    }
}