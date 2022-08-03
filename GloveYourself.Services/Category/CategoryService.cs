using System;
using GloveYourself.Data.Data;
using GloveYourself.Models.Category;

namespace GloveYourself.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CategoryIndex> GetAllCategories()
        {
            var query = _context.Categories.Select(
                    g =>
                    new CategoryIndex
                    {
                        Id = g.Id,
                        CategoryName = g.CategoryName
                    }
                    );
            return query.ToArray();
        }
    }
}

