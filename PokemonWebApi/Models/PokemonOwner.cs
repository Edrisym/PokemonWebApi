using System;
namespace PokemonWebApi.Models
{
    public class PokemonOwner
    {
        public int PokemonId { get; set; }
        public int OwnerId { get; set; }

        public Pokemon Pokemon { get; set; }
        public Owner Owner { get; set; }
    }
}

