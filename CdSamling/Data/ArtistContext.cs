using CdSamling.Models;
using Microsoft.EntityFrameworkCore;

namespace CdSamling.Data 
{
    public class ArtistContext : DbContext 
    {
        public ArtistContext(DbContextOptions<ArtistContext> options) : base(options) {
            
        }

        public DbSet<Artist> Artist { get; set; }
    }
}