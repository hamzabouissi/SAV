namespace WebApplication1.Dtos.Taches;

public class TacheDto
{
    public int Id { get; set; }
    public string Intitule { get; set; }
    public DateTime DateCreation { get; set; }
    public string Type { get; set; }
    public DateTime DateDemarrage { get; set; }
    public string Observation { get; set; }
    public int Classement { get; set; }
    public Boolean Etat { get; set; }
    public string DescriptionTaches { get; set; }
}