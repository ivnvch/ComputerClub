using Computer_Club.Model.DataBaseModels;
using Microsoft.EntityFrameworkCore;

namespace Computer_Club.Model
{
    public class ApplicationDataBaseContext:DbContext
    {
        public ApplicationDataBaseContext(DbContextOptions<ApplicationDataBaseContext> dbContextOptions) 
            : base(dbContextOptions) => Database.EnsureCreated();


        public DbSet<Computer> Computers { get; set; } = null!;
        public DbSet<ComputerClub> Clubs { get; set; } = null!;
        public DbSet<Game> Games { get; set; } = null!;

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ComputerClub>().HasData(new ComputerClub { Id = 1, Name = "Stares" });
        //    modelBuilder.Entity<ComputerClub>().HasData(new ComputerClub { Id = 2, Name = "Berlingo" });
        //}

    }
}
