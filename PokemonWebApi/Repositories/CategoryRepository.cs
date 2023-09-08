using System;
using PokemonWebApi.Data;
using PokemonWebApi.Interfaces;
using PokemonWebApi.Models;

namespace PokemonWebApi.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public bool CategoryExists(int id)
        {
            var result = _context.Categories.Any(x => x.Id == id);
            return result;
        }

        public ICollection<Category> GetCategories()
        {
            var result = _context.Categories.OrderBy(x => x.Id).ToList();
            return result;
        }

        public Category GetCategory(int id)
        {
            var result = _context.Categories.Where(x => x.Id == id).FirstOrDefault();
            return result;
        }

        public ICollection<Pokemon> GetPokemonsByCategory(int categoryId)
        {
            var result = _context.PokemonCategories.Where(x => x.CategoryId == categoryId);
            var res = result.Select(x => x.Pokemon).ToList();
            return res;
        }
    }
}

