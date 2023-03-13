using System;
using FacilitiesAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FacilitiesAPI.DAL
{
    public class AppDbContext: DbContext
    {
        public DbSet<TankEntity> Tanks { get; set; } = null!;
        public DbSet<UnitEntity> Units { get; set; } = null!;

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UnitEntity>().HasData(new
            {
                Id = 1,
                Name = "ГФУ-2",
                Description = "Газофракционирующая установка",
            });

            modelBuilder.Entity<UnitEntity>().HasData(new
            {
                Id = 2,
                Name = "АВТ-6",
                Description = "Атмосферно-вакуумная трубчатка",
            });

            modelBuilder.Entity<UnitEntity>().HasData(new
            {
                Id = 3,
                Name = "АВТ-10",
                Description = "Атмосферно-вакуумная трубчатка",
            });

            modelBuilder.Entity<TankEntity>().HasData(new
            {
                Id = 1,
                Name = "Резервуар 1",
                Description = "Надземный - вертикальный",
                Volume = 1500,
                MaxVolume = 2000,
                UnitId = 1
            });

            modelBuilder.Entity<TankEntity>().HasData(new
            {
                Id = 2,
                Name = "Резервуар 2",
                Description = "Надземный - горизонтальный",
                Volume = 2500,
                MaxVolume = 3000,
                UnitId = 1
            });

            modelBuilder.Entity<TankEntity>().HasData(new
            {
                Id = 3,
                Name = "Дополнительный резервуар 24",
                Description = "Надземный - горизонтальный",
                Volume = 3000,
                MaxVolume = 3000,
                UnitId = 2
            });

            modelBuilder.Entity<TankEntity>().HasData(new
            {
                Id = 4,
                Name = "Резервуар 35",
                Description = "Надземный - вертикальный",
                Volume = 3000,
                MaxVolume = 3000,
                UnitId = 2
            });

            modelBuilder.Entity<TankEntity>().HasData(new
            {
                Id = 5,
                Name = "Резервуар 47",
                Description = "Подземный - двустенный",
                Volume = 4000,
                MaxVolume = 5000,
                UnitId = 2
            });

            modelBuilder.Entity<TankEntity>().HasData(new
            {
                Id = 6,
                Name = "Резервуар 256",
                Description = "Подводный",
                Volume = 500,
                MaxVolume = 500,
                UnitId = 3
            });
        }
    }
}