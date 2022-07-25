


namespace Core.Entities;
public class Agent
{
    private Agent()
    {
        
    }
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public Boolean Inactif { get; set; }

}
