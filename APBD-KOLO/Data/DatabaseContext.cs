using APBD_KOLO.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_KOLO.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<backpacks> backpacks { get; set; }
    public DbSet<characters> characters { get; set; }
    public DbSet<character_titles> character_titles { get; set; }
    public DbSet<items> items { get; set; }
    public DbSet<titles> titles { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<items>().HasData(new List<items>
            {
                new items {
                    Id = 1,
                    Name = "KrzysioweZakola",
                    Weight = 50
                },
                new items {
                    Id = 2,
                    Name = "KrzysioweOkulary",
                    Weight = 3
                }
            });

            modelBuilder.Entity<characters>().HasData(new List<characters>
            {
                new characters {
                    Id = 1,
                    FirstName = "Krzysztow",
                    LastName = "Gargulec",
                    CurrentWei = 50,
                    MaxWeight = 100
                },
                new characters {
                    Id = 2,
                    FirstName = "Adam",
                    LastName = "Kulogniot",
                    CurrentWei = 60,
                    MaxWeight = 100
                }
            });

            modelBuilder.Entity<titles>().HasData(new List<titles>
            {
                new titles
                {
                    Id = 1,
                    Name = "Kryminalista",
                    
                },
                new titles
                {
                    Id = 2,
                    Name = "Kapus",
                   
                },
               
            });

            modelBuilder.Entity<character_titles>().HasData(new List<character_titles>
            {
                new character_titles
                {
                    CharacterId = 1,
                    TitleId = 1,
                    AcquiredAt = DateTime.Parse("2024-05-29")
                },
                new character_titles
                {
                    CharacterId = 2,
                    TitleId = 2,
                    AcquiredAt = DateTime.Parse("2024-05-30")
                },
            });

            modelBuilder.Entity<backpacks>().HasData(new List<backpacks>
            {
                new backpacks
                {
                    CharacterId = 1,
                    ItemId = 1,
                    Amount = 1
                },
                new backpacks
                {
                    CharacterId = 2,
                    ItemId = 2,
                    Amount = 2
                },
              
            });
    }
}
