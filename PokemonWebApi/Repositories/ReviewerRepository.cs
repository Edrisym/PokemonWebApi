using System;
using PokemonWebApi.Interfaces;
using PokemonWebApi.Models;
using PokemonWebApi.Data;
using Microsoft.EntityFrameworkCore;

namespace PokemonWebApi.Repositories
{
    public class ReviewerRepository : IReviewerRepository
    {
        private readonly DataContext _context;
        public ReviewerRepository(DataContext context)
        {
            _context = context;
        }
       
        public Reviewer GetReviewer(int reviewerId)
        {
            return _context.Reviewers.Where(x => x.Id == reviewerId).Include(x =>x.Reviews).FirstOrDefault();
        }

        public ICollection<Reviewer> GetReviewers()
        {
            return _context.Reviewers.OrderBy(x => x.Id).ToList();
        }

        public ICollection<Review> GetReviewsByReviewer(int reviewerId)
        {
            return _context.Reviews.Where(x => x.Reviewer.Id == reviewerId).ToList();
        }

        public bool ReviewerExists(int reviewerId)
        {
            return _context.Reviewers.Where(x => x.Id == reviewerId).Any();
        }

        public Reviewer GetReviewerWithInclude()
        {
            throw new NotImplementedException();
        }
    }
}

