using GloveYourself.Models.Category;

namespace GloveYourself.Services.Category
{
    public interface ICategoryService
    {
        IEnumerable<CategoryIndex> GetAllCategories();
    }
}