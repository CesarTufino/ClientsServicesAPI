using ClientsServicesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientsServicesAPI.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
