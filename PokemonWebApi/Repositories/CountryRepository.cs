using System;
using PokemonWebApi.Models;
using PokemonWebApi.Data;
using PokemonWebApi.Interfaces;
using AutoMapper;

namespace PokemonWebApi.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public CountryRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool CountryExists(int id)
        {
            return _context.Countries.Any(x => x.Id == id);
        }

        public ICollection<Country> GetCountries()
        {
            return _context.Countries.ToList();
        }

        public Country GetCountry(int id)
        {
            return _context.Countries.Where(x => x.Id == id).FirstOrDefault();
        }

        public Country GetCountryByOwner(int ownerId)
        {
            return _context.Owners.Where(x => x.Id == ownerId).Select(x => x.Country).FirstOrDefault();
        }

        public ICollection<Owner> GetOwnersFromACountry(int countryId)
        {
            return _context.Owners.Where(x => x.Country.Id == countryId).ToList();
        }
    }
}

