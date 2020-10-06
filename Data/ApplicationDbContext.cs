using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportsPlus.Models;

namespace SportsPlus.Data {
    public class ApplicationDbContext : IdentityDbContext {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) { }

        protected override void OnModelCreating (ModelBuilder builder) {
            builder.Entity<Player> ().Property (m => m.TeamName).IsRequired ();

            builder.Entity<Team> ().Property (p => p.TeamName).HasMaxLength (30);
            
            builder.Entity<Team> ().ToTable ("Team");
            builder.Entity<Player> ().ToTable ("Player");

            // builder.Entity<Province>().ToTable("Province");
            // builder.Entity<City>().ToTable("City");

            builder.Seed();
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }
    }
}