using System;
using Microsoft.AspNetCore.Mvc;
using PokemonWebApi.Interfaces;
using PokemonWebApi.Models;

namespace PokemonWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;
        public PokemonController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]

        public IActionResult GetPokemon()
        {
            var pokemon = _pokemonRepository.GetPokemons();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(pokemon);
        }
    }
}

