using e_Tickets.Models;
using Microsoft.EntityFrameworkCore;

namespace e_Tickets.Context
{
    public class ETicketsDbContext1:DbContext
    {
        public ETicketsDbContext1() {}
        //database connectionstring 
        public ETicketsDbContext1(DbContextOptions<ETicketsDbContext1> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //add configration of the relation many-->many between the movies and actors
            //add the composedprimarykey
            modelBuilder.Entity<Actors_Movies>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            //add the relation 
            modelBuilder.Entity<Actors_Movies>().HasOne(a=> a.Actror).WithMany(am => am.Actors_Movies).HasForeignKey(a => a.ActorId);
            modelBuilder.Entity<Actors_Movies>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
