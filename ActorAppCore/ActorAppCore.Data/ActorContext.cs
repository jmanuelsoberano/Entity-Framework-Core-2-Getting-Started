using ActorAppCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace ActorAppCore.Data
{
    public class ActorContext : DbContext
    {
        public ActorContext(DbContextOptions<ActorContext> options)
            : base(options)
        { }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovie>()
                .HasKey(s => new { s.ActorId, s.MovieId });
        }
    }
}
