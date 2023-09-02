using System;
using PokemonWebApi.Models;

namespace PokemonWebApi.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        decimal GetRating(int pokeId);
        bool PokemonExist(int pokeId);
    }
}

