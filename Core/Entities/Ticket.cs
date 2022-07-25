namespace Core.Entities
{
    public class Ticket
    {
        private Ticket()
        {
            
        }
        public int Id { get; set; }
        public string Intitule { get; set; }
        public string Famille { get; set; }
        public string Description { get; set; }
        public Boolean Inactif { get; set; }
        public Boolean Etat { get; set; }
        public string TravailEffect { get; set; }
        public string Notes { get; set; }


    }
}
