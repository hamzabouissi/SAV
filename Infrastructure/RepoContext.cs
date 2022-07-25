using Core.Entities;
using Infrastructure.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SAV.infrastructure.Configurations;
using Version = Core.Entities.Version;


namespace SAV.infrastructure
{
    public class RepoContext : IdentityDbContext<User>
    {
        public RepoContext(DbContextOptions option) : base(option) { }
        public DbSet<FamilleTiers> FamilleTiers{ get; set; }
       
        public DbSet<Tiers> Tiers { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Ticket> Ticket { get; set; }

  
        public DbSet<Agent> Agent { get; set; }
        public DbSet<Produit> Produit { get; set; }
        public DbSet<Installation> Installation { get; set; }
        public DbSet<Incident> Incident { get; set; }
        public DbSet<Taches> Taches { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Version> Version{ get; set; }



        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //      optionsBuilder.UseNpgsql("Host=localhost;Database=savdb;Username=user;Password=mysecretpassword");
        // }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new FamilleTiersConfig());
            modelBuilder.ApplyConfiguration(new TicketConfig());
            modelBuilder.ApplyConfiguration(new TiersConfig());
            modelBuilder.ApplyConfiguration(new ContactConfig());
            modelBuilder.ApplyConfiguration(new AgentConfig());
            modelBuilder.ApplyConfiguration(new ProduitConfig());
            modelBuilder.ApplyConfiguration(new IncidentConfig());
            modelBuilder.ApplyConfiguration(new InstallationConfig());
            modelBuilder.ApplyConfiguration(new ProduitConfig());
            modelBuilder.ApplyConfiguration(new VersionConfig());
            modelBuilder.ApplyConfiguration(new ClientConfig());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
