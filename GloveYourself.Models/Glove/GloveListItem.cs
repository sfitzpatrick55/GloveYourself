using System;
using System.ComponentModel.DataAnnotations;

namespace GloveYourself.Models.Glove
{
    public class GloveListItem
    {
        public int Id { get; set; }

        public byte Image { get; set; }

        public string Brand { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        [Display(Name="Perfect for:")]
        public string UserTask { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }
    }
}

