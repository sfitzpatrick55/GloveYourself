using GloveYourself.Models.Glove;

namespace GloveYourself.Services.Glove
{
    public interface IGloveService
    {
        IEnumerable<GloveIndex> GetGloves();

        GloveDetail GetGloveById(int Id);

        bool CreateGlove(GloveCreate model);

        bool EditGlove(GloveEdit model);

        bool DeleteGlove(int id);

        IEnumerable<GloveIndex> CreateCategoryDropDownList();
    }
}