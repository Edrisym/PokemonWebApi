using System;
using PokemonWebApi.Interfaces;
using PokemonWebApi.Models;

namespace PokemonWebApi.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        public OwnerRepository()
        {
        }

        public Owner GetOwner(int ownerid)
        {
            throw new NotImplementedException();
        }

        public ICollection<Owner> GetOwnerOfAPokemon(int pokeId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Owner> GetOwners()
        {
            throw new NotImplementedException();
        }

        public ICollection<Pokemon> GetPokemonByOwner(int ownerId)
        {
            throw new NotImplementedException();
        }

        public bool OwnerExists(int ownerId)
        {
            throw new NotImplementedException();
        }
    }
}

