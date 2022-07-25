namespace Core.Entities
{
    public class FamilleTiers
    {
        private FamilleTiers()
        {
            
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public Boolean Inactif { get; set; }
        public int Code { get; set; }
        public string Intitule { get; set; }
        public string Type { get; set; }

    }
}
