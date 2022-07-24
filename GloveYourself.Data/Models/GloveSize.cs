using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GloveYourself.Data.Models
{
    public class GloveSize
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [Display(Name = "Minimum Hand Width")]
        public int MinHandWidth { get; set; }

        [Display(Name = "Maximum Hand Width")]
        public int MaxHandWidth { get; set; }

        [Required]
        public string Size { get; set; }

        public ICollection<Glove> Gloves { get; set; }
    }
}
