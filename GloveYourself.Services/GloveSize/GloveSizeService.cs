using System;
using GloveYourself.Models.Glove;
using GloveYourself.Data.Data;
using GloveYourself.Data.Models;
using GloveYourself.Models.GloveSize;

namespace GloveYourself.Services.GloveSize
{
    public class GloveSizeService
    {
        private readonly ApplicationDbContext _context;

        public GloveSizeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<GloveSizeIndex> GetGloveSizes()
        {
            var query = _context.GloveSizes.Select(
                    g =>
                    new GloveSizeIndex
                    {
                        Id = g.Id,
                        Size = g.Size
                    }
                    );
            return query.ToArray();
        }
    }
}
