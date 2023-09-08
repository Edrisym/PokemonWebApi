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
            CreateMap<Category, CategoryDto>();
            //CreateMap<Country, CountryDto>();
            //CreateMap<Owner, OwnerDto>();
            //CreateMap<Category, CategoryDto>();
        }
    }
}

