namespace Core.Entities
{
    public class Tiers
    {
        private Tiers()
        {
            
        }
        public int Id { get; set; }
        public int Code { get; set; }
        public string Type { get; set; }
        public string Intitule { get; set; }
        public string FormeJuridique { get; set; }
        public string Adresse { get; set; }
        public string Complement { get; set; }
        public int CP { get; set; }
        public string Ville { get; set; }
        public string Gouvernorat { get; set; }
        public string Pays { get; set; }
        public int Tel1 { get; set; }
        public int Tel2 { get; set; }
        public string RegCom { get; set; }
        public string MatFiscal { get; set; }
        public int Gsm { get; set; }
        public string Email { get; set; }
        public int Cin { get; set; }
        public Boolean Inactif { get; set; }
        public string FonctionOccupé { get; set; }
        public string Notes { get; set; }

}
}
