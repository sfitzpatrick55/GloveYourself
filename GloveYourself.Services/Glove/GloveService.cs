using System;
using GloveYourself.Models.Glove;
using GloveYourself.Data.Data;

namespace GloveYourself.Services.Glove
{
    public class GloveService
    {
        //private readonly Guid _userId;

        //public GloveService(Guid userId)
        //{
        //    _userId = userId;
        //}

        //public bool CreateGlove(GloveCreate model)
        //{
        //    var entity =
        //        new Glove()
        //        {
        //            GloveId = _userId,
        //            Brand = model.Brand,
        //            Title = model.Title,
        //            Description = model.Description,
        //            CreatedUtc = DateTimeOffset.Now
        //        };

        //    using (var _context = new ApplicationDbContext())
        //    {
        //        _context.Gloves.Add(entity);
        //        return _context.SaveChanges() == 1;
        //    }
        //}

        //public IEnumerable<GloveListItem> GetGloves()
        //{
        //    using (var _context = new ApplicationDbContext())
        //    {
        //        var query =
        //            _context
        //            .Gloves
        //            .Where(g => g.OwnerId == _userId)
        //            .Select(
        //                g =>
        //                new GloveListItem
        //                {
        //                    Id = g.Id,
        //                    Brand = g.Brand,
        //                    Title = g.Title,
        //                    CreatedUtc = g.CreatedUtc
        //                }
        //                );
        //        return query.ToArray();
        //    }
        //}
    }
}

