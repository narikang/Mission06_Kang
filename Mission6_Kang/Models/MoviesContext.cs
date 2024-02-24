using Microsoft.EntityFrameworkCore;

namespace Mission06_Kang.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base (options) 
        {
        }

        public DbSet<AddingMovie>? Movies { get; set; }

        public DbSet<Categories> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(

                new Categories { CategoryId = 1, CategoryName = "Miscellaneous" },
                new Categories { CategoryId = 2, CategoryName = "Drama" },
                new Categories { CategoryId = 3, CategoryName = "Magic" },
                new Categories { CategoryId = 4, CategoryName = "Television" },
                new Categories { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Categories { CategoryId = 6, CategoryName = "Comedy" },
                new Categories { CategoryId = 7, CategoryName = "Family" },
                new Categories { CategoryId = 8, CategoryName = "Action/Adventure" },
                new Categories { CategoryId = 9, CategoryName = "VHS" }

                );
        }
    }
}
 