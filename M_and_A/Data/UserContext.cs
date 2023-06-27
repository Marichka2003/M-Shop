﻿using M_and_A.Models;
using Microsoft.EntityFrameworkCore;

namespace M_and_A.Data
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(p => p.Id);

                entity.Property(c => c.Type)
                .HasConversion<string>()
                .HasMaxLength(150)
                .IsUnicode(false);

                entity.Property(s => s.Password)
                .HasColumnType("varchar")
                .HasMaxLength(150)
                .IsUnicode(false);

            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
