using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GloveYourself.Data.Models
{
    public enum Size
    {
        Small, Medium, Large, XLarge
    }

    public class GloveSize
    {
        [Key]
        public int Id { get; set; }

        //[ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        [Display(Name = "Minimum Hand Width")]
        public int MinHandWidth { get; set; }

        [Display(Name = "Maximum Hand Width")]
        public int MaxHandWidth { get; set; }

        public Size Size { get; set; }

        public virtual Category Category { get; set; } // One-to-one

        public virtual ICollection<Glove> Gloves { get; set; } // One-to-many
    }
}
