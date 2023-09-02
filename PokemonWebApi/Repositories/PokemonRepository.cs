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

        public List<Pokemon> GetPokemon(int id)
        {
            return _context.Pokemons.OrderBy(x=>x.Id == id).ToList();
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemons.Where(x=>x.Name == name).FirstOrDefault();
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

        public bool PokemonExist(int pokeId)
        {
            var result = _context.Pokemons.Any(x => x.Id == pokeId);
            return result;
        }
    }
}

