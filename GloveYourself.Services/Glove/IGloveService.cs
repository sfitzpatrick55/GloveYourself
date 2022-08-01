using GloveYourself.Models.Glove;

namespace GloveYourself.Services.Glove
{
    public interface IGloveService
    {
        IEnumerable<GloveIndex> GetGloves();

        bool CreateGlove(GloveCreate model);

        bool Edit(GloveEdit model);

        bool Delete(int id);
    }
}