

namespace Core.Entities
{
    public class Contact

    {
        private Contact()
        {
            
        }
        public int Id { get; set; }
        public int Code { get; set; }
        public int tel1 { get; set; }
        public int tel2 { get; set; }
        public string Email { get; set; }
        public int Cin { get; set; }
    }
}
