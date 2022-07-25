namespace Core.Entities
{
    public  class Installation
    {
        private Installation()
        {
            
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
    }
}
