using Microsoft.EntityFrameworkCore;

namespace Mission06_Kang.Models
{
    public class MovieAddedContext : DbContext
    {
        public MovieAddedContext(DbContextOptions<MovieAddedContext> options) : base (options) 
        {
        }

        public DbSet<AddingMovie> MoviesAdded { get; set; }
    }
}
 