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
                Name = "���-2",
                Description = "������������������� ���������",
            });

            modelBuilder.Entity<UnitEntity>().HasData(new
            {
                Id = 2,
                Name = "���-6",
                Description = "����������-��������� ���������",
            });

            modelBuilder.Entity<UnitEntity>().HasData(new
            {
                Id = 3,
                Name = "���-10",
                Description = "����������-��������� ���������",
            });

            modelBuilder.Entity<TankEntity>().HasData(new
            {
                Id = 1,
                Name = "��������� 1",
                Description = "��������� - ������������",
                Volume = 1500,
                MaxVolume = 2000,
                UnitId = 1
            });

            modelBuilder.Entity<TankEntity>().HasData(new
            {
                Id = 2,
                Name = "��������� 2",
                Description = "��������� - ��������������",
                Volume = 2500,
                MaxVolume = 3000,
                UnitId = 1
            });

            modelBuilder.Entity<TankEntity>().HasData(new
            {
                Id = 3,
                Name = "�������������� ��������� 24",
                Description = "��������� - ��������������",
                Volume = 3000,
                MaxVolume = 3000,
                UnitId = 2
            });

            modelBuilder.Entity<TankEntity>().HasData(new
            {
                Id = 4,
                Name = "��������� 35",
                Description = "��������� - ������������",
                Volume = 3000,
                MaxVolume = 3000,
                UnitId = 2
            });

            modelBuilder.Entity<TankEntity>().HasData(new
            {
                Id = 5,
                Name = "��������� 47",
                Description = "��������� - ����������",
                Volume = 4000,
                MaxVolume = 5000,
                UnitId = 2
            });

            modelBuilder.Entity<TankEntity>().HasData(new
            {
                Id = 6,
                Name = "��������� 256",
                Description = "���������",
                Volume = 500,
                MaxVolume = 500,
                UnitId = 3
            });
        }
    }
}