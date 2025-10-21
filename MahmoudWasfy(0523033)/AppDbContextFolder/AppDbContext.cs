using MahmoudWasfy_0523033_.Models;
using Microsoft.EntityFrameworkCore;

namespace MahmoudWasfy_0523033_.AppDbContextFolder
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Coach> coaches { get; set; }

        public DbSet<Competition>  competitions { get; set; }

        public DbSet<Player> players { get; set; }

        public DbSet<Team> teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Coach>().HasOne(x => x.Team).WithOne(x => x.Coach).HasForeignKey<Team>(x => x.Coachid);

            modelBuilder.Entity<Team>().HasMany(x => x.players).WithOne(x => x.Team);

            modelBuilder.Entity<Team>().HasMany(x => x.competitions).WithMany(x => x.Teams);


            modelBuilder.Entity<Competition>().HasData
           (
                new Competition { Id = 1, Title = "idk", Location = "7elwan",}

           );


            modelBuilder.Entity<Team>().HasData
          (
               new Team { Id = 1, Name = "el ahly", city = "Cairo" , Coachid = 1     }

          );

            modelBuilder.Entity<Player>().HasData
            (

                new Player { Id = 1,FullName= "Wasfy",Position="Striker",Age = 18, TeamId = 1}

            );

            modelBuilder.Entity<Coach>().HasData
            (

                new Coach { Id = 1,Name = "mostafa",Specialization="Vollyball",ExpierneceYears = 3}


            );
        }
        
    }
}
