using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class MovieDbContext :DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Movie> Movies { get; set; }

    }
}
