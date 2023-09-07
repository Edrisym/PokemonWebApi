using System;
using AutoMapper;
using PokemonWebApi.Dto;
using PokemonWebApi.Models;

namespace PokemonWebApi.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}

