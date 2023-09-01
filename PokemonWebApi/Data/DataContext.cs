using System;
using Microsoft.EntityFrameworkCore;
using PokemonWebApi.Models;

namespace PokemonWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonCategory> PokemonCategories { get; set; }
        public DbSet<PokemonOwner> PokemonOwners { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonCategory>()
                .HasKey(pc => new { pc.CategoryId, pc.PokemonId });
            modelBuilder.Entity<PokemonCategory>()
                .HasOne(p => p.Pokemon)
                .WithMany(pc => pc.PokemonCategories)
                .HasForeignKey(p => p.PokemonId);

            modelBuilder.Entity<PokemonCategory>()
                .HasOne(p => p.Category)
                .WithMany(pc => pc.PokemonCategories)
                .HasForeignKey(p => p.CategoryId);


            modelBuilder.Entity<PokemonOwner>()
                .HasKey(pc => new { pc.OwnerId, pc.PokemonId });
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(p => p.Pokemon)
                .WithMany(pc => pc.PokemonOwners)
                .HasForeignKey(p => p.PokemonId);

            modelBuilder.Entity<PokemonOwner>()
                .HasOne(p => p.Owner)
                .WithMany(pc => pc.PokemonOwners)
                .HasForeignKey(p => p.OwnerId);
        }
    }
}

