using GraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Utilisateur> Utilisateurs { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

    }
}
