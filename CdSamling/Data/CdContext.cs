using CdSamling.Models;
using Microsoft.EntityFrameworkCore;

namespace CdSamling.Data 
{
    public class CdContext : DbContext 
    {
        public CdContext(DbContextOptions<CdContext> options) : base(options) {

        }

        public DbSet<Cd> Cd { get; set; }
    }
}