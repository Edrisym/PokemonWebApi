using System;
using PokemonWebApi.Models;
namespace PokemonWebApi.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonsByCategory(int categoryId);
        bool CategoryExists(int id);

        bool CreateCategory(Category category);
        bool Save();
    }
}
