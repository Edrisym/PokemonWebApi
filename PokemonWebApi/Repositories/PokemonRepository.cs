using System;
using PokemonWebApi.Data;
using PokemonWebApi.Interfaces;
using PokemonWebApi.Models;

namespace PokemonWebApi.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemons.Where(x => x.Id == id).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemons.Where(x => x.Name == name).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemons.OrderBy(p => p.Id).ToList();
        }

        public decimal GetPokemonRating(int pokeId)
        {
            var reviews = _context.Reviews.Where(x => x.Pokemon.Id == pokeId);
            if (reviews.Count() <= 0)
                return 0;
            return ((decimal)reviews.Sum(x => x.Rating) / reviews.Count());

        }

        public bool PokemonExists(int pokeId)
        {
            var result = _context.Pokemons.Any(x => x.Id == pokeId);
            return result;
        }

        public bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon)
        {
            var pokemonOwnerEntity = _context.Owners.Where(x => x.Id == ownerId).FirstOrDefault();
            var category = _context.Categories.Where(x => x.Id == categoryId).FirstOrDefault();

            var pokemonOwner = new PokemonOwner()
            {
                Owner = pokemonOwnerEntity,
                Pokemon = pokemon,
            };

            _context.Add(pokemonOwner);

            var pokemonCategory = new PokemonCategory()
            {
                Category = category,
                Pokemon = pokemon,
            };

            _context.Add(pokemonCategory);

            _context.Add(pokemon);

            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}

