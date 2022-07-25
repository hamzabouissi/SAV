namespace Core.Entities
{
    public class Incident
    {
        private Incident()
        {
            
        }
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime date { get; set; }
        public int heure { get; set; }
        public string notes { get; set; }
        public string nature { get; set; }


    }
}
