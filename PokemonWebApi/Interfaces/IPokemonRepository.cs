using System;
using PokemonWebApi.Models;

namespace PokemonWebApi.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        List<Pokemon> GetPokemon(int id);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExist(int pokeId);
    }
}

