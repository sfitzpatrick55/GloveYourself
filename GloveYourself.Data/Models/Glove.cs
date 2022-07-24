using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GloveYourself.Data.Models
{
    public class Glove
    {
        [Key]
        public int Id { get; set; }

        public byte Image { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public ICollection<GloveSize> GloveSizes { get; set; }

        [ForeignKey(nameof(UserTask))]
        public int TaskId { get; set; }

        public virtual UserTask UserTask { get; set; }

        //[ForeignKey(nameof(ApplicationUser))]
        public string ApplicationUserId { get; set; }

        //public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
