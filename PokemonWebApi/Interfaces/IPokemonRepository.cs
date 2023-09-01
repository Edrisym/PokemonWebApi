using System;
using PokemonWebApi.Models;

namespace PokemonWebApi.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
    }
}

