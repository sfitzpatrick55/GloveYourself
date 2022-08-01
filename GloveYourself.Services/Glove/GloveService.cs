using System;
using GloveYourself.Models.Glove;
using GloveYourself.Data.Data;

namespace GloveYourself.Services.Glove
{
    public class GloveService : IGloveService
    {
        private readonly ApplicationDbContext _context;

        public GloveService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<GloveIndex> GetGloves()
        {
            var query =
                _context
                .Gloves
                .Select(
                    g =>
                    new GloveIndex
                    {
                        Id = g.Id,
                        Brand = g.Brand,
                        Title = g.Title,
                        CreatedUtc = g.CreatedUtc
                    }
                    );
            return query.ToArray();
        }

        public bool CreateGlove(GloveCreate model)
        {
            var entity = new GloveYourself.Data.Models.Glove()
                {
                    Image = model.Image,
                    Title = model.Title,
                    Brand = model.Brand,
                    Description = model.Description,
                    CreatedUtc = DateTimeOffset.Now,
                    GloveSizes = model.GloveSizes,
                    UserTasks = model.UserTasks
                };

            /*var newGlove =*/ _context.Gloves.Add(entity);
            foreach (var glove in model.GloveSizes)
            {
                _context.GloveSizes.Add(glove);
            }
            return _context.SaveChanges() == 5;
        }

        public bool Edit(GloveEdit model)
        {
            var glove = _context.Gloves.Find(model.Id);

            glove.Title = model.Title;
            glove.Brand = model.Brand;
            glove.Description = model.Description;

            if (model.Image != null)
            {
                glove.Image = model.Image;
            }

            return _context.SaveChanges() == 1;
        }

        public bool Delete(int id)
        {
            var glove = _context.Gloves.Find(id);

            _context.Gloves.Remove(glove);
            return _context.SaveChanges() == 1;

            //var model = new GloveDetail
            //{
            //    Image = glove.Image,
            //    Id = glove.Id,
            //    Title = glove.Title,
            //    Brand = glove.Brand,
            //    Description = glove.Description,
            //    //UserTask = _context.Tasks.TaskName,
            //    CreatedUtc = glove.CreatedUtc
            //};
        }
    }
}
