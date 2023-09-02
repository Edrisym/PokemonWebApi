using System;
using PokemonWebApi.Models;

namespace PokemonWebApi.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(stringn name);
        decimal GetRating(Pokemon pokeId);
        bool PokemonExist(Pokemon pokeId);
    }
}

