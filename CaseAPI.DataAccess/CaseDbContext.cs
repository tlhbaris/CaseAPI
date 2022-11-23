using CaseAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CaseAPI.DataAccess;

public class CaseDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-NOQ0LHU;Initial Catalog=CaseAPIDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasIndex(x => x.Id);
            entity.Property(x => x.Color).HasMaxLength(50).IsRequired();
            entity.Property(x => x.Wheels).IsRequired();
            entity.Property(x => x.Headlights).IsRequired();

            entity.HasData(new Car {Id = 1,Color = "black",Headlights = true,Wheels = 4});
            entity.HasData(new Car { Id = 2, Color = "yellow", Headlights = false, Wheels = 4 });
            entity.HasData(new Car { Id = 3, Color = "blue", Headlights = true, Wheels = 4 });
            entity.HasData(new Car { Id = 4, Color = "yellow", Headlights = false, Wheels = 4 });

        });

        modelBuilder.Entity<Bus>(entity =>
        {
            entity.HasIndex(x => x.Id);
            entity.Property(x => x.Color).HasMaxLength(50).IsRequired();
            entity.Property(x => x.Wheels).IsRequired();
            entity.Property(x => x.Headlights).IsRequired();
            entity.Property(x => x.Capacity).IsRequired();

            entity.HasData(new Bus {Id = 1, Color = "blue", Headlights = true, Wheels = 6, Capacity = 27});
            entity.HasData(new Bus { Id = 2, Color = "yellow", Headlights = false, Wheels = 8, Capacity = 9700 });
            entity.HasData(new Bus { Id = 3, Color = "indigo", Headlights = true, Wheels = 4, Capacity = 16 });
            entity.HasData(new Bus { Id = 4, Color = "blue", Headlights = false, Wheels = 6, Capacity = 27 });
        });

        modelBuilder.Entity<Boat>(entity =>
        {
            entity.HasIndex(x => x.Id);
            entity.Property(x => x.Color).HasMaxLength(50).IsRequired();
            entity.Property(x => x.Length).IsRequired();

            entity.HasData(new Boat {Id = 1, Color = "orange", Length = 3.7M, WithSail = true});
            entity.HasData(new Boat { Id = 2, Color = "pink", Length =12.6M, WithSail = true});         
            entity.HasData(new Boat { Id = 3, Color = "brown", Length =7.6M, WithSail = false});
            entity.HasData(new Boat { Id = 4, Color = "black", Length = 1.2M, WithSail = false});
        });


    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<Bus> Buses { get; set; }
    public DbSet<Boat> Boats { get; set; }
}